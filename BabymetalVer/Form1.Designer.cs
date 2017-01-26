namespace BabymetalVer
{
    partial class Form1
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
            this.lbx_songs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitwirkendeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_aendern = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_dauer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_songs
            // 
            this.lbx_songs.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbx_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_songs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbx_songs.FormattingEnabled = true;
            this.lbx_songs.ItemHeight = 24;
            this.lbx_songs.Location = new System.Drawing.Point(12, 43);
            this.lbx_songs.Name = "lbx_songs";
            this.lbx_songs.Size = new System.Drawing.Size(283, 316);
            this.lbx_songs.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.mitwirkendeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // mitwirkendeToolStripMenuItem
            // 
            this.mitwirkendeToolStripMenuItem.Name = "mitwirkendeToolStripMenuItem";
            this.mitwirkendeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.mitwirkendeToolStripMenuItem.Text = "Mitwirkende";
            // 
            // btn_aendern
            // 
            this.btn_aendern.BackgroundImage = global::BabymetalVer.Properties.Resources.by;
            this.btn_aendern.Location = new System.Drawing.Point(12, 378);
            this.btn_aendern.Name = "btn_aendern";
            this.btn_aendern.Size = new System.Drawing.Size(75, 23);
            this.btn_aendern.TabIndex = 2;
            this.btn_aendern.Text = "Ändern";
            this.btn_aendern.UseVisualStyleBackColor = true;
            this.btn_aendern.Click += new System.EventHandler(this.btn_aendern_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.BackColor = System.Drawing.Color.Transparent;
            this.btn_loeschen.BackgroundImage = global::BabymetalVer.Properties.Resources.by;
            this.btn_loeschen.Location = new System.Drawing.Point(93, 378);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(75, 23);
            this.btn_loeschen.TabIndex = 3;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(340, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informationen:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(340, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "BABYMETAL - Beispiel";
            // 
            // lbl_dauer
            // 
            this.lbl_dauer.AutoSize = true;
            this.lbl_dauer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dauer.Location = new System.Drawing.Point(385, 97);
            this.lbl_dauer.Name = "lbl_dauer";
            this.lbl_dauer.Size = new System.Drawing.Size(34, 13);
            this.lbl_dauer.TabIndex = 6;
            this.lbl_dauer.Text = "02:30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(340, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dauer:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BabymetalVer.Properties.Resources._6dc7bbe69f734e9af8a0f93fdf961f294d51d150_hq;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(507, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BabymetalVer.Properties.Resources.by;
            this.ClientSize = new System.Drawing.Size(605, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dauer);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_aendern);
            this.Controls.Add(this.lbx_songs);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Babymetal Songs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_songs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitwirkendeToolStripMenuItem;
        private System.Windows.Forms.Button btn_aendern;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_dauer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

