using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RJPK;
using RJPK.ADO;
using RJPK.DB;
using System.Threading;
using System.Data.OleDb;

namespace RJPK
{
    public partial class frmMain : Form
    {
        DbCommon dbcommon = new DbCommon();
        CourseAdo courseAdo = new CourseAdo();
        public static bool RefreshBool = false; //刷新标记        
        public static bool numberFinishBool = false; //合班结束标记
        public static bool coursementFinishBool = false; //重复课结束标记
        public static bool theoryFinishBool = false; //理论结束标记
        public static bool experimentFinishBool = false; //实验结束标记
        public static bool practiceFinishBool = false; //实践结束标记        
        public static bool finalFinishBool = false; //结束标记       
        public static bool SCBool = false; //结束标记

        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_SC_Click(object sender, EventArgs e)
        {
            SC sc = new SC();
            sc.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            try
            {
                String sql = "delete from CourseCal";
                dbcommon.ExcuteUpdateTable(sql);

                DataSet dsCourseName = courseAdo.GetCourseName();
                for (int i = 0; i < dsCourseName.Tables[0].Rows.Count; i++)
                {
                    cbox_CourseName.Items.Add(dsCourseName.Tables[0].Rows[i][0].ToString());
                }   
            }
            catch (System.Exception ex)
            {
            	MessageBox.Show(ex.Message, "注意");
            }         
        }

        private void cbox_CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 1;
                String sql = "select 课程代码,课程名称,周学时,课程性质,讲课学时,实验学时,实践学时 from Course where 课程名称 = '" + cbox_CourseName.Text + "'";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);

                /*string sql_id = "select top 1 id from CourseCal order by id desc";*/
                string sql_id = "select count(*) from CourseCal";
                DataSet ds_id = courseAdo.GetCourseInfo(sql_id);

                if (ds_id.Tables[0].Rows[0][0].ToString() == "" || ds_id.Tables[0].Rows[0][0].ToString() == null)
                {
                    id = Convert.ToInt32(ds_id.Tables[0].Rows[0][0]) + 1;
                    String sql_course = "insert into CourseCal (ID,课程代码,课程名称,周学时,课程性质,讲课学时,实验学时,实践学时) values('" + id + "','" +
                        dsCourse.Tables[0].Rows[0][0].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][1].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][2].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][3].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][4].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][5].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][6].ToString() + "')";  
                }
                else
                {
                    id = Convert.ToInt32(ds_id.Tables[0].Rows[0][0]) + 1;
                    String sql_course = "insert into CourseCal (ID,课程代码,课程名称,周学时,课程性质,讲课学时,实验学时,实践学时) values('" + id + "','" +
                        dsCourse.Tables[0].Rows[0][0].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][1].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][2].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][3].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][4].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][5].ToString() + "','" +
                        dsCourse.Tables[0].Rows[0][6].ToString() + "')";                
                    dbcommon.ExcuteUpdateTable(sql_course);
                }

                String sql_courseCal = "select * from CourseCal";
                DataSet ds_courseCal = courseAdo.GetCourseInfo(sql_courseCal);
                this.Dgv_Course.DataSource =//设置数据源
                    ds_courseCal.Tables[0].DefaultView;

                Dgv_Course.Columns["班级"].Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "注意");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                btnCalculate.Text = "核算中";
                btnCalculate.Enabled = false;

                //理论教分
                Thread threadTheory = new Thread(new ThreadStart(theoryCal));
                threadTheory.Start();
                threadTheory.IsBackground = true;

                //实践教分
                Thread threadPractice = new Thread(new ThreadStart(practiceCal));
                threadPractice.Start();
                threadPractice.IsBackground = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "核算");
            }        
        }

        //////////////////////////////////////////////////////////////////////////

