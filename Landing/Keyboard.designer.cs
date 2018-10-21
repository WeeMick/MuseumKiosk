using System;

namespace Landing
{
    public partial class Keyboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboard));
            this.QKey = new System.Windows.Forms.Button();
            this.WKey = new System.Windows.Forms.Button();
            this.EKey = new System.Windows.Forms.Button();
            this.RKey = new System.Windows.Forms.Button();
            this.TKey = new System.Windows.Forms.Button();
            this.YKey = new System.Windows.Forms.Button();
            this.UKey = new System.Windows.Forms.Button();
            this.IKey = new System.Windows.Forms.Button();
            this.OKey = new System.Windows.Forms.Button();
            this.PKey = new System.Windows.Forms.Button();
            this.AKey = new System.Windows.Forms.Button();
            this.SKey = new System.Windows.Forms.Button();
            this.DKey = new System.Windows.Forms.Button();
            this.FKey = new System.Windows.Forms.Button();
            this.GKey = new System.Windows.Forms.Button();
            this.HKey = new System.Windows.Forms.Button();
            this.JKey = new System.Windows.Forms.Button();
            this.KKey = new System.Windows.Forms.Button();
            this.LKey = new System.Windows.Forms.Button();
            this.ZKey = new System.Windows.Forms.Button();
            this.XKey = new System.Windows.Forms.Button();
            this.CKey = new System.Windows.Forms.Button();
            this.VKey = new System.Windows.Forms.Button();
            this.BKey = new System.Windows.Forms.Button();
            this.NKey = new System.Windows.Forms.Button();
            this.MKey = new System.Windows.Forms.Button();
            this.Space = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hyphenButton = new System.Windows.Forms.Button();
            this.otherE = new System.Windows.Forms.Button();
            this.otherN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QKey
            // 
            this.QKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.QKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QKey.ForeColor = System.Drawing.Color.Cyan;
            this.QKey.Location = new System.Drawing.Point(229, 13);
            this.QKey.Margin = new System.Windows.Forms.Padding(4);
            this.QKey.Name = "QKey";
            this.QKey.Size = new System.Drawing.Size(104, 82);
            this.QKey.TabIndex = 3;
            this.QKey.Text = "Q";
            this.QKey.UseVisualStyleBackColor = false;
            this.QKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QKey_MouseDown);
            this.QKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QKey_MouseUp);
            // 
            // WKey
            // 
            this.WKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.WKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WKey.ForeColor = System.Drawing.Color.Cyan;
            this.WKey.Location = new System.Drawing.Point(341, 13);
            this.WKey.Margin = new System.Windows.Forms.Padding(4);
            this.WKey.Name = "WKey";
            this.WKey.Size = new System.Drawing.Size(104, 82);
            this.WKey.TabIndex = 4;
            this.WKey.Text = "W";
            this.WKey.UseVisualStyleBackColor = false;
            this.WKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WKey_MouseDown);
            this.WKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WKey_MouseUp);
            // 
            // EKey
            // 
            this.EKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.EKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EKey.ForeColor = System.Drawing.Color.Cyan;
            this.EKey.Location = new System.Drawing.Point(453, 13);
            this.EKey.Margin = new System.Windows.Forms.Padding(4);
            this.EKey.Name = "EKey";
            this.EKey.Size = new System.Drawing.Size(104, 82);
            this.EKey.TabIndex = 5;
            this.EKey.Text = "E";
            this.EKey.UseVisualStyleBackColor = false;
            this.EKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EKey_MouseDown);
            this.EKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EKey_MouseUp);
            // 
            // RKey
            // 
            this.RKey.BackColor = System.Drawing.SystemColors.ControlText;
            this.RKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RKey.ForeColor = System.Drawing.Color.Cyan;
            this.RKey.Location = new System.Drawing.Point(565, 13);
            this.RKey.Margin = new System.Windows.Forms.Padding(4);
            this.RKey.Name = "RKey";
            this.RKey.Size = new System.Drawing.Size(104, 82);
            this.RKey.TabIndex = 6;
            this.RKey.Text = "R";
            this.RKey.UseVisualStyleBackColor = false;
            this.RKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RKey_MouseDown);
            this.RKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RKey_MouseUp);
            // 
            // TKey
            // 
            this.TKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.TKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKey.ForeColor = System.Drawing.Color.Cyan;
            this.TKey.Location = new System.Drawing.Point(677, 13);
            this.TKey.Margin = new System.Windows.Forms.Padding(4);
            this.TKey.Name = "TKey";
            this.TKey.Size = new System.Drawing.Size(104, 82);
            this.TKey.TabIndex = 7;
            this.TKey.Text = "T";
            this.TKey.UseVisualStyleBackColor = false;
            this.TKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TKey_MouseDown);
            this.TKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TKey_MouseUp);
            // 
            // YKey
            // 
            this.YKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.YKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YKey.ForeColor = System.Drawing.Color.Cyan;
            this.YKey.Location = new System.Drawing.Point(789, 13);
            this.YKey.Margin = new System.Windows.Forms.Padding(4);
            this.YKey.Name = "YKey";
            this.YKey.Size = new System.Drawing.Size(104, 82);
            this.YKey.TabIndex = 8;
            this.YKey.Text = "Y";
            this.YKey.UseVisualStyleBackColor = false;
            this.YKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YKey_MouseDown);
            this.YKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YKey_MouseUp);
            // 
            // UKey
            // 
            this.UKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.UKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UKey.ForeColor = System.Drawing.Color.Cyan;
            this.UKey.Location = new System.Drawing.Point(901, 13);
            this.UKey.Margin = new System.Windows.Forms.Padding(4);
            this.UKey.Name = "UKey";
            this.UKey.Size = new System.Drawing.Size(104, 82);
            this.UKey.TabIndex = 9;
            this.UKey.Text = "U";
            this.UKey.UseVisualStyleBackColor = false;
            this.UKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UKey_MouseDown);
            this.UKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UKey_MouseUp);
            // 
            // IKey
            // 
            this.IKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.IKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IKey.ForeColor = System.Drawing.Color.Cyan;
            this.IKey.Location = new System.Drawing.Point(1013, 13);
            this.IKey.Margin = new System.Windows.Forms.Padding(4);
            this.IKey.Name = "IKey";
            this.IKey.Size = new System.Drawing.Size(104, 82);
            this.IKey.TabIndex = 10;
            this.IKey.Text = "I";
            this.IKey.UseVisualStyleBackColor = false;
            this.IKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IKey_MouseDown);
            this.IKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IKey_MouseUp);
            // 
            // OKey
            // 
            this.OKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.OKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKey.ForeColor = System.Drawing.Color.Cyan;
            this.OKey.Location = new System.Drawing.Point(1125, 13);
            this.OKey.Margin = new System.Windows.Forms.Padding(4);
            this.OKey.Name = "OKey";
            this.OKey.Size = new System.Drawing.Size(104, 82);
            this.OKey.TabIndex = 11;
            this.OKey.Text = "O";
            this.OKey.UseVisualStyleBackColor = false;
            this.OKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OKey_MouseDown);
            this.OKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OKey_MouseUp);
            // 
            // PKey
            // 
            this.PKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.PKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PKey.ForeColor = System.Drawing.Color.Cyan;
            this.PKey.Location = new System.Drawing.Point(1237, 13);
            this.PKey.Margin = new System.Windows.Forms.Padding(4);
            this.PKey.Name = "PKey";
            this.PKey.Size = new System.Drawing.Size(104, 82);
            this.PKey.TabIndex = 12;
            this.PKey.Text = "P";
            this.PKey.UseVisualStyleBackColor = false;
            this.PKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKey_MouseDown);
            this.PKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PKey_MouseUp);
            // 
            // AKey
            // 
            this.AKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.AKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AKey.ForeColor = System.Drawing.Color.Cyan;
            this.AKey.Location = new System.Drawing.Point(272, 103);
            this.AKey.Margin = new System.Windows.Forms.Padding(4);
            this.AKey.Name = "AKey";
            this.AKey.Size = new System.Drawing.Size(104, 82);
            this.AKey.TabIndex = 13;
            this.AKey.Text = "A";
            this.AKey.UseVisualStyleBackColor = false;
            this.AKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AKey_MouseDown);
            this.AKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AKey_MouseUp);
            // 
            // SKey
            // 
            this.SKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.SKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKey.ForeColor = System.Drawing.Color.Cyan;
            this.SKey.Location = new System.Drawing.Point(384, 103);
            this.SKey.Margin = new System.Windows.Forms.Padding(4);
            this.SKey.Name = "SKey";
            this.SKey.Size = new System.Drawing.Size(104, 82);
            this.SKey.TabIndex = 14;
            this.SKey.Text = "S";
            this.SKey.UseVisualStyleBackColor = false;
            this.SKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SKey_MouseDown);
            this.SKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SKey_MouseUp);
            // 
            // DKey
            // 
            this.DKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.DKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKey.ForeColor = System.Drawing.Color.Cyan;
            this.DKey.Location = new System.Drawing.Point(496, 103);
            this.DKey.Margin = new System.Windows.Forms.Padding(4);
            this.DKey.Name = "DKey";
            this.DKey.Size = new System.Drawing.Size(104, 82);
            this.DKey.TabIndex = 15;
            this.DKey.Text = "D";
            this.DKey.UseVisualStyleBackColor = false;
            this.DKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DKey_MouseDown);
            this.DKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DKey_MouseUp);
            // 
            // FKey
            // 
            this.FKey.BackColor = System.Drawing.SystemColors.ControlText;
            this.FKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FKey.ForeColor = System.Drawing.Color.Cyan;
            this.FKey.Location = new System.Drawing.Point(608, 103);
            this.FKey.Margin = new System.Windows.Forms.Padding(4);
            this.FKey.Name = "FKey";
            this.FKey.Size = new System.Drawing.Size(104, 82);
            this.FKey.TabIndex = 16;
            this.FKey.Text = "F";
            this.FKey.UseVisualStyleBackColor = false;
            this.FKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FKey_MouseDown);
            this.FKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FKey_MouseUp);
            // 
            // GKey
            // 
            this.GKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.GKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GKey.ForeColor = System.Drawing.Color.Cyan;
            this.GKey.Location = new System.Drawing.Point(720, 103);
            this.GKey.Margin = new System.Windows.Forms.Padding(4);
            this.GKey.Name = "GKey";
            this.GKey.Size = new System.Drawing.Size(104, 82);
            this.GKey.TabIndex = 17;
            this.GKey.Text = "G";
            this.GKey.UseVisualStyleBackColor = false;
            this.GKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GKey_MouseDown);
            this.GKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GKey_MouseUp);
            // 
            // HKey
            // 
            this.HKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.HKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HKey.ForeColor = System.Drawing.Color.Cyan;
            this.HKey.Location = new System.Drawing.Point(832, 103);
            this.HKey.Margin = new System.Windows.Forms.Padding(4);
            this.HKey.Name = "HKey";
            this.HKey.Size = new System.Drawing.Size(104, 82);
            this.HKey.TabIndex = 18;
            this.HKey.Text = "H";
            this.HKey.UseVisualStyleBackColor = false;
            this.HKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HKey_MouseDown);
            this.HKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HKey_MouseUp);
            // 
            // JKey
            // 
            this.JKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.JKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JKey.ForeColor = System.Drawing.Color.Cyan;
            this.JKey.Location = new System.Drawing.Point(944, 103);
            this.JKey.Margin = new System.Windows.Forms.Padding(4);
            this.JKey.Name = "JKey";
            this.JKey.Size = new System.Drawing.Size(104, 82);
            this.JKey.TabIndex = 19;
            this.JKey.Text = "J";
            this.JKey.UseVisualStyleBackColor = false;
            this.JKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JKey_MouseDown);
            this.JKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JKey_MouseUp);
            // 
            // KKey
            // 
            this.KKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.KKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KKey.ForeColor = System.Drawing.Color.Cyan;
            this.KKey.Location = new System.Drawing.Point(1056, 103);
            this.KKey.Margin = new System.Windows.Forms.Padding(4);
            this.KKey.Name = "KKey";
            this.KKey.Size = new System.Drawing.Size(104, 82);
            this.KKey.TabIndex = 20;
            this.KKey.Text = "K";
            this.KKey.UseVisualStyleBackColor = false;
            this.KKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KKey_MouseDown);
            this.KKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KKey_MouseUp);
            // 
            // LKey
            // 
            this.LKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.LKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKey.ForeColor = System.Drawing.Color.Cyan;
            this.LKey.Location = new System.Drawing.Point(1168, 103);
            this.LKey.Margin = new System.Windows.Forms.Padding(4);
            this.LKey.Name = "LKey";
            this.LKey.Size = new System.Drawing.Size(104, 82);
            this.LKey.TabIndex = 21;
            this.LKey.Text = "L";
            this.LKey.UseVisualStyleBackColor = false;
            this.LKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LKey_MouseDown);
            this.LKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LKey_MouseUp);
            // 
            // ZKey
            // 
            this.ZKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.ZKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZKey.ForeColor = System.Drawing.Color.Cyan;
            this.ZKey.Location = new System.Drawing.Point(215, 193);
            this.ZKey.Margin = new System.Windows.Forms.Padding(4);
            this.ZKey.Name = "ZKey";
            this.ZKey.Size = new System.Drawing.Size(104, 82);
            this.ZKey.TabIndex = 22;
            this.ZKey.Text = "Z";
            this.ZKey.UseVisualStyleBackColor = false;
            this.ZKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZKey_MouseDown);
            this.ZKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZKey_MouseUp);
            // 
            // XKey
            // 
            this.XKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.XKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XKey.ForeColor = System.Drawing.Color.Cyan;
            this.XKey.Location = new System.Drawing.Point(327, 193);
            this.XKey.Margin = new System.Windows.Forms.Padding(4);
            this.XKey.Name = "XKey";
            this.XKey.Size = new System.Drawing.Size(104, 82);
            this.XKey.TabIndex = 23;
            this.XKey.Text = "X";
            this.XKey.UseVisualStyleBackColor = false;
            this.XKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XKey_MouseDown);
            this.XKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XKey_MouseUp);
            // 
            // CKey
            // 
            this.CKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.CKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKey.ForeColor = System.Drawing.Color.Cyan;
            this.CKey.Location = new System.Drawing.Point(439, 193);
            this.CKey.Margin = new System.Windows.Forms.Padding(4);
            this.CKey.Name = "CKey";
            this.CKey.Size = new System.Drawing.Size(104, 82);
            this.CKey.TabIndex = 24;
            this.CKey.Text = "C";
            this.CKey.UseVisualStyleBackColor = false;
            this.CKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CKey_MouseDown);
            this.CKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CKey_MouseUp);
            // 
            // VKey
            // 
            this.VKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.VKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VKey.ForeColor = System.Drawing.Color.Cyan;
            this.VKey.Location = new System.Drawing.Point(551, 193);
            this.VKey.Margin = new System.Windows.Forms.Padding(4);
            this.VKey.Name = "VKey";
            this.VKey.Size = new System.Drawing.Size(104, 82);
            this.VKey.TabIndex = 25;
            this.VKey.Text = "V";
            this.VKey.UseVisualStyleBackColor = false;
            this.VKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VKey_MouseDown);
            this.VKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VKey_MouseUp);
            // 
            // BKey
            // 
            this.BKey.BackColor = System.Drawing.SystemColors.ControlText;
            this.BKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BKey.ForeColor = System.Drawing.Color.Cyan;
            this.BKey.Location = new System.Drawing.Point(667, 193);
            this.BKey.Margin = new System.Windows.Forms.Padding(4);
            this.BKey.Name = "BKey";
            this.BKey.Size = new System.Drawing.Size(104, 82);
            this.BKey.TabIndex = 26;
            this.BKey.Text = "B";
            this.BKey.UseVisualStyleBackColor = false;
            this.BKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BKey_MouseDown);
            this.BKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BKey_MouseUp);
            // 
            // NKey
            // 
            this.NKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.NKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NKey.ForeColor = System.Drawing.Color.Cyan;
            this.NKey.Location = new System.Drawing.Point(779, 193);
            this.NKey.Margin = new System.Windows.Forms.Padding(4);
            this.NKey.Name = "NKey";
            this.NKey.Size = new System.Drawing.Size(104, 82);
            this.NKey.TabIndex = 27;
            this.NKey.Text = "N";
            this.NKey.UseVisualStyleBackColor = false;
            this.NKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NKey_MouseDown);
            this.NKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NKey_MouseUp);
            // 
            // MKey
            // 
            this.MKey.BackColor = System.Drawing.SystemColors.Desktop;
            this.MKey.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKey.ForeColor = System.Drawing.Color.Cyan;
            this.MKey.Location = new System.Drawing.Point(891, 193);
            this.MKey.Margin = new System.Windows.Forms.Padding(4);
            this.MKey.Name = "MKey";
            this.MKey.Size = new System.Drawing.Size(104, 82);
            this.MKey.TabIndex = 28;
            this.MKey.Text = "M";
            this.MKey.UseVisualStyleBackColor = false;
            this.MKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MKey_MouseDown);
            this.MKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MKey_MouseUp);
            // 
            // Space
            // 
            this.Space.BackColor = System.Drawing.SystemColors.Desktop;
            this.Space.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Space.ForeColor = System.Drawing.Color.Cyan;
            this.Space.Location = new System.Drawing.Point(370, 296);
            this.Space.Margin = new System.Windows.Forms.Padding(4);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(833, 72);
            this.Space.TabIndex = 29;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = false;
            this.Space.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Space_MouseDown);
            this.Space.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Space_MouseUp);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(1405, 12);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 82);
            this.delete.TabIndex = 32;
            this.delete.Text = "X";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.delete_MouseDown);
            this.delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.delete_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 82);
            this.button1.TabIndex = 33;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1350, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 84);
            this.button2.TabIndex = 34;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hyphenButton
            // 
            this.hyphenButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.hyphenButton.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyphenButton.ForeColor = System.Drawing.Color.Cyan;
            this.hyphenButton.Location = new System.Drawing.Point(1280, 103);
            this.hyphenButton.Margin = new System.Windows.Forms.Padding(4);
            this.hyphenButton.Name = "hyphenButton";
            this.hyphenButton.Size = new System.Drawing.Size(104, 82);
            this.hyphenButton.TabIndex = 35;
            this.hyphenButton.Text = "-";
            this.hyphenButton.UseVisualStyleBackColor = false;
            this.hyphenButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hyphenButton_MouseDown);
            this.hyphenButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hyphenButton_MouseUp);
            // 
            // otherE
            // 
            this.otherE.BackColor = System.Drawing.SystemColors.Desktop;
            this.otherE.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherE.ForeColor = System.Drawing.Color.Cyan;
            this.otherE.Location = new System.Drawing.Point(1003, 193);
            this.otherE.Margin = new System.Windows.Forms.Padding(4);
            this.otherE.Name = "otherE";
            this.otherE.Size = new System.Drawing.Size(104, 82);
            this.otherE.TabIndex = 36;
            this.otherE.Text = "É";
            this.otherE.UseVisualStyleBackColor = false;
            this.otherE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.otherE_MouseDown);
            this.otherE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.otherE_MouseUp);
            // 
            // otherN
            // 
            this.otherN.BackColor = System.Drawing.SystemColors.Desktop;
            this.otherN.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherN.ForeColor = System.Drawing.Color.Cyan;
            this.otherN.Location = new System.Drawing.Point(1115, 193);
            this.otherN.Margin = new System.Windows.Forms.Padding(4);
            this.otherN.Name = "otherN";
            this.otherN.Size = new System.Drawing.Size(104, 82);
            this.otherN.TabIndex = 37;
            this.otherN.Text = "Ñ";
            this.otherN.UseVisualStyleBackColor = false;
            this.otherN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.otherN_MouseDown);
            this.otherN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.otherN_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(160, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 82);
            this.button3.TabIndex = 38;
            this.button3.Text = "\'";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1538, 423);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.otherN);
            this.Controls.Add(this.otherE);
            this.Controls.Add(this.hyphenButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.MKey);
            this.Controls.Add(this.NKey);
            this.Controls.Add(this.BKey);
            this.Controls.Add(this.VKey);
            this.Controls.Add(this.CKey);
            this.Controls.Add(this.XKey);
            this.Controls.Add(this.ZKey);
            this.Controls.Add(this.LKey);
            this.Controls.Add(this.KKey);
            this.Controls.Add(this.JKey);
            this.Controls.Add(this.HKey);
            this.Controls.Add(this.GKey);
            this.Controls.Add(this.FKey);
            this.Controls.Add(this.DKey);
            this.Controls.Add(this.SKey);
            this.Controls.Add(this.AKey);
            this.Controls.Add(this.PKey);
            this.Controls.Add(this.OKey);
            this.Controls.Add(this.IKey);
            this.Controls.Add(this.UKey);
            this.Controls.Add(this.YKey);
            this.Controls.Add(this.TKey);
            this.Controls.Add(this.RKey);
            this.Controls.Add(this.EKey);
            this.Controls.Add(this.WKey);
            this.Controls.Add(this.QKey);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Keyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space";
            this.ResumeLayout(false);

        } 
      

        #endregion
        private System.Windows.Forms.Button QKey;
        private System.Windows.Forms.Button WKey;
        private System.Windows.Forms.Button EKey;
        private System.Windows.Forms.Button RKey;
        private System.Windows.Forms.Button TKey;
        private System.Windows.Forms.Button YKey;
        private System.Windows.Forms.Button UKey;
        private System.Windows.Forms.Button IKey;
        private System.Windows.Forms.Button OKey;
        private System.Windows.Forms.Button PKey;
        private System.Windows.Forms.Button AKey;
        private System.Windows.Forms.Button SKey;
        private System.Windows.Forms.Button DKey;
        private System.Windows.Forms.Button FKey;
        private System.Windows.Forms.Button GKey;
        private System.Windows.Forms.Button HKey;
        private System.Windows.Forms.Button JKey;
        private System.Windows.Forms.Button KKey;
        private System.Windows.Forms.Button LKey;
        private System.Windows.Forms.Button ZKey;
        private System.Windows.Forms.Button XKey;
        private System.Windows.Forms.Button CKey;
        private System.Windows.Forms.Button VKey;
        private System.Windows.Forms.Button BKey;
        private System.Windows.Forms.Button NKey;
        private System.Windows.Forms.Button MKey;
        private System.Windows.Forms.Button Space;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hyphenButton;
        private System.Windows.Forms.Button otherE;
        private System.Windows.Forms.Button otherN;
        private System.Windows.Forms.Button button3;
    }
}