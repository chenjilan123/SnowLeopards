﻿using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class RichTextBoxDemo : BlueForm
    {
        public RichTextBoxDemo()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TextArea.Text);
        }
    }
}