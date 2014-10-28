using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Watermarking
{
    public partial class Splash : Form
    {
        int i = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            tmrStart.Enabled = true;
            //tmrSplash.Enabled = true;
            tmrStart.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (i < 12)
            {
                this.Opacity -= .08;
                i += 1;
            }
            else
            {
                MainForm frmMainForm = new MainForm();
                frmMainForm.Show();
                tmrSplash.Stop();
                this.Hide();
            }
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {

            if (i < 8)
            {
                i += 1;
            }
            else
            {
                i = 0;
                tmrSplash.Enabled = true;
                tmrSplash.Start();
                tmrStart.Stop();

            }
        }
    }
}
