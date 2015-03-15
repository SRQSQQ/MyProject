using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using JWGZ.bl;
using JWGZ.update;
using JWGZ.com;
using System.Threading;

namespace JWGZ
{
    public partial class frmMain : Form
    {
        DbCommon dbcommon = new DbCommon();
        TeacherAdo teacherado = new TeacherAdo();
        TheoryAdo theoryado = new TheoryAdo();
        PracticeAdo practiceado = new PracticeAdo();
        DepartAdo departado = new DepartAdo();
        RankAdo rankado = new RankAdo();
        ClassAdo classado = new ClassAdo();
        ExperimentAdo experimentado = new ExperimentAdo();
        MasterAdo masterado = new MasterAdo();
        Dean_allowanceAdo dean_allowanceado = new Dean_allowanceAdo();
        ResultAdo resultado = new ResultAdo();
        AdultAdo adultado = new AdultAdo();

        public static bool ResultBool = false;
        public static bool PracticeBool = false;
        public static bool TheoryBool = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            this.toolStripStatusLabel3.Text = "系统时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            String trem = null;
            if (DateTime.Now.Month == 3 || DateTime.Now.Month == 4 || DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7)
            {
                trem = "秋";
                lblYear.Text = DateTime.Now.Year.ToString();
                lblTerm.Text = trem;
            }
            else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12 || DateTime.Now.Month == 1)
            {
                trem = "春";
                lblYear.Text = DateTime.Now.Year.ToString();
                lblTerm.Text = trem;
            }
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            SC sc = new SC();
            sc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "系统时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            #region 教师更新
            if (TeacherUpdate.GlobalFlag == true)
            {
                DataSet ds = teacherado.GetTeacher();
                this.DgvTeacher.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                TeacherUpdate.GlobalFlag = false;
            }
            if (TeacherInsert.GlobalFlag == true)
            {
                DataSet ds = teacherado.GetTeacher();
                this.DgvTeacher.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                TeacherInsert.GlobalFlag = false;
            }
            #endregion
            #region 专业更新
            if (DepartUpdate.GlobalFlag == true)
            {
                DataSet ds = departado.GetDepart();
                this.DgvDepart.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                DepartUpdate.GlobalFlag = false;
            }
            if (DepartInsert.GlobalFlag == true)
            {
                DataSet ds = departado.GetDepart();
                this.DgvDepart.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                DepartInsert.GlobalFlag = false;
            }
            #endregion
            #region 职称更新
            if (RankUpdate.GlobalFlag == true)
            {
                DataSet ds = rankado.GetRank();
                this.DgvRank.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                RankUpdate.GlobalFlag = false;
            }
            if (RankInsert.GlobalFlag == true)
            {
                DataSet ds = rankado.GetRank();
                this.DgvRank.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                RankInsert.GlobalFlag = false;
            }
            #endregion
            #region 班级更新
            if (ClassUpdate.GlobalFlag == true)
            {
                DataSet ds = classado.GetClass();
                this.DgvClass.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ClassUpdate.GlobalFlag = false;
            }
            if (ClassInsert.GlobalFlag == true)
            {
                DataSet ds = classado.GetClass();
                this.DgvClass.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ClassInsert.GlobalFlag = false;
            }
            #endregion
            #region 理论更新
            if (TheoryUpdate.GlobalFlag == true || TheoryBool == true)
            {
                DataSet ds = theoryado.GetTheory();
                this.DgvTheory.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                TheoryUpdate.GlobalFlag = false;
                TheoryBool = false;
            }
            if (TheoryInsert.GlobalFlag == true || TheoryBool == true)
            {
                DataSet ds = theoryado.GetTheory();
                this.DgvTheory.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                TheoryInsert.GlobalFlag = false;
                TheoryBool = false;
            }
            #endregion
            #region 实践更新
            if (PracticeUpdate.GlobalFlag == true || PracticeBool == true)
            {
                DataSet ds = practiceado.GetPractice();
                this.DgvPractice.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                PracticeUpdate.GlobalFlag = false;
                PracticeBool = false;
            }
            if (PracticeInsert.GlobalFlag == true || PracticeBool == true)
            {
                DataSet ds = practiceado.GetPractice();
                this.DgvPractice.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                PracticeInsert.GlobalFlag = false;
                PracticeBool = false;
            }
            #endregion
            #region 实验更新
            if (ExperimentUpdate.GlobalFlag == true)
            {
                DataSet ds = experimentado.GetExperiment();
                this.DgvExperiment.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ExperimentUpdate.GlobalFlag = false;
            }
            if (ExperimentInsert.GlobalFlag == true)
            {
                DataSet ds = experimentado.GetExperiment();
                this.DgvExperiment.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ExperimentInsert.GlobalFlag = false;
            }
            #endregion
            #region 研究生更新
            if (MasterUpdate.GlobalFlag == true)
            {
                DataSet ds = masterado.GetMaster();
                this.DgvMaster.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                MasterUpdate.GlobalFlag = false;
            }
            if (MasterInsert.GlobalFlag == true)
            {
                DataSet ds = masterado.GetMaster();
                this.DgvMaster.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                MasterInsert.GlobalFlag = false;
            }
            #endregion
            #region 系主任津贴更新
            if (DeanUpdate.GlobalFlag == true)
            {
                DataSet ds = dean_allowanceado.GetDean_allowance();
                this.DgvDean_allowance.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                DeanUpdate.GlobalFlag = false;
            }
            if (DeanInsert.GlobalFlag == true)
            {
                DataSet ds = dean_allowanceado.GetDean_allowance();
                this.DgvDean_allowance.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                DeanInsert.GlobalFlag = false;
            }
            #endregion
            #region 汇总更新
            if (ResultUpdate.GlobalFlag == true || ResultBool == true)
            {
                DataSet ds = resultado.GetResult();
                this.DgvResult.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ResultUpdate.GlobalFlag = false;
                ResultBool = false;
            }
            if (ResultInsert.GlobalFlag == true || ResultBool == true)
            {
                DataSet ds = resultado.GetResult();
                this.DgvResult.DataSource =//设置数据源
                    ds.Tables[0].DefaultView;
                ResultInsert.GlobalFlag = false;
                ResultBool = false;
            }
            #endregion
            #region 历史更新
            if (HistoryUpdate.GlobalFlag == true)
            {
                String term = cbox_YearH.Text + cbox_TermH.Text;

                String ConStr = string.Format(//设置数据库连接字符串
    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\历史.mdb");
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                OleDbDataAdapter oleDap = new OleDbDataAdapter(//创建数据适配器对象
                    "select ID,教师号,姓名,职称,硕导,学院,系,身份证号,总计,学期 from " + term + "", oleCon);
                DataSet ds = new DataSet();//创建数据集
                oleDap.Fill(ds, "" + term + "");//填充数据集
                this.DgvHistory.DataSource =//设置数据源
        ds.Tables[0].DefaultView;
                DgvHistory.Columns["ID"].Visible = false;
                oleCon.Close();//关闭数据库连接
                oleCon.Dispose();//释放连接资源
                HistoryUpdate.GlobalFlag = false;
            }
            #endregion
        }

