﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_FInder
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
        }

        private void aisleNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            Close();
        }
    }
}
