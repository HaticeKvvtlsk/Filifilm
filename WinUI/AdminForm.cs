using BLL.Repository;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WinUI.ServiceReference1;

namespace WinUI
{
    public partial class AdminForm : Form
    {
        FilmRepositories filmrepo = new FilmRepositories();
        FiliFilmEntities db = new FiliFilmEntities();
        SqlConnection conn = new SqlConnection(@"server=LAPTOP-47D8GKTS;database=FiliFilm;UID=sa;PWD=HaticeK.1029");
        SqlDataAdapter dap;
        DataTable dt;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        { 
            
            temizle();
            //filmlerigetir();
            DilSec();
            TurSec();
            UlkeSec();
            
        }

        private void UlkeSec()
        {

            dap = new SqlDataAdapter("Select * from Ulke", conn);
            dt = new DataTable();
            dap.Fill(dt);
            cmbUlke.DataSource = dt;
            cmbUlke.DisplayMember = "Ulke";
            cmbUlke.ValueMember = "UlkeID";
            cmbUlke.Text = "Seçiniz...";
        }

        private void TurSec()
        {
            dap = new SqlDataAdapter("Select * from Tur", conn);
            dt = new DataTable();
            dap.Fill(dt);
            cmbTur.DataSource = dt;
            cmbTur.DisplayMember = "Tur";
            cmbTur.ValueMember = "TurID";
            cmbTur.Text = "Seçiniz...";
        }

        private void DilSec()
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select * from Dil", conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            cmbDil.DataSource = dt;
            cmbDil.DisplayMember = "Dil";
            cmbDil.ValueMember = "DilID";
            cmbDil.Text = "Seçiniz...";
        }

        // Service1Client istemci = new Service1Client();


        private void filmlerigetir()
        {
            //  dataGridView1.DataSource = istemci.FilmleriGetir();

            dataGridView1.DataSource = filmrepo.GetAll().Select(a =>
              new

              {
                  a.FilmID,
                  a.FilmAdi,
                  a.Aciklama,
                  a.YapimYili,
                  a.VizyonTarihi,
                  a.Picture,
                  a.Dil.Dil1,
                  a.Tur.Tur1,
                  a.Ulke.Ulke1,
                  //a.Yonetmen.AdiSoyadi,
                  a.IsDeleted,
                  a.Link
              }).ToList();



        }



        private void btn_Getir_Click(object sender, EventArgs e)
        {
            filmlerigetir();
        }

        private void temizle()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
        }
        Filmler secilenFilm;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            temizle();
            dataGridView1_CellDoubleClick(sender, e);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (dataGridView1.SelectedRows.Count > 0)
            {
                secilenFilm = filmrepo.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                textBox1.Text = secilenFilm.FilmAdi;
                textBox2.Text = secilenFilm.Aciklama;
                textBox3.Text = secilenFilm.YapimYili.ToString();
                textBox4.Text = secilenFilm.Picture;
               
               
                pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }



        }


            private void btn_Kaydet_Click(object sender, EventArgs e)
            {




            filmrepo.insert(new Filmler
            {
                FilmAdi = textBox1.Text,
                Aciklama = textBox2.Text,
                VizyonTarihi = dateTimePicker1.Value,
                YapimYili = int.Parse(textBox3.Text),
                IsDeleted = false,
                Picture = textBox4.Text,
                DilID = cmbDil.SelectedIndex,
                FilmTurID = cmbTur.SelectedIndex,
                UlkeID = cmbUlke.SelectedIndex,
                Link = textBox5.Text
            }); ;
            
                filmlerigetir();
                temizle();

            }

            private void btn_Guncelle_Click(object sender, EventArgs e)
            {
            secilenFilm.FilmAdi = textBox1.Text;
            secilenFilm.Aciklama = textBox2.Text;
            secilenFilm.VizyonTarihi = dateTimePicker1.Value;
            secilenFilm.YapimYili = int.Parse(textBox3.Text);
            secilenFilm.IsDeleted = false;
            secilenFilm.Picture = textBox4.Text;
            secilenFilm.DilID = cmbDil.SelectedIndex+1;
            secilenFilm.FilmTurID = cmbTur.SelectedIndex+1;
            secilenFilm.UlkeID = cmbUlke.SelectedIndex+1;
            secilenFilm.Link = textBox5.Text;
                filmrepo.update(secilenFilm);

                filmlerigetir();
                temizle();


            }

            private void btn_Sil_Click(object sender, EventArgs e)
            {
                secilenFilm = filmrepo.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                secilenFilm.IsDeleted = true;
                filmrepo.update(secilenFilm);

                MessageBox.Show("Film Silindi", "Silme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filmlerigetir();

            }

            private void btn_Sec_Click(object sender, EventArgs e)
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
                dosya.ShowDialog();
                string dosyayolu = dosya.FileName;
                textBox4.Text = dosyayolu;
                pictureBox1.ImageLocation = dosyayolu;
            }

   
    }

    }



