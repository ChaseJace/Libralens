﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libsys1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = library; Integrated Security = true");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username",SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) 
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
                else
            {
                MessageBox.Show("Login Failed");
            }
            con.Close();
        }
    }
}
