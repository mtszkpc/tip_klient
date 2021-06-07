using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tip
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String data1 = null;
            String login = textBox1.Text;
            String password = textBox2.Text;
            
            if (login.Length > 0 && password.Length > 0)
            {
                connection c = new connection("127.0.0.1", "0", data1);
                c.Send("3;;;" + login + ";" + password, data1);
                if (!c.data1.Equals("3;ok"))
                {
                    label3.Text = "login zajety!";
                }
                else
                {
                    label3.Text = "zarejestrowano pomyslnie!";
                }
            }
            else
            {
                label3.Text = "login login lub hasło zbyt krótkie";
            }
            
        }
    }
}
