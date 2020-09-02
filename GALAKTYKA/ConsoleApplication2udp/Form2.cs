using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Sockets;



namespace ConsoleApplication2udp
{

    public partial class Form2 : Form
    {
        public string minut60;
        public string minut45;
        public string minut30;
        public string minut15;
        public string minut5;
        public string muza_statek;
        public string muza_winda;
        public string muza_odliczanie;
        public string muza_palac;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = Properties.Settings.Default.DZWIEK_CZAS_60_SCIEZKA;
            label8.Text = Properties.Settings.Default.DZWIEK_CZAS_45_SCIEZKA;
            label9.Text = Properties.Settings.Default.DZWIEK_CZAS_30_SCIEZKA;
            label10.Text = Properties.Settings.Default.DZWIEK_CZAS_15_SCIEZKA;
            label11.Text = Properties.Settings.Default.DZWIEK_CZAS_5_SCIEZKA;
            label17.Text = Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA;
            label18.Text = Properties.Settings.Default.MUZYKA_WOJNA_SCIEZKA;
            label19.Text = Properties.Settings.Default.MUZYKA_PALAC_SCIEZKA;
            label20.Text = Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA;
        }

        private void button_60_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
                minut60 = dlg.FileName;
                label7.Text = minut60;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_60_SCIEZKA = minut60;
                Properties.Settings.Default.Save();
            }
        }
        
        private void button_45_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut45 = dlg.FileName;
                label8.Text = minut45;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_45_SCIEZKA = minut45;
                Properties.Settings.Default.Save();
            }
        }

        private void button_30_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut30 = dlg.FileName;
                label9.Text = minut30;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_30_SCIEZKA = minut30;
                Properties.Settings.Default.Save();
            }
        }

        private void button_15_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*"; ;
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut15 = dlg.FileName;
                label10.Text = minut15;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_15_SCIEZKA = minut15;
                Properties.Settings.Default.Save();
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut5 = dlg.FileName;
                label11.Text = minut5;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_5_SCIEZKA = minut5;
                Properties.Settings.Default.Save();
            }
        }

        private void button_STATEK_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_statek = dlg.FileName;
                label17.Text = muza_statek;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_STATEK_SCIEZKA = muza_statek;
                Properties.Settings.Default.Save();
            }
        }

        private void button_WINDA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_winda = dlg.FileName;
                label18.Text = muza_winda;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_WOJNA_SCIEZKA = muza_winda;
                Properties.Settings.Default.Save();
            }
        }

        private void button_PALAC_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_palac = dlg.FileName;
                label19.Text = muza_palac;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_PALAC_SCIEZKA = muza_palac;
                Properties.Settings.Default.Save();
            }
        }

        private void button_ODLICZANIE_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_odliczanie = dlg.FileName;
                label20.Text = muza_odliczanie;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA = muza_odliczanie;
                Properties.Settings.Default.Save();
            }
        }

        private void button_ZAPIS_CENTR_IP_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CENTRALNE_IP = textBox_IP_CENTRALNE.Text;
            Properties.Settings.Default.Save();
        }

        private void button_ZAPIS_KOMP_IP_Click(object sender, EventArgs e)
        {
            
        }
    }
}