#region 理论教分核算
        /* ************************************
        * void theoryCal()
        * 功能	    理论工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        * 注意    theoryCal方法在核算按钮点击事件中开启线程调用
        **************************************/
        public void theoryCal()
        {
            try
            {
                //合班
                theoryCal_number();

                //重复课
                theoryCal_course();                

                #region 理论核算
                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
                int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

                for (int count = firstRow; count < H_Max; count++)
                {
                    //讲课学时
                    String sql_time = "select 讲课学时 from CourseCal where ID = '" + count + "'";
                    DataSet ds_time = courseAdo.GetCourseInfo(sql_time);
                    if (ds_time.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 理论教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String teach_hour = ds_time.Tables[0].Rows[0][0].ToString().Trim();

                    //合班系数
                    String sql_number = "select 理论合班系数 from CourseCal where ID = '" + count + "'";
                    DataSet ds_number = courseAdo.GetCourseInfo(sql_number);
                    if (ds_number.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 理论教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String number_weight = ds_number.Tables[0].Rows[0][0].ToString().Trim();

                    //重复课系数
                    String sql_course = "select 理论重复课系数 from CourseCal where ID = '" + count + "'";
                    DataSet ds_course = courseAdo.GetCourseInfo(sql_course);
                    if (ds_course.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 理论教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String course_weight = ds_course.Tables[0].Rows[0][0].ToString().Trim();

                    //计算公式
                    string cal_weight = teach_hour + "*" + number_weight + "*" + course_weight;

                    //理论教分
                    double teach_point = Convert.ToDouble(teach_hour) * Convert.ToDouble(number_weight) * Convert.ToDouble(course_weight);

                    /*String point_final = cal_weight + "＝" + teach_point;*/
                    String sql_point = "update CourseCal set 理论公式 = '" + cal_weight + "', 理论教分 = '" + teach_point + "' where ID = '" + count + "'";
                    dbcommon.ExcuteUpdateTable(sql_point);
                }
                #endregion
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "理论教学核算");
            }

            RefreshBool = true;
            theoryFinishBool = true;
        }

        /* ************************************
        * void theoryCal_number()
        * 功能	    理论工作量 合班系数核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal_number()
        {
            String sql = "select * from CourseCal";
            DataSet dsCourse = courseAdo.GetCourseInfo(sql);
            int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
            int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

            try
            {
                for (int count = firstRow; count < H_Max; count++)
                {
                    String sql_SeleteNumber = "select 班级人数 from CourseCal where ID = '" + count + "'"; //查询选课人数SQL
                    DataSet ds_SeleteNumber = courseAdo.GetCourseInfo(sql_SeleteNumber);

                    //选课人数为空
                    if (ds_SeleteNumber.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;

                    }
                    int course_numInt = Convert.ToInt32(ds_SeleteNumber.Tables[0].Rows[0][0].ToString());   //选课人数

                    //选课人数小于30
                    if (course_numInt <= 30)
                    {
                        double number_weight = 0.7;
                        String sql_number = "update CourseCal set 理论合班系数 = '" + number_weight + "' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_number);
                    }
                    //选课人数大于30小于等于120
                    else if (course_numInt > 30 && course_numInt <= 120)
                    {
                        int class_numZ = course_numInt / 30;    //班数
                        int class_numY = course_numInt % 30;    //余人数    
                        if (class_numZ == 1)
                        {
                            double number_weightZ = 0.7;
                            double number_weightY = 0.005 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_number = "update CourseCal set 理论合班系数 = '" + number_weight + "' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_number);
                        }
                        else if (class_numZ == 2)
                        {
                            double number_weightZ = 0.85;
                            double number_weightY = 0.005 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_number = "update CourseCal set 理论合班系数 = '" + number_weight + "' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_number);
                        }
                        else if (class_numZ == 3)
                        {
                            double number_weightZ = 1;
                            double number_weightY = 0.005 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_number = "update CourseCal set 理论合班系数 = '" + number_weight + "' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_number);
                        }
                        else if (class_numZ == 4 && class_numY == 0)
                        {
                            double number_weightZ = 1.15;
                            String sql_number = "update CourseCal set 理论合班系数 = '" + number_weightZ + "' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_number);
                        }
                    }
                    //选课人数大于120
                    else if (course_numInt > 120)
                    {
                        int class_numAdd = course_numInt - 120; //增加人数
                        double number_weightZ = 1.15;
                        double number_weightY = 0.01 * class_numAdd;
                        double number_weight = number_weightZ + number_weightY;
                        String sql_number = "update CourseCal set 理论合班系数 = '" + number_weight + "' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_number);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "理论合班系数");
            }

            numberFinishBool = true;
        }

        /* ************************************
        * void theoryCal_course()
        * 功能	    理论工作量 重复课系数核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal_course()
        {
            try
            {
                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
                int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

                for (int count = firstRow; count < H_Max; count++)
                {
                    String sql_couse = "select 课程代码,课程名称 from CourseCal where ID = '" + count + "'";
                    DataSet ds_couse = courseAdo.GetCourseInfo(sql_couse);
                    if (ds_couse.Tables[0].Rows[0][0].ToString() == "" || ds_couse.Tables[0].Rows[0][1].ToString() == "")
                    {
                        continue;
                    }
                    String course_id = ds_couse.Tables[0].Rows[0][0].ToString();
                    String course_name = ds_couse.Tables[0].Rows[0][1].ToString();
                    String sql_count = "select * from CourseCal where 课程代码 = '" + course_id + "' and 课程名称 = '" + course_name + "'";
                    DataSet ds_count = courseAdo.GetCourseInfo(sql_count);
                    for (int row = 0; row < ds_count.Tables[0].Rows.Count; row++)
                    {
                        int cs_id1 = row + 1;
                        String id = ds_count.Tables[0].Rows[row][0].ToString();
                        String sql_KC = "update CourseCal set 课序号 = '" + cs_id1 + "' where ID = '" + id + "'";
                        dbcommon.ExcuteUpdateTable(sql_KC);
                    }

                    String sql_seleteKC = "select 课序号 from CourseCal where ID = '" + count + "'";
                    DataSet ds_seleteKC = courseAdo.GetCourseInfo(sql_seleteKC);

                    if (ds_seleteKC.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_Repetition = "update CourseCal set 理论重复课系数 = '1' where ID = '" + count + "'";   //修改重复课系数SQL
                        dbcommon.ExcuteUpdateTable(sql_Repetition);
                        continue;
                    }
                    else if (ds_seleteKC.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        double course_weight = 1;
                        String sql_Repetition = "update CourseCal set 理论重复课系数 = '" + course_weight + "' where ID = '" + count + "'";   //修改重复课系数SQL
                        dbcommon.ExcuteUpdateTable(sql_Repetition);
                    }
                    else
                    {
                        double course_weight = 0.8;
                        String sql_Repetition = "update CourseCal set 理论重复课系数 = '" + course_weight + "' where ID = '" + count + "'";   //修改重复课系数SQL
                        dbcommon.ExcuteUpdateTable(sql_Repetition);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "理论重复课系数");
            }

            coursementFinishBool = true;
        }
#endregion
#region 实践教分核算
        /* ************************************
        * void practiceCal()
        * 功能	    实践工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void practiceCal()
        {
            String sql = "select * from CourseCal";
            DataSet dsCourse = courseAdo.GetCourseInfo(sql);
            int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
            int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

            for (int count = firstRow; count < H_Max; count++)
            {
                try
                {
                    //课程名称
                    String sql_CourseName = "select 课程名称 from CourseCal where ID = '" + count + "'";
                    DataSet ds_CourseName = courseAdo.GetCourseInfo(sql_CourseName);
                    if (ds_CourseName.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    if (ds_CourseName.Tables[0].Rows[0][0].ToString().Length < 4)
                    {
                        String sql_point = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_point);
                        continue;
                    }
                    String courseName = ds_CourseName.Tables[0].Rows[0][0].ToString().Substring(0, 4);

                    if (courseName == "学年设计")
                    {
                        //周学时
                        String sql_time = "select 周学时 from CourseCal where ID = '" + count + "'";
                        DataSet ds_time = courseAdo.GetCourseInfo(sql_time);
                        if (ds_time.Tables[0].Rows[0][0].ToString() == "")
                        {
                            String sql_null = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_null);
                            continue;
                        }
                        String teach_hour = ds_time.Tables[0].Rows[0][0].ToString().Trim().Substring(1, 1);
                        //人数
                        String sql_number = "select 班级人数 from CourseCal where ID = '" + count + "'";
                        DataSet ds_number = courseAdo.GetCourseInfo(sql_number);
                        if (ds_number.Tables[0].Rows[0][0].ToString() == "")
                        {
                            String sql_null = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_null);
                            continue;
                        }
                        String seleteNumber = ds_number.Tables[0].Rows[0][0].ToString().Trim();

                        //课程教分
                        double course_weight = 0.5;

                        //实践教分
                        double teach_point = Convert.ToDouble(teach_hour) * Convert.ToDouble(seleteNumber) * course_weight;

                        /*String point_final = cal_weight + "＝" + teach_point;*/

                        //计算公式
                        String cal_weight = teach_hour + "*" + seleteNumber + "*" + course_weight;
                        String sql_point = "update CourseCal set 实践公式 = '" + cal_weight + "',实践教分 = '" + teach_point + "' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_point);
                    }
                    else if (courseName == "课程设计" || courseName == "认识实习")
                    {
                        //周学时
                        String sql_time = "select 周学时 from CourseCal where ID = '" + count + "'";
                        DataSet ds_time = courseAdo.GetCourseInfo(sql_time);
                        if (ds_time.Tables[0].Rows[0][0].ToString() == "")
                        {
                            String sql_null = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_null);
                            continue;
                        }
                        String teach_hour = ds_time.Tables[0].Rows[0][0].ToString().Trim().Substring(1, 1);
                        //人数
                        String sql_number = "select 班级人数 from CourseCal where ID = '" + count + "'";
                        DataSet ds_number = courseAdo.GetCourseInfo(sql_number);
                        if (ds_number.Tables[0].Rows[0][0].ToString() == "")
                        {
                            String sql_null = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                            dbcommon.ExcuteUpdateTable(sql_null);
                            continue;
                        }
                        String seleteNumber = ds_number.Tables[0].Rows[0][0].ToString().Trim();

                        //课程教分
                        double course_weight = 0.25;

                        //实践教分
                        double teach_point = Convert.ToDouble(teach_hour) * Convert.ToDouble(seleteNumber) * course_weight;

                        /*String point_final = cal_weight + "＝" + teach_point;*/

                        //计算公式
                        String cal_weight = teach_hour + "*" + seleteNumber + "*" + course_weight;
                        String sql_point = "update CourseCal set 实践公式 = '" + cal_weight + "',实践教分 = '" + teach_point + "' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_point);
                    }
                    else
                    {
                        String sql_point = "update CourseCal set 实践教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_point);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "实践");
                }
                  
            }
            RefreshBool = true;
            practiceFinishBool = true;
        }
