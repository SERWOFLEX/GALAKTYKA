using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Speech;
using System.Speech.Synthesis;

namespace ConsoleApplication2udp
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer _SS = new SpeechSynthesizer();
        public int tempo = -2;
        public int SSvolume = 80;

        public int minuty = 75;
        public int sekundy = 60;
        public int stan_GRY = 0;

        public Form1()
        {
            _SS.Volume = SSvolume;
            _SS.Rate = tempo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(textBox_ip.Text, Convert.ToInt32(textBox_port.Text));
         

                Byte[] senddata = Encoding.ASCII.GetBytes(textBox_message.Text);

                udpClient.Send(senddata, senddata.Length);

                udpClient.Close();
            
            for(int i = 0;i< senddata.Length; i++)
            {
                senddata[i] = 0;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label_INFO.Text = "";
            STATEK_PLAYER.settings.volume = 50;
            trackBar2.Value = STATEK_PLAYER.settings.volume;
           String vol_muz = STATEK_PLAYER.settings.volume.ToString();
            label9.Text = vol_muz;

            CZASY_PALYER.settings.volume = 50;
            trackBar1.Value = CZASY_PALYER.settings.volume;
            String vol_efekt = CZASY_PALYER.settings.volume.ToString();
            label6.Text = vol_efekt;

            WOJNA_PLAYER.settings.volume = 50;
            trackBar_WOJNA.Value = WOJNA_PLAYER.settings.volume;
            String vol_odlicz = WOJNA_PLAYER.settings.volume.ToString();
            label14.Text = vol_odlicz;

            _SS.Volume = SSvolume;
            trackBar_VOL_TEXT_NA_MOWE.Value = SSvolume;
            String vol_TEXT = SSvolume.ToString();
            label_VOL_TEKST_NA_MOWE.Text = vol_TEXT;

            _SS.Rate = tempo;
            trackBar_TEMPO.Value = _SS.Rate;
            String TEMPO = tempo.ToString();
            label_TEMPO.Text = TEMPO;



            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread()
        {


            UdpClient udpClient = new UdpClient(Convert.ToInt32(textBox_port.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox_port.Text));
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
               
                this.Invoke(new MethodInvoker(delegate()
                {

                    listBox_received.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                    listBox_received.SelectedIndex = listBox_received.Items.Count - 1;
                    listBox_received.SelectedIndex = -1;

                    if (returnData == "START GRY")
                    // if (returnData.ToString() == "ODEBRANO" + "\r")
                    {
                        if (stan_GRY == 0) { 
                        minuty = 74;
                        STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA;
                        timer1.Start();
                            stan_GRY = 1;
                        }   

                    }
                    if (returnData == "START GRY")
                    {
                        button_START_GRY.PerformClick();
                    }

                    if (returnData == "PLAY ODLICZANIE")
                    {
                        button_KAPSULA.PerformClick();
                    }

                    if (returnData == "PLAY PALAC")
                    {
                        button_PALAC.PerformClick();
                    }


                }));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach(var process in Process.GetProcessesByName("GALAKTYKA TAJEMNIC"))
            {
                process.Kill();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            sekundy--;

            String min = minuty.ToString();
            String sek = sekundy.ToString();

            label8.Text = sek;
            label7.Text = min;
            if (sekundy == 0)
            {
                minuty--;
                sekundy = 60;
            }

            if ((min == "60") && (sek == "0"))
            {
                
               
                 CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_15_SCIEZKA;
                


            }
            if ((min == "45") && (sek == "0"))
            {
                CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_30_SCIEZKA;

            }
            if ((min == "30") && (sek == "0"))
            {
                CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_45_SCIEZKA;

            }
            if ((min == "15") && (sek == "0"))
            {
                CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_60_SCIEZKA;

            }
            if ((min == "5") && (sek == "0"))
            {
                CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_5_SCIEZKA;

            }
        }

        private void button_START_GRY_Click(object sender, EventArgs e)
        {
            minuty = 74;
            sekundy = 60;
            timer1.Start();
            stan_GRY = 1;
            STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA;
        }

        private void button_STOP_GRY_Click(object sender, EventArgs e)
        {
            label_INFO.Text = "";
            timer1.Stop();
            WOJNA_PLAYER.Ctlcontrols.stop();
            STATEK_PLAYER.Ctlcontrols.stop();
            CZASY_PALYER.Ctlcontrols.stop();
            button_STATEK.Text = "STATEK";
            button_KAPSULA.Text = "KAPSUŁA";
            button_PALAC.Text = "PAŁAC";
            button_WOJNA.Text = "WOJNA";
        }

        private void button_RESET_Click(object sender, EventArgs e)
        {
            WOJNA_PLAYER.Ctlcontrols.stop();
            STATEK_PLAYER.Ctlcontrols.stop();
            CZASY_PALYER.Ctlcontrols.stop();
            button_STATEK.Text = "STATEK";
            button_KAPSULA.Text = "KAPSUŁA";
            button_PALAC.Text = "PAŁAC";
            button_WOJNA.Text = "WOJNA";
            label_INFO.Text = "";

            timer1.Stop();
          sekundy = 60;
           minuty = 75;
            label8.Text = "0";
            label7.Text = "75";
            listBox_received.Items.Clear();
            stan_GRY = 0;
        }

        private void dZWIĘKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_received.Items.Clear();
        }

        private void button_STATEK_Click(object sender, EventArgs e)
        {
            button_KAPSULA.Text = "KAPSUŁA";
            button_PALAC.Text = "PAŁAC";
            if (button_STATEK.Text == "STATEK")
            {
                button_STATEK.Text = "STATEK STOP";
                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA;
            }
           else if (button_STATEK.Text == "STATEK STOP")
            {
                button_STATEK.Text = "STATEK";
               STATEK_PLAYER.Ctlcontrols.stop();
            }
        }
        private void button_WOJNA_Click(object sender, EventArgs e)

        {

            if (button_WOJNA.Text == "WOJNA")
            {
                WOJNA_PLAYER.URL = Properties.Settings.Default.MUZYKA_WOJNA_SCIEZKA;
                button_WOJNA.Text = "WOJNA STOP";
            }
            else if (button_WOJNA.Text == "WOJNA STOP")
            {
                WOJNA_PLAYER.Ctlcontrols.stop();
                button_WOJNA.Text = "WOJNA";
            }
        }

        private void button_KAPSULA_Click(object sender, EventArgs e)
        {
            button_PALAC.Text = "PAŁAC";
            button_STATEK.Text = "STATEK";
            //STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA;
            // WOJNA_PLAYER.Ctlcontrols.stop();

            if (button_KAPSULA.Text == "KAPSUŁA")
            {
                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA;
                WOJNA_PLAYER.Ctlcontrols.stop();
                button_KAPSULA.Text = "KAPSUŁA STOP";
            }
            else if (button_KAPSULA.Text == "KAPSUŁA STOP")
            {
                STATEK_PLAYER.Ctlcontrols.stop();
                button_KAPSULA.Text = "KAPSUŁA";
            }
        }

        private void button_PALAC_Click(object sender, EventArgs e)
        {
            button_STATEK.Text = "STATEK";
            button_KAPSULA.Text = "KAPSUŁA";
            if (button_PALAC.Text == "PAŁAC")
            {
                button_PALAC.Text = "PAŁAC STOP";
                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_PALAC_SCIEZKA;
            }
            else if (button_PALAC.Text == "PAŁAC STOP")
            {
                button_PALAC.Text = "PAŁAC";
                STATEK_PLAYER.Ctlcontrols.stop();
            }
            
        }

      
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            String val = trackBar1.Value.ToString();
            label6.Text = val;
            CZASY_PALYER.settings.volume = trackBar1.Value;

        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            String val = trackBar2.Value.ToString();
            label9.Text = val;
            STATEK_PLAYER.settings.volume = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            String val = trackBar_WOJNA.Value.ToString();
            label14.Text = val;
            WOJNA_PLAYER.settings.volume = trackBar_WOJNA.Value;
        }

        private void STATEK_PLAYER_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (STATEK_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (STATEK_PLAYER.URL == Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA)
                {
                    button_STATEK.BackColor = Color.Green;
                    label_STATEK.ForeColor = Color.Lime;
                    button_STATEK.Text = "STATEK STOP";
                    label_INFO.Text = "GRA W TOKU";
                }
                if (STATEK_PLAYER.URL == Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA)
                {
                    button_KAPSULA.BackColor = Color.Green;
                    label_KAPSULA.ForeColor = Color.Lime;
                }
                if (STATEK_PLAYER.URL == Properties.Settings.Default.MUZYKA_PALAC_SCIEZKA)
                {
                    button_PALAC.BackColor = Color.Green;
                    label_PALAC.ForeColor = Color.Lime;
                }

            }
            else
            {
                button_STATEK.BackColor = DefaultBackColor;
                button_KAPSULA.BackColor = DefaultBackColor;
                button_PALAC.BackColor = DefaultBackColor;
                label_STATEK.ForeColor = Color.White;
                label_KAPSULA.ForeColor = Color.White;
                label_PALAC.ForeColor = Color.White;

            }

            if (STATEK_PLAYER.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                button_STATEK.BackColor = DefaultBackColor;
                button_KAPSULA.BackColor = DefaultBackColor;
                button_PALAC.BackColor = DefaultBackColor;
                label_STATEK.ForeColor = Color.White;
                label_KAPSULA.ForeColor = Color.White;
                label_PALAC.ForeColor = Color.White;
                button_STATEK.Text = "STATEK";
                button_KAPSULA.Text = "KAPSUŁA";
                button_PALAC.Text = "PAŁAC";

                //button_KAPSULA.Text = "KAPSUŁA";
                //button_KAPSULA.BackColor = DefaultBackColor;
            }
          //  if (STATEK_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
           // {
                //button_KAPSULA.Text = "KAPSUŁA STOP";
               // button_KAPSULA.BackColor = Color.Green;
          //  }

        }

        private void WOJNA_PLAYER_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WOJNA_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (WOJNA_PLAYER.URL == Properties.Settings.Default.MUZYKA_WOJNA_SCIEZKA)
                {
                    button_WOJNA.BackColor = Color.Green;
                    label_WOJNA.ForeColor = Color.Lime;
                }
               

            }
            else
            {
                button_WOJNA.BackColor = DefaultBackColor;
                label_WOJNA.ForeColor = Color.White;
                button_WOJNA.Text = "WOJNA";

            }
        }

        private void CZASY_PALYER_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (WOJNA_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label_CZASY.ForeColor = Color.Lime;
            }
            if (WOJNA_PLAYER.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                label_CZASY.ForeColor = Color.White;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_message_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_PLAY_SPEAK_Click(object sender, EventArgs e)
        {
            _SS.SpeakAsync(textBox_SPEAK.Text);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            _SS.SpeakAsyncCancelAll();
            base.OnClosing(e);


        }

        private void trackBar_VOL_TEXT_NA_MOWE_Scroll(object sender, EventArgs e)
        {
            String val = trackBar_VOL_TEXT_NA_MOWE.Value.ToString();
            label_VOL_TEKST_NA_MOWE.Text = val;
            _SS.Volume = trackBar_VOL_TEXT_NA_MOWE.Value;
            SSvolume = trackBar_VOL_TEXT_NA_MOWE.Value;
        }

        private void trackBar_TEMPO_Scroll(object sender, EventArgs e)
        {
            String val1 = trackBar_TEMPO.Value.ToString();
            label_TEMPO.Text = val1;
            _SS.Rate = trackBar_TEMPO.Value;
            tempo = trackBar_TEMPO.Value;
        }
    }
}
