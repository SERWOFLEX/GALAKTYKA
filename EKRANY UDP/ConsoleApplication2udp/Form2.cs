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
        
        public string minut5_EN;
        public string minut5_PL;
        public string muza_statek_PL;
        public string muza_statek_EN;
        public string muza_winda;
        public string muza_odliczanie;
        public string muza_palac;
        public string wyjscie_efekt;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            label11.Text = Properties.Settings.Default.DZWIEK_CZAS_5_PL_SCIEZKA;
            label17.Text = Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA;
            label18.Text = Properties.Settings.Default.MUZYKA_WOJNA_SCIEZKA;
            label19.Text = Properties.Settings.Default.MUZYKA_PALAC_SCIEZKA;
            label20.Text = Properties.Settings.Default.MUZYKA_KAPSULA_SCIEZKA;
            textBox_IP_CENTRALNE.Text = Properties.Settings.Default.CENTRALNE_IP;
            label23.Text = Properties.Settings.Default.WYJSCIE_EFEKT_SCIEZKA;
            label28.Text = Properties.Settings.Default.DZWIEK_CZAS_5_EN_SCIEZKA;
            label26.Text = Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA;

        }

       
        
        

        private void button_CZAS_5_PL_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut5_PL = dlg.FileName;
                label11.Text = minut5_PL;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_5_PL_SCIEZKA = minut5_PL;
                Properties.Settings.Default.Save();
            }
        }
        


        private void button_STATEK_PL_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_statek_PL = dlg.FileName;
                label17.Text = muza_statek_PL;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_STATEK_PL_SCIEZKA = muza_statek_PL;
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

        private void button_WYJSCIE_EFEKT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                wyjscie_efekt = dlg.FileName;
                label23.Text = wyjscie_efekt;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.WYJSCIE_EFEKT_SCIEZKA = wyjscie_efekt;
                Properties.Settings.Default.Save();
            }
        }

        private void button_CZAS_5_EN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                minut5_EN = dlg.FileName;
                label28.Text = minut5_EN;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.DZWIEK_CZAS_5_EN_SCIEZKA = minut5_EN;
                Properties.Settings.Default.Save();
            }
        }

        private void button_STATEK_EN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            // dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                muza_statek_EN = dlg.FileName;
                label26.Text = muza_statek_EN;
                //MessageBox.Show(fileName);
                Properties.Settings.Default.MUZYKA_STATEK_EN_SCIEZKA = muza_statek_EN;
                Properties.Settings.Default.Save();
            }
        }
    }
}
