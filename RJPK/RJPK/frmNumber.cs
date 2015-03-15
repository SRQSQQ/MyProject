using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RJPK.ADO;
using RJPK.DB;

namespace RJPK
{
    public partial class frmNumber : Form
    {
        DbCommon dbcommon = new DbCommon();
        CourseAdo courseAdo = new CourseAdo();

        public frmNumber()
        {
            InitializeComponent();
        }

        private void frmNumber_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dsCourseName = courseAdo.GetCourseName();   //全部课程名
                for (int i = 0; i < dsCourseName.Tables[0].Rows.Count; i++)
                {
                    //总人数
                    String sql_sumNumber = "select 人数 from Course where 课程名称 = '" + dsCourseName.Tables[0].Rows[i][0].ToString() + "'";
                    DataSet ds_sumNumber = courseAdo.GetCourseInfo(sql_sumNumber);

                    if (ds_sumNumber.Tables[0].Rows[0][0].ToString() == null || ds_sumNumber.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }

                    int sumNumber = Convert.ToInt32(ds_sumNumber.Tables[0].Rows[0][0]);

                    //已分配人数
                    String sql_number = "select 班级人数 from History where 课程名称 = '" + dsCourseName.Tables[0].Rows[i][0].ToString() + "'";
                    DataSet ds_number = courseAdo.GetCourseInfo(sql_number);

                    int number = 0;
                    for (int j = 0; j < ds_number.Tables[0].Rows.Count; j++)
                    {
                        if (ds_number.Tables[0].Rows[j][0].ToString() == null || ds_number.Tables[0].Rows[j][0].ToString() == "")
                        {
                            continue;
                        }

                        number = number + Convert.ToInt32(ds_number.Tables[0].Rows[j][0]);
                    }

                    //剩余人数
                    int residue = sumNumber - number;

                    Dgv_Number.Rows.Add(dsCourseName.Tables[0].Rows[i][0].ToString(), residue);
                }  
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");	
            } 
        }
    }
}
