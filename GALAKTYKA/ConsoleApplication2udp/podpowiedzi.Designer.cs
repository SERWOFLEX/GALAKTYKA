
namespace ConsoleApplication2udp
{
    partial class podpowiedzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(podpowiedzi));
            this.button_CZYSC_LISTE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_USUN_POZYCJE_Z_LISTY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PODPOWIEDZI_PLAYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox_PODPOWIEDZI_ZAPIS = new System.Windows.Forms.ListBox();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.trackBar_PODPOW = new System.Windows.Forms.TrackBar();
            this.txtLoad = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.listBox_WIDOK = new System.Windows.Forms.ListBox();
            this.button_PLAY_PODPOWIEDZ = new System.Windows.Forms.Button();
            this.button_WCZYTAJ = new System.Windows.Forms.Button();
            this.button_ZAPISZ = new System.Windows.Forms.Button();
            this.button_DODAJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PODPOWIEDZI_PLAYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PODPOW)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CZYSC_LISTE
            // 
            this.button_CZYSC_LISTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CZYSC_LISTE.Location = new System.Drawing.Point(237, 721);
            this.button_CZYSC_LISTE.Name = "button_CZYSC_LISTE";
            this.button_CZYSC_LISTE.Size = new System.Drawing.Size(95, 25);
            this.button_CZYSC_LISTE.TabIndex = 348;
            this.button_CZYSC_LISTE.Text = "CZYŚĆ";
            this.button_CZYSC_LISTE.UseVisualStyleBackColor = true;
            this.button_CZYSC_LISTE.Click += new System.EventHandler(this.button_CZYSC_LISTE_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 347;
            this.label3.Text = "UDZIELONE PODPOWIEDZI";
            // 
            // button_USUN_POZYCJE_Z_LISTY
            // 
            this.button_USUN_POZYCJE_Z_LISTY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_USUN_POZYCJE_Z_LISTY.Location = new System.Drawing.Point(837, 572);
            this.button_USUN_POZYCJE_Z_LISTY.Name = "button_USUN_POZYCJE_Z_LISTY";
            this.button_USUN_POZYCJE_Z_LISTY.Size = new System.Drawing.Size(162, 23);
            this.button_USUN_POZYCJE_Z_LISTY.TabIndex = 346;
            this.button_USUN_POZYCJE_Z_LISTY.Text = "USUŃ WYBRANĄ POZYCJĘ";
            this.button_USUN_POZYCJE_Z_LISTY.UseVisualStyleBackColor = true;
            this.button_USUN_POZYCJE_Z_LISTY.Click += new System.EventHandler(this.button_USUN_POZYCJE_Z_LISTY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(993, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 345;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 344;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PODPOWIEDZI_PLAYER
            // 
            this.PODPOWIEDZI_PLAYER.Enabled = true;
            this.PODPOWIEDZI_PLAYER.Location = new System.Drawing.Point(982, 695);
            this.PODPOWIEDZI_PLAYER.Name = "PODPOWIEDZI_PLAYER";
            this.PODPOWIEDZI_PLAYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PODPOWIEDZI_PLAYER.OcxState")));
            this.PODPOWIEDZI_PLAYER.Size = new System.Drawing.Size(75, 23);
            this.PODPOWIEDZI_PLAYER.TabIndex = 343;
            this.PODPOWIEDZI_PLAYER.Visible = false;
            this.PODPOWIEDZI_PLAYER.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.PODPOWIEDZI_PLAYER_PlayStateChange);
            // 
            // listBox_PODPOWIEDZI_ZAPIS
            // 
            this.listBox_PODPOWIEDZI_ZAPIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_PODPOWIEDZI_ZAPIS.FormattingEnabled = true;
            this.listBox_PODPOWIEDZI_ZAPIS.HorizontalScrollbar = true;
            this.listBox_PODPOWIEDZI_ZAPIS.Location = new System.Drawing.Point(12, 567);
            this.listBox_PODPOWIEDZI_ZAPIS.Name = "listBox_PODPOWIEDZI_ZAPIS";
            this.listBox_PODPOWIEDZI_ZAPIS.Size = new System.Drawing.Size(534, 147);
            this.listBox_PODPOWIEDZI_ZAPIS.TabIndex = 342;
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.BackColor = System.Drawing.Color.Transparent;
            this.label_4.ForeColor = System.Drawing.Color.Black;
            this.label_4.Location = new System.Drawing.Point(1071, 707);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(41, 13);
            this.label_4.TabIndex = 341;
            this.label_4.Text = "label_4";
            this.label_4.Visible = false;
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.BackColor = System.Drawing.Color.Transparent;
            this.label_3.ForeColor = System.Drawing.Color.Black;
            this.label_3.Location = new System.Drawing.Point(1071, 689);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(41, 13);
            this.label_3.TabIndex = 340;
            this.label_3.Text = "label_3";
            this.label_3.Visible = false;
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.White;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(650, 727);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(13, 13);
            this.label55.TabIndex = 339;
            this.label55.Text = "0";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(609, 679);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(95, 13);
            this.label56.TabIndex = 338;
            this.label56.Text = "PODPOWIEDZI";
            // 
            // trackBar_PODPOW
            // 
            this.trackBar_PODPOW.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar_PODPOW.BackColor = System.Drawing.Color.White;
            this.trackBar_PODPOW.Location = new System.Drawing.Point(552, 695);
            this.trackBar_PODPOW.Maximum = 100;
            this.trackBar_PODPOW.Name = "trackBar_PODPOW";
            this.trackBar_PODPOW.Size = new System.Drawing.Size(200, 45);
            this.trackBar_PODPOW.TabIndex = 337;
            this.trackBar_PODPOW.Scroll += new System.EventHandler(this.trackBar_PODPOW_Scroll);
            // 
            // txtLoad
            // 
            this.txtLoad.AutoSize = true;
            this.txtLoad.BackColor = System.Drawing.Color.Transparent;
            this.txtLoad.ForeColor = System.Drawing.Color.Black;
            this.txtLoad.Location = new System.Drawing.Point(1071, 631);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(42, 13);
            this.txtLoad.TabIndex = 336;
            this.txtLoad.Text = "txtLoad";
            this.txtLoad.Visible = false;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(38, 256);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(264, 225);
            this.listBoxSongs.TabIndex = 335;
            this.listBoxSongs.Visible = false;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.BackColor = System.Drawing.Color.Transparent;
            this.label_2.ForeColor = System.Drawing.Color.Black;
            this.label_2.Location = new System.Drawing.Point(1071, 667);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(41, 13);
            this.label_2.TabIndex = 334;
            this.label_2.Text = "label_2";
            this.label_2.Visible = false;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.Transparent;
            this.label_1.ForeColor = System.Drawing.Color.Black;
            this.label_1.Location = new System.Drawing.Point(1071, 646);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(41, 13);
            this.label_1.TabIndex = 333;
            this.label_1.Text = "label_1";
            this.label_1.Visible = false;
            // 
            // listBox_WIDOK
            // 
            this.listBox_WIDOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_WIDOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_WIDOK.FormattingEnabled = true;
            this.listBox_WIDOK.HorizontalScrollbar = true;
            this.listBox_WIDOK.ItemHeight = 20;
            this.listBox_WIDOK.Location = new System.Drawing.Point(12, 15);
            this.listBox_WIDOK.Name = "listBox_WIDOK";
            this.listBox_WIDOK.Size = new System.Drawing.Size(1308, 524);
            this.listBox_WIDOK.TabIndex = 332;
            this.listBox_WIDOK.SelectedIndexChanged += new System.EventHandler(this.listBox_WIDOK_SelectedIndexChanged);
            // 
            // button_PLAY_PODPOWIEDZ
            // 
            this.button_PLAY_PODPOWIEDZ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_PLAY_PODPOWIEDZ.Location = new System.Drawing.Point(612, 572);
            this.button_PLAY_PODPOWIEDZ.Name = "button_PLAY_PODPOWIEDZ";
            this.button_PLAY_PODPOWIEDZ.Size = new System.Drawing.Size(75, 23);
            this.button_PLAY_PODPOWIEDZ.TabIndex = 331;
            this.button_PLAY_PODPOWIEDZ.Text = "PLAY";
            this.button_PLAY_PODPOWIEDZ.UseVisualStyleBackColor = true;
            this.button_PLAY_PODPOWIEDZ.Click += new System.EventHandler(this.button_PLAY_PODPOWIEDZ_Click);
            // 
            // button_WCZYTAJ
            // 
            this.button_WCZYTAJ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_WCZYTAJ.Location = new System.Drawing.Point(552, 638);
            this.button_WCZYTAJ.Name = "button_WCZYTAJ";
            this.button_WCZYTAJ.Size = new System.Drawing.Size(200, 23);
            this.button_WCZYTAJ.TabIndex = 330;
            this.button_WCZYTAJ.Text = "WCZYTAJ LISTĘ";
            this.button_WCZYTAJ.UseVisualStyleBackColor = true;
            this.button_WCZYTAJ.Click += new System.EventHandler(this.button_WCZYTAJ_Click);
            // 
            // button_ZAPISZ
            // 
            this.button_ZAPISZ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ZAPISZ.Location = new System.Drawing.Point(662, 608);
            this.button_ZAPISZ.Name = "button_ZAPISZ";
            this.button_ZAPISZ.Size = new System.Drawing.Size(90, 23);
            this.button_ZAPISZ.TabIndex = 329;
            this.button_ZAPISZ.Text = "ZAPISZ";
            this.button_ZAPISZ.UseVisualStyleBackColor = true;
            this.button_ZAPISZ.Click += new System.EventHandler(this.button_ZAPISZ_Click);
            // 
            // button_DODAJ
            // 
            this.button_DODAJ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_DODAJ.Location = new System.Drawing.Point(552, 608);
            this.button_DODAJ.Name = "button_DODAJ";
            this.button_DODAJ.Size = new System.Drawing.Size(90, 23);
            this.button_DODAJ.TabIndex = 328;
            this.button_DODAJ.Text = "DODAJ";
            this.button_DODAJ.UseVisualStyleBackColor = true;
            this.button_DODAJ.Click += new System.EventHandler(this.button_DODAJ_Click);
            // 
            // podpowiedzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 761);
            this.Controls.Add(this.button_CZYSC_LISTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_USUN_POZYCJE_Z_LISTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PODPOWIEDZI_PLAYER);
            this.Controls.Add(this.listBox_PODPOWIEDZI_ZAPIS);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.trackBar_PODPOW);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.listBox_WIDOK);
            this.Controls.Add(this.button_PLAY_PODPOWIEDZ);
            this.Controls.Add(this.button_WCZYTAJ);
            this.Controls.Add(this.button_ZAPISZ);
            this.Controls.Add(this.button_DODAJ);
            this.Name = "podpowiedzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "podpowiedzi";
            this.Load += new System.EventHandler(this.podpowiedzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PODPOWIEDZI_PLAYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PODPOW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CZYSC_LISTE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_USUN_POZYCJE_Z_LISTY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer PODPOWIEDZI_PLAYER;
        public System.Windows.Forms.ListBox listBox_PODPOWIEDZI_ZAPIS;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TrackBar trackBar_PODPOW;
        private System.Windows.Forms.Label txtLoad;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.ListBox listBox_WIDOK;
        private System.Windows.Forms.Button button_PLAY_PODPOWIEDZ;
        private System.Windows.Forms.Button button_WCZYTAJ;
        private System.Windows.Forms.Button button_ZAPISZ;
        private System.Windows.Forms.Button button_DODAJ;
    }
}