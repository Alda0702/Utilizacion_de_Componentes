﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12032025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpAe.URL = "C:\\Users\\usuario\\Downloads\\video.mp4";
            wmpAe.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }
    }
}
