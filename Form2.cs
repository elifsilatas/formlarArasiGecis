﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Eight
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ad;
        public string soyad;
        public string no;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(ad + " " + soyad + "-" + no);
        }
    }
}
