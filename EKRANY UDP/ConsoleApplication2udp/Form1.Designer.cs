namespace ConsoleApplication2udp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EKRANY_PALYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SUBWOFER_PLAYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_PAUZA = new System.Windows.Forms.Timer(this.components);
            this.timer_ZMIANA_KOSMOS = new System.Windows.Forms.Timer(this.components);
            this.timer_START_STATKU = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EKRANY_PALYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUBWOFER_PLAYER)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EKRANY_PALYER
            // 
            this.EKRANY_PALYER.Enabled = true;
            this.EKRANY_PALYER.Location = new System.Drawing.Point(0, 0);
            this.EKRANY_PALYER.Name = "EKRANY_PALYER";
            this.EKRANY_PALYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("EKRANY_PALYER.OcxState")));
            this.EKRANY_PALYER.Size = new System.Drawing.Size(3880, 1090);
            this.EKRANY_PALYER.TabIndex = 0;
            this.EKRANY_PALYER.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.CZASY_PALYER_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SUBWOFER_PLAYER
            // 
            this.SUBWOFER_PLAYER.Enabled = true;
            this.SUBWOFER_PLAYER.Location = new System.Drawing.Point(12, 576);
            this.SUBWOFER_PLAYER.Name = "SUBWOFER_PLAYER";
            this.SUBWOFER_PLAYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SUBWOFER_PLAYER.OcxState")));
            this.SUBWOFER_PLAYER.Size = new System.Drawing.Size(75, 23);
            this.SUBWOFER_PLAYER.TabIndex = 1;
            this.SUBWOFER_PLAYER.Visible = false;
            // 
            // timer_PAUZA
            // 
            this.timer_PAUZA.Interval = 1500;
            this.timer_PAUZA.Tick += new System.EventHandler(this.timer_PAUZA_Tick);
            // 
            // timer_ZMIANA_KOSMOS
            // 
            this.timer_ZMIANA_KOSMOS.Interval = 44000;
            this.timer_ZMIANA_KOSMOS.Tick += new System.EventHandler(this.timer_ZMIANA_KOSMOS_Tick);
            // 
            // timer_START_STATKU
            // 
            this.timer_START_STATKU.Interval = 47000;
            this.timer_START_STATKU.Tick += new System.EventHandler(this.timer_START_STATKU_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1047);
            this.ControlBox = false;
            this.Controls.Add(this.SUBWOFER_PLAYER);
            this.Controls.Add(this.EKRANY_PALYER);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " GALAKTYKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            ((System.ComponentModel.ISupportInitialize)(this.EKRANY_PALYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUBWOFER_PLAYER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer EKRANY_PALYER;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer SUBWOFER_PLAYER;
        private System.Windows.Forms.Timer timer_PAUZA;
        private System.Windows.Forms.Timer timer_ZMIANA_KOSMOS;
        private System.Windows.Forms.Timer timer_START_STATKU;
    }
}

