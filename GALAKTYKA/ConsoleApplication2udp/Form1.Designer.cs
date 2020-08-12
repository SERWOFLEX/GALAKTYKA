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
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.listBox_received = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSTAWIENIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dZWIĘKIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_START_GRY = new System.Windows.Forms.Button();
            this.button_STOP_GRY = new System.Windows.Forms.Button();
            this.button_RESET = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button_STATEK = new System.Windows.Forms.Button();
            this.button_KAPSULA = new System.Windows.Forms.Button();
            this.button_PALAC = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_CZASY = new System.Windows.Forms.Label();
            this.label_STATEK = new System.Windows.Forms.Label();
            this.label_WOJNA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBar_WOJNA = new System.Windows.Forms.TrackBar();
            this.button_WOJNA = new System.Windows.Forms.Button();
            this.label_KAPSULA = new System.Windows.Forms.Label();
            this.label_PALAC = new System.Windows.Forms.Label();
            this.label_INFO = new System.Windows.Forms.Label();
            this.WOJNA_PLAYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.STATEK_PLAYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.CZASY_PALYER = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox_SPEAK = new System.Windows.Forms.TextBox();
            this.button_PLAY_SPEAK = new System.Windows.Forms.Button();
            this.label_TEMPO = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_VOL_TEKST_NA_MOWE = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBar_TEMPO = new System.Windows.Forms.TrackBar();
            this.trackBar_VOL_TEXT_NA_MOWE = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WOJNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOJNA_PLAYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STATEK_PLAYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CZASY_PALYER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TEMPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VOL_TEXT_NA_MOWE)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(531, 33);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(192, 28);
            this.textBox_message.TabIndex = 0;
            this.textBox_message.Text = "RESET";
            this.textBox_message.Visible = false;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(582, 121);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(82, 20);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Visible = false;
            this.button_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_received
            // 
            this.listBox_received.FormattingEnabled = true;
            this.listBox_received.Location = new System.Drawing.Point(35, 56);
            this.listBox_received.Name = "listBox_received";
            this.listBox_received.Size = new System.Drawing.Size(293, 212);
            this.listBox_received.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(480, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesage";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(452, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Destination";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(531, 69);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(192, 20);
            this.textBox_ip.TabIndex = 6;
            this.textBox_ip.Text = "192.168.100.156";
            this.textBox_ip.Visible = false;
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_ip_TextChanged);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(531, 95);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(192, 20);
            this.textBox_port.TabIndex = 8;
            this.textBox_port.Text = "49955";
            this.textBox_port.Visible = false;
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(499, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ZAMKNIJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSTAWIENIAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSTAWIENIAToolStripMenuItem
            // 
            this.uSTAWIENIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dZWIĘKIToolStripMenuItem});
            this.uSTAWIENIAToolStripMenuItem.Name = "uSTAWIENIAToolStripMenuItem";
            this.uSTAWIENIAToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.uSTAWIENIAToolStripMenuItem.Text = "USTAWIENIA";
            // 
            // dZWIĘKIToolStripMenuItem
            // 
            this.dZWIĘKIToolStripMenuItem.Name = "dZWIĘKIToolStripMenuItem";
            this.dZWIĘKIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dZWIĘKIToolStripMenuItem.Text = "DŹWIĘKI";
            this.dZWIĘKIToolStripMenuItem.Click += new System.EventHandler(this.dZWIĘKIToolStripMenuItem_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.label7);
            this.Panel1.Controls.Add(this.label8);
            this.Panel1.Controls.Add(this.label10);
            this.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel1.Location = new System.Drawing.Point(13, 345);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(351, 41);
            this.Panel1.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(253, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(211, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "75";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(291, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(28, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "CZAS GRY";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_START_GRY
            // 
            this.button_START_GRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_START_GRY.Location = new System.Drawing.Point(13, 391);
            this.button_START_GRY.Name = "button_START_GRY";
            this.button_START_GRY.Size = new System.Drawing.Size(95, 25);
            this.button_START_GRY.TabIndex = 110;
            this.button_START_GRY.Text = "START GRY";
            this.button_START_GRY.UseVisualStyleBackColor = true;
            this.button_START_GRY.Click += new System.EventHandler(this.button_START_GRY_Click);
            // 
            // button_STOP_GRY
            // 
            this.button_STOP_GRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_STOP_GRY.Location = new System.Drawing.Point(142, 391);
            this.button_STOP_GRY.Name = "button_STOP_GRY";
            this.button_STOP_GRY.Size = new System.Drawing.Size(95, 25);
            this.button_STOP_GRY.TabIndex = 111;
            this.button_STOP_GRY.Text = "STOP GRY";
            this.button_STOP_GRY.UseVisualStyleBackColor = true;
            this.button_STOP_GRY.Click += new System.EventHandler(this.button_STOP_GRY_Click);
            // 
            // button_RESET
            // 
            this.button_RESET.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_RESET.Location = new System.Drawing.Point(269, 391);
            this.button_RESET.Name = "button_RESET";
            this.button_RESET.Size = new System.Drawing.Size(95, 25);
            this.button_RESET.TabIndex = 112;
            this.button_RESET.Text = "RESET";
            this.button_RESET.UseVisualStyleBackColor = true;
            this.button_RESET.Click += new System.EventHandler(this.button_RESET_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 25);
            this.button2.TabIndex = 113;
            this.button2.Text = "CZYŚĆ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_STATEK
            // 
            this.button_STATEK.Location = new System.Drawing.Point(356, 143);
            this.button_STATEK.Name = "button_STATEK";
            this.button_STATEK.Size = new System.Drawing.Size(150, 25);
            this.button_STATEK.TabIndex = 114;
            this.button_STATEK.Text = "STATEK";
            this.button_STATEK.UseVisualStyleBackColor = true;
            this.button_STATEK.Click += new System.EventHandler(this.button_STATEK_Click);
            // 
            // button_KAPSULA
            // 
            this.button_KAPSULA.Location = new System.Drawing.Point(356, 188);
            this.button_KAPSULA.Name = "button_KAPSULA";
            this.button_KAPSULA.Size = new System.Drawing.Size(150, 25);
            this.button_KAPSULA.TabIndex = 116;
            this.button_KAPSULA.Text = "KAPSUŁA";
            this.button_KAPSULA.UseVisualStyleBackColor = true;
            this.button_KAPSULA.Click += new System.EventHandler(this.button_KAPSULA_Click);
            // 
            // button_PALAC
            // 
            this.button_PALAC.Location = new System.Drawing.Point(531, 188);
            this.button_PALAC.Name = "button_PALAC";
            this.button_PALAC.Size = new System.Drawing.Size(150, 25);
            this.button_PALAC.TabIndex = 117;
            this.button_PALAC.Text = "PAŁAC";
            this.button_PALAC.UseVisualStyleBackColor = true;
            this.button_PALAC.Click += new System.EventHandler(this.button_PALAC_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(380, 245);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(291, 45);
            this.trackBar1.TabIndex = 120;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(380, 320);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(291, 45);
            this.trackBar2.TabIndex = 121;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(511, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(511, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "0";
            // 
            // label_CZASY
            // 
            this.label_CZASY.AutoSize = true;
            this.label_CZASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CZASY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_CZASY.Location = new System.Drawing.Point(498, 229);
            this.label_CZASY.Name = "label_CZASY";
            this.label_CZASY.Size = new System.Drawing.Size(47, 13);
            this.label_CZASY.TabIndex = 124;
            this.label_CZASY.Text = "CZASY";
            // 
            // label_STATEK
            // 
            this.label_STATEK.AutoSize = true;
            this.label_STATEK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_STATEK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_STATEK.Location = new System.Drawing.Point(432, 304);
            this.label_STATEK.Name = "label_STATEK";
            this.label_STATEK.Size = new System.Drawing.Size(55, 13);
            this.label_STATEK.TabIndex = 125;
            this.label_STATEK.Text = "STATEK";
            // 
            // label_WOJNA
            // 
            this.label_WOJNA.AutoSize = true;
            this.label_WOJNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_WOJNA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_WOJNA.Location = new System.Drawing.Point(494, 374);
            this.label_WOJNA.Name = "label_WOJNA";
            this.label_WOJNA.Size = new System.Drawing.Size(51, 13);
            this.label_WOJNA.TabIndex = 128;
            this.label_WOJNA.Text = "WOJNA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(511, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 127;
            this.label14.Text = "0";
            // 
            // trackBar_WOJNA
            // 
            this.trackBar_WOJNA.Location = new System.Drawing.Point(380, 391);
            this.trackBar_WOJNA.Maximum = 100;
            this.trackBar_WOJNA.Name = "trackBar_WOJNA";
            this.trackBar_WOJNA.Size = new System.Drawing.Size(291, 45);
            this.trackBar_WOJNA.TabIndex = 126;
            this.trackBar_WOJNA.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // button_WOJNA
            // 
            this.button_WOJNA.Location = new System.Drawing.Point(531, 143);
            this.button_WOJNA.Name = "button_WOJNA";
            this.button_WOJNA.Size = new System.Drawing.Size(150, 25);
            this.button_WOJNA.TabIndex = 132;
            this.button_WOJNA.Text = "WOJNA";
            this.button_WOJNA.UseVisualStyleBackColor = true;
            this.button_WOJNA.Click += new System.EventHandler(this.button_WOJNA_Click);
            // 
            // label_KAPSULA
            // 
            this.label_KAPSULA.AutoSize = true;
            this.label_KAPSULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_KAPSULA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_KAPSULA.Location = new System.Drawing.Point(493, 304);
            this.label_KAPSULA.Name = "label_KAPSULA";
            this.label_KAPSULA.Size = new System.Drawing.Size(64, 13);
            this.label_KAPSULA.TabIndex = 133;
            this.label_KAPSULA.Text = "KAPSUŁA";
            // 
            // label_PALAC
            // 
            this.label_PALAC.AutoSize = true;
            this.label_PALAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PALAC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_PALAC.Location = new System.Drawing.Point(563, 304);
            this.label_PALAC.Name = "label_PALAC";
            this.label_PALAC.Size = new System.Drawing.Size(47, 13);
            this.label_PALAC.TabIndex = 134;
            this.label_PALAC.Text = "PAŁAC";
            // 
            // label_INFO
            // 
            this.label_INFO.AutoSize = true;
            this.label_INFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_INFO.ForeColor = System.Drawing.Color.Lime;
            this.label_INFO.Location = new System.Drawing.Point(121, 314);
            this.label_INFO.Name = "label_INFO";
            this.label_INFO.Size = new System.Drawing.Size(140, 24);
            this.label_INFO.TabIndex = 135;
            this.label_INFO.Text = "GRA W TOKU";
            // 
            // WOJNA_PLAYER
            // 
            this.WOJNA_PLAYER.Enabled = true;
            this.WOJNA_PLAYER.Location = new System.Drawing.Point(357, 72);
            this.WOJNA_PLAYER.Name = "WOJNA_PLAYER";
            this.WOJNA_PLAYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WOJNA_PLAYER.OcxState")));
            this.WOJNA_PLAYER.Size = new System.Drawing.Size(75, 23);
            this.WOJNA_PLAYER.TabIndex = 119;
            this.WOJNA_PLAYER.Visible = false;
            this.WOJNA_PLAYER.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WOJNA_PLAYER_PlayStateChange);
            // 
            // STATEK_PLAYER
            // 
            this.STATEK_PLAYER.Enabled = true;
            this.STATEK_PLAYER.Location = new System.Drawing.Point(359, 33);
            this.STATEK_PLAYER.Name = "STATEK_PLAYER";
            this.STATEK_PLAYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("STATEK_PLAYER.OcxState")));
            this.STATEK_PLAYER.Size = new System.Drawing.Size(96, 32);
            this.STATEK_PLAYER.TabIndex = 118;
            this.STATEK_PLAYER.Visible = false;
            this.STATEK_PLAYER.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.STATEK_PLAYER_PlayStateChange);
            // 
            // CZASY_PALYER
            // 
            this.CZASY_PALYER.Enabled = true;
            this.CZASY_PALYER.Location = new System.Drawing.Point(364, 95);
            this.CZASY_PALYER.Name = "CZASY_PALYER";
            this.CZASY_PALYER.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CZASY_PALYER.OcxState")));
            this.CZASY_PALYER.Size = new System.Drawing.Size(68, 46);
            this.CZASY_PALYER.TabIndex = 10;
            this.CZASY_PALYER.Visible = false;
            this.CZASY_PALYER.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.CZASY_PALYER_PlayStateChange);
            // 
            // textBox_SPEAK
            // 
            this.textBox_SPEAK.Location = new System.Drawing.Point(751, 56);
            this.textBox_SPEAK.Multiline = true;
            this.textBox_SPEAK.Name = "textBox_SPEAK";
            this.textBox_SPEAK.Size = new System.Drawing.Size(314, 135);
            this.textBox_SPEAK.TabIndex = 136;
            // 
            // button_PLAY_SPEAK
            // 
            this.button_PLAY_SPEAK.Location = new System.Drawing.Point(875, 245);
            this.button_PLAY_SPEAK.Name = "button_PLAY_SPEAK";
            this.button_PLAY_SPEAK.Size = new System.Drawing.Size(75, 23);
            this.button_PLAY_SPEAK.TabIndex = 137;
            this.button_PLAY_SPEAK.Text = "PLAY";
            this.button_PLAY_SPEAK.UseVisualStyleBackColor = true;
            this.button_PLAY_SPEAK.Click += new System.EventHandler(this.button_PLAY_SPEAK_Click);
            // 
            // label_TEMPO
            // 
            this.label_TEMPO.AutoSize = true;
            this.label_TEMPO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TEMPO.Location = new System.Drawing.Point(903, 423);
            this.label_TEMPO.Name = "label_TEMPO";
            this.label_TEMPO.Size = new System.Drawing.Size(13, 13);
            this.label_TEMPO.TabIndex = 143;
            this.label_TEMPO.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(887, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 142;
            this.label12.Text = "TEMPO";
            // 
            // label_VOL_TEKST_NA_MOWE
            // 
            this.label_VOL_TEKST_NA_MOWE.AutoSize = true;
            this.label_VOL_TEKST_NA_MOWE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_VOL_TEKST_NA_MOWE.Location = new System.Drawing.Point(903, 351);
            this.label_VOL_TEKST_NA_MOWE.Name = "label_VOL_TEKST_NA_MOWE";
            this.label_VOL_TEKST_NA_MOWE.Size = new System.Drawing.Size(13, 13);
            this.label_VOL_TEKST_NA_MOWE.TabIndex = 141;
            this.label_VOL_TEKST_NA_MOWE.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(830, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "VOLUME TEKST NA MOWĘ";
            // 
            // trackBar_TEMPO
            // 
            this.trackBar_TEMPO.Location = new System.Drawing.Point(855, 391);
            this.trackBar_TEMPO.Minimum = -10;
            this.trackBar_TEMPO.Name = "trackBar_TEMPO";
            this.trackBar_TEMPO.Size = new System.Drawing.Size(104, 45);
            this.trackBar_TEMPO.TabIndex = 139;
            this.trackBar_TEMPO.Value = 10;
            this.trackBar_TEMPO.Scroll += new System.EventHandler(this.trackBar_TEMPO_Scroll);
            // 
            // trackBar_VOL_TEXT_NA_MOWE
            // 
            this.trackBar_VOL_TEXT_NA_MOWE.Location = new System.Drawing.Point(751, 320);
            this.trackBar_VOL_TEXT_NA_MOWE.Maximum = 100;
            this.trackBar_VOL_TEXT_NA_MOWE.Name = "trackBar_VOL_TEXT_NA_MOWE";
            this.trackBar_VOL_TEXT_NA_MOWE.Size = new System.Drawing.Size(314, 45);
            this.trackBar_VOL_TEXT_NA_MOWE.TabIndex = 138;
            this.trackBar_VOL_TEXT_NA_MOWE.Scroll += new System.EventHandler(this.trackBar_VOL_TEXT_NA_MOWE_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(748, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 144;
            this.label11.Text = "TEKST NA MOWĘ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1097, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_TEMPO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_VOL_TEKST_NA_MOWE);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.trackBar_TEMPO);
            this.Controls.Add(this.trackBar_VOL_TEXT_NA_MOWE);
            this.Controls.Add(this.button_PLAY_SPEAK);
            this.Controls.Add(this.textBox_SPEAK);
            this.Controls.Add(this.label_INFO);
            this.Controls.Add(this.label_PALAC);
            this.Controls.Add(this.label_KAPSULA);
            this.Controls.Add(this.button_WOJNA);
            this.Controls.Add(this.label_WOJNA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackBar_WOJNA);
            this.Controls.Add(this.label_STATEK);
            this.Controls.Add(this.label_CZASY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.WOJNA_PLAYER);
            this.Controls.Add(this.STATEK_PLAYER);
            this.Controls.Add(this.button_PALAC);
            this.Controls.Add(this.button_KAPSULA);
            this.Controls.Add(this.button_STATEK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_RESET);
            this.Controls.Add(this.button_STOP_GRY);
            this.Controls.Add(this.button_START_GRY);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.CZASY_PALYER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_received);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GALAKTYKA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_WOJNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOJNA_PLAYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STATEK_PLAYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CZASY_PALYER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TEMPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VOL_TEXT_NA_MOWE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ListBox listBox_received;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer CZASY_PALYER;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSTAWIENIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dZWIĘKIToolStripMenuItem;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_START_GRY;
        private System.Windows.Forms.Button button_STOP_GRY;
        private System.Windows.Forms.Button button_RESET;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_STATEK;
        private System.Windows.Forms.Button button_KAPSULA;
        private System.Windows.Forms.Button button_PALAC;
        private AxWMPLib.AxWindowsMediaPlayer STATEK_PLAYER;
        private AxWMPLib.AxWindowsMediaPlayer WOJNA_PLAYER;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_CZASY;
        private System.Windows.Forms.Label label_STATEK;
        private System.Windows.Forms.Label label_WOJNA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBar_WOJNA;
        private System.Windows.Forms.Button button_WOJNA;
        private System.Windows.Forms.Label label_KAPSULA;
        private System.Windows.Forms.Label label_PALAC;
        private System.Windows.Forms.Label label_INFO;
        private System.Windows.Forms.TextBox textBox_SPEAK;
        private System.Windows.Forms.Button button_PLAY_SPEAK;
        private System.Windows.Forms.Label label_TEMPO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_VOL_TEKST_NA_MOWE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackBar_TEMPO;
        private System.Windows.Forms.TrackBar trackBar_VOL_TEXT_NA_MOWE;
        private System.Windows.Forms.Label label11;
    }
}

