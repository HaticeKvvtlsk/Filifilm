
namespace WinUI
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
            System.Windows.Forms.ListView listView2;
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.richFilmAciklama = new System.Windows.Forms.RichTextBox();
            this.lblFilmYayınTarihi = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            listView2 = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.lblYonetmen);
            this.panel3.Controls.Add(this.lblDil);
            this.panel3.Controls.Add(this.lblUlke);
            this.panel3.Controls.Add(this.richFilmAciklama);
            this.panel3.Controls.Add(this.lblFilmYayınTarihi);
            this.panel3.Controls.Add(this.lblFilmAdi);
            this.panel3.Controls.Add(this.picFilm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(765, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 703);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(286, 229);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 30);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link :";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYonetmen.Location = new System.Drawing.Point(286, 112);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(124, 24);
            this.lblYonetmen.TabIndex = 7;
            this.lblYonetmen.Text = "Yönetmen :";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDil.Location = new System.Drawing.Point(286, 152);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(50, 24);
            this.lblDil.TabIndex = 6;
            this.lblDil.Text = "Dil :";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlke.Location = new System.Drawing.Point(286, 191);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(68, 24);
            this.lblUlke.TabIndex = 5;
            this.lblUlke.Text = "Ulke :";
            // 
            // richFilmAciklama
            // 
            this.richFilmAciklama.BackColor = System.Drawing.Color.Gray;
            this.richFilmAciklama.Location = new System.Drawing.Point(40, 422);
            this.richFilmAciklama.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.richFilmAciklama.Name = "richFilmAciklama";
            this.richFilmAciklama.ReadOnly = true;
            this.richFilmAciklama.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richFilmAciklama.Size = new System.Drawing.Size(500, 139);
            this.richFilmAciklama.TabIndex = 3;
            this.richFilmAciklama.Text = "";
            // 
            // lblFilmYayınTarihi
            // 
            this.lblFilmYayınTarihi.AutoSize = true;
            this.lblFilmYayınTarihi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmYayınTarihi.Location = new System.Drawing.Point(286, 72);
            this.lblFilmYayınTarihi.Name = "lblFilmYayınTarihi";
            this.lblFilmYayınTarihi.Size = new System.Drawing.Size(141, 24);
            this.lblFilmYayınTarihi.TabIndex = 2;
            this.lblFilmYayınTarihi.Text = "Yayin Tarihi :";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmAdi.Location = new System.Drawing.Point(286, 26);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(105, 24);
            this.lblFilmAdi.TabIndex = 1;
            this.lblFilmAdi.Text = "Film Adı :";
            // 
            // picFilm
            // 
            this.picFilm.Location = new System.Drawing.Point(40, 26);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(225, 375);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 0;
            this.picFilm.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 703);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türe Göre Filmler";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(1079, 703);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(listView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 703);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Türleri";
            // 
            // listView2
            // 
            listView2.BackColor = System.Drawing.Color.Gray;
            listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new System.Drawing.Point(0, 0);
            listView2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Scrollable = false;
            listView2.ShowGroups = false;
            listView2.Size = new System.Drawing.Size(304, 703);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1383, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.RichTextBox richFilmAciklama;
        private System.Windows.Forms.Label lblFilmYayınTarihi;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}