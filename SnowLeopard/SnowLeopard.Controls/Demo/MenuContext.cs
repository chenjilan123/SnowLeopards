﻿using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Demo
{
    public partial class MenuContext : BlueForm
    {
        public MenuContext()
        {
            InitializeComponent();
        }

        private void ShowContext_Click(object sender, EventArgs e)
        {
            //cms.Show(this, PointToClient(MousePosition));
            cms.Show(sender as Control, PointToClient(MousePosition));
        }
    }
}