        #region 教师信息
        private void btnUpdate_Teacher_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpTeacher;
            DataSet ds = teacherado.GetTeacher();
            this.DgvTeacher.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectTeacherOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from teacher where 教师名 LIKE '%" + txtTeacher_name.Text + "%'";
            DataSet ds = teacherado.SelectTeacher(sql);
            this.DgvTeacher.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectTeacherTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from teacher where 系 = '" + txtTeacher_Depart.Text + "'";
            DataSet ds = teacherado.SelectTeacher(sql);
            this.DgvTeacher.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = DgvTeacher.SelectedRows[0].Cells[0].Value.ToString();
                teacherado.DeleteTeacher(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = teacherado.GetTeacher();
            this.DgvTeacher.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateTeacher_Click_1(object sender, EventArgs e)
        {
            try
            {
                String t_id = DgvTeacher.SelectedRows[0].Cells[0].Value.ToString();
                String t_name = DgvTeacher.SelectedRows[0].Cells[1].Value.ToString();
                String depart = DgvTeacher.SelectedRows[0].Cells[2].Value.ToString();
                String rank = DgvTeacher.SelectedRows[0].Cells[3].Value.ToString();
                String card_id = DgvTeacher.SelectedRows[0].Cells[4].Value.ToString();
                String status = DgvTeacher.SelectedRows[0].Cells[5].Value.ToString();
                String school = DgvTeacher.SelectedRows[0].Cells[6].Value.ToString();
                TeacherUpdate teacherupdate = new TeacherUpdate(t_id, t_name, depart, rank, card_id, status, school);
                teacherupdate.Show();                
            }
            catch(Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！","注意");
            }
        }

        private void btnInsertTeacher_Click(object sender, EventArgs e)
        {
            TeacherInsert teacherinsert = new TeacherInsert();
            teacherinsert.Show();
        }

        private void btnRefreshTeacher_Click(object sender, EventArgs e)
        {
            DataSet ds = teacherado.GetTeacher();
            this.DgvTeacher.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 专业信息
        private void btnUpdate_Depart_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpDepart;
            DataSet ds = departado.GetDepart();
            this.DgvDepart.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectDepartOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from depart where 系名 LIKE '%" + txtDepart_name.Text + "%'";
            DataSet ds = departado.SelectDepart(sql);
            this.DgvDepart.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectDepartTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from depart where 系名 = '" + txtDepart.Text + "'";
            DataSet ds = departado.SelectDepart(sql);
            this.DgvDepart.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteDepart_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = DgvDepart.SelectedRows[0].Cells[0].Value.ToString();
                departado.DeleteDepart(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = departado.GetDepart();
            this.DgvDepart.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateDepart_Click(object sender, EventArgs e)
        {
            try
            {
                String depart_id = DgvDepart.SelectedRows[0].Cells[0].Value.ToString();
                String depart = DgvDepart.SelectedRows[0].Cells[1].Value.ToString();
                String school = DgvDepart.SelectedRows[0].Cells[2].Value.ToString();
                String status = DgvDepart.SelectedRows[0].Cells[3].Value.ToString();
                DepartUpdate departupdate = new DepartUpdate(depart_id, depart, school, status);
                departupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertDepart_Click(object sender, EventArgs e)
        {
            DepartInsert departinsert = new DepartInsert();
            departinsert.Show();
        }

        private void btnRefreshDepart_Click(object sender, EventArgs e)
        {
            DataSet ds = departado.GetDepart();
            this.DgvDepart.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 职称信息
        private void btnUpdate_Rank_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpRank;
            DataSet ds = rankado.GetRank();
            this.DgvRank.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectRankOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from rank where 职称 LIKE '%" + txtRank_name.Text + "%'";
            DataSet ds = rankado.SelectRank(sql);
            this.DgvRank.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectRankTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from rank where 职称 = '" + txtRank.Text + "'";
            DataSet ds = rankado.SelectRank(sql);
            this.DgvRank.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteRank_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = DgvRank.SelectedRows[0].Cells[0].Value.ToString();
                rankado.DeleteRank(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = rankado.GetRank();
            this.DgvRank.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateRank_Click(object sender, EventArgs e)
        {
            try
            {
                String rank_id = DgvRank.SelectedRows[0].Cells[0].Value.ToString();
                String rank = DgvRank.SelectedRows[0].Cells[1].Value.ToString();
                String rank_weight = DgvRank.SelectedRows[0].Cells[2].Value.ToString();
                RankUpdate rankupdate = new RankUpdate(rank_id, rank, rank_weight);
                rankupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertRank_Click(object sender, EventArgs e)
        {
            RankInsert rankinsert = new RankInsert();
            rankinsert.Show();
        }

        private void btnRefreshRank_Click(object sender, EventArgs e)
        {
            DataSet ds = rankado.GetRank();
            this.DgvRank.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 班级信息
        private void btnUpdate_Class_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpClass;
            DataSet ds = classado.GetClass();
            this.DgvClass.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectClassOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from class where 班级名 LIKE '%" + txtClass_name.Text + "%'";
            DataSet ds = classado.SelectClass(sql);
            this.DgvClass.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectClassTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from class where 院系 = '" + txtSchool.Text + "'";
            DataSet ds = classado.SelectClass(sql);
            this.DgvClass.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = DgvClass.SelectedRows[0].Cells[0].Value.ToString();
                classado.DeleteClass(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = classado.GetClass();
            this.DgvClass.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            try
            {
                String class_id = DgvClass.SelectedRows[0].Cells[0].Value.ToString();
                String class_name = DgvClass.SelectedRows[0].Cells[1].Value.ToString();
                String school = DgvClass.SelectedRows[0].Cells[2].Value.ToString();
                ClassUpdate classupdate = new ClassUpdate(class_id, class_name, school);
                classupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertClass_Click(object sender, EventArgs e)
        {
            ClassInsert classinsert = new ClassInsert();
            classinsert.Show();
        }

        private void btnRefreshClass_Click(object sender, EventArgs e)
        {
            DataSet ds = classado.GetClass();
            this.DgvClass.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 理论工作量
        private void btnUpdate_Theory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpTheory;
            DataSet ds = theoryado.GetTheory();
            this.DgvTheory.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvTheory.Columns["ID"].Visible = false;
        }

        private void btnSelectTheoryOne_Click(object sender, EventArgs e)
        {
            String sql = "select ID,课程号,课程名称,开课院系,主讲教师号,主讲教师姓名,主讲教师职称,合班,讲课学时,选课人数,折合教分,学期 from theoryCourse where 主讲教师姓名 LIKE '%" + txtTheory_name.Text + "%'";
            DataSet ds = theoryado.SelectTheory(sql);
            this.DgvTheory.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectTheoryTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from theoryCourse where 开课院系 = '" + txtTheory_Depart.Text + "'";
            DataSet ds = theoryado.SelectTheory(sql);
            this.DgvTheory.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteTheory_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvTheory.Columns[0].HeaderText;
                string ID = DgvTheory.SelectedRows[0].Cells[0].Value.ToString();
                theoryado.DeleteTheory(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = theoryado.GetTheory();
            this.DgvTheory.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateTheory_Click_1(object sender, EventArgs e)
        {
            try
            {
                String id = DgvTheory.SelectedRows[0].Cells[0].Value.ToString();
                String course_id = DgvTheory.SelectedRows[0].Cells[1].Value.ToString();
                String course_name = DgvTheory.SelectedRows[0].Cells[2].Value.ToString();
                String open_dep = DgvTheory.SelectedRows[0].Cells[3].Value.ToString();
                String t_id = DgvTheory.SelectedRows[0].Cells[4].Value.ToString();
                String teach_name = DgvTheory.SelectedRows[0].Cells[5].Value.ToString();
                String rank = DgvTheory.SelectedRows[0].Cells[6].Value.ToString();
                String teach_class = DgvTheory.SelectedRows[0].Cells[7].Value.ToString();
                String teach_hour = DgvTheory.SelectedRows[0].Cells[8].Value.ToString();
                String teach_number = DgvTheory.SelectedRows[0].Cells[9].Value.ToString();
                String teach_point = DgvTheory.SelectedRows[0].Cells[10].Value.ToString();
                String term = DgvTheory.SelectedRows[0].Cells[11].Value.ToString();
                TheoryUpdate theoryupdate = new TheoryUpdate(id, course_id, course_name, open_dep, t_id, teach_name, rank, teach_class, teach_hour, teach_number, teach_point, term);
                theoryupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertTheory_Click_1(object sender, EventArgs e)
        {
            TheoryInsert theoryinsert = new TheoryInsert();
            theoryinsert.Show();
        }

        private void btnRefreshTheory_Click_1(object sender, EventArgs e)
        {
            String sql = "delete from theoryCourse";
            dbcommon.ExcuteUpdateTable(sql);
        }

        private void btnCalculateTheory_Click(object sender, EventArgs e)
        {
            btnCalculateTheory.Text = "核算中";
            btnCalculateTheory.Enabled = false;
            
            Thread threadTheory = new Thread(new ThreadStart(theoryCal));
            threadTheory.Start();
            threadTheory.IsBackground = true;
        }
        #endregion
        #region 实践工作量
        private void btnUpdate_Practice_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpPractice;
            DataSet ds = practiceado.GetPractice();
            this.DgvPractice.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvPractice.Columns["ID"].Visible = false;
        }

        private void btnSelectPracticeOne_Click(object sender, EventArgs e)
        {
            String sql = "select ID,课程号,课程名称,开课院系,主讲教师号,主讲教师姓名,主讲教师职称,折合教分,学期 from practiceCourse where 主讲教师姓名 LIKE '%" + txtPractice_name.Text + "%'";
            DataSet ds = practiceado.SelectPractice(sql);
            this.DgvPractice.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectPracticeTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from practiceCourse where 开课院系 = '" + txtPractice_Depart.Text + "'";
            DataSet ds = practiceado.SelectPractice(sql);
            this.DgvPractice.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeletePractice_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvPractice.Columns[0].HeaderText;
                string ID = DgvPractice.SelectedRows[0].Cells[0].Value.ToString();
                practiceado.DeletePractice(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = practiceado.GetPractice();
            this.DgvPractice.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdatePractice_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvPractice.SelectedRows[0].Cells[0].Value.ToString();
                String course_id = DgvPractice.SelectedRows[0].Cells[1].Value.ToString();
                String course_name = DgvPractice.SelectedRows[0].Cells[2].Value.ToString();
                String open_dep = DgvPractice.SelectedRows[0].Cells[3].Value.ToString();
                String t_id = DgvPractice.SelectedRows[0].Cells[4].Value.ToString();
                String teach_name = DgvPractice.SelectedRows[0].Cells[5].Value.ToString();
                String rank = DgvPractice.SelectedRows[0].Cells[6].Value.ToString();
                String prac_point = DgvPractice.SelectedRows[0].Cells[7].Value.ToString();
                String term = DgvPractice.SelectedRows[0].Cells[8].Value.ToString();
                PracticeUpdate practiceupdate = new PracticeUpdate(id, course_id, course_name, open_dep, t_id, teach_name, rank, prac_point, term);
                practiceupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertPractice_Click(object sender, EventArgs e)
        {
            PracticeInsert practiceinsert = new PracticeInsert();
            practiceinsert.Show();
        }

        private void btnRefreshPractice_Click(object sender, EventArgs e)
        {
            String sql = "delete from practiceCourse";
            dbcommon.ExcuteUpdateTable(sql);
        }

        private void btnCalculatePractice_Click(object sender, EventArgs e)
        {
            btnCalculatePractice.Text = "核算中";
            btnCalculateTheory.Enabled = false;
            Thread threadPractice = new Thread(new ThreadStart(practiceCal));
            threadPractice.Start();
            threadPractice.IsBackground = true;
        }
        #endregion
        #region 实验工作量
        private void btnUpdate_Experiment_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpExperiment;
            DataSet ds = experimentado.GetExperiment();
            this.DgvExperiment.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvExperiment.Columns["ID"].Visible = false;
//             String sql = "delete from experiment";
//             dbcommon.ExcuteUpdateTable(sql);
        }

        private void btnSelectExperimentOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from experiment where 教师名 LIKE '%" + txtExperiment_name.Text + "%'";
            DataSet ds = experimentado.SelectExperiment(sql);
            this.DgvExperiment.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnSelectExperimentTwo_Click(object sender, EventArgs e)
        {
            String sql = "select * from experiment where 开课院系 = '" + txtExperiment_Depart.Text + "'";
            DataSet ds = experimentado.SelectExperiment(sql);
            this.DgvExperiment.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteExperiment_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvExperiment.Columns[0].HeaderText;
                string ID = DgvExperiment.SelectedRows[0].Cells[0].Value.ToString();
                experimentado.DeleteExperiment(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = experimentado.GetExperiment();
            this.DgvExperiment.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateExperiment_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvExperiment.SelectedRows[0].Cells[0].Value.ToString();
                String t_id = DgvExperiment.SelectedRows[0].Cells[1].Value.ToString();
                String t_name = DgvExperiment.SelectedRows[0].Cells[2].Value.ToString();
                String rank = DgvExperiment.SelectedRows[0].Cells[3].Value.ToString();
                String exp_ori = DgvExperiment.SelectedRows[0].Cells[4].Value.ToString();
                String exp_point = DgvExperiment.SelectedRows[0].Cells[5].Value.ToString();
                String depart_name = DgvExperiment.SelectedRows[0].Cells[6].Value.ToString();
                String term = DgvExperiment.SelectedRows[0].Cells[7].Value.ToString();
                ExperimentUpdate experimentupdate = new ExperimentUpdate(id, t_id, t_name, rank, exp_ori, exp_point, depart_name, term);
                experimentupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertExperiment_Click(object sender, EventArgs e)
        {
            ExperimentInsert experimentinsert = new ExperimentInsert();
            experimentinsert.Show();
        }

        private void btnRefreshExperiment_Click(object sender, EventArgs e)
        {
            DataSet ds = experimentado.GetExperiment();
            this.DgvExperiment.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 研究生工作量
        private void btnUpdate_Master_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpMaster;
            DataSet ds = masterado.GetMaster();
            this.DgvMaster.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvMaster.Columns["ID"].Visible = false;
//             String sql = "delete from master";
//             dbcommon.ExcuteUpdateTable(sql);
        }

        private void btnSelectMasterOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from master where 主讲教师姓名 LIKE '%" + txtMaster_name.Text + "%'";
            DataSet ds = masterado.SelectMaster(sql);
            this.DgvMaster.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvMaster.Columns[0].HeaderText;
                string ID = DgvMaster.SelectedRows[0].Cells[0].Value.ToString();
                masterado.DeleteMaster(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = masterado.GetMaster();
            this.DgvMaster.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateMaster_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvMaster.SelectedRows[0].Cells[0].Value.ToString();
                String t_id = DgvMaster.SelectedRows[0].Cells[1].Value.ToString();
                String t_name = DgvMaster.SelectedRows[0].Cells[2].Value.ToString();
                String mas_hour = DgvMaster.SelectedRows[0].Cells[3].Value.ToString();
                String mas_point = DgvMaster.SelectedRows[0].Cells[4].Value.ToString();
                String tut_point = DgvMaster.SelectedRows[0].Cells[5].Value.ToString();
                String goal_point = DgvMaster.SelectedRows[0].Cells[6].Value.ToString();
                String sum = DgvMaster.SelectedRows[0].Cells[7].Value.ToString();
                String is_tutor = DgvMaster.SelectedRows[0].Cells[8].Value.ToString();
                String term = DgvMaster.SelectedRows[0].Cells[9].Value.ToString();
                MasterUpdate masterupdate = new MasterUpdate(id, t_id, t_name, mas_hour, mas_point, tut_point, goal_point, sum, is_tutor, term);
                masterupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertMaster_Click(object sender, EventArgs e)
        {
            MasterInsert masterinsert = new MasterInsert();
            masterinsert.Show();
        }

        private void btnRefreshMaster_Click(object sender, EventArgs e)
        {
            DataSet ds = masterado.GetMaster();
            this.DgvMaster.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion
        #region 系主任津贴统计
        private void btnUpdate_Dean_allowance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpDean_allowance;
            DataSet ds = dean_allowanceado.GetDean_allowance();
            this.DgvDean_allowance.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvDean_allowance.Columns["ID"].Visible = false;
        }

        private void btnSelectDeanOne_Click(object sender, EventArgs e)
        {
            String sql = "select * from dean_allowance where 教师名 LIKE '%" + txtDean_name.Text + "%'";
            DataSet ds = dean_allowanceado.SelectDean_allowance(sql);
            this.DgvDean_allowance.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteDean_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvDean_allowance.Columns[0].HeaderText;
                string ID = DgvDean_allowance.SelectedRows[0].Cells[0].Value.ToString();
                dean_allowanceado.DeleteDean_allowance(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = dean_allowanceado.GetDean_allowance();
            this.DgvDean_allowance.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateDean_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvDean_allowance.SelectedRows[0].Cells[0].Value.ToString();
                String t_id = DgvDean_allowance.SelectedRows[0].Cells[1].Value.ToString();
                String t_name = DgvDean_allowance.SelectedRows[0].Cells[2].Value.ToString();
                String exp_allow_point = DgvDean_allowance.SelectedRows[0].Cells[3].Value.ToString();
                String statement = DgvDean_allowance.SelectedRows[0].Cells[4].Value.ToString();
                String term = DgvDean_allowance.SelectedRows[0].Cells[5].Value.ToString();
                DeanUpdate deanupdate = new DeanUpdate(id, t_id, t_name, exp_allow_point, statement, term);
                deanupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertDean_Click(object sender, EventArgs e)
        {
            DeanInsert deaninsert = new DeanInsert();
            deaninsert.Show();
        }

        private void btnRefreshDean_Click(object sender, EventArgs e)
        {
            DataSet ds = dean_allowanceado.GetDean_allowance();
            this.DgvDean_allowance.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }
        #endregion 
        #region 汇总工作量
        private void btnUpdate_Result_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpResult;
            DataSet ds = resultado.GetResult();
            this.DgvResult.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
            DgvResult.Columns["ID"].Visible = false;
        }

        private void btnSelectResultOne_Click(object sender, EventArgs e)
        {
            String sql = "select ID,教师号,姓名,职称,硕导,学院,系,身份证号,总计,学期 from result where 姓名 LIKE '%" + txtResult_name.Text + "%'";
            DataSet ds = resultado.SelectResult(sql);
            this.DgvResult.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            try
            {
                string Key = DgvResult.Columns[0].HeaderText;
                string ID = DgvResult.SelectedRows[0].Cells[0].Value.ToString();
                resultado.DeleteResult(Key, ID);
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要删除的行！", "注意");
            }

            DataSet ds = resultado.GetResult();
            this.DgvResult.DataSource =//设置数据源
                ds.Tables[0].DefaultView;
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvResult.SelectedRows[0].Cells[0].Value.ToString();
                String t_id = DgvResult.SelectedRows[0].Cells[1].Value.ToString();
                String t_name = DgvResult.SelectedRows[0].Cells[2].Value.ToString();
                String rank = DgvResult.SelectedRows[0].Cells[3].Value.ToString();
                String is_tutor = DgvResult.SelectedRows[0].Cells[4].Value.ToString();
                String school = DgvResult.SelectedRows[0].Cells[5].Value.ToString();
                String depart = DgvResult.SelectedRows[0].Cells[6].Value.ToString();
                String card_id = DgvResult.SelectedRows[0].Cells[7].Value.ToString();
                String point_sum = DgvResult.SelectedRows[0].Cells[8].Value.ToString();
                String term = DgvResult.SelectedRows[0].Cells[9].Value.ToString();
                ResultUpdate resultupdate = new ResultUpdate(id, t_id, t_name, rank, is_tutor, school, depart, card_id, point_sum, term);
                resultupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }

        private void btnInsertResult_Click(object sender, EventArgs e)
        {
            ResultInsert resultinsert = new ResultInsert();
            resultinsert.Show();
        }

        private void btnRefreshResult_Click(object sender, EventArgs e)
        {
            String sql = "delete from result";
            dbcommon.ExcuteUpdateTable(sql);
        }

        private void btnCalculateResult_Click(object sender, EventArgs e)
        {
            btnCalculateResult.Text = "核算中";
            btnCalculateTheory.Enabled = false;
            Thread threadResult = new Thread(new ThreadStart(resultCal));
            threadResult.Start();
            threadResult.IsBackground = true;
        }

        private void btnSaveHistory_Click(object sender, EventArgs e)
        {
            String trem = null;
            String nowTerm = null;
            if (DateTime.Now.Month == 3 || DateTime.Now.Month == 4 || DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7)
            {
                trem = "秋";
                nowTerm = DateTime.Now.Year + trem;
            }
            else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12 || DateTime.Now.Month == 1)
            {
                trem = "春";
                nowTerm = DateTime.Now.Year + trem;
            }

            try
            {
                string ConStr2 = string.Format(//设置数据库连接字符串
@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\教务工资结算.mdb",
Application.StartupPath);
                OleDbConnection oleCon2 = new OleDbConnection(ConStr2);//创建数据库连接对象
                oleCon2.Open();
                OleDbDataAdapter oleDap2 = new OleDbDataAdapter(//创建数据适配器对象
                    "select * from result", oleCon2);
                DataSet ds = new DataSet();//创建数据集
                oleDap2.Fill(ds, "result");//填充数据集

                String ConStr1 = string.Format(//设置数据库连接字符串
    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\历史.mdb");
                OleDbConnection oleCon1 = new OleDbConnection(ConStr1);//创建数据库连接对象
                oleCon1.Open();                

//                 //删除表
//                 String dropSql = "drop table " + nowTerm + "";
//                 OleDbCommand dropcmd = new OleDbCommand();
//                 dropcmd.Connection = oleCon1;
//                 dropcmd.CommandText = dropSql;
//                 dropcmd.CommandType = CommandType.Text;
//                 dropcmd.ExecuteNonQuery();

                //创建表
                OleDbCommand com1 = new OleDbCommand("create table " + nowTerm + "(ID counter(1,1),教师号 varchar(255),姓名 varchar(255),职称 varchar(255),硕导 varchar(255),学院 varchar(255),系 varchar(255),身份证号 varchar(255),研究生原始 varchar(255),研究生折合 varchar(255),研究生指导 varchar(255),研究生目标 varchar(255),成人合计 varchar(255),理论原始 varchar(255),理论折合 varchar(255),实践原始 varchar(255),实践折合 varchar(255),教务津贴 varchar(255),实验原始 varchar(255),实验折合 varchar(255),实验津贴 varchar(255),总计 varchar(255),学期 varchar(255),备注 varchar(255))", oleCon1);
                com1.ExecuteNonQuery();

                //导入
                OleDbConnection oleCon = new OleDbConnection(ConStr1);//创建数据库连接对象
                oleCon.Open();
                OleDbDataAdapter oleDap1 = new OleDbDataAdapter(//创建数据适配器对象
                    "select * from " + nowTerm + "", oleCon1);
                OleDbCommandBuilder cmdbld = new OleDbCommandBuilder(oleDap1);
                cmdbld.SetAllValues = true;
                oleDap1.InsertCommand = cmdbld.GetInsertCommand();
                ds.Tables[0].BeginLoadData();
                int rowcount = ds.Tables[0].Rows.Count;
                for (int n = 0; n < rowcount; n++)
                {
                    ds.Tables[0].Rows[n].SetAdded();
                }
                ds.Tables[0].EndLoadData();
                oleDap1.Update(ds, ds.Tables[0].TableName);
                oleCon1.Close();
                oleCon2.Close();
                oleCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("保存成功！");
        }
        #endregion
        #region 历史工作量
        private void btnUpdate_History_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpHistory;
        }
        private void btnSelectHistory_Click(object sender, EventArgs e)
        {
            try
            {
                String term = cbox_YearH.Text + cbox_TermH.Text;

                String ConStr = string.Format(//设置数据库连接字符串
@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\历史.mdb");
                OleDbConnection oleCon = new OleDbConnection(ConStr);//创建数据库连接对象
                OleDbDataAdapter oleDap = new OleDbDataAdapter(//创建数据适配器对象
                    "select ID,教师号,姓名,职称,硕导,学院,系,身份证号,总计,学期 from " + term + "", oleCon);
                DataSet ds = new DataSet();//创建数据集
                oleDap.Fill(ds, "" + term + "");//填充数据集
                this.DgvHistory.DataSource =//设置数据源
        ds.Tables[0].DefaultView;
                DgvHistory.Columns["ID"].Visible = false;
                oleCon.Close();//关闭数据库连接
                oleCon.Dispose();//释放连接资源
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateHistory_Click(object sender, EventArgs e)
        {
            try
            {
                String id = DgvHistory.SelectedRows[0].Cells[0].Value.ToString();
                String t_id = DgvHistory.SelectedRows[0].Cells[1].Value.ToString();
                String t_name = DgvHistory.SelectedRows[0].Cells[2].Value.ToString();
                String rank = DgvHistory.SelectedRows[0].Cells[3].Value.ToString();
                String is_tutor = DgvHistory.SelectedRows[0].Cells[4].Value.ToString();
                String school = DgvHistory.SelectedRows[0].Cells[5].Value.ToString();
                String depart = DgvHistory.SelectedRows[0].Cells[6].Value.ToString();
                String card_id = DgvHistory.SelectedRows[0].Cells[7].Value.ToString();
                String point_sum = DgvHistory.SelectedRows[0].Cells[8].Value.ToString();
                String term = DgvHistory.SelectedRows[0].Cells[9].Value.ToString();
                HistoryUpdate historyupdate = new HistoryUpdate(id, t_id, t_name, rank, is_tutor, school, depart, card_id, point_sum, term);
                historyupdate.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要修改的行！", "注意");
            }
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                String term = cbox_YearH.Text + cbox_TermH.Text;
                String t_name = DgvHistory.SelectedRows[0].Cells[2].Value.ToString();
                frmDetail frmdetail = new frmDetail(t_name, term);
                frmdetail.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("注意：请选择要查看的行！", "注意");
            }
        }
        #endregion


        #region 理论工作量核算
        /* ************************************
        * void theoryCal()
        * 功能	    理论工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal()
        {
            //职称线程
            Thread threadTheory_rank = new Thread(new ThreadStart(theoryCal_rank));
            threadTheory_rank.Start();
            threadTheory_rank.IsBackground = true;

            //重复课线程
            Thread threadTheory_course = new Thread(new ThreadStart(theoryCal_course));
            threadTheory_course.Start();
            threadTheory_course.IsBackground = true;

            //合班线程
            Thread threadTheory_number = new Thread(new ThreadStart(theoryCal_number));
            threadTheory_number.Start();
            threadTheory_number.IsBackground = true;
            
            String sql = "select * from theoryCourse";
            DataSet ds = theoryado.SelectTheory(sql);
            int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            
            #region 难度系数
            #region 三表班级系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_S1 = "select 合班 from theoryCourse where ID = " + count + "";
                    DataSet ds_S1 = theoryado.SelectTheory(sql_S1);
                    if (ds_S1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String teach_class = ds_S1.Tables[0].Rows[0][0].ToString();
                    String[] str_class = Regex.Split(teach_class, @"\s+");

                    String sql_S2 = "select 班级名 from class";
                    DataSet ds_S2 = classado.SelectClass(sql_S2);
                    String school = ds_S2.Tables[0].Rows[0][0].ToString();

                    int temp = 0;

                    for (int i = 0; i < str_class.Length; i++)
                    {
                        for (int j = 0; j < ds_S2.Tables[0].Rows.Count; j++)
                        {
                            if (ds_S2.Tables[0].Rows[j][0].ToString() == str_class[i])
                            {
                                temp++;
                            }
                        }
                    }
                    if (temp == str_class.Length)
                    {
                        double spe_weight = 0.15;
                        String sql_S3 = "update theoryCourse set 三表班级系数 = '" + spe_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_S3);
                    }
                    else if (temp != 0)
                    {
                        double spe_weight = 0.05;
                        String sql_S3 = "update theoryCourse set 三表班级系数 = '" + spe_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_S3);
                    }
                    else if (temp == 0)
                    {
                        double spe_weight = 0;
                        String sql_S3 = "update theoryCourse set 三表班级系数 = '" + spe_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_S3);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "三表班级系数");
            }
            #endregion
            #region 专业课系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_D1 = "select 课程号 from theoryCourse where ID = " + count + "";
                    DataSet ds_D1 = theoryado.SelectTheory(sql_D1);
                    if (ds_D1.Tables[0].Rows[0][0].ToString() == "" || ds_D1.Tables[0].Rows[0][0].ToString().Length < 5)
                    {
                        continue;
                    }
                    String course_id = ds_D1.Tables[0].Rows[0][0].ToString();
                    String c_f = course_id.Substring(4, 1);
                    if (c_f == "D" || c_f == "E")
                    {
                        double desc_weight = 0.2;
                        String sql_D2 = "update theoryCourse set 专业课系数 = '" + desc_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_D2);
                    }
                    else
                    {
                        double desc_weight = 0;
                        String sql_D2 = "update theoryCourse set 专业课系数 = '" + desc_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_D2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "专业课系数");
            }
            #endregion
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_Q1 = "select 专业课系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_Q1 = theoryado.SelectTheory(sql_Q1);
                    if (ds_Q1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String desc_weight = ds_Q1.Tables[0].Rows[0][0].ToString().Trim();
                    String sql_Q2 = "select 三表班级系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_Q2 = theoryado.SelectTheory(sql_Q2);
                    if (ds_Q2.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String spe_weight = ds_Q2.Tables[0].Rows[0][0].ToString().Trim();

                    double qua_weight = 1 + Convert.ToDouble(desc_weight) + Convert.ToDouble(spe_weight);

                    String sql_Q3 = "update theoryCourse set 难度系数 = '" + qua_weight + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_Q3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "难度系数");
            }
            #endregion
            #region 折合教分
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //讲课学时
                    String sql_C1 = "select 讲课学时 from theoryCourse where ID = " + count + "";
                    DataSet ds_C1 = theoryado.SelectTheory(sql_C1);
                    if (ds_C1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String teach_hour = ds_C1.Tables[0].Rows[0][0].ToString().Trim();

                    //合班系数
                    String sql_C2 = "select 合班系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_C2 = theoryado.SelectTheory(sql_C2);
                    if (ds_C2.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String number_weight = ds_C2.Tables[0].Rows[0][0].ToString().Trim();

                    //重复课系数
                    String sql_C3 = "select 重复课系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_C3 = theoryado.SelectTheory(sql_C3);
                    if (ds_C3.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String course_weight = ds_C3.Tables[0].Rows[0][0].ToString().Trim();

                    //职称系数
                    String sql_C4 = "select 职称系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_C4 = theoryado.SelectTheory(sql_C4);
                    if (ds_C4.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String rank_weight = ds_C4.Tables[0].Rows[0][0].ToString().Trim();

                    //难度系数
                    String sql_C5 = "select 难度系数 from theoryCourse where ID = " + count + "";
                    DataSet ds_C5 = theoryado.SelectTheory(sql_C5);
                    if (ds_C5.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String qua_weight = ds_C5.Tables[0].Rows[0][0].ToString().Trim();

                    //计算公式
                    String cal_weight = teach_hour + "*" + number_weight + "*" + course_weight + "*" + rank_weight + "*" + qua_weight;
                    String sql_C6 = "update theoryCourse set 计算公式 = '" + cal_weight + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_C6);

                    //折合教分
                    double teach_point = Convert.ToDouble(teach_hour) * Convert.ToDouble(number_weight) * Convert.ToDouble(course_weight) * Convert.ToDouble(rank_weight) * Convert.ToDouble(qua_weight);
                    String sql_C7 = "update theoryCourse set 折合教分 = '" + teach_point + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_C7);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "折合教分");
            }
            #endregion
            #region 安全讲座类折合教分
            try
            {
                //安全讲座类折合教分            
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //开课院系
                    String sql_1 = "select 开课院系 from theoryCourse where ID = " + count + "";
                    DataSet ds_1 = theoryado.SelectTheory(sql_1);
                    if (ds_1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String open_dep = ds_1.Tables[0].Rows[0][0].ToString().Trim();

                    //讲课学时
                    String sql_2 = "select 讲课学时 from theoryCourse where ID = " + count + "";
                    DataSet ds_2 = theoryado.SelectTheory(sql_2);
                    if (ds_2.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String teach_hour = ds_2.Tables[0].Rows[0][0].ToString().Trim();

                    double hour = (Convert.ToDouble(teach_hour) / 2);

                    if (open_dep == "保卫处办公室")
                    {
                        //计算公式
                        String cal_weight = hour + "100元/2学时";
                        String sql_3 = "update theoryCourse set 计算公式 = '" + cal_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_3);

                        //折合教分
                        double teach_point = 100 * hour;
                        String sql_4 = "update theoryCourse set 折合教分 = '" + teach_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_4);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "安全讲座类折合教分");
            }
            #endregion
            #region 学期
            if (DateTime.Now.Month == 3 || DateTime.Now.Month == 4 || DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7)
            {
                String trem = "秋";
                String nowTerm = DateTime.Now.Year + trem;
                String sql_term = "update theoryCourse set 学期 = '" + nowTerm + "'";
                dbcommon.ExcuteUpdateTable(sql_term);
            }
            else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12 || DateTime.Now.Month == 1)
            {
                String trem = "春";
                String nowTerm = DateTime.Now.Year + trem;
                String sql_term = "update theoryCourse set 学期 = '" + nowTerm + "'";
                dbcommon.ExcuteUpdateTable(sql_term);
            }
            #endregion

            TheoryBool = true;

            MessageBox.Show("核算完成！", "理论工作量");
            btnCalculateTheory.Text = "核算";
            btnCalculateTheory.Enabled = true;
        }
        /* ************************************
        * void theoryCal_course()
        * 功能	    理论工作量 重复课系数核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal_course()
        {
            String sql = "select * from theoryCourse";
            DataSet ds = theoryado.SelectTheory(sql);
            int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            #region 重复课系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_C1 = "select 课程号,主讲教师姓名 from theoryCourse where ID = " + count + "";
                    DataSet ds_C1 = theoryado.SelectTheory(sql_C1);
                    if (ds_C1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String course_id = ds_C1.Tables[0].Rows[0][0].ToString();
                    String t_name = ds_C1.Tables[0].Rows[0][1].ToString();
                    String sql_C2 = "select * from theoryCourse where 课程号 = '" + course_id + "' and 主讲教师姓名 = '" + t_name + "'";
                    DataSet ds_C2 = theoryado.SelectTheory(sql_C2);
                    for (int row = 0; row < ds_C2.Tables[0].Rows.Count; row++)
                    {
                        int cs_id1 = row + 1;
                        String id = ds_C2.Tables[0].Rows[row][0].ToString();
                        String sql_C3 = "update theoryCourse set 课序号 = '" + cs_id1 + "' where ID = " + id + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                }

                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_C4 = "select 课序号 from theoryCourse where ID = " + count + "";
                    DataSet ds_C4 = theoryado.SelectTheory(sql_C4);
                    if (ds_C4.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    int cs_id2 = Convert.ToInt32(ds_C4.Tables[0].Rows[0][0].ToString());

                    //前两次授课
                    if (cs_id2 == 1 || cs_id2 == 2)
                    {
                        double course_weight = 1;
                        String sql_C5 = "update theoryCourse set 重复课系数 = '" + course_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C5);
                    }
                    else if (cs_id2 == 3)
                    {
                        double course_weight = 0.85;
                        String sql_C5 = "update theoryCourse set 重复课系数 = '" + course_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C5);
                    }
                    else if (cs_id2 == 4)
                    {
                        double course_weight = 0.7;
                        String sql_C5 = "update theoryCourse set 重复课系数 = '" + course_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C5);
                    }
                    else
                    {
                        double course_weight = 0;
                        String sql_C5 = "update theoryCourse set 重复课系数 = '" + course_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C5);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "重复课系数");
            }
            #endregion
        }
        /* ************************************
        * void theoryCal_rank()
        * 功能	    理论工作量 职称系数核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal_rank()
        {
            String sql = "select * from theoryCourse";
            DataSet ds = theoryado.SelectTheory(sql);
            int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            #region 职称系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //获取主讲教师职称
                    String sql_Z1 = "select 主讲教师职称 from theoryCourse where ID = " + count + "";
                    DataSet ds_Z1 = theoryado.SelectTheory(sql_Z1);
                    string rank = ds_Z1.Tables[0].Rows[0][0].ToString();
                    //获取职称系数
                    String sql_Z2 = "select 职称系数 from rank where 职称 = '" + rank + "'";
                    DataSet ds_Z2 = rankado.SelectRank(sql_Z2);
                    if (ds_Z2.Tables[0].Rows.Count == 0)
                    {
                        continue;
                    }
                    string rank_weight = ds_Z2.Tables[0].Rows[0][0].ToString();
                    //将获取的职称系数插入到theoryCourse表中
                    String sql_Z3 = "update theoryCourse set 职称系数 = '" + rank_weight + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_Z3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "职称系数");
            }
            #endregion
        }
        /* ************************************
        * void theoryCal_number()
        * 功能	    理论工作量 合班系数核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void theoryCal_number()
        {
            String sql = "select * from theoryCourse";
            DataSet ds = theoryado.SelectTheory(sql);
            int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            #region 合班系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    String sql_K1 = "select 选课人数 from theoryCourse where ID = " + count + "";
                    DataSet ds_K1 = theoryado.SelectTheory(sql_K1);

                    //选课人数为空
                    if (ds_K1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    int course_numInt = Convert.ToInt32(ds_K1.Tables[0].Rows[0][0].ToString());

                    //选课人数小于20
                    if (course_numInt < 30)
                    {
                        double number_weight = 0.9;
                        String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_K2);
                    }
                    //选课人数大于30小于等于90
                    else if (course_numInt > 30 && course_numInt <= 90)
                    {
                        int class_numZ = course_numInt / 30;    //班数
                        int class_numY = course_numInt % 30;    //余人数    
                        if (class_numZ == 1)
                        {
                            double number_weightZ = 1;
                            double number_weightY = 0.003 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                            dbcommon.ExcuteUpdateTable(sql_K2);
                        }
                        else if (class_numZ == 2)
                        {
                            double number_weightZ = 1.105;
                            double number_weightY = 0.003 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                            dbcommon.ExcuteUpdateTable(sql_K2);
                        }
                        else if (class_numZ == 3)
                        {
                            double number_weightZ = 1.21;
                            double number_weightY = 0.003 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                            dbcommon.ExcuteUpdateTable(sql_K2);
                        }
                    }
                    //选课人数大于90小于等于120
                    else if (course_numInt > 90 && course_numInt <= 120)
                    {
                        int class_numZ = course_numInt / 30;    //班数
                        int class_numY = course_numInt % 30;    //余人数  
                        if (class_numZ == 3)
                        {
                            double number_weightZ = 1.21;
                            double number_weightY = 0.002 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                            dbcommon.ExcuteUpdateTable(sql_K2);
                        }
                        else if (class_numZ == 4)
                        {
                            double number_weightZ = 1.28;
                            double number_weightY = 0.002 * class_numY;
                            double number_weight = number_weightZ + number_weightY;
                            String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                            dbcommon.ExcuteUpdateTable(sql_K2);
                        }
                    }
                    //选课人数大于120
                    else if (course_numInt > 120)
                    {
                        double number_weight = 1.28;
                        String sql_K2 = "update theoryCourse set 合班系数 = '" + number_weight + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_K2);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "合班系数");
            }
            #endregion            
        }
        
        #endregion
        #region 实践工作量核算
        /* ************************************
        * void practiceCal()
        * 功能	    实践工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void practiceCal()
        {
            String sql = "select * from practiceCourse";
            DataSet ds = practiceado.SelectPractice(sql);
            int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            #region 职称
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //获取主讲教师姓名
                    String sql_name = "select 主讲教师姓名 from practiceCourse where ID = " + count + "";
                    DataSet ds_name = practiceado.SelectPractice(sql_name);
                    string t_name = ds_name.Tables[0].Rows[0][0].ToString();
                    //获取职称
                    String sql_rank = "select 职称 from teacher where 教师名 = '" + t_name + "'";
                    DataSet ds_rank = rankado.SelectRank(sql_rank);
                    if (ds_rank.Tables[0].Rows.Count == 0)
                    {
                        continue;
                    }
                    string rank = ds_rank.Tables[0].Rows[0][0].ToString();
                    //将获取的职称插入到practiceCourse表中
                    String sql_Z = "update practiceCourse set 主讲教师职称 = '" + rank + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_Z);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "职称");
            }
            #endregion
            #region 职称系数
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //获取主讲教师职称
                    String sql_Z1 = "select 主讲教师职称 from practiceCourse where ID = " + count + "";
                    DataSet ds_Z1 = practiceado.SelectPractice(sql_Z1);
                    string rank = ds_Z1.Tables[0].Rows[0][0].ToString();
                    //获取职称系数
                    String sql_Z2 = "select 职称系数 from rank where 职称 = '" + rank + "'";
                    DataSet ds_Z2 = rankado.SelectRank(sql_Z2);
                    if (ds_Z2.Tables[0].Rows.Count == 0)
                    {
                        continue;
                    }
                    string rank_weight = ds_Z2.Tables[0].Rows[0][0].ToString();
                    //将获取的职称系数插入到practiceCourse表中
                    String sql_Z3 = "update practiceCourse set 职称系数 = '" + rank_weight + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_Z3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "职称系数");
            }
            #endregion
            #region 折合教分
            try
            {
                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //职称系数
                    String sql_1 = "select 职称系数 from practiceCourse where ID = " + count + "";
                    DataSet ds_1 = practiceado.SelectPractice(sql_1);
                    if (ds_1.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String rank_weight = ds_1.Tables[0].Rows[0][0].ToString().Trim();

                    //持续时间
                    String sql_2 = "select 持续时间 from practiceCourse where ID = " + count + "";
                    DataSet ds_2 = practiceado.SelectPractice(sql_2);
                    if (ds_2.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String prac_week = ds_2.Tables[0].Rows[0][0].ToString().Trim();

                    //选课人数
                    String sql_3 = "select 选课人数 from practiceCourse where ID = " + count + "";
                    DataSet ds_3 = practiceado.SelectPractice(sql_3);
                    if (ds_3.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String prac_num = ds_3.Tables[0].Rows[0][0].ToString().Trim();

                    //实习类型
                    String sql_5 = "select 实习类型 from practiceCourse where ID = " + count + "";
                    DataSet ds_5 = practiceado.SelectPractice(sql_5);
                    if (ds_5.Tables[0].Rows[0][0].ToString() == "")
                    {
                        continue;
                    }
                    String prac_location = ds_5.Tables[0].Rows[0][0].ToString().Trim();

                    #region 金工实习
                    //计算金工实习折合教分
                    if (prac_location == "金工实习")
                    {
                        String cal_formula = 1.7 + "*" + prac_num + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 1.7 * Convert.ToDouble(prac_num) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }

                    #endregion
                    #region 生产实习
                    //计算生产实习折合教分
                    else if (prac_location == "市外生产实习")
                    {
                        String cal_formula = 0.34 + "*" + prac_num + "*" + prac_week + "*" + rank_weight + "*" + 1.2;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.34 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight) * 1.2;
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    else if (prac_location == "市内生产实习")
                    {
                        String cal_formula = 0.34 + "*" + prac_num + "*" + prac_week + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.34 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    #endregion
                    #region 毕业设计
                    //计算毕业设计折合教分
                    else if (prac_location == "毕业设计")
                    {
                        String cal_formula = 0.56 + "*" + prac_num + "*" + prac_week + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.56 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    #endregion
                    #region 课程设计
                    else if (prac_location == "课程设计")
                    {
                        String cal_formula = 0.27 + "*" + prac_num + "*" + prac_week + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.27 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    #endregion
                    #region 综合性设计与训练
                    else if (prac_location == "综合性设计与训练")
                    {
                        String cal_formula = 0.33 + "*" + prac_num + "*" + prac_week + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.33 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    #endregion
                    #region 分散性设计与训练
                    else if (prac_location == "分散性实习与实践")
                    {
                        String cal_formula = 0.15 + "*" + prac_num + "*" + prac_week + "*" + rank_weight;
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + cal_formula + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        double prac_point = 0.15 * Convert.ToDouble(prac_num) * Convert.ToDouble(prac_week) * Convert.ToDouble(rank_weight);
                        String sql_C3 = "update practiceCourse set 折合教分 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }
                    #endregion
                    else
                    {
                        String sql_C2 = "update practiceCourse set 计算公式 = '" + 0 +"' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C2);

                        String sql_C3 = "update practiceCourse set 折合教分 = '" + 0 + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_C3);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "折合教分");
            }
            #endregion
            #region 学期
            if (DateTime.Now.Month == 3 || DateTime.Now.Month == 4 || DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7)
            {
                String trem = "秋";
                String nowTerm = DateTime.Now.Year + trem;
                String sql_term = "update practiceCourse set 学期 = '" + nowTerm + "'";
                dbcommon.ExcuteUpdateTable(sql_term);
            }
            else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12 || DateTime.Now.Month == 1)
            {
                String trem = "春";
                String nowTerm = DateTime.Now.Year + trem;
                String sql_term = "update practiceCourse set 学期 = '" + nowTerm + "'";
                dbcommon.ExcuteUpdateTable(sql_term);
            }
            #endregion

            PracticeBool = true;

            MessageBox.Show("核算完成！", "实践工作量");
            btnCalculatePractice.Text = "核算";
            btnCalculateTheory.Enabled = true;
        }
        #endregion
        #region 汇总工作量核算
        /* ************************************
        * void resultCal()
        * 功能	    汇总工作量核算
        * 参数	    无参数
        * 返回值	无返回值
        **************************************/
        public void resultCal()
        {
            try
            {
                String sql = "select ID,教师号,姓名,职称,硕导,学院,系,身份证号,总计,学期 from result";
                DataSet ds = resultado.SelectResult(sql);
                int H_Max = ds.Tables[0].Rows.Count + Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                for (int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); count < H_Max; count++)
                {
                    //取教师名
                    String sql_name = "select 姓名 from result where ID = " + count + "";
                    DataSet ds_name = resultado.SelectResult(sql_name);
                    String t_name = ds_name.Tables[0].Rows[0][0].ToString();

                    #region 研究生
                    try
                    {
                        String sql_master = "select 研究生学时,研究生教分,指导教分,目标教分 from master where 主讲教师姓名 = '" + t_name + "'";
                        DataSet ds_master = masterado.SelectMaster(sql_master);

                        double mas_hour = 0;
                        double mas_point = 0;
                        double tut_point = 0;
                        double goal_point = 0;
                        for (int i = 0; i < ds_master.Tables[0].Rows.Count; i++)
                        {
                            mas_hour += Convert.ToDouble(ds_master.Tables[0].Rows[i][0]);   //研究生学时
                            mas_point += Convert.ToDouble(ds_master.Tables[0].Rows[i][1]);  //研究生教分
                            tut_point += Convert.ToDouble(ds_master.Tables[0].Rows[i][2]);  //指导教分 
                            goal_point += Convert.ToDouble(ds_master.Tables[0].Rows[i][3]); //目标教分
                        }
                        String sql_R1 = "update result set 研究生原始 = '" + mas_hour + "',研究生折合 = '" + mas_point + "',研究生指导 = '" + tut_point + "',研究生目标 = '" + goal_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "研究生");
                    }
                    #endregion
                    #region 成人
                    try
                    {
                        String sql_adult = "select 教分 from adult where 教师名 = '" + t_name + "'";
                        DataSet ds_adult = adultado.SelectAdult(sql_adult);

                        double adult_point = 0;
                        for (int i = 0; i < ds_adult.Tables[0].Rows.Count; i++)
                        {
                            adult_point += Convert.ToDouble(ds_adult.Tables[0].Rows[i][0]);
                        }
                        String sql_R2 = "update result set 成人合计 = '" + adult_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "成人");
                    }
                    #endregion
                    #region 理论
                    try
                    {
                        String sql_theory = "select 讲课学时,折合教分 from theoryCourse where 主讲教师姓名 = '" + t_name + "'";
                        DataSet ds_theory = theoryado.SelectTheory(sql_theory);

                        double teach_hour = 0;
                        double teach_point = 0;
                        for (int i = 0; i < ds_theory.Tables[0].Rows.Count; i++)
                        {
                            teach_hour += Convert.ToDouble(ds_theory.Tables[0].Rows[i][0]);
                            teach_point += Convert.ToDouble(ds_theory.Tables[0].Rows[i][1]);
                        }
                        String sql_R3 = "update result set 理论原始 = '" + teach_hour + "',理论折合 = '" + teach_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "理论");
                    }
                    #endregion
                    #region 实践
                    try
                    {
                        String sql_practice = "select 持续时间,折合教分 from practiceCourse where 主讲教师姓名 = '" + t_name + "'";
                        DataSet ds_practice = practiceado.SelectPractice(sql_practice);

                        double prac_week = 0;
                        double prac_point = 0;
                        for (int i = 0; i < ds_practice.Tables[0].Rows.Count; i++)
                        {
                            prac_week += Convert.ToDouble(ds_practice.Tables[0].Rows[i][0]);
                            prac_point += Convert.ToDouble(ds_practice.Tables[0].Rows[i][1]);
                        }
                        String sql_R4 = "update result set 实践原始 = '" + prac_week + "',实践折合 = '" + prac_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R4);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "实践");
                    }
                    #endregion
                    #region 系主任津贴
                    try
                    {
                        String sql_dean = "select 教分 from dean_allowance where 教师名 = '" + t_name + "'";
                        DataSet ds_dean = dean_allowanceado.SelectDean_allowance(sql_dean);

                        double dean_point = 0;
                        for (int i = 0; i < ds_dean.Tables[0].Rows.Count; i++)
                        {
                            dean_point += Convert.ToDouble(ds_dean.Tables[0].Rows[i][0]);
                        }
                        String sql_R5 = "update result set 教务津贴 = '" + dean_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R5);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "系主任津贴");
                    }
                    #endregion
                    #region 实验
                    try
                    {
                        String sql_experiment = "select 实验原始,实验教分 from experiment where 教师名 = '" + t_name + "'";
                        DataSet ds_experiment = experimentado.SelectExperiment(sql_experiment);

                        double exp_ori = 0;
                        double exp_point = 0;
                        for (int i = 0; i < ds_experiment.Tables[0].Rows.Count; i++)
                        {
                            exp_ori += Convert.ToDouble(ds_experiment.Tables[0].Rows[i][0]);
                            exp_point += Convert.ToDouble(ds_experiment.Tables[0].Rows[i][1]);
                        }
                        String sql_R6 = "update result set 实验原始 = '" + exp_ori + "',实验折合 = '" + exp_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R6);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "实验");
                    }
                    #endregion
                    #region 实验津贴
                    try
                    {
                        String sql_exp = "select 教分 from exp_allowance where 教师名 = '" + t_name + "'";
                        DataSet ds_exp = adultado.SelectAdult(sql_exp);

                        double exp_allow_point = 0;
                        for (int i = 0; i < ds_exp.Tables[0].Rows.Count; i++)
                        {
                            exp_allow_point += Convert.ToDouble(ds_exp.Tables[0].Rows[i][0]);
                        }
                        String sql_R7 = "update result set 实验津贴 = '" + exp_allow_point + "' where ID = " + count + "";
                        dbcommon.ExcuteUpdateTable(sql_R7);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "实验津贴");
                    }
                    #endregion
                    #region 总记
                    String sql_sum = "select 研究生折合,研究生指导,研究生目标,成人合计,理论折合,实践折合,教务津贴,实验折合,实验津贴 from result where 姓名 = '" + t_name + "'";
                    DataSet ds_sum = resultado.SelectResult(sql_sum);

                    double point_sum = 0;
                    for (int i = 0; i < ds_sum.Tables[0].Columns.Count; i++)
                    {
                        point_sum += Convert.ToDouble(ds_sum.Tables[0].Rows[0][i]);
                    }
                    String sql_R8 = "update result set 总计 = '" + point_sum + "' where ID = " + count + "";
                    dbcommon.ExcuteUpdateTable(sql_R8);
                    #endregion
                    #region 学期
                    if (DateTime.Now.Month == 3 || DateTime.Now.Month == 4 || DateTime.Now.Month == 5 || DateTime.Now.Month == 6 || DateTime.Now.Month == 7)
                    {
                        String trem = "秋";
                        String nowTerm = DateTime.Now.Year + trem;
                        String sql_term = "update result set 学期 = '" + nowTerm + "'";
                        dbcommon.ExcuteUpdateTable(sql_term);
                    }
                    else if (DateTime.Now.Month == 9 || DateTime.Now.Month == 10 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12 || DateTime.Now.Month == 1)
                    {
                        String trem = "春";
                        String nowTerm = DateTime.Now.Year + trem;
                        String sql_term = "update result set 学期 = '" + nowTerm + "'";
                        dbcommon.ExcuteUpdateTable(sql_term);
                    }
                    #endregion
                }

                ResultBool = true;

                MessageBox.Show("汇总完成！", "汇总工作量");
                btnCalculateResult.Text = "核算";
                btnCalculateTheory.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
