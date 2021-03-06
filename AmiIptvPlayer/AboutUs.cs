﻿using System;
using System.Deployment.Application;
using System.Reflection;
using System.Windows.Forms;

namespace AmiIptvPlayer
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            lbVersion.Text = ApplicationDeployment.IsNetworkDeployed
               ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
               : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://github.com");
        }
    }
}
