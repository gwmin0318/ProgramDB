﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arr_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IDB_ADD_Click(object sender, EventArgs e)
        {
            Form2 DataSetup = new Form2();
            DataSetup.ShowDialog();
        }

        private void IDB_EXIT_Click(object sender, EventArgs e)
        {

        }
    }
}
