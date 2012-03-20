using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using ScrumBrowser.Properties;
using Awesomium.Core;

namespace ScrumBrowser
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

            WebCoreConfig webConfig = new WebCoreConfig()
            {
                SaveCacheAndCookies = true,
                HomeURL = "http://www.google.com",
                LogLevel = LogLevel.Verbose
            };
            WebCore.Initialize(webConfig);

            DocumentWindow MainTab = new DocumentWindow();
            MainTab.Text = "Home";
            Browser MainBr = new Browser();
            MainBr.Dock = DockStyle.Fill;
            MainTab.Controls.Add(MainBr);
            radDock1.AddDocument(MainTab, DockPosition.Fill);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DocumentWindow tab = new DocumentWindow();
            Browser br = new Browser();
            br.Dock = DockStyle.Fill;
            tab.Controls.Add(br);
            radDock1.AddDocument(tab, DockPosition.Fill);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocumentWindow MainTab = new DocumentWindow();
            //HistoryForm Hst = new HistoryForm();
            //Hst.Dock = DockStyle.Fill;
            //MainTab.Controls.Add(Hst);
            radDock1.AddDocument(MainTab, DockPosition.Fill);
        }

        private void radDock1_Click(object sender, EventArgs e)
        {

        }

        private void ClearSource()
        {
            HistoryQueryResult oldSource = bindingSource.DataSource as HistoryQueryResult;

            if (oldSource != null)
            {
                using (oldSource)
                    bindingSource.DataSource = null;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.ClearSource();

            if (!WebCore.IsRunning)
                return;


            bindingSource.DataSource = WebCore.QueryHistory();
            HistoryQueryResult source = bindingSource.DataSource as HistoryQueryResult;

            for (int i = 0; i < source.Count; i++)
            {
                MessageBox.Show(source[i].Url.ToString());
            }
                        
            /*DocumentWindow history = new DocumentWindow();
            History h = new History(source);
            h.Dock = DockStyle.Fill;
            history.Controls.Add(h);
            radDock1.AddDocument(history, DockPosition.Fill);*/
        }

       
    }
}
