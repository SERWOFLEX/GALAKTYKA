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
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Management;
using WebSocket4Net;
using Newtonsoft.Json;








namespace ConsoleApplication2udp
{
    public partial class Form1 : Form
    {

        
               
        WebSocket websocket = new WebSocket("ws://192.168.100.164:4444/");

        private SpeechSynthesizer _SS = new SpeechSynthesizer();
        public int tempo = -2;
        public int SSvolume = 80;

        public int minuty = 75;
        public int sekundy = 60;
        public int stan_GRY = 0;
        public string nazwa = "Urządzenie do przechwytywania wideo";
        public string nazwa2 = "Obraz 2";
        public bool costam = true;
        public bool wersja_jezykowa;
        public int czas_odliczania_pl;
        public int czas_odliczania_en;

        public Form1()
        {
           
           // websocket.Opened += new EventHandler(websocket_Opened);
            //websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            //websocket.Closed += new EventHandler(websocket_Closed);
           //websocket.MessageReceived += new EventHandler(websocket_MessageReceived);
           // websocket.Open();

            _SS.Volume = SSvolume;
            _SS.Rate = tempo;
            InitializeComponent();
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            //comboBox1.Items.AddRange(devices.ToArray());
        }
        


                public void MySocketClosed(object s, EventArgs e)
        {
            //button4.BackColor = Color.Red;
           // label16.Text = websocket.State.ToString();
            // MessageBox.Show("Połączenie z OBS jest zamknięte" & vbCrLf & "Sprawdź czy uruchomiono OBS na komputerze docelowym")
            // Close()
            // End
            //CheckForIllegalCrossThreadCalls = true;
        }

        public void MySocketOpened(object s, EventArgs e)
        {
           // label16.Text = websocket.State.ToString();
           // button4.BackColor = Color.Green;
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form.KeyPreview = true;
            timer1.Start();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // 
            //axWindowsMediaPlayer1.Height *= 2;
           EKRANY_PALYER.URL = "C:\\FILMY\\start.mp4";
           
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            if (EKRANY_PALYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //  axWindowsMediaPlayer1.fullScreen = false;
                this.WindowState = FormWindowState.Maximized;
            }
            EKRANY_PALYER.Ctlcontrols.pause();

            //EKRANY_PALYER.settings.setMode("Loop", true);

            czas_odliczania_pl = Properties.Settings.Default.CZAS_ODLICZANIA_PL;
            czas_odliczania_en = Properties.Settings.Default.CZAS_ODLICZANIA_EN;
           

            bool isAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (isAvailable == true)
            {
                Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
                thdUDPServer.Start();
               
                //listBox_received.Items.Add();
                
            }
            else
            {
                // MessageBox.Show("BRAK POŁACZENIA Z SIECIĄ");
               
            }

            //Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            //thdUDPServer.Start();
           START_EKRANY();
        }

        public void ServerThread()
        {


            UdpClient udpClient = new UdpClient(Convert.ToInt32(49955));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(49955));
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
               
