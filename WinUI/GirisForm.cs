using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class GirisForm : Form
    {
        FiliFilmEntities db = new FiliFilmEntities();
        public static GirisForm Current;
        public GirisForm()
        {
            InitializeComponent();
            Current = this;
            
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, Color.SlateGray);
            button1.BackColor = Color.FromArgb(120, Color.SlateGray);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            var sorgu = from sr in db.Giris
                        where sr.KullaniciAdi == textBox1.Text && sr.Sifre == textBox2.Text
                        select sr;
            if (sorgu.Any())
            {
               
               if(textBox1.Text=="hatice"&& textBox2.Text=="1111")
                {
                    this.Hide();
                    AdminForm f1 = new AdminForm();
                    f1.Show();
                }
               else
                {
                    this.Hide();
                    MainForm mnFrm = new MainForm();
                    mnFrm.Show();
                }

            }
            else
            {
                sayac++;

                MessageBox.Show("Lütfen Kullanıcı Adınızı ve Şifrenizi Konrol Ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
                if (sayac == 3)
                {
                    MessageBox.Show("Üst üste hatalı giriş yaptınız. Program Sonlandırılıyor");
                    Application.Exit();
                }
            }
        }

        private void Temizle()
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Giris yeniKullanici = new Giris
                {
                    KullaniciAdi = textBox1.Text,
                    Sifre = textBox2.Text
                };
                db.Giris.Add(yeniKullanici);
                db.SaveChanges();
                Temizle();
                MessageBox.Show("Kullanıcı Kaydı Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Girinizi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
