namespace 扫雷
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.难度选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eazy10104ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normal404016ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lunatic10010050ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.难度选择ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 难度选择ToolStripMenuItem
            // 
            this.难度选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eazy10104ToolStripMenuItem,
            this.normal404016ToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.lunatic10010050ToolStripMenuItem});
            this.难度选择ToolStripMenuItem.Name = "难度选择ToolStripMenuItem";
            this.难度选择ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.难度选择ToolStripMenuItem.Text = "难度选择";
            this.难度选择ToolStripMenuItem.Click += new System.EventHandler(this.难度选择ToolStripMenuItem_Click);
            // 
            // eazy10104ToolStripMenuItem
            // 
            this.eazy10104ToolStripMenuItem.Name = "eazy10104ToolStripMenuItem";
            this.eazy10104ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eazy10104ToolStripMenuItem.Text = "eazy(10*10,4)";
            this.eazy10104ToolStripMenuItem.Click += new System.EventHandler(this.eazy10104ToolStripMenuItem_Click);
            // 
            // normal404016ToolStripMenuItem
            // 
            this.normal404016ToolStripMenuItem.Name = "normal404016ToolStripMenuItem";
            this.normal404016ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.normal404016ToolStripMenuItem.Text = "normal(40*40,16)";
            this.normal404016ToolStripMenuItem.Click += new System.EventHandler(this.normal404016ToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hardToolStripMenuItem.Text = "hard(60*60,24)";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // lunatic10010050ToolStripMenuItem
            // 
            this.lunatic10010050ToolStripMenuItem.Name = "lunatic10010050ToolStripMenuItem";
            this.lunatic10010050ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.lunatic10010050ToolStripMenuItem.Text = "lunatic(100*100,50)";
            this.lunatic10010050ToolStripMenuItem.Click += new System.EventHandler(this.lunatic10010050ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 403);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 难度选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normal404016ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lunatic10010050ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eazy10104ToolStripMenuItem;
    }
}

