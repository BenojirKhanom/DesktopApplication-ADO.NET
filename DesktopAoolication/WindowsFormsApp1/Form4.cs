using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();

            main.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();

            form2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
