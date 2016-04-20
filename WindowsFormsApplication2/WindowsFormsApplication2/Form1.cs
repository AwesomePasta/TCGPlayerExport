using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.IO;



namespace WindowsFormsApplication2
{
    public partial class Form : System.Windows.Forms.Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=c:\users\jseitter\documents\visual studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\cards.accdb; Persist Security Info=True";
            cmd.Connection = cn;
            loaddata();

        }

        private void loaddata()
        {
            listCardID.Items.Clear();
            listCardName.Items.Clear();

            try
            {

                cmd.CommandText = "select * from cards;";
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listCardID.Items.Add(dr[0].ToString());
                        listCardName.Items.Add(dr[1].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            //Grab the text from the user's input
            string searchString = tbCardSearch.Text;

            // Ensure we have a proper string to search for.
            if (searchString != string.Empty)
            {
                // Find the item in the list and store the index to the item.
                int index = listCardName.FindString(searchString);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index != -1)
                {
                    listCardName.SetSelected(index, true);
                    listCardID.SetSelected(index, true);

                }
                else
                    MessageBox.Show("The search string did not match any items in the ListBox");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Declarations
            List<int> mainDeckQuantities = new List<int>();
            List<string> mainDeckNames = new List<string>();
            char[] possibleQuantites = new char[] { '1', '2', '3' };
            //Declarations
            List<int> extradeckQuantities = new List<int>();
            List<string> extradeckNames = new List<string>();
            //Declarations
            List<int> sidedeckQuantities = new List<int>();
            List<string> sidedeckNames = new List<string>();
            //Declarations
            string savepath = tbSavePath.Text;
            string fileName = Clipboard.GetText();
            //Use for index references 
            int first;
            int last;


            //Downloads the webpage to a text file.
            WebClient client = new WebClient();
            string reply = client.DownloadString(fileName);
            string copy = reply; //Creates a copy so I can just do the same process of building the deck list 3 times.

            //Make the Deck Name based off the Title and Author
            //Go straight to the first letter. the beginning will never change
            //
            //

            //First add the deck name to the title. 
            reply = reply.Substring(141, 75);
            reply.Trim();
            last = reply.IndexOf("<");
            lblTitle.Text = reply.Substring(0, last);
            /*
            //Second add the author to the title
            first = reply.IndexOf("<br>");
            last = reply.IndexOf("<br></b>");
            lblTitle.Text = lblTitle.Text + " " + reply.Substring(first + "<br>".Length, last - 1 - "<br></b>".Length * 3);
            */


           

            reply = copy;
            //Search for just the main deck, roughly
            first = reply.IndexOf("<b>Main Deck:</b><br>") + "<b>Main Deck:</b><br>".Length;
            last = reply.LastIndexOf("<br><b>Sideboard:</b><br>");
            string reply1 = reply.Substring(first, last - first);

            //Next remove the extra formatting
            first = reply1.IndexOf(">") + (">").Length;
            last = reply1.LastIndexOf("</font>");
            string maindeck = reply1.Substring(first, last - first) + "<BR>123456";
            maindeck.Trim();


            //Loop Starts Here

            while (maindeck.Length > 15)
            {
                //Finds the first quantity that occurs in the decklist.
                char b = maindeck[maindeck.IndexOfAny(possibleQuantites)];

                //Converts the character into an integer
                int a = Convert.ToInt32(b) - 48;

                //Remove the number from the list 
                mainDeckQuantities.Add(a);
                first = maindeck.IndexOfAny(possibleQuantites) + 2;
                maindeck = maindeck.Substring(first);




                last = maindeck.IndexOf("<");
                mainDeckNames.Add(maindeck.Substring(0, last));

                first = maindeck.IndexOf(">") + (">").Length;
                maindeck = maindeck.Substring(first);
            }
            //Loop ends here




            // STARTING THE EXTRA DECK HERE ==========================================================================================




            //Reload the copy
            reply = copy;


            //Search for just the Extra deck, roughly
            first = reply.IndexOf("<br><b>Extra Deck:</b><br>") + "<br><b>Extra Deck:</b><br>".Length;
            last = reply.LastIndexOf("</font>");
            reply1 = reply.Substring(first, last - first);

            //Next remove the extra formatting
            first = reply1.IndexOf(">") + (">").Length;
            last = reply1.LastIndexOf("</font>");
            string extradeck = reply1;
            extradeck.Trim();


            //Loop Starts Here

            while (extradeck.Length > 15)
            {
                //Finds the first quantity that occurs in the decklist.
                char b = extradeck[extradeck.IndexOfAny(possibleQuantites)];

                //Converts the character into an integer
                int a = Convert.ToInt32(b) - 48;

                //Remove the number from the list 
                extradeckQuantities.Add(a);
                first = extradeck.IndexOfAny(possibleQuantites) + 2;
                extradeck = extradeck.Substring(first);




                last = extradeck.IndexOf("<");
                extradeckNames.Add(extradeck.Substring(0, last));

                first = extradeck.IndexOf(">") + (">").Length;
                extradeck = extradeck.Substring(first);
            }
            //Loop ends here



            // STARTING THE SIDE DECK HERE ===========================================================================================


            //copy the text file again
            reply = copy;


            //Search for just the side deck, roughly
            first = reply.IndexOf("<b>Sideboard:</b><br>") + "<b>Sideboard:</b><br>".Length;
            last = reply.LastIndexOf("<br><b>");
            reply1 = reply.Substring(first, last - first);
            reply1.Trim();
            //Next remove the extra formatting

            first = ("<font face=\"arial\" size=\"2\">").Length;
            string sidedeck = reply1.Substring(first);







            //Loop Starts Here

            while (sidedeck.Length > 15)
            {
                //Finds the first quantity that occurs in the decklist.
                char b = sidedeck[sidedeck.IndexOfAny(possibleQuantites)];

                //Converts the character into an integer
                int a = Convert.ToInt32(b) - 48;

                //Remove the number from the list 
                sidedeckQuantities.Add(a);
                first = sidedeck.IndexOfAny(possibleQuantites) + 2;
                sidedeck = sidedeck.Substring(first);




                last = sidedeck.IndexOf("<");
                sidedeckNames.Add(sidedeck.Substring(0, last));

                first = sidedeck.IndexOf(">") + (">").Length;
                sidedeck = sidedeck.Substring(first);
            }


            lbMainDeck.DataSource = mainDeckNames;
            lbExtraDeck.DataSource = extradeckNames;
            lbSideDeck.DataSource = sidedeckNames;
            lbSideDeckQuantities.DataSource = sidedeckQuantities;
            lbMainDeckQuantities.DataSource = mainDeckQuantities;
            lbExtraDeckQuantites.DataSource = extradeckQuantities;
            



            string searchString;

            //write the main deck
            StreamWriter Output = new StreamWriter(savepath + lblTitle.Text + ".ydk");
            Output.Write("#created by AwesomePasta Program\r\n");
            Output.Write("#main\r\n");

            for (int i = 1; i <= mainDeckNames.Count; i++)
            {
                searchString = mainDeckNames[i - 1];

                // Ensure we have a proper string to search for.
                if (searchString != string.Empty)
                {
                    // Find the item in the list and store the index to the item.
                    int index = listCardName.FindString(searchString);
                    listCardID.SelectedIndex = index;
                    // Determine if a valid index is returned. Select the item if it is valid.

                    
                    if (index != -1)
                    {
                        for (int z = 1; z <= mainDeckQuantities[i-1]; z++)
                        {
                            Output.Write(listCardID.SelectedItem);
                            Output.Write("\r\n");
                            

                        }

                    }
                    else
                        MessageBox.Show("The search string did not match any items in the ListBox");
                }

            }


            //Write Extra Deck
            Output.Write("#extra\r\n");

            for (int i = 1; i <= extradeckNames.Count; i++)
            {
                searchString = extradeckNames[i - 1];

                // Ensure we have a proper string to search for.
                if (searchString != string.Empty)
                {
                    // Find the item in the list and store the index to the item.
                    int index = listCardName.FindString(searchString);
                    listCardID.SelectedIndex = index;
                    // Determine if a valid index is returned. Select the item if it is valid.


                    if (index != -1)
                    {
                        for (int z = 1; z <= extradeckQuantities[i - 1]; z++)
                        {
                            Output.Write(listCardID.SelectedItem);
                            Output.Write("\r\n");


                        }

                    }
                    else
                        MessageBox.Show("The search string did not match any items in the ListBox");
                }

            }



            //Write side Deck
            Output.Write("!side\r\n");

            for (int i = 1; i <= sidedeckNames.Count; i++)
            {
                searchString = sidedeckNames[i - 1];

                // Ensure we have a proper string to search for.
                if (searchString != string.Empty)
                {
                    // Find the item in the list and store the index to the item.
                    int index = listCardName.FindString(searchString);
                    listCardID.SelectedIndex = index;
                    // Determine if a valid index is returned. Select the item if it is valid.


                    if (index != -1)
                    {
                        for (int z = 1; z <= sidedeckQuantities[i - 1]; z++)
                        {
                            Output.Write(listCardID.SelectedItem);
                            Output.Write("\r\n");


                        }

                    }
                    else
                        MessageBox.Show("The search string did not match any items in the ListBox");
                }

            }



            Output.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbClipboard.Text = Clipboard.GetText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnFindCard_Click(object sender, EventArgs e)
        {
            //Grab the text from the user's input
            string searchString = tbIDSearch.Text;

            // Ensure we have a proper string to search for.
            if (searchString != string.Empty)
            {
                // Find the item in the list and store the index to the item.
                int index = listCardID.FindString(searchString);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index != -1)
                {
                    listCardName.SetSelected(index, true);
                    listCardID.SetSelected(index, true);

                }
                else
                    MessageBox.Show("The search string did not match any items in the ListBox");
            }
        }

        private void btnSetFilePath_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void tbClipboard_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
