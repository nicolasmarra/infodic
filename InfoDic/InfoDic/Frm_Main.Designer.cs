namespace InfoDic
{
    partial class Frm_Main
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
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.ltb_lettres = new System.Windows.Forms.ListBox();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.ltb_mots = new System.Windows.Forms.ListBox();
            this.rtb_mot = new System.Windows.Forms.RichTextBox();
            this.rtb_definition = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ltb_lettresf = new System.Windows.Forms.ListBox();
            this.ltb_motsf = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ptb_rechercher = new System.Windows.Forms.PictureBox();
            this.ptb_home = new System.Windows.Forms.PictureBox();
            this.ptb_pronunciation = new System.Windows.Forms.PictureBox();
            this.ptb_favoris = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pronunciation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_favoris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.Gray;
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 698);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1367, 32);
            this.pnl_bottom.TabIndex = 1;
            // 
            // ltb_lettres
            // 
            this.ltb_lettres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ltb_lettres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_lettres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_lettres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ltb_lettres.FormattingEnabled = true;
            this.ltb_lettres.ItemHeight = 21;
            this.ltb_lettres.Items.AddRange(new object[] {
            "A"});
            this.ltb_lettres.Location = new System.Drawing.Point(0, 131);
            this.ltb_lettres.Name = "ltb_lettres";
            this.ltb_lettres.Size = new System.Drawing.Size(22, 569);
            this.ltb_lettres.TabIndex = 2;
            this.ltb_lettres.SelectedIndexChanged += new System.EventHandler(this.ltb_lettres_SelectedIndexChanged);
            // 
            // txt_recherche
            // 
            this.txt_recherche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche.Location = new System.Drawing.Point(0, 101);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(233, 29);
            this.txt_recherche.TabIndex = 3;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // ltb_mots
            // 
            this.ltb_mots.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ltb_mots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_mots.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_mots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ltb_mots.FormattingEnabled = true;
            this.ltb_mots.ItemHeight = 21;
            this.ltb_mots.Location = new System.Drawing.Point(22, 131);
            this.ltb_mots.Name = "ltb_mots";
            this.ltb_mots.Size = new System.Drawing.Size(211, 569);
            this.ltb_mots.TabIndex = 4;
            this.ltb_mots.SelectedIndexChanged += new System.EventHandler(this.ltb_mots_SelectedIndexChanged);
            // 
            // rtb_mot
            // 
            this.rtb_mot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_mot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_mot.ForeColor = System.Drawing.Color.MediumBlue;
            this.rtb_mot.Location = new System.Drawing.Point(240, 83);
            this.rtb_mot.Name = "rtb_mot";
            this.rtb_mot.ReadOnly = true;
            this.rtb_mot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_mot.Size = new System.Drawing.Size(1062, 49);
            this.rtb_mot.TabIndex = 6;
            this.rtb_mot.Text = "";
            this.rtb_mot.TextChanged += new System.EventHandler(this.rtb_mot_TextChanged);
            // 
            // rtb_definition
            // 
            this.rtb_definition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_definition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_definition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_definition.Location = new System.Drawing.Point(238, 131);
            this.rtb_definition.Name = "rtb_definition";
            this.rtb_definition.ReadOnly = true;
            this.rtb_definition.Size = new System.Drawing.Size(1129, 567);
            this.rtb_definition.TabIndex = 7;
            this.rtb_definition.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(22, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 569);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(238, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(488, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(238, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(267, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Home";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(343, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Favoris";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(409, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pronunciation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(507, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rechercher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(663, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Aide";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(589, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Effacer";
            // 
            // ltb_lettresf
            // 
            this.ltb_lettresf.BackColor = System.Drawing.Color.Gray;
            this.ltb_lettresf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_lettresf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_lettresf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ltb_lettresf.FormattingEnabled = true;
            this.ltb_lettresf.ItemHeight = 21;
            this.ltb_lettresf.Items.AddRange(new object[] {
            "A"});
            this.ltb_lettresf.Location = new System.Drawing.Point(0, 131);
            this.ltb_lettresf.Name = "ltb_lettresf";
            this.ltb_lettresf.Size = new System.Drawing.Size(22, 569);
            this.ltb_lettresf.TabIndex = 31;
            this.ltb_lettresf.Visible = false;
            this.ltb_lettresf.SelectedIndexChanged += new System.EventHandler(this.ltb_lettresf_SelectedIndexChanged);
            // 
            // ltb_motsf
            // 
            this.ltb_motsf.BackColor = System.Drawing.Color.Gray;
            this.ltb_motsf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_motsf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_motsf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ltb_motsf.FormattingEnabled = true;
            this.ltb_motsf.ItemHeight = 21;
            this.ltb_motsf.Location = new System.Drawing.Point(22, 131);
            this.ltb_motsf.Name = "ltb_motsf";
            this.ltb_motsf.Size = new System.Drawing.Size(211, 569);
            this.ltb_motsf.TabIndex = 32;
            this.ltb_motsf.Visible = false;
            this.ltb_motsf.SelectedIndexChanged += new System.EventHandler(this.ltb_motsf_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::InfoDic.Properties.Resources.delete__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(580, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 36);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::InfoDic.Properties.Resources.magnifier_and_mark_help__4_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(655, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 36);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ptb_rechercher
            // 
            this.ptb_rechercher.BackgroundImage = global::InfoDic.Properties.Resources.search__3_;
            this.ptb_rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_rechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_rechercher.Enabled = false;
            this.ptb_rechercher.Location = new System.Drawing.Point(511, 6);
            this.ptb_rechercher.Name = "ptb_rechercher";
            this.ptb_rechercher.Size = new System.Drawing.Size(65, 36);
            this.ptb_rechercher.TabIndex = 11;
            this.ptb_rechercher.TabStop = false;
            this.ptb_rechercher.Click += new System.EventHandler(this.ptb_rechercher_Click);
            // 
            // ptb_home
            // 
            this.ptb_home.BackgroundImage = global::InfoDic.Properties.Resources.home;
            this.ptb_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_home.Location = new System.Drawing.Point(260, 6);
            this.ptb_home.Name = "ptb_home";
            this.ptb_home.Size = new System.Drawing.Size(65, 36);
            this.ptb_home.TabIndex = 14;
            this.ptb_home.TabStop = false;
            this.ptb_home.Click += new System.EventHandler(this.ptb_inicio_Click);
            // 
            // ptb_pronunciation
            // 
            this.ptb_pronunciation.BackgroundImage = global::InfoDic.Properties.Resources.voz;
            this.ptb_pronunciation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_pronunciation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_pronunciation.Enabled = false;
            this.ptb_pronunciation.Location = new System.Drawing.Point(417, 6);
            this.ptb_pronunciation.Name = "ptb_pronunciation";
            this.ptb_pronunciation.Size = new System.Drawing.Size(65, 36);
            this.ptb_pronunciation.TabIndex = 13;
            this.ptb_pronunciation.TabStop = false;
            this.ptb_pronunciation.Click += new System.EventHandler(this.ptb_pronunciation_Click);
            // 
            // ptb_favoris
            // 
            this.ptb_favoris.BackgroundImage = global::InfoDic.Properties.Resources.favorito2;
            this.ptb_favoris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_favoris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_favoris.Location = new System.Drawing.Point(339, 6);
            this.ptb_favoris.Name = "ptb_favoris";
            this.ptb_favoris.Size = new System.Drawing.Size(65, 36);
            this.ptb_favoris.TabIndex = 12;
            this.ptb_favoris.TabStop = false;
            this.ptb_favoris.Click += new System.EventHandler(this.ptb_favoris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::InfoDic.Properties.Resources.favorito1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1306, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 49);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InfoDic.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-77, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fermer
            // 
            this.btn_fermer.FlatAppearance.BorderSize = 0;
            this.btn_fermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_fermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fermer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.Location = new System.Drawing.Point(1328, 0);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(39, 26);
            this.btn_fermer.TabIndex = 33;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1367, 730);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.ltb_mots);
            this.Controls.Add(this.ltb_lettres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptb_rechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptb_home);
            this.Controls.Add(this.ptb_pronunciation);
            this.Controls.Add(this.ptb_favoris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtb_definition);
            this.Controls.Add(this.rtb_mot);
            this.Controls.Add(this.txt_recherche);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltb_lettresf);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ltb_motsf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pronunciation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_favoris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.ListBox ltb_lettres;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.ListBox ltb_mots;
        private System.Windows.Forms.RichTextBox rtb_mot;
        private System.Windows.Forms.RichTextBox rtb_definition;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_rechercher;
        private System.Windows.Forms.PictureBox ptb_favoris;
        private System.Windows.Forms.PictureBox ptb_pronunciation;
        private System.Windows.Forms.PictureBox ptb_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox ltb_lettresf;
        private System.Windows.Forms.ListBox ltb_motsf;
        private System.Windows.Forms.Button btn_fermer;
    }
}