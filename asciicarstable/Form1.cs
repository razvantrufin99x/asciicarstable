﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asciicarstable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = -1;
            while(i < 300)
            {
                  i++;

                  comboBox1.Items.Add((char)i);
                  textBox1.Text += (char)i;
                  comboBox2.Items.Add(i.ToString());
            };
        }
    }
}
