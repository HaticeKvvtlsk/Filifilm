using BLL.Repository;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{

   
    public partial class Form1 : Form
    {
       // FilmRepositories filmrepo = new FilmRepositories();
        //Class1 turrepo = new Class1();
        FiliFilmEntities db = new FiliFilmEntities();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("Tür", 175);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Film Afişi", 120);
            listView1.Columns.Add("Film İsmi", 200);

            GenreListDoldur();
        }

        private void GenreListDoldur()
        {
            ImageList resimlistesi = new ImageList();
            resimlistesi.ColorDepth = ColorDepth.Depth32Bit;
            resimlistesi.ImageSize = new Size(175, 175);

            string resimKlasoru = "C:/Users/HATİCE/OneDrive/Masaüstü/yedek/Filifilm/WinUI/bin/Debug/turler/";
            List<Tur> turliste = db.Tur.ToList();
            try
            {
                string resimyok = resimKlasoru + "yok.jpg";

                foreach (Tur tur in turliste)
                {
                    string resimyolu = resimKlasoru + tur.TurID.ToString() + ".jpg";
                    if (File.Exists(resimyolu))
                    {
                        resimlistesi.Images.Add(tur.TurID.ToString(), Image.FromFile(resimyolu));
                    }
                    else
                    {
                        resimlistesi.Images.Add(tur.TurID.ToString(), Image.FromFile(resimyok));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
            }
            listView2.SmallImageList = resimlistesi;

            foreach (Tur tur in turliste)
            {
                ListViewItem _item1 = new ListViewItem();
                _item1.Tag = tur.Tur1.ToString();
                _item1.SubItems.Add(tur.ToString());
                _item1.ImageKey = tur.TurID.ToString();
                listView2.Items.Add(_item1);
            }
        }
   
        private void listView2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {

                int seciliTurID = Convert.ToInt32(listView2.SelectedItems[0].ImageKey);
                FilmListDoldur(seciliTurID);
                label2.Text = "Türe Göre Filmler (Tür: " + listView2.SelectedItems[0].Tag + ")";
               
                listView1.Visible = true;
                panel2.Visible = true;
            }
        }

        private void FilmDetayDoldur(int seciliFilmID)
        {
           
       

            Filmler FilmDetay = db.Filmler.Where(f => f.FilmID == seciliFilmID).FirstOrDefault();
            lblFilmAdi.Text = FilmDetay.FilmAdi.ToString();
            lblFilmYayınTarihi.Text = FilmDetay.VizyonTarihi.ToString();
            richFilmAciklama.Text = FilmDetay.Aciklama.ToString();
            lblYonetmen.Text = FilmDetay.Yonetmen.AdiSoyadi.ToString();
            lblDil.Text = FilmDetay.Dil.Dil1.ToString();
            lblUlke.Text = FilmDetay.Ulke.Ulke1.ToString();
            linkLabel1.Text = FilmDetay.Link.ToString();
            //resim
            string resimYolu = "C:/Users/HATİCE/OneDrive/Masaüstü/yedek/Filifilm/WinUI/bin/Debug/Filmler/" + FilmDetay.FilmAdi+".jpg";
            string resimsizYolu = "C:/Users/HATİCE/OneDrive/Masaüstü/yedek/Filifilm/WinUI/bin/Debug/Filmler/yok.jpg";

            if (File.Exists(resimYolu))
            {
                picFilm.Image = Image.FromFile(resimYolu);
            }
            else
            {
                picFilm.Image = Image.FromFile(resimsizYolu);
            }


        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
            FilmDetayDoldur(Convert.ToInt32(listView1.SelectedItems[0].ImageKey.ToString()));
            panel3.Visible = true;
        }

        private void FilmListDoldur(int seciliTurID)
        {
            ImageList resimlistesi = new ImageList();
            resimlistesi.ColorDepth = ColorDepth.Depth32Bit;
            resimlistesi.ImageSize = new Size(110, 165);

            string resimKlasoru = "C:/Users/HATİCE/OneDrive/Masaüstü/yedek/Filifilm/WinUI/bin/Debug/Filmler/";
            List<Filmler> filmliste = db.Filmler.Where(f => f.Tur.TurID == seciliTurID).ToList();
            try
            {
               

                foreach (Filmler film in filmliste)
                {
                    string resimyolu = resimKlasoru + film.FilmAdi.ToString() + ".jpg";
                    if (File.Exists(resimyolu))
                    {
                        resimlistesi.Images.Add(film.FilmID.ToString(), Image.FromFile(resimyolu));

                    }
                    else
                    {
                        string resimyok = resimKlasoru + "yok.jpg";
                        resimlistesi.Images.Add(film.FilmID.ToString(), Image.FromFile(resimyok));
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
            }
            listView1.SmallImageList = resimlistesi;



            foreach (Filmler film in filmliste)
            {
                ListViewItem _item1 = new ListViewItem();
                _item1.Tag = film.FilmAdi.ToString();
                _item1.SubItems.Add(film.FilmAdi.ToString());
                _item1.SubItems.Add(film.VizyonTarihi.ToString());
                _item1.ImageKey = film.FilmID.ToString();
                _item1.SubItems.Add(film.Dil.Dil1.ToString());
                _item1.SubItems.Add(film.Ulke.Ulke1.ToString());
                listView1.Items.Add(_item1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(linkLabel1.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("Link açılamadı.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
