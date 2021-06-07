using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tip
{
    public partial class Form_4 : Form
    {
        String login;
        public Form_4(String login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_4_Load(object sender, EventArgs e)
        {

        }
    }
}
