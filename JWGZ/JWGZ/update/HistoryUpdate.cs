using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JWGZ.update
{
    public partial class HistoryUpdate : Form
    {
        public static bool GlobalFlag;

        public HistoryUpdate()
        {
            InitializeComponent();
        }
        public HistoryUpdate(String id, String t_id, String t_name, String rank, String is_tutor, String school, String depart, String card_id, String point_sum, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtT_id.Text = t_id;
            txtT_name.Text = t_name;
            txt_Rank.Text = rank;
            txtIs_tutor.Text = is_tutor;
            txtSchool.Text = school;
            txtDepart.Text = depart;
            txtCard_id.Text = card_id;
            txtPoint_sum.Text = point_sum;
            txtTerm.Text = term;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String t_id = txtT_id.Text;
            String t_name = txtT_name.Text;
            String rank = txt_Rank.Text;
            String is_tutor = txtIs_tutor.Text;
            String school = txtSchool.Text;
            String depart = txtDepart.Text;
            String card_id = txtCard_id.Text;
            String point_sum = txtPoint_sum.Text;
            String term = txtTerm.Text;
            String remark = txtRemark.Text;

            String ConStr = string.Format(//设置数据库连接字符串
@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\历史.mdb");
            try
            {
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                oleCon.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = oleCon;
                cmd.CommandText = "update " + term + " set 教师号 = '" + t_id + "',姓名 = '" + t_name + "',职称 = '" + rank + "',硕导 = '" + is_tutor + "',学院 = '" + school + "' ,系 = '" + depart + "',身份证号 = '" + card_id + "',总计 = '" + point_sum + "',学期 = '" + term + "',备注 = '" + remark + "' where ID = " + id + "";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                oleCon.Close();//关闭数据库连接
                oleCon.Dispose();//释放连接资源

                GlobalFlag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
