using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tip
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String data1 = null;
            String login = textBox1.Text;
            String password = textBox2.Text;

            connection c = new connection("127.0.0.1", "0", data1);
            c.Send("2;" + login + ";" + password, data1);
            char foo = '0';
            if (c.data1 != null)
            {
                foo = c.data1[0];
            }


            int bar = foo - '0';
            if (bar == 0)
            {
                label3.Text = "blad polaczenia";

            }
            else if (bar != 2)
            {
                label3.Text = "blad logowania, zaloguj sie ponownie";
            }

            else
            {
                Form1 Form1 = new Form1(c.data1);

                // Show the settings form
                Form1.Show();
                //this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            
        }
    }
}
