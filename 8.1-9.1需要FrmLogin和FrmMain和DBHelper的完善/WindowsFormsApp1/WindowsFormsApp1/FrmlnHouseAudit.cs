using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmlnHouseAudit : Form
    {
        public FrmlnHouseAudit()
        {
            InitializeComponent();
        }

        private void dvgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntAudit_Click(object sender, EventArgs e)
        {
            String sql = "select * from inorder where status=0";
            this.dgvOrder.DataSource = DBHelper.GetDataTable(sql);

        }

        private void bntAll_Click(object sender, EventArgs e)
        {
            String sql = "select * from inorder ";
            this.dgvOrder.DataSource = DBHelper.GetDataTable(sql);
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string no = this.dgvOrder.CurrentRow.Cells[0].Value.ToString();
            //根据入库订单号，差入库明细
            string sql = "select * from InOrderDetail where orderNo=" + no+"'";
            this.dgvOrderDetail.DataSource = DBHelper.GetDataTable(sql);
        }
    }
}
