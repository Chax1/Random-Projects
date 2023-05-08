using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HaveANiceDay
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeText()
        {
            Application.DoEvents();
            Thread.Sleep(2000);
            MainLabel.Text = "Have";
            MainLabel.Update(); ;
            Thread.Sleep(1000);
            MainLabel.Text = "A";
            MainLabel.Update(); ;
            Thread.Sleep(1000);
            MainLabel.Text = "Nice";
            MainLabel.Update(); ;
            Thread.Sleep(1000);
            MainLabel.Text = "Day!";
            MainLabel.Update(); ;
            Thread.Sleep(1000);
            MainLabel.Text = "H";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Ha";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Hav";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a n";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a ni";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a nic";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a nice";
            MainLabel.Update();
            Thread.Sleep(500);
            MainLabel.Text = "Have a nice d";
            MainLabel.Update();
            Thread.Sleep(500);
            MainLabel.Text = "Have a nice da";
            MainLabel.Update();
            Thread.Sleep(500);
            MainLabel.Text = "Have a nice day";
            MainLabel.Update(); ;
            Thread.Sleep(500);
            MainLabel.Text = "Have a nice day!";
            MainLabel.Update(); ;
            Thread.Sleep(5000);
            Application.Exit();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            ChangeText();
        }
    }
}