#endregion
#region 实验教分核算
        /* ************************************
        * void practiceCal()
        * 功能	    实验工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        * 注意    practiceCal方法在计时器控件触发事件中调用
        **************************************/
        public void experimentCal()
        {
            try
            {
                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
                int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

                for (int count = firstRow; count < H_Max; count++)
                {
                    //实验学时
                    String sql_time = "select 实验学时 from CourseCal where ID = '" + count + "'";
                    DataSet ds_time = courseAdo.GetCourseInfo(sql_time);
                    if (ds_time.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 实验教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String teach_hour = ds_time.Tables[0].Rows[0][0].ToString().Trim();

                    //合班系数
                    String sql_number = "select 理论合班系数 from CourseCal where ID = '" + count + "'";
                    DataSet ds_number = courseAdo.GetCourseInfo(sql_number);
                    if (ds_number.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 实验教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String number_weight = ds_number.Tables[0].Rows[0][0].ToString().Trim();

                    //重复课系数
                    String sql_course = "select 理论重复课系数 from CourseCal where ID = '" + count + "'";
                    DataSet ds_course = courseAdo.GetCourseInfo(sql_course);
                    if (ds_course.Tables[0].Rows[0][0].ToString() == "")
                    {
                        String sql_null = "update CourseCal set 实验教分 = '0' where ID = '" + count + "'";
                        dbcommon.ExcuteUpdateTable(sql_null);
                        continue;
                    }
                    String course_weight = ds_course.Tables[0].Rows[0][0].ToString().Trim();

                    //实验性质系数
                    double experiment_weight = 1.1;

                    //计算公式
                    String cal_weight = teach_hour + "*" + number_weight + "*" + experiment_weight + "*" + course_weight;

                    //理论教分
                    double teach_point = Convert.ToDouble(teach_hour) * Convert.ToDouble(number_weight) * experiment_weight * Convert.ToDouble(course_weight);

                    /*String point_final = cal_weight + "＝" + teach_point;*/
                    String sql_point = "update CourseCal set 实验公式 = '" + cal_weight + "', 实验教分 = '" + teach_point + "' where ID = '" + count + "'";
                    dbcommon.ExcuteUpdateTable(sql_point);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "实验教学核算");
            }

            RefreshBool = true;
            experimentFinishBool = true;
        }
#endregion
#region 总教分
        /* ************************************
        * void finalCal()
        * 功能	    理论工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        * 注意    finalCal方法在计时器控件触发事件中调用
        **************************************/
        public void finalCal()
        {
            try
            {
                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                int firstRow = Convert.ToInt32(dsCourse.Tables[0].Rows[0][0]); //第一行ID
                int H_Max = dsCourse.Tables[0].Rows.Count + firstRow; //Course表总行数 + 第一行ID

                for (int count = firstRow; count < H_Max; count++)
                {
                    //教分
                    String sql_cal = "select 实践教分,实验教分,理论教分 from CourseCal where ID = '" + count + "'";
                    DataSet ds_cal = courseAdo.GetCourseInfo(sql_cal);
                    if (ds_cal.Tables[0].Rows[0][0].ToString() == "" || ds_cal.Tables[0].Rows[0][1].ToString() == "" || ds_cal.Tables[0].Rows[0][2].ToString() == "")
                    {
                        continue;
                    }
                    String practiceCal = ds_cal.Tables[0].Rows[0][0].ToString().Trim(); //实践
                    String experimentCal = ds_cal.Tables[0].Rows[0][1].ToString().Trim();   //实验
                    String theoryCal = ds_cal.Tables[0].Rows[0][2].ToString().Trim();   //理论

                    //总教分
                    double teach_point = Convert.ToDouble(practiceCal) + Convert.ToDouble(experimentCal) + Convert.ToDouble(theoryCal);
                    String sql_point = "update CourseCal set 教分 = '" + teach_point + "' where ID = '" + count + "'";
                    dbcommon.ExcuteUpdateTable(sql_point);
                }

                double finalCal = 0;
                for (int count = firstRow; count < H_Max; count++)
                {
                    String sql_cal = "select 教分 from CourseCal where ID = '" + count + "'";
                    DataSet ds_cal = courseAdo.GetCourseInfo(sql_cal);

                    finalCal = finalCal + Convert.ToDouble(ds_cal.Tables[0].Rows[0][0]);
                }

                String sql_finalCal = "update CourseCal set 总计 = '" + finalCal + "'";
                dbcommon.ExcuteUpdateTable(sql_finalCal);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "总教学核算");
            }

            finalFinishBool = true;
        }
#endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
//             //判断是否上传完成
//             if (SCBool == true)
//             {
//                 DataSet dsCourse = courseAdo.GetCourse();
//                 this.Dgv_Course.DataSource =//设置数据源
//                     dsCourse.Tables[0].DefaultView;
//                 SCBool = false;
//             }
            if (RefreshBool == true)
            {

                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                this.Dgv_Course.DataSource =//设置数据源
                    dsCourse.Tables[0].DefaultView;
                RefreshBool = false;
            }

            //判断合班系数和重复课系数是否核算完成
            if (numberFinishBool == true && coursementFinishBool == true)
            {
                numberFinishBool = false;
                coursementFinishBool = false;

                //开启实验教分线程
                Thread threadExperiment = new Thread(new ThreadStart(experimentCal));
                threadExperiment.Start();
                threadExperiment.IsBackground = true;
            }

            //判断理论、实验和实践是否核算完成
            if (theoryFinishBool == true && experimentFinishBool == true && practiceFinishBool == true)
            {
                theoryFinishBool = false;
                experimentFinishBool = false;
                practiceFinishBool = false;

                //开启实践教分线程
                Thread threadFinal = new Thread(new ThreadStart(finalCal));
                threadFinal.Start();
                threadFinal.IsBackground = true;
            }

            //判断总教分是否核算完成
            if (finalFinishBool == true)
            {
                finalFinishBool = false;

                String sql = "select * from CourseCal";
                DataSet dsCourse = courseAdo.GetCourseInfo(sql);
                this.Dgv_Course.DataSource =//设置数据源
                    dsCourse.Tables[0].DefaultView;

                MessageBox.Show("核算完成！", "提示");
                btnCalculate.Text = "核算";
                btnCalculate.Enabled = true;
            }
            //修改后更新
            if (updateCourse.GlobalFlag == true)
            {
                String sql_courseCal = "select * from CourseCal";
                DataSet ds_courseCal = courseAdo.GetCourseInfo(sql_courseCal);
                this.Dgv_Course.DataSource =//设置数据源
                    ds_courseCal.Tables[0].DefaultView;
                updateCourse.GlobalFlag = false;
            }
        }

        private void btn_DC_Click(object sender, EventArgs e)
        {
            int exceedCount = 0;    //超额标记
            int residueCount = 0;   //剩余标记
            String exceedCourseName = null; //超额课程名                
            String residueCourseName = null;   //剩余课程名
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

                    if (residue < 0)
                    {
                        exceedCount++;
                        exceedCourseName = exceedCourseName + dsCourseName.Tables[0].Rows[i][0].ToString() + "  ";
                    }
                    if (residue > 0)
                    {
                        residueCount++;
                        residueCourseName = residueCourseName + dsCourseName.Tables[0].Rows[i][0].ToString() + "  ";
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "剩余人数");
            }

            if (exceedCount != 0 || residueCount != 0)
            {
                DialogResult result= MessageBox.Show(exceedCount + "个课程分配超额： " + exceedCourseName + "\n\n" + residueCount + "个课程未全部分配： " + residueCourseName + "\n\n" + "是否继续？", "警告", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DC dc = new DC();
                    dc.Show();
                }
            }
            else
            {
                DC dc = new DC();
                dc.Show();
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                String id = Dgv_Course.SelectedRows[0].Cells[0].Value.ToString();
                String course_id = Dgv_Course.SelectedRows[0].Cells[1].Value.ToString();
                String course_name = Dgv_Course.SelectedRows[0].Cells[3].Value.ToString();
                String number = Dgv_Course.SelectedRows[0].Cells[5].Value.ToString();
                String theoryTime = Dgv_Course.SelectedRows[0].Cells[7].Value.ToString();
                String experimentTime = Dgv_Course.SelectedRows[0].Cells[8].Value.ToString();
                String practiceTime = Dgv_Course.SelectedRows[0].Cells[9].Value.ToString(); updateCourse updatecourse = new updateCourse(id, course_id, course_name, number, theoryTime, experimentTime, practiceTime);
                updatecourse.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "修改");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                /*string sql_id = "select count(*) from History";*/
                //确保历史库中有数据
                string sql_insert = "insert into History (ID) values('0')";
                DataSet ds_insert = courseAdo.GetCourseInfo(sql_insert);

                string sql_id = "SELECT TOP 1 * FROM History ORDER BY ID DESC";
                DataSet ds_id = courseAdo.GetCourseInfo(sql_id);
                int flags = 1;

                if (ds_id.Tables[0].Rows[0][0].ToString() == "" || ds_id.Tables[0].Rows[0][0].ToString() == null)
                {
                    flags = 1;
                }
                else
                {
                    flags = Convert.ToInt32(ds_id.Tables[0].Rows[0][0].ToString()) + 1;
                }

                string ConStr = string.Format(//设置数据库连接字符串
@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\data.mdb",
Application.StartupPath);
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                oleCon.Open();
                OleDbDataAdapter oleDap1 = new OleDbDataAdapter(//创建数据适配器对象
                    "select * from CourseCal", oleCon);
                DataSet ds = new DataSet();//创建数据集
                oleDap1.Fill(ds, "result");//填充数据集

                OleDbDataAdapter oleDap2 = new OleDbDataAdapter(//创建数据适配器对象
                    "select * from History", oleCon);
                OleDbCommandBuilder cmdbld = new OleDbCommandBuilder(oleDap2);
                cmdbld.SetAllValues = true;
                oleDap2.InsertCommand = cmdbld.GetInsertCommand();
                ds.Tables[0].BeginLoadData();
                int rowcount = ds.Tables[0].Rows.Count;
                for (int n = 0; n < rowcount; n++)
                {
                    ds.Tables[0].Rows[n].SetAdded();
                }
                for (int n = 0; n < rowcount; n++)
                {
                    ds.Tables[0].Rows[n][0] = flags;
                }
                ds.Tables[0].EndLoadData();
                oleDap2.Update(ds, ds.Tables[0].TableName);
                oleCon.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "保存");
            }

            MessageBox.Show("保存完成", "提示");

            String sql = "delete from CourseCal";
            dbcommon.ExcuteUpdateTable(sql);

            String sql_courseCal = "select * from CourseCal";
            DataSet ds_courseCal = courseAdo.GetCourseInfo(sql_courseCal);
            this.Dgv_Course.DataSource =//设置数据源
                ds_courseCal.Tables[0].DefaultView;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            String sql = "delete from History";
            dbcommon.ExcuteUpdateTable(sql);

            String sql_courseCal = "select * from CourseCal";
            DataSet ds_courseCal = courseAdo.GetCourseInfo(sql_courseCal);
            this.Dgv_Course.DataSource =//设置数据源
                ds_courseCal.Tables[0].DefaultView;

            MessageBox.Show("历史库已清空，可重新核算！");
        }

        private void btn_ShowNumber_Click(object sender, EventArgs e)
        {
            frmNumber frmnumber = new frmNumber();
            frmnumber.Show();
        }
    }
}