                this.Invoke(new MethodInvoker(delegate()
                {

                   // listBox_received.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                   // listBox_received.SelectedIndex = listBox_received.Items.Count - 1;
                   //listBox_received.SelectedIndex = -1;

                    
                    if (returnData == "STOP")
                    {
                        foreach (var process in Process.GetProcessesByName("GALAKTYKA EKRANY"))
                        {
                            process.Kill();
                        }
                    }
                    if (returnData == "WOJNA")
                    {
                        
                        EKRANY_PALYER.URL = "C:\\FILMY\\wojna.mp4";
                        EKRANY_PALYER.settings.setMode("Loop", true);
                        WYSYLKA("START WOJNA");
                    }
                    if (returnData == "KOSMOS")
                    {
                       
                        EKRANY_PALYER.URL = "C:\\FILMY\\gwiazdy.mp4";
                        EKRANY_PALYER.settings.setMode("Loop", true);
                        WYSYLKA("START KOSMOS");
                    }
                    if (returnData == "RESET")
                    {
                        EKRANY_PALYER.URL = "C:\\FILMY\\start.mp4";
                        timer_PAUZA.Start();

                        SUBWOFER_PLAYER.Ctlcontrols.stop();
                        EKRANY_PALYER.settings.setMode("Loop", false);
                        WYSYLKA("RESET EKRANY");
                        timer_ZMIANA_KOSMOS.Stop();
                        timer_START_STATKU.Stop();
                    }
                    if (returnData == "START")
                    {

                        EKRANY_PALYER.Ctlcontrols.play();
                        SUBWOFER_PLAYER.URL = "C:\\FILMY\\start_muza.mp3";
                        WYSYLKA("START STATKU");
                    }

                    if (returnData == "DOWN")
                    {
                           WYSYLKA("ZAMYKAM KOMPUTER EKRANY");
                        Shutdown();
                        foreach (var process in Process.GetProcessesByName("GALAKTYKA EKRANY"))
                        {
                            process.Kill();
                        }
                        
                    }
                    if (returnData == "START GRY PL")
                    {
                        timer_START_STATKU.Interval = czas_odliczania_pl;
                        timer_START_STATKU.Start();
                        //EKRANY_PALYER.Ctlcontrols.play();
                        //SUBWOFER_PLAYER.URL = "C:\\FILMY\\start_muza.mp3";
                       // WYSYLKA("START STATKU");
                    }
                    if (returnData == "START GRY EN")
                    {
                        timer_START_STATKU.Interval = czas_odliczania_en;
                        timer_START_STATKU.Start();
                        //EKRANY_PALYER.Ctlcontrols.play();
                        //SUBWOFER_PLAYER.URL = "C:\\FILMY\\start_muza.mp3";
                        //WYSYLKA("START STATKU");
                    }

                    if((returnData.Length >= 7)&& (returnData.Length <= 11))
                    {
                        if(returnData.Substring(0,6) == "CZASPL")
                        {
                          

                             if (Int32.TryParse(returnData.Substring(6, returnData.Length - 6), out czas_odliczania_pl))
                             {
                                Properties.Settings.Default.CZAS_ODLICZANIA_PL = czas_odliczania_pl;
                                Properties.Settings.Default.Save();
                                WYSYLKA("ZMIENIONO CZAS ODLICZANIA PL  " + czas_odliczania_pl.ToString());
                            }
                           
                        }

                        if (returnData.Substring(0, 6) == "CZASEN")
                        {


                            if (Int32.TryParse(returnData.Substring(6, returnData.Length - 6), out czas_odliczania_en))
                            {
                                Properties.Settings.Default.CZAS_ODLICZANIA_EN = czas_odliczania_en;
                                Properties.Settings.Default.Save();
                                WYSYLKA("ZMIENIONO CZAS ODLICZANIA EN  " + czas_odliczania_en.ToString());
                            }

                        }
                    }



                    returnData = "";
                }));
            }
        }
        void Shutdown()
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            foreach (var process in Process.GetProcessesByName("GALAKTYKA EKRANY"))
            {
                process.Kill();
            }
        }
        private void timer_PAUZA_Tick(object sender, EventArgs e)
        {
            timer_PAUZA.Stop();
            EKRANY_PALYER.Ctlcontrols.pause();
        }

        
        

        private void dZWIĘKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        
        private void START_EKRANY()
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect("192.168.1.101", 49955);


            Byte[] senddata = Encoding.ASCII.GetBytes("START EKRANY");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }


        }

        private void WYSYLKA(String message)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect("192.168.1.101", 49955);


            Byte[] senddata = Encoding.ASCII.GetBytes(message);

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }


        }









        private void CZASY_PALYER_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if (WOJNA_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
          //  {
           //     label_CZASY.ForeColor = Color.Lime;
           // }
           // if (WOJNA_PLAYER.playState == WMPLib.WMPPlayState.wmppsStopped)
           // {
           //     label_CZASY.ForeColor = Color.White;
           // }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EKRANY_PALYER.Ctlcontrols.pause();
            timer1.Stop();
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                foreach (var process in Process.GetProcessesByName("GALAKTYKA EKRANY"))
                {
                    process.Kill();
                }
            }
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs kea)
        {
            if (kea.KeyCode.Equals(Keys.Escape))
            {
                foreach (var process in Process.GetProcessesByName("GALAKTYKA EKRANY"))
                {
                    process.Kill();
                }
            }
            if (kea.KeyCode.Equals(Keys.F1))
            {
                EKRANY_PALYER.Ctlcontrols.play();
                SUBWOFER_PLAYER.URL= "C:\\FILMY\\start_muza.mp3";
            }
            if (kea.KeyCode.Equals(Keys.F2))
            {
                EKRANY_PALYER.URL = "C:\\FILMY\\start.mp4";
                EKRANY_PALYER.settings.setMode("Loop", true);
                
            }
            if (kea.KeyCode.Equals(Keys.F3))
            {
                EKRANY_PALYER.URL = "C:\\FILMY\\wojna.mp4";
                EKRANY_PALYER.settings.setMode("Loop", true);
                SUBWOFER_PLAYER.Ctlcontrols.stop();
            }
        }

        private void timer_ZMIANA_KOSMOS_Tick(object sender, EventArgs e)
        {
            EKRANY_PALYER.URL = "C:\\FILMY\\gwiazdy.mp4";
            EKRANY_PALYER.settings.setMode("Loop", true);
            WYSYLKA("START KOSMOS");
            SUBWOFER_PLAYER.Ctlcontrols.stop();
            timer_ZMIANA_KOSMOS.Stop();
        }

        private void timer_START_STATKU_Tick(object sender, EventArgs e)
        {
            EKRANY_PALYER.Ctlcontrols.play();
            SUBWOFER_PLAYER.URL = "C:\\FILMY\\start_muza.mp3";
            WYSYLKA("START STATKU");
            timer_ZMIANA_KOSMOS.Start();
            timer_START_STATKU.Stop();
        }
    }
}
