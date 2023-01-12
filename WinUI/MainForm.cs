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
    public partial class MainForm : Form
    {
        public static MainForm Current;
        public MainForm()
        {
            InitializeComponent();
            Current = this;
      
        }
        //bool durum = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(120, Color.SlateGray);
            MainAnaForm form1 = new MainAnaForm();
            FormuGetir(form1);
           // pictureBox1.Image = ımageList1.Images[0];

        }

        //void AcilacakForm(Form Acilacak)
        //{
        //    foreach (Form item in this.MdiChildren)
        //    {
        //        if (item.Text==Acilacak.Text)
        //        {
        //            durum = true;
        //            item.Activate();
        //        }
        //    }
        //    if (!durum)
        //    {
        //        Acilacak.MdiParent = this;
        //        Acilacak.Show();

        //    }
        //}

        private void FormuGetir(Form form)
        {
            panel2.Controls.Clear(); // Panel'in içini temizliyoruz..
           
            form.TopLevel = false;
            form.TopMost = true;
            panel2.Controls.Add(form); // panel1 içerisinde formu ekledik

            form.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            form.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            form.BringToFront(); // formu panel içinde en öne getirdik

            
        }

   

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm.Current.Show();
            
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            MainAnaForm form = new MainAnaForm();
            FormuGetir(form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            FormuGetir(form);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Message form = new Message();
            FormuGetir(form);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

