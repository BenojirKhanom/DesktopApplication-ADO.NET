using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog=AspProject; Integrated Security=True;");
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Field can not be empty");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password not match.");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Reg values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Wellcome " + textBox1.Text + "! You are Registrated Successfully");

                Form4 firstPage = new Form4();
                this.Hide();
                firstPage.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Form2 form1 = new Form2();
            this.Hide();
           // form1.Show();
        }
    }
}
