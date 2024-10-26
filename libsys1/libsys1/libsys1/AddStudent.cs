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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace libsys1
{
    public partial class AddStudent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = library; Integrated Security = true");
        public AddStudent()
        {
            InitializeComponent();

            comboBox1.Items.Add("CCIS");
            comboBox1.Items.Add("CAS");
            comboBox1.Items.Add("CEA");
            comboBox1.Items.Add("ATYCB");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@ID_No", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Added");
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
