using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip
{
    public partial class Form1 : Form
    {
        String login;
        public Form1(String login)
        {
            InitializeComponent();
            //login = login + " ";//usunac potem
            if (!login.Contains(';'))
            {
                login = login + ";;;";
            }
            string[] subs = login.Split(";");
            this.login = subs[1];
            label2.Text = this.login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(login);
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(login);
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_4 form4 = new Form_4(login);
            form4.Show();
        }
    }
}
