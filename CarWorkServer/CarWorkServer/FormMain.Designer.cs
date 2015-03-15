namespace CarWorkServer
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStare = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPhone,
            this.toolStripMenuItemSearch,
            this.ToolStripMenuItemStare,
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemDisconnect,
            this.ToolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 136);
            // 
            // toolStripMenuItemPhone
            // 
            this.toolStripMenuItemPhone.Name = "toolStripMenuItemPhone";
            this.toolStripMenuItemPhone.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemPhone.Text = "绑定手机连接";
            this.toolStripMenuItemPhone.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemSearch.Text = "信息查询";
            this.toolStripMenuItemSearch.Click += new System.EventHandler(this.toolStripMenuItemSearch_Click_1);
            // 
            // ToolStripMenuItemStare
            // 
            this.ToolStripMenuItemStare.Name = "ToolStripMenuItemStare";
            this.ToolStripMenuItemStare.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemStare.Text = "开始侦听";
            this.ToolStripMenuItemStare.Click += new System.EventHandler(this.开始侦听ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemClose.Text = "关闭侦听";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.关闭侦听ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemDisconnect
            // 
            this.ToolStripMenuItemDisconnect.Name = "ToolStripMenuItemDisconnect";
            this.ToolStripMenuItemDisconnect.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemDisconnect.Text = "断开连接";
            this.ToolStripMenuItemDisconnect.Click += new System.EventHandler(this.断开连接ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemExit.Text = "关闭程序";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.关闭程序ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPhone;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStare;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDisconnect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        public System.Windows.Forms.Timer timer1;
    }
}

