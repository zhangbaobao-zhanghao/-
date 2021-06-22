
namespace WindowsFormsApp1
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库审批ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库记录查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem,
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.基础信息ToolStripMenuItem.Text = "基础信息";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库登记ToolStripMenuItem,
            this.入库审批ToolStripMenuItem,
            this.入库记录查看ToolStripMenuItem});
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.出库管理ToolStripMenuItem.Text = "出库管理";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 入库登记ToolStripMenuItem
            // 
            this.入库登记ToolStripMenuItem.Name = "入库登记ToolStripMenuItem";
            this.入库登记ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.入库登记ToolStripMenuItem.Text = "入库登记";
            // 
            // 入库审批ToolStripMenuItem
            // 
            this.入库审批ToolStripMenuItem.Name = "入库审批ToolStripMenuItem";
            this.入库审批ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.入库审批ToolStripMenuItem.Text = "入库审批";
            this.入库审批ToolStripMenuItem.Click += new System.EventHandler(this.入库审批ToolStripMenuItem_Click);
            // 
            // 入库记录查看ToolStripMenuItem
            // 
            this.入库记录查看ToolStripMenuItem.Name = "入库记录查看ToolStripMenuItem";
            this.入库记录查看ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.入库记录查看ToolStripMenuItem.Text = "入库记录查看";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 659);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "主界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库审批ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库记录查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
    }
}