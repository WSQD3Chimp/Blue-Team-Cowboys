﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamProject
{
    public partial class ViewInventoryForm : Form
    {
        public ViewInventoryForm()
        {
            InitializeComponent();
        }

        private void ViewInventoryPanel_Paint(object sender, PaintEventArgs e)
        {
            this.ViewInventoryPanel.AutoScroll = true;

        }
    }
}