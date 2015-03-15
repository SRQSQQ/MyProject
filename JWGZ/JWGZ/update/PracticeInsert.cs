using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using JWGZ.bl;

namespace JWGZ.update
{
    public partial class PracticeInsert : Form
    {
        PracticeAdo practiceado = new PracticeAdo();
        public static bool GlobalFlag;

        public PracticeInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String course_id = txtCourse_id.Text;
            String course_name = txtCourse_name.Text;
            String open_dep = txtOpen_dep.Text;
            String t_id = txtT_id.Text;
            String teach_name = txtTeach_name.Text;
            String rank = txtRank.Text;
            String rank_weight = txtRank_weight.Text;
            String prac_week = txtPrac_week.Text;
            String prac_num = txtPrac_num.Text;
            String prac_class = txtPrac_class.Text;
            String prac_location = txtPrac_location.Text;
            String cal_formula = txtCal_formula.Text;
            String prac_point = txtPrac_point.Text;
            String term = txtTerm.Text;
            practiceado.InsertPractice(id, course_id, course_name, open_dep, t_id, teach_name, rank, rank_weight, prac_week, prac_num, prac_class, prac_location, cal_formula, prac_point, term);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
