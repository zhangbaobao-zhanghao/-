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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNo.Text = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            //显示仓库下拉
            this.cmbWarehouseID.DataSource = DBHelper.GetDataTable(sql);
            this.cmbWarehouseID.DisplayMember = "Name";
            this.cmbWarehouseID.ValueMember = " ID";

            //经手人
            this.txtHandlerID.Text = Common.userName;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barCode = this.txtBarcode.Text;
            string sql = "select * from product where barCode=" + barCode;
            DataTable dt = DBHelper.GetDataTable(sql);
            if(dt!= null && dt.Rows.Count > 0)
            {
                //循环变例数据表
                int count = 0;
                for (int i = 0; i < dgvInHouse.Rows.Count; i++)
                {                    
                    if (barCode == dgvInHouse.Rows[i].Count[1].Value.ToString()) ;
                    {
                        //如果值相等，就不用新增行，直接加数量1
                        dgvInHouse.Rows[i].Count[3].Value = int.Parse(dgvInHouse.Rows[i].Count[3].Value.ToString()) + 1;
                        break;
                    }
                    count++;
                }
                //如果实际循环次数和这个表格的行数相等的话，就说明没有相同的条码，就要新增一行
                if(count == dgvinHouse.Rows.Count)
                {
                    int index = this.dgvlnHouse.Rows.Add();
                    this.dgvlnHouse.Rows[index].Cells[0].Value = dt.Rows[0][0].ToString();
                    this.dgvlnHouse.Rows[index].Cells[1].Value = dt.Rows[0][1].ToString();
                    this.dgvlnHouse.Rows[index].Cells[2].Value = dt.Rows[0][2].ToString();
                    this.dgvlnHouse.Rows[index].Cells[3].Value = 1;
                }

                //如果输入的条码是第一次
                //将搜索出来的产品，追加到列表的一行                
            }
            else
            {
                MessageBox.Show("没有该产品");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //插入入库信息单(1条)
            string no = this.txtNo.Text;
            string wareHouseID = this.cmbWarehouseID.SelectedValue.ToString();
            string remark = this.txtRemark.Text;
            int handlerID = Common.userID;
            string sqlOrder = $"insert InOrder (no,warehouseID,handlerID,remark) values('{no}','{WarehouseID}','{handlerID}','{remark}')";
            DBHelper.ExcuteSql(sqlOrder);

            //插入订单明细（多条）
            foreach (DataGirdViewRow dr in this.dgvInHouse.Rows)
            {
                string pid = dr.Cells[0].ToString();
                float nums = double.Parse(dr.Cells[3].Value.ToString());
                string sqlOrderDetail = "insert InOrderDetail values('{no}','{pid},'{nums}')";
                DBHelper.ExcuteSql(sqlOrderDetail);
            }
        }
    }
}
