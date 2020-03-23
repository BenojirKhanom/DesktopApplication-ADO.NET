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
    public partial class Form2 : Form
    {

        SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog=AspProject; Integrated Security=True;");
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Reg where UserName = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count == 1)
            {
                Form4 ff = new Form4();
                this.Hide();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Form3 registration = new Form3();
            this.Hide();
           // registration.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 registration = new Form3();
           
            registration.Show();
        }
    }
}
