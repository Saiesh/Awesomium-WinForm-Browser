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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();

        }

        public History(HistoryQueryResult source)
        {
            InitializeComponent();
            try
            {
                listView1.Dock = DockStyle.Fill;
                if (source != null)
                {
                    for (int i = 0; i < source.Count; i++)
                    {
                        listView1.Items.Add(source[i].Title);
                    }

                    
                }

                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR : "+e.ToString());
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
