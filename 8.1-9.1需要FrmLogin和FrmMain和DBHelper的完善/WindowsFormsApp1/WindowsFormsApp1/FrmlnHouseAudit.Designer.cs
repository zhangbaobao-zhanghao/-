
namespace WindowsFormsApp1
{
    partial class FrmlnHouseAudit
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
            this.bntAudit = new System.Windows.Forms.Button();
            this.bntAll = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.bntSave = new System.Windows.Forms.Button();
            this.txtAudit = new System.Windows.Forms.TextBox();
            this.txtAuditRemark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAudit
            // 
            this.bntAudit.Location = new System.Drawing.Point(26, 40);
            this.bntAudit.Name = "bntAudit";
            this.bntAudit.Size = new System.Drawing.Size(163, 23);
            this.bntAudit.TabIndex = 0;
            this.bntAudit.Text = "待审批入库单";
            this.bntAudit.UseVisualStyleBackColor = true;
            this.bntAudit.Click += new System.EventHandler(this.bntAudit_Click);
            // 
            // bntAll
            // 
            this.bntAll.Location = new System.Drawing.Point(259, 40);
            this.bntAll.Name = "bntAll";
            this.bntAll.Size = new System.Drawing.Size(130, 23);
            this.bntAll.TabIndex = 1;
            this.bntAll.Text = "所有入库单";
            this.bntAll.UseVisualStyleBackColor = true;
            this.bntAll.Click += new System.EventHandler(this.bntAll_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(26, 122);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(1024, 150);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgOrder_CellContentClick);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(26, 287);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 27;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1024, 218);
            this.dgvOrderDetail.TabIndex = 3;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(931, 539);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(91, 42);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "审核通过";
            this.bntSave.UseVisualStyleBackColor = true;
            // 
            // txtAudit
            // 
            this.txtAudit.Location = new System.Drawing.Point(696, 550);
            this.txtAudit.Name = "txtAudit";
            this.txtAudit.Size = new System.Drawing.Size(132, 25);
            this.txtAudit.TabIndex = 5;
            // 
            // txtAuditRemark
            // 
            this.txtAuditRemark.AutoSize = true;
            this.txtAuditRemark.Location = new System.Drawing.Point(551, 560);
            this.txtAuditRemark.Name = "txtAuditRemark";
            this.txtAuditRemark.Size = new System.Drawing.Size(67, 15);
            this.txtAuditRemark.TabIndex = 6;
            this.txtAuditRemark.Text = "审批意见";
            // 
            // FrmlnHouseAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 606);
            this.Controls.Add(this.txtAuditRemark);
            this.Controls.Add(this.txtAudit);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.bntAll);
            this.Controls.Add(this.bntAudit);
            this.Name = "FrmlnHouseAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库审批";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAudit;
        private System.Windows.Forms.Button bntAll;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox txtAudit;
        private System.Windows.Forms.Label txtAuditRemark;
    }
}