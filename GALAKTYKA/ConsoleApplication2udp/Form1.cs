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


        private void button1_Click(object sender, EventArgs e)
        {
           
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(textBox_ip.Text, Convert.ToInt32(textBox_port.Text));


             Byte[] senddata = Encoding.ASCII.GetBytes(textBox_message.Text);
            //Byte[] senddata = Encoding.UTF8.GetBytes("1".ToArray());

            udpClient.Send(senddata, senddata.Length);

                udpClient.Close();
            
            for(int i = 0;i< senddata.Length; i++)
            {
                senddata[i] = 0;
            }
            //comboBox1.Items.Clear();
            //   NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            //   var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            //   comboBox1.Items.AddRange(devices.ToArray());
            // label13.Text = NAudio.CoreAudioApi.DeviceState.Disabled.ToString();
            //label13.Text = "";
            //var enumerator = new MMDeviceEnumerator();
           // foreach (var endpoint in
            //         enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
            //{
            //    Console.WriteLine(endpoint.FriendlyName);
            }
            //ManagementObjectSearcher mo = new ManagementObjectSearcher("select * from Win32_SoundDevice");

            //foreach (ManagementObject soundDevice in mo.Get())
            //{
           //     Console.WriteLine(soundDevice.GetPropertyValue("DeviceId"));
            //    Console.WriteLine(soundDevice.GetPropertyValue("Manufacturer"));
                // etc                       
           // }

       // }

        private void Form1_Load(object sender, EventArgs e)
        {
            wersja_jezykowa = false;


            

            foreach (var voice in _SS.GetInstalledVoices())
            {
                comboBox_LISTA_JEZYKOW.Items.Add(voice.VoiceInfo.Name);
            }

            timer4.Start();
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

           // IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach(IPAddress address in localIP)
           // {
           //     if (address.AddressFamily == AddressFamily.InterNetwork)
            //        listBox_received.Items.Add(address.ToString());
            //    listBox_received.Items.Add(Dns.GetHostName().ToString());
           // }


            bool isAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (isAvailable == true)
            {
                Thread thdUDPServer = new Thread(new ThreadStart(ServerThread));
                thdUDPServer.Start();
                timer2.Start();
                //listBox_received.Items.Add();
                
            }
            else
            {
                // MessageBox.Show("BRAK POŁACZENIA Z SIECIĄ");
                label_SIEC.Text = "BRAK POŁACZENIA Z SIECIĄ SPRAWDŹ POŁĄCZENIE I URUCHOM PONOWNIE PROGRAM";
            }

            //Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            //thdUDPServer.Start();
            if (Properties.Settings.Default.WERSJA_JEZYKOWA == false)
            {
                button_WERSJA_JEZYKOWA.Text = "WERSJA POLSKA";
            }
            if (Properties.Settings.Default.WERSJA_JEZYKOWA == true)
            {
                button_WERSJA_JEZYKOWA.Text = "WERSJA ANGIELSKA";
            }
        }

        public void ServerThread()
        {


            UdpClient udpClient = new UdpClient(Convert.ToInt32(textBox_port.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox_port.Text));
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
               
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
                            if(wersja_jezykowa == false)
                            {
                                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA;
                            }
                            if (wersja_jezykowa == true)
                            {
                                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA;
                            }

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
                        STATEK_PLAYER.settings.volume = 10;
                        trackBar2.Value = STATEK_PLAYER.settings.volume;
                        String vol_muz = STATEK_PLAYER.settings.volume.ToString();
                        label9.Text = vol_muz;
                    }
                    if (returnData == "WYJSCIE AKTYWNE")
                    {
                        button_AKTYWACJA_WYJSCIE.BackColor = Color.Green;
                        WOJNA_PLAYER.URL = Properties.Settings.Default.WYJSCIE_EFEKT_SCIEZKA;

                    }
                    if (returnData == "WYJSCIE NIE AKTYWNE")
                    {
                        button_AKTYWACJA_WYJSCIE.BackColor = DefaultBackColor;
                       

                    }
                    if (returnData == "ZWORA KAPSULA ON")
                    {
                        button_ZWORA_KAPSULA.BackColor = Color.Green;


                    }
                    if ((returnData == "START EKRANY")||(returnData == "RESET EKRANY"))
                    {
                        button_STATUS_EKRANY.BackColor = Color.Green;
                    }
                    if ((returnData == "CENTRALNY ZALOGOWANY") || (returnData == "PRZYCISKI ZRESETOWANE"))
                    {
                        button_STATUS_CENTRALNY.BackColor = Color.Green;
                    }
                    if ((returnData == "TABLET REBEL START") || (returnData == "RESET TABLET"))
                    {
                        button_STATUS_TABLET.BackColor = Color.Green;
                    }
                    if (returnData == "START STATKU")
                    {
                        button_START_STATKU.BackColor = Color.Green;
                       
                    }
                    if (returnData == "START KOSMOS")
                    {
                        button_START_KOSMOS.BackColor = Color.Green;
                        button_START_STATKU.BackColor = DefaultBackColor;

                    }
                    if (returnData == "START WOJNA")
                    {
                        button_START_KOSMOS.BackColor = DefaultBackColor;
                        button_START_WOJNA.BackColor = Color.Green;

                    }


                    returnData = "";
                }));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Properties.Settings.Default.WERSJA_JEZYKOWA = wersja_jezykowa;
            Properties.Settings.Default.Save();
            foreach (var process in Process.GetProcessesByName("GALAKTYKA TAJEMNIC"))
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

          //  if ((min == "60") && (sek == "0"))
           // {
                
               
              //   CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_15_SCIEZKA;
                


          //  }
          //  if ((min == "45") && (sek == "0"))
           // {
            //    CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_30_SCIEZKA;

           // }
           // if ((min == "30") && (sek == "0"))
           // {
               // CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_45_SCIEZKA;

           // }
          //  if ((min == "15") && (sek == "0"))
           // {
              //  CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_60_SCIEZKA;

          //  }
            if ((min == "10") && (sek == "0"))
            {
                if (wersja_jezykowa == false)
                {
                    CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_5_PL_SCIEZKA;
                }
                if (wersja_jezykowa == true)
                {
                    CZASY_PALYER.URL = Properties.Settings.Default.DZWIEK_CZAS_5_EN_SCIEZKA;
                }
            }
        }

        private void button_START_GRY_Click(object sender, EventArgs e)
        {
            minuty = 74;
            sekundy = 60;
            timer1.Start();
            stan_GRY = 1;
            if (wersja_jezykowa == false)
            {
                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA;
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


                Byte[] senddata = Encoding.ASCII.GetBytes("START GRY PL");

                udpClient.Send(senddata, senddata.Length);

                udpClient.Close();

                for (int i = 0; i < senddata.Length; i++)
                {
                    senddata[i] = 0;
                }


            }
            if (wersja_jezykowa == true)
            {
                STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA;
                
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


                Byte[] senddata = Encoding.ASCII.GetBytes("START GRY EN");

                udpClient.Send(senddata, senddata.Length);

                udpClient.Close();

                for (int i = 0; i < senddata.Length; i++)
                {
                    senddata[i] = 0;
                }
            }


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
            button_AKTYWACJA_WYJSCIE.BackColor = DefaultBackColor;
            button_ZWORA_KAPSULA.BackColor = DefaultBackColor;
            button_STATUS_CENTRALNY.BackColor = DefaultBackColor;
            button_STATUS_EKRANY.BackColor = DefaultBackColor;
            button_STATUS_TABLET.BackColor = DefaultBackColor;
            button_START_STATKU.BackColor = DefaultBackColor;
            button_START_KOSMOS.BackColor = DefaultBackColor;
            button_START_WOJNA.BackColor = DefaultBackColor;

            //string version = Application.ProductVersion;
            //listBox_received.Items.Add(version);

            timer1.Stop();
          sekundy = 60;
           minuty = 75;
            label8.Text = "0";
            label7.Text = "75";
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("RESET");

            udpClient.Send(senddata, senddata.Length);
            udpClient.Connect(Properties.Settings.Default.TABLET_IP, Convert.ToInt32(textBox_port.Text));
            udpClient.Send(senddata, senddata.Length);
            udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));
            udpClient.Send(senddata, senddata.Length);


            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
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
                if (wersja_jezykowa == false)
                {
                    STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA;
                }
                if (wersja_jezykowa == true)
                {
                    STATEK_PLAYER.URL = Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA;
                }


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
                UdpClient udpClient = new UdpClient();
                udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


                Byte[] senddata = Encoding.ASCII.GetBytes("WOJNA");

                udpClient.Send(senddata, senddata.Length);

                udpClient.Close();

                for (int i = 0; i < senddata.Length; i++)
                {
                    senddata[i] = 0;
                }
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
                if ((STATEK_PLAYER.URL == Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA) || (STATEK_PLAYER.URL == Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA))
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
            if (comboBox_LISTA_JEZYKOW.Text != "") { 

            _SS.SelectVoice(comboBox_LISTA_JEZYKOW.Text);
            _SS.SpeakAsync(textBox_SPEAK.Text);
            }   
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

        private void button_ZAPISZ_Click(object sender, EventArgs e)
        {
            StreamWriter Write;

            SaveFileDialog savePlaylist = new SaveFileDialog();
            savePlaylist.RestoreDirectory = false;
            try
            {
                savePlaylist.InitialDirectory = "C:\\Users\\Desktop\\LISTA PODPOWIEDZI";
                savePlaylist.Filter = ("TXT File|*.txt|All Files|*.*");

                savePlaylist.ShowDialog();

                Write = new StreamWriter(savePlaylist.FileName);

                for (int I = 0; I < listBox_WIDOK.Items.Count; I++)
                {
                    Write.WriteLine(listBox_WIDOK.Items[I]);


                }


                MessageBox.Show("LISTA PODPOWIEDZI ZAPISANA");
                Write.Close();
            }

            catch //(Exception ex)
            {
                return;
            }
        }

        private void button_DODAJ_Click(object sender, EventArgs e)
        {
            listBox_WIDOK.Items.Add(textBox_SPEAK.Text);
        }

        private void button_PLAY_PODPOWIEDZ_Click(object sender, EventArgs e)
        {
            _SS.SpeakAsync(listBox_WIDOK.SelectedItem.ToString());
        }

        private void button_WCZYTAJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadPlaylist = new OpenFileDialog();
            loadPlaylist.Multiselect = false;


           
            this.listBox_WIDOK.Items.Clear();

            try
            {
                loadPlaylist.ShowDialog();

                loadPlaylist.InitialDirectory = "C:\\Users\\Desktop\\LISTA PODPOWIEDZI";

                //txtLoad.Text = loadPlaylist.Filename;
                StreamReader playlist = new StreamReader(loadPlaylist.FileName);


                while (playlist.Peek() >= 0)

                    listBox_WIDOK.Items.Add(playlist.ReadLine());

                //txtLoad.Text = loadPlaylist.FileName;



            }

            catch
            {


                return;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bool isAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (isAvailable == true)
            {
                label_SIEC.Text = "";
            }
            else
            {
                // MessageBox.Show("BRAK POŁACZENIA Z SIECIĄ");
                label_SIEC.Text = "BRAK POŁACZENIA Z SIECIĄ";
            }
        }

        private void button_RESET_KULE_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("RESET KULE");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("RESET KARTY");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // dynamic json = JsonConvert.DeserializeObject(nazwa);
           // string wysylka = json[nazwa];
            var version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            string appVersion = $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
            // label16.Text = appVersion;
            

            websocket.Send(@"{""request-type"":""SetSourceRender"",""message-id"":""SetRender"",""render"":true,""source"":""" + nazwa + @""" }");
            websocket.Send(@"{""request-type"":""SetSourceRender"",""message-id"":""SetRender"",""render"":true,""source"":""" + nazwa2 + @""" }");
            //websocket.Send("Hello World!");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            websocket.Open();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("RESET 273");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_AKTYWACJA_WYJSCIE_Click(object sender, EventArgs e)
        {
            
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));

            WOJNA_PLAYER.URL = Properties.Settings.Default.WYJSCIE_EFEKT_SCIEZKA;

            Byte[] senddata = Encoding.ASCII.GetBytes("AKTYW WYJ");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_WERSJA_JEZYKOWA_Click(object sender, EventArgs e)
        {
            if(wersja_jezykowa == false)
            {
                button_WERSJA_JEZYKOWA.Text = "WERSJA ANGIELSKA";
                wersja_jezykowa = true;
                //Properties.Settings.Default.WERSJA_JEZYKOWA = true;
                //Properties.Settings.Default.Save();
            }
            else if (wersja_jezykowa == true)
            {
                button_WERSJA_JEZYKOWA.Text = "WERSJA POLSKA";
                wersja_jezykowa = false;
               // Properties.Settings.Default.WERSJA_JEZYKOWA = false;
                //Properties.Settings.Default.Save();
            }
        }

        private void button_ZWORA_KAPSULA_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.CENTRALNE_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("ZW KAPS ON");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_START_STATKU_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("START");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_START_KOSMOS_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("KOSMOS");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_START_WOJNA_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


            Byte[] senddata = Encoding.ASCII.GetBytes("WOJNA");

            udpClient.Send(senddata, senddata.Length);

            udpClient.Close();

            for (int i = 0; i < senddata.Length; i++)
            {
                senddata[i] = 0;
            }
        }

        private void button_KOMP_EKRANY_DOWN_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show(("CZY NA PEWNO ZAMKNĄĆ KOMPUTER EKRANY"), "POTWIERDZENIE ZAMKNIĘCIA KOMPUTERA EKRANY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {


                UdpClient udpClient = new UdpClient();
                udpClient.Connect(Properties.Settings.Default.EKRANY_IP, Convert.ToInt32(textBox_port.Text));


                Byte[] senddata = Encoding.ASCII.GetBytes("DOWN");

                udpClient.Send(senddata, senddata.Length);

                udpClient.Close();

                for (int i = 0; i < senddata.Length; i++)
                {
                    senddata[i] = 0;
                }

            }


        }
    }
}
