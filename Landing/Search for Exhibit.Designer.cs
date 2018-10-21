namespace Landing
{
    partial class Search_Via_Text
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Via_Text));
            this.label1 = new System.Windows.Forms.Label();
            this.textExhibit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.orderByListBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.listBoxFinal = new System.Windows.Forms.ListBox();
            this.textSearch = new System.Windows.Forms.Button();
            this.filterSearch = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helpButton4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(268, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the name of exhibit";
            this.label1.Visible = false;
            // 
            // textExhibit
            // 
            this.textExhibit.AutoCompleteCustomSource.AddRange(new string[] {
            "Tanks",
            "Army",
            "Navy",
            "Aircraft",
            "Battles"});
            this.textExhibit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textExhibit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textExhibit.Enabled = false;
            this.textExhibit.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExhibit.Location = new System.Drawing.Point(275, 348);
            this.textExhibit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textExhibit.Name = "textExhibit";
            this.textExhibit.Size = new System.Drawing.Size(388, 45);
            this.textExhibit.TabIndex = 2;
            this.textExhibit.Visible = false;
            this.textExhibit.TextChanged += new System.EventHandler(this.textExhibit_TextChanged);
            this.textExhibit.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.textExhibit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_GotFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(684, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 85);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEARCH FOR EXHIBIT";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 602);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 156);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(496, 418);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(219, 136);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(1122, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(536, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Use the filters to find your exhibit";
            this.label5.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 38;
            this.listBox1.Items.AddRange(new object[] {
            "Temporary",
            "Permanent"});
            this.listBox1.Location = new System.Drawing.Point(1127, 348);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(674, 80);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // orderByListBox
            // 
            this.orderByListBox.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByListBox.FormattingEnabled = true;
            this.orderByListBox.ItemHeight = 38;
            this.orderByListBox.Items.AddRange(new object[] {
            "A - Z",
            "Closing Date"});
            this.orderByListBox.Location = new System.Drawing.Point(1125, 452);
            this.orderByListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.orderByListBox.Name = "orderByListBox";
            this.orderByListBox.Size = new System.Drawing.Size(676, 80);
            this.orderByListBox.TabIndex = 10;
            this.orderByListBox.Visible = false;
            this.orderByListBox.SelectedIndexChanged += new System.EventHandler(this.orderByListBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "mmmm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1125, 566);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 5, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(676, 45);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleGreen;
            this.label6.Location = new System.Drawing.Point(843, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type of Exhibit";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleGreen;
            this.label7.Location = new System.Drawing.Point(843, 452);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 38);
            this.label7.TabIndex = 17;
            this.label7.Text = "Order By";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleGreen;
            this.label8.Location = new System.Drawing.Point(839, 566);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Closing Month";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PaleGreen;
            this.label9.Location = new System.Drawing.Point(843, 650);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 38);
            this.label9.TabIndex = 19;
            this.label9.Text = "Select Exhibit ";
            this.label9.Visible = false;
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.Lime;
            this.goButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goButton.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.ForeColor = System.Drawing.Color.White;
            this.goButton.Location = new System.Drawing.Point(1129, 827);
            this.goButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(553, 107);
            this.goButton.TabIndex = 20;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Visible = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listBoxFinal
            // 
            this.listBoxFinal.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFinal.FormattingEnabled = true;
            this.listBoxFinal.ItemHeight = 38;
            this.listBoxFinal.Location = new System.Drawing.Point(1127, 650);
            this.listBoxFinal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBoxFinal.Name = "listBoxFinal";
            this.listBoxFinal.Size = new System.Drawing.Size(674, 156);
            this.listBoxFinal.TabIndex = 21;
            this.listBoxFinal.Visible = false;
            this.listBoxFinal.SelectedIndexChanged += new System.EventHandler(this.listBoxFinal_SelectedIndexChanged);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.textSearch.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(275, 147);
            this.textSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(440, 105);
            this.textSearch.TabIndex = 22;
            this.textSearch.Text = "Search via Text";
            this.textSearch.UseVisualStyleBackColor = false;
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            // 
            // filterSearch
            // 
            this.filterSearch.BackColor = System.Drawing.SystemColors.ControlText;
            this.filterSearch.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSearch.ForeColor = System.Drawing.Color.White;
            this.filterSearch.Location = new System.Drawing.Point(948, 147);
            this.filterSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.filterSearch.Name = "filterSearch";
            this.filterSearch.Size = new System.Drawing.Size(570, 105);
            this.filterSearch.TabIndex = 23;
            this.filterSearch.Text = "Search via Filters";
            this.filterSearch.UseVisualStyleBackColor = false;
            this.filterSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(727, 200);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1530, 200);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(479, 84);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(484, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 85);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // helpButton4
            // 
            this.helpButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton4.BackColor = System.Drawing.SystemColors.ControlText;
            this.helpButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton4.BackgroundImage")));
            this.helpButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton4.ForeColor = System.Drawing.Color.White;
            this.helpButton4.Location = new System.Drawing.Point(1848, 0);
            this.helpButton4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.helpButton4.Name = "helpButton4";
            this.helpButton4.Size = new System.Drawing.Size(136, 121);
            this.helpButton4.TabIndex = 28;
            this.helpButton4.Text = "Help";
            this.helpButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton4.UseVisualStyleBackColor = false;
            this.helpButton4.Click += new System.EventHandler(this.helpButton4_Click);
            // 
            // Search_Via_Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1982, 1325);
            this.Controls.Add(this.helpButton4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.filterSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.listBoxFinal);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.orderByListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textExhibit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Search_Via_Text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Via_Text";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button searchButton;

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox orderByListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button goButton;
        public System.Windows.Forms.TextBox textExhibit;
        private System.Windows.Forms.Button textSearch;
        private System.Windows.Forms.Button filterSearch;
        public System.Windows.Forms.ListBox listBoxFinal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button helpButton4;
    }
}