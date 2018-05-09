namespace Management
{
    partial class MainFrm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.添加单词包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加单词ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加单词包ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加单词包类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.显示单词ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 126);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(490, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "当前单词数：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel2.Text = "***";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel3.Text = "                       ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel4.Text = "当前时间：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel5.Text = "显示当前时间";
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            this.toolStripStatusLabel5.DoubleClick += new System.EventHandler(this.toolStripStatusLabel5_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 添加单词包ToolStripMenuItem
            // 
            this.添加单词包ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加单词ToolStripMenuItem,
            this.添加单词包ToolStripMenuItem1,
            this.添加单词包类型ToolStripMenuItem});
            this.添加单词包ToolStripMenuItem.Name = "添加单词包ToolStripMenuItem";
            this.添加单词包ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.添加单词包ToolStripMenuItem.Text = "添加单词(包)";
            this.添加单词包ToolStripMenuItem.Click += new System.EventHandler(this.添加单词包ToolStripMenuItem_Click);
            // 
            // 添加单词ToolStripMenuItem
            // 
            this.添加单词ToolStripMenuItem.Name = "添加单词ToolStripMenuItem";
            this.添加单词ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加单词ToolStripMenuItem.Text = "添加单词";
            this.添加单词ToolStripMenuItem.Click += new System.EventHandler(this.添加单词ToolStripMenuItem_Click);
            // 
            // 添加单词包ToolStripMenuItem1
            // 
            this.添加单词包ToolStripMenuItem1.Name = "添加单词包ToolStripMenuItem1";
            this.添加单词包ToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.添加单词包ToolStripMenuItem1.Text = "添加单词包";
            this.添加单词包ToolStripMenuItem1.Click += new System.EventHandler(this.添加单词包ToolStripMenuItem1_Click);
            // 
            // 添加单词包类型ToolStripMenuItem
            // 
            this.添加单词包类型ToolStripMenuItem.Name = "添加单词包类型ToolStripMenuItem";
            this.添加单词包类型ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加单词包类型ToolStripMenuItem.Text = "添加单词包类型";
            this.添加单词包类型ToolStripMenuItem.Click += new System.EventHandler(this.添加单词包类型ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加单词包ToolStripMenuItem,
            this.显示单词ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 显示单词ToolStripMenuItem
            // 
            this.显示单词ToolStripMenuItem.Name = "显示单词ToolStripMenuItem";
            this.显示单词ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.显示单词ToolStripMenuItem.Text = "显示单词";
            this.显示单词ToolStripMenuItem.Click += new System.EventHandler(this.显示单词ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 148);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 添加单词包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加单词ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加单词包ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 添加单词包类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示单词ToolStripMenuItem;
    }
}

