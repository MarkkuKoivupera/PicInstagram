namespace PicInstagram
{
    partial class Frm_PicsInst
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PicsInst));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.TSBtn_open = new System.Windows.Forms.ToolStripButton();
            this.TSBtn_Trash = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSText_Address = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBtn_Load = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.TS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1445, 553);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1445, 578);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.TS_Main);
            // 
            // TS_Main
            // 
            this.TS_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_open,
            this.TSBtn_Trash,
            this.toolStripSeparator1,
            this.TSText_Address,
            this.toolStripSeparator2,
            this.TSBtn_Load,
            this.toolStripButton4,
            this.toolStripButton5});
            this.TS_Main.Location = new System.Drawing.Point(3, 0);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(672, 25);
            this.TS_Main.TabIndex = 0;
            // 
            // TSBtn_open
            // 
            this.TSBtn_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_open.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_open.Image")));
            this.TSBtn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_open.Name = "TSBtn_open";
            this.TSBtn_open.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_open.Text = "Open";
            this.TSBtn_open.Click += new System.EventHandler(this.TSBtn_open_Click);
            // 
            // TSBtn_Trash
            // 
            this.TSBtn_Trash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Trash.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_Trash.Image")));
            this.TSBtn_Trash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Trash.Name = "TSBtn_Trash";
            this.TSBtn_Trash.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Trash.Text = "Trash ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSText_Address
            // 
            this.TSText_Address.Name = "TSText_Address";
            this.TSText_Address.Size = new System.Drawing.Size(500, 25);
            this.TSText_Address.Text = "https://instagram.com/tiiasusannae/";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBtn_Load
            // 
            this.TSBtn_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBtn_Load.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_Load.Image")));
            this.TSBtn_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtn_Load.Name = "TSBtn_Load";
            this.TSBtn_Load.Size = new System.Drawing.Size(23, 22);
            this.TSBtn_Load.Text = "Load";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // Frm_PicsInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 578);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Frm_PicsInst";
            this.Text = "Pics from Instagramm";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripButton TSBtn_open;
        private System.Windows.Forms.ToolStripButton TSBtn_Trash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TSText_Address;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBtn_Load;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

