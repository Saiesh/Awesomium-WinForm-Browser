namespace ScrumBrowser
{
    partial class Browser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.ForwardBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBox1 = new Awesomium.Windows.Forms.AddressBox();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBttn,
            this.ForwardBttn,
            this.RefreshBttn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // BackBttn
            // 
            this.BackBttn.Image = ((System.Drawing.Image)(resources.GetObject("BackBttn.Image")));
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(65, 20);
            this.BackBttn.Text = "BACK";
            this.BackBttn.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // ForwardBttn
            // 
            this.ForwardBttn.Image = ((System.Drawing.Image)(resources.GetObject("ForwardBttn.Image")));
            this.ForwardBttn.Name = "ForwardBttn";
            this.ForwardBttn.Size = new System.Drawing.Size(91, 20);
            this.ForwardBttn.Text = "FORWARD";
            this.ForwardBttn.Click += new System.EventHandler(this.ForwardBttn_Click);
            // 
            // RefreshBttn
            // 
            this.RefreshBttn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBttn.Image")));
            this.RefreshBttn.Name = "RefreshBttn";
            this.RefreshBttn.Size = new System.Drawing.Size(82, 20);
            this.RefreshBttn.Text = "REFRESH";
            this.RefreshBttn.Click += new System.EventHandler(this.RefreshBttn_Click);
            // 
            // addressBox1
            // 
            this.addressBox1.AcceptsReturn = true;
            this.addressBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressBox1.Location = new System.Drawing.Point(249, 2);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(339, 20);
            this.addressBox1.TabIndex = 1;
            this.addressBox1.URL = null;
            this.addressBox1.WebControl = this.webControl1;
            this.addressBox1.TextChanged += new System.EventHandler(this.addressBox1_TextChanged);
            // 
            // webControl1
            // 
            this.webControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webControl1.IsRendering = true;
            this.webControl1.Location = new System.Drawing.Point(0, 27);
            this.webControl1.Name = "webControl1";
            this.webControl1.SelfUpdate = false;
            this.webControl1.Size = new System.Drawing.Size(588, 378);
            this.webControl1.TabIndex = 2;
            this.webControl1.Zoom = 100;
            this.webControl1.Click += new System.EventHandler(this.webControl1_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Awesomium.Core.HistoryQueryResult);
            // 
            // Browser
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webControl1);
            this.Name = "Browser";
            this.Size = new System.Drawing.Size(591, 408);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackBttn;
        private System.Windows.Forms.ToolStripMenuItem ForwardBttn;
        private System.Windows.Forms.ToolStripMenuItem RefreshBttn;
        private Awesomium.Windows.Forms.AddressBox addressBox1;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.BindingSource bindingSource;


    }
}
