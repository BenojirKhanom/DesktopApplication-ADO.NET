using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       SqlConnection con = new SqlConnection ("Data Source =.\\SQLEXPRESS; Initial Catalog=AspProject; Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            display();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Student values('"+textBox3.Text+"')";
             cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" inserted a row");
            display();
        }

        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Student set StudentName ='" + textBox3.Text + "'where StudentID = '" + textBox1.Text + "'";
             cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Updated a row");
            display();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Student where StudentID ='" + textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Deleted a row");
            display();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
