using BLL;
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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            ToolTip tooltip1 = new ToolTip();
            tooltip1.SetToolTip(textBox1, "Lütfen outlook hesabı kullanınız.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        MailGonder mgonder = new MailGonder();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mgonder.mesajgonder(textBox1.Text, textBox4.Text, "nilufer_bad_34@hotmail.com", "1472Suiren156", textBox2.Text, textBox3.Text);
                MessageBox.Show("Mesajınız iletildi!!");
                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!! şifreni doğru gir");
                temizle();
                return;

            }


        }

        private void temizle()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

    }
}
