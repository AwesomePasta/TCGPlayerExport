namespace WindowsFormsApplication2
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCardID = new System.Windows.Forms.ListBox();
            this.listCardName = new System.Windows.Forms.ListBox();
            this.tbCardSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDSearch = new System.Windows.Forms.TextBox();
            this.btnFindID = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lbMainDeck = new System.Windows.Forms.ListBox();
            this.lbExtraDeck = new System.Windows.Forms.ListBox();
            this.lbSideDeck = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbClipboard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckClipboard = new System.Windows.Forms.Button();
            this.btnFindCard = new System.Windows.Forms.Button();
            this.lbMainDeckQuantities = new System.Windows.Forms.ListBox();
            this.lbExtraDeckQuantites = new System.Windows.Forms.ListBox();
            this.lbSideDeckQuantities = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCardID
            // 
            this.listCardID.FormattingEnabled = true;
            this.listCardID.Location = new System.Drawing.Point(454, 128);
            this.listCardID.Name = "listCardID";
            this.listCardID.Size = new System.Drawing.Size(120, 95);
            this.listCardID.TabIndex = 0;
            this.listCardID.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listCardName
            // 
            this.listCardName.FormattingEnabled = true;
            this.listCardName.Location = new System.Drawing.Point(580, 128);
            this.listCardName.Name = "listCardName";
            this.listCardName.Size = new System.Drawing.Size(120, 95);
            this.listCardName.TabIndex = 1;
            // 
            // tbCardSearch
            // 
            this.tbCardSearch.Location = new System.Drawing.Point(454, 50);
            this.tbCardSearch.Name = "tbCardSearch";
            this.tbCardSearch.Size = new System.Drawing.Size(100, 20);
            this.tbCardSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card ID\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card ID";
            // 
            // tbIDSearch
            // 
            this.tbIDSearch.Location = new System.Drawing.Point(580, 50);
            this.tbIDSearch.Name = "tbIDSearch";
            this.tbIDSearch.Size = new System.Drawing.Size(100, 20);
            this.tbIDSearch.TabIndex = 7;
            // 
            // btnFindID
            // 
            this.btnFindID.Location = new System.Drawing.Point(454, 76);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(75, 23);
            this.btnFindID.TabIndex = 8;
            this.btnFindID.Text = "Find ID";
            this.btnFindID.UseVisualStyleBackColor = true;
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(17, 297);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 77);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Convert";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lbMainDeck
            // 
            this.lbMainDeck.FormattingEnabled = true;
            this.lbMainDeck.Location = new System.Drawing.Point(202, 279);
            this.lbMainDeck.Name = "lbMainDeck";
            this.lbMainDeck.Size = new System.Drawing.Size(120, 290);
            this.lbMainDeck.TabIndex = 10;
            // 
            // lbExtraDeck
            // 
            this.lbExtraDeck.FormattingEnabled = true;
            this.lbExtraDeck.Location = new System.Drawing.Point(381, 279);
            this.lbExtraDeck.Name = "lbExtraDeck";
            this.lbExtraDeck.Size = new System.Drawing.Size(120, 290);
            this.lbExtraDeck.TabIndex = 11;
            // 
            // lbSideDeck
            // 
            this.lbSideDeck.FormattingEnabled = true;
            this.lbSideDeck.Location = new System.Drawing.Point(590, 279);
            this.lbSideDeck.Name = "lbSideDeck";
            this.lbSideDeck.Size = new System.Drawing.Size(120, 290);
            this.lbSideDeck.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Main Deck";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Side Deck";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Extra Deck";
            // 
            // tbClipboard
            // 
            this.tbClipboard.Location = new System.Drawing.Point(240, 50);
            this.tbClipboard.Name = "tbClipboard";
            this.tbClipboard.Size = new System.Drawing.Size(100, 20);
            this.tbClipboard.TabIndex = 16;
            this.tbClipboard.TextChanged += new System.EventHandler(this.tbClipboard_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Clipboard";
            // 
            // btnCheckClipboard
            // 
            this.btnCheckClipboard.Location = new System.Drawing.Point(17, 268);
            this.btnCheckClipboard.Name = "btnCheckClipboard";
            this.btnCheckClipboard.Size = new System.Drawing.Size(128, 23);
            this.btnCheckClipboard.TabIndex = 18;
            this.btnCheckClipboard.Text = "Check Clipboard";
            this.btnCheckClipboard.UseVisualStyleBackColor = true;
            this.btnCheckClipboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFindCard
            // 
            this.btnFindCard.Location = new System.Drawing.Point(580, 76);
            this.btnFindCard.Name = "btnFindCard";
            this.btnFindCard.Size = new System.Drawing.Size(75, 23);
            this.btnFindCard.TabIndex = 21;
            this.btnFindCard.Text = "Find Card";
            this.btnFindCard.UseVisualStyleBackColor = true;
            this.btnFindCard.Click += new System.EventHandler(this.btnFindCard_Click);
            // 
            // lbMainDeckQuantities
            // 
            this.lbMainDeckQuantities.FormattingEnabled = true;
            this.lbMainDeckQuantities.Location = new System.Drawing.Point(164, 279);
            this.lbMainDeckQuantities.Name = "lbMainDeckQuantities";
            this.lbMainDeckQuantities.Size = new System.Drawing.Size(32, 290);
            this.lbMainDeckQuantities.TabIndex = 22;
            // 
            // lbExtraDeckQuantites
            // 
            this.lbExtraDeckQuantites.FormattingEnabled = true;
            this.lbExtraDeckQuantites.Location = new System.Drawing.Point(343, 279);
            this.lbExtraDeckQuantites.Name = "lbExtraDeckQuantites";
            this.lbExtraDeckQuantites.Size = new System.Drawing.Size(32, 290);
            this.lbExtraDeckQuantites.TabIndex = 23;
            // 
            // lbSideDeckQuantities
            // 
            this.lbSideDeckQuantities.FormattingEnabled = true;
            this.lbSideDeckQuantities.Location = new System.Drawing.Point(552, 279);
            this.lbSideDeckQuantities.Name = "lbSideDeckQuantities";
            this.lbSideDeckQuantities.Size = new System.Drawing.Size(32, 290);
            this.lbSideDeckQuantities.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(14, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 13);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Deck Title";
            this.lblTitle.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Save Path";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(240, 105);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(100, 20);
            this.tbSavePath.TabIndex = 27;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 638);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbSideDeckQuantities);
            this.Controls.Add(this.lbExtraDeckQuantites);
            this.Controls.Add(this.lbMainDeckQuantities);
            this.Controls.Add(this.btnFindCard);
            this.Controls.Add(this.btnCheckClipboard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbClipboard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSideDeck);
            this.Controls.Add(this.lbExtraDeck);
            this.Controls.Add(this.lbMainDeck);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFindID);
            this.Controls.Add(this.tbIDSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCardSearch);
            this.Controls.Add(this.listCardName);
            this.Controls.Add(this.listCardID);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCardID;
        private System.Windows.Forms.ListBox listCardName;
        private System.Windows.Forms.TextBox tbCardSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDSearch;
        private System.Windows.Forms.Button btnFindID;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListBox lbMainDeck;
        private System.Windows.Forms.ListBox lbExtraDeck;
        private System.Windows.Forms.ListBox lbSideDeck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbClipboard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckClipboard;
        private System.Windows.Forms.Button btnFindCard;
        private System.Windows.Forms.ListBox lbMainDeckQuantities;
        private System.Windows.Forms.ListBox lbExtraDeckQuantites;
        private System.Windows.Forms.ListBox lbSideDeckQuantities;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSavePath;
    }
}

