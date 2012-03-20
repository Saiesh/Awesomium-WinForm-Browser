using System;
using System.Linq;
using System.IO;
using System.Net;
using Awesomium.Core;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Telerik.WinControls.UI.Docking;

namespace ScrumBrowser
{
    public partial class Browser : UserControl
    {
        static String HomePage = "http://www.google.com";
                
        public Browser()
        {
            InitializeComponent();
            webControl1.Source = new Uri(HomePage);
        }

        public Browser(String url)
        {
            InitializeComponent();
           // webControl1.Source = new Uri(HomePage);
        }

        private void webControl1_Click(object sender, EventArgs e)
        {

        }

       
        private void ForwardBttn_Click(object sender, EventArgs e)
        {
            if (webControl1.IsCrashed)
                return;

            webControl1.GoForward();
        }

        private void RefreshBttn_Click(object sender, EventArgs e)
        {
            if (webControl1.IsCrashed)
                return;

            webControl1.Reload();               
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            if (webControl1.IsCrashed)
                return;

            webControl1.GoBack();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void webControl_TargetUrlChanged(object sender, UrlEventArgs e)
        {
           
        }

        private void addressBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }
               
    }

    
}

