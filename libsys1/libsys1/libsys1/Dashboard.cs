﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libsys1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks f = new AddBooks();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBookReports ibr = new IssueBookReports();
            ibr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnBookReports rbr = new ReturnBookReports();
            rbr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddStudent s = new AddStudent();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewStudents vs = new ViewStudents();
            vs.Show();
        }
    }
}
