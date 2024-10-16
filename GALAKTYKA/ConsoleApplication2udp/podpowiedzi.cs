using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication2udp
{
    public partial class podpowiedzi : Form
    {
        String itemSelected;
        string sciezka;

        String sciezka_wczytania_listy;
        public static podpowiedzi podp;
        public Form1 form1;
        public int ilosc_podpowiedzi;
        String[] paths, files;

        public podpowiedzi(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void podpowiedzi_Load(object sender, EventArgs e)
        {

            podp = this;
            PODPOWIEDZI_PLAYER.settings.volume = 50;
            trackBar_PODPOW.Value = PODPOWIEDZI_PLAYER.settings.volume;
            label55.Text = PODPOWIEDZI_PLAYER.settings.volume.ToString();




            if (!Directory.Exists("C:\\PODPOWIEDZI GALAKTYKA\\LISTA PL"))
                Directory.CreateDirectory("C:\\PODPOWIEDZI GALAKTYKA\\LISTA PL");

            if (!Directory.Exists("C:\\PODPOWIEDZI GALAKTYKA\\LISTA EN"))
                Directory.CreateDirectory("C:\\PODPOWIEDZI GALAKTYKA\\LISTA EN");

            if (form1.wersja_jezykowa == false)
            {
                if (!File.Exists("C:\\PODPOWIEDZI GALAKTYKA\\LISTA PL\\lista podpowiedzi PL.xml"))
                {

                    MessageBox.Show(("Brak listy podpowiedzi PL lub błędna nazwa listy"), "BRAK LISTY PODPOWIEDZI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sciezka_wczytania_listy = "C:\\PODPOWIEDZI GALAKTYKA\\LISTA PL\\lista podpowiedzi PL.xml";
                    StreamReader playlist = new StreamReader(sciezka_wczytania_listy);

                    try
                    {
                        //txtLoad.Text = loadPlaylist.Filename;



                        while (playlist.Peek() >= 0)

                            listBoxSongs.Items.Add(playlist.ReadLine());

                        //txtLoad.Text = loadPlaylist.FileName;

                    }

                    catch
                    {
                        return;
                    }
                    for (int i = 0; i < listBoxSongs.Items.Count; i++)
                    {

                        itemSelected = listBoxSongs.GetItemText(listBoxSongs.Items[i]);
                        label_3.Text = itemSelected;
                        int znak;
                        //int dlugosc;
                        int spr;
                        int kropka;
                        int ukosnik;

                        //znak = label_3.Text.IndexOf("PODPOWIEDZI MILA");
                        //kropka = label_3.Text.IndexOf(".");
                        ukosnik = label_3.Text.LastIndexOf("\\");
                        //label1.Text = kropka.ToString();
                        label2.Text = ukosnik.ToString();
                        //dlugosc = 26;
                        spr = label_3.Text.IndexOf("PODPOWIEDZI GALAKTYKA");
                        String wynik = spr.ToString();
                        label_4.Text = wynik;

                        // listBox_WIDOK.Items.Add(label_3.Text.Substring((znak + dlugosc), (label_3.Text.Length - (znak + dlugosc))));
                        listBox_WIDOK.Items.Add(label_3.Text.Substring(ukosnik + 1));

                    }
                }

            }
            else if (form1.wersja_jezykowa == true)
            {
                if (!File.Exists("C:\\PODPOWIEDZI GALAKTYKA\\LISTA EN\\lista podpowiedzi EN.xml"))
                {
                    MessageBox.Show(("Brak listy podpowiedzi EN lub błędna nazwa listy"), "BRAK LISTY PODPOWIEDZI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sciezka_wczytania_listy = "C:\\PODPOWIEDZI GALAKTYKA\\LISTA EN\\lista podpowiedzi EN.xml";
                    StreamReader playlist = new StreamReader(sciezka_wczytania_listy);

                    try
                    {
                        //txtLoad.Text = loadPlaylist.Filename;



                        while (playlist.Peek() >= 0)

                            listBoxSongs.Items.Add(playlist.ReadLine());

                        //txtLoad.Text = loadPlaylist.FileName;

                    }

                    catch
                    {
                        return;
                    }
                    for (int i = 0; i < listBoxSongs.Items.Count; i++)
                    {

                        itemSelected = listBoxSongs.GetItemText(listBoxSongs.Items[i]);
                        label_3.Text = itemSelected;
                        int znak;
                        //int dlugosc;
                        int spr;
                        int kropka;
                        int ukosnik;

                        //znak = label_3.Text.IndexOf("PODPOWIEDZI MILA");
                        //kropka = label_3.Text.IndexOf(".");
                        ukosnik = label_3.Text.LastIndexOf("\\");
                        //label1.Text = kropka.ToString();
                        label2.Text = ukosnik.ToString();
                        //dlugosc = 26;
                        spr = label_3.Text.IndexOf("PODPOWIEDZI GALAKTYKA");
                        String wynik = spr.ToString();
                        label_4.Text = wynik;

                        // listBox_WIDOK.Items.Add(label_3.Text.Substring((znak + dlugosc), (label_3.Text.Length - (znak + dlugosc))));
                        listBox_WIDOK.Items.Add(label_3.Text.Substring(ukosnik + 1));

                    }
                }
            }

            listBox_WIDOK.Sorted = true;
            listBoxSongs.Sorted = true;
            PODPOWIEDZI_PLAYER.settings.setMode("loop", false);
        }
       

        private void button_PLAY_PODPOWIEDZ_Click(object sender, EventArgs e)
        {
            PODPOWIEDZI_PLAYER.settings.setMode("loop", false);
            if (listBox_WIDOK.SelectedIndex > -1)
            {
                if (button_PLAY_PODPOWIEDZ.Text == "PLAY")
                {
                    ilosc_podpowiedzi++;
                    PODPOWIEDZI_PLAYER.URL = itemSelected;
                    button_PLAY_PODPOWIEDZ.Text = "STOP";
                    //String minuta_gry = form1.label_min_plus.Text;
                   // String sekunda_gry = form1.label_sek_plus.Text;

                   // form1.listBox_PODPOWIEDZI_ZAPIS.Items.Add(ilosc_podpowiedzi.ToString() + ") " + listBox_WIDOK.SelectedItem + " | " + DateTime.Now.ToString("yyyy/MM/dd | HH:mm:ss") + " | minuta gry |  " + minuta_gry + " : " + sekunda_gry);
                    listBox_PODPOWIEDZI_ZAPIS.Items.Add(ilosc_podpowiedzi.ToString() + ") " + listBox_WIDOK.SelectedItem );
                }
                else if (button_PLAY_PODPOWIEDZ.Text == "STOP")
                {
                    PODPOWIEDZI_PLAYER.Ctlcontrols.stop();
                    button_PLAY_PODPOWIEDZ.Text = "PLAY";
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myString = listBoxSongs.SelectedIndex.ToString();
            label_1.Text = myString;
            itemSelected = listBoxSongs.GetItemText(listBoxSongs.SelectedItem);
            label_2.Text = itemSelected;
        }

        private void button_ZAPISZ_Click(object sender, EventArgs e)
        {
            StreamWriter Write;

            SaveFileDialog savePlaylist = new SaveFileDialog();

            //savePlaylist.RestoreDirectory = false;
            savePlaylist.InitialDirectory = "C:\\PODPOWIEDZI GALAKTYKA";

            try
            {
                //savePlaylist.InitialDirectory = "C:\\LISTA PODPOWIEDZI MILA";
                savePlaylist.Filter = ("XML File|*.xml|All Files|*.*");

                savePlaylist.ShowDialog();

                Write = new StreamWriter(savePlaylist.FileName);

                for (int I = 0; I < listBoxSongs.Items.Count; I++)
                {
                    Write.WriteLine(listBoxSongs.Items[I]);


                }


                MessageBox.Show("LISTA PODPOWIEDZI ZAPISANA");
                Write.Close();
            }

            catch //(Exception ex)
            {
                return;
            }
        }

        private void button_WCZYTAJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadPlaylist = new OpenFileDialog();
            loadPlaylist.Multiselect = false;
            loadPlaylist.InitialDirectory = "C:\\PODPOWIEDZI GALAKTYKA";
            loadPlaylist.ShowDialog();
            this.listBoxSongs.Items.Clear();
            this.listBox_WIDOK.Items.Clear();

            try
            {
                //txtLoad.Text = loadPlaylist.Filename;
                StreamReader playlist = new StreamReader(loadPlaylist.FileName);

                while (playlist.Peek() >= 0)

                    listBoxSongs.Items.Add(playlist.ReadLine());

                //txtLoad.Text = loadPlaylist.FileName;

            }

            catch
            {
                return;
            }
            for (int i = 0; i < listBoxSongs.Items.Count; i++)
            {

                itemSelected = listBoxSongs.GetItemText(listBoxSongs.Items[i]);
                label_3.Text = itemSelected;
                int znak;
                //int dlugosc;
                int spr;
                int kropka;
                int ukosnik;

                //znak = label_3.Text.IndexOf("PODPOWIEDZI MILA");
                //kropka = label_3.Text.IndexOf(".");
                ukosnik = label_3.Text.LastIndexOf("\\");
                //label1.Text = kropka.ToString();
                label2.Text = ukosnik.ToString();
                //dlugosc = 26;
                spr = label_3.Text.IndexOf("PODPOWIEDZI GALAKTYKA");
                String wynik = spr.ToString();
                label_4.Text = wynik;

                // listBox_WIDOK.Items.Add(label_3.Text.Substring((znak + dlugosc), (label_3.Text.Length - (znak + dlugosc))));
                listBox_WIDOK.Items.Add(label_3.Text.Substring(ukosnik + 1));

            }
        }

        private void trackBar_PODPOW_Scroll(object sender, EventArgs e)
        {
            String val = trackBar_PODPOW.Value.ToString();
            label55.Text = val;
            PODPOWIEDZI_PLAYER.settings.volume = trackBar_PODPOW.Value;
        }

        private void listBox_WIDOK_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSongs.SelectedIndex = listBox_WIDOK.SelectedIndex;
        }

        private void PODPOWIEDZI_PLAYER_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (PODPOWIEDZI_PLAYER.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                button_PLAY_PODPOWIEDZ.BackColor = Color.Green;
                
                    form1.STATEK_PLAYER.settings.volume = 5;
                    form1.trackBar2.Value = form1.STATEK_PLAYER.settings.volume;
                    form1.label9.Text = form1.STATEK_PLAYER.settings.volume.ToString();
                
               

            }

            if (PODPOWIEDZI_PLAYER.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                button_PLAY_PODPOWIEDZ.BackColor = DefaultBackColor;

                button_PLAY_PODPOWIEDZ.Text = "PLAY";
                
                    form1.STATEK_PLAYER.settings.volume = form1.glosnisc_podklad_gluwny;
                    form1.trackBar2.Value = form1.STATEK_PLAYER.settings.volume;
                    form1.label9.Text = form1.STATEK_PLAYER.settings.volume.ToString();
                
                
            }
        }

        private void button_USUN_POZYCJE_Z_LISTY_Click(object sender, EventArgs e)
        {
            if (listBox_WIDOK.SelectedIndex > -1)
            {

                listBoxSongs.SelectedIndex = listBox_WIDOK.SelectedIndex;
                foreach (string s in listBox_WIDOK.SelectedItems.OfType<string>().ToList())
                {
                    listBox_WIDOK.Items.Remove(s);

                }
                listBoxSongs.Items.RemoveAt(listBox_WIDOK.SelectedIndex + 1);

                DialogResult d;
                d = MessageBox.Show(("CZY ZAPISAĆ LISTĘ PODPOWIEDZI? "), "USUNIĘTO PODPOWIEDŹ Z LISTY", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    button_ZAPISZ.PerformClick();
                }
            }

            else
            {
                MessageBox.Show("NIE WYBRANO POZYCJI DO USUNIENCIA");
            }
        }

        private void button_CZYSC_LISTE_Click(object sender, EventArgs e)
        {
            listBox_PODPOWIEDZI_ZAPIS.Items.Clear();
            ilosc_podpowiedzi = 0;
        }

        private void button_DODAJ_Click(object sender, EventArgs e)
        {

            OpenFileDialog newPlaylist = new OpenFileDialog();
            // OpenFileDialog dlg = new OpenFileDialog();
            //newPlaylist.InitialDirectory = "C:\\PODPOWIEDZI MILA";
            newPlaylist.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            // dlg.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            newPlaylist.RestoreDirectory = false;
            newPlaylist.Multiselect = true;
            if (newPlaylist.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = newPlaylist.SafeFileNames;
                sciezka = newPlaylist.FileName;
                txtLoad.Text = sciezka;
                paths = newPlaylist.FileNames;
                for (int list = 0; list < files.Length; list++)
                {
                    listBoxSongs.Items.Add(paths[list]);
                }
                for (int list = 0; list < files.Length; list++)
                {
                    listBox_WIDOK.Items.Add(files[list]);
                }
            }
        }
    }
}
