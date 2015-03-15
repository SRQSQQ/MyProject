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

namespace JWGZ
{
    public partial class TheoryInsert : Form
    {
        TheoryAdo theoryado = new TheoryAdo();
        public static bool GlobalFlag;

        public TheoryInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String course_id = txtCourse_id.Text;
            String cousre_seq = txtCourse_seq.Text;
            String course_name = txtCourse_name.Text;
            String open_dep = txtOpen_dep.Text;
            String t_id = txtT_id.Text;
            String teach_name = txtTeach_name.Text;
            String rank = txtRank.Text;
            String teach_class = txtTeach_class.Text;
            String teach_hour = txtTeach_hour.Text;
            String teach_number = txtTeach_number.Text;
            String number_weight = txtNumber_weight.Text;
            String course_weight = txtCourse_weight.Text;
            String desc_weight = txtDesc_weight.Text;
            String rank_weight = txtRank_weight.Text;
            String spe_weight = txtSpe_weight.Text;
            String qua_weight = txtQua_weight.Text;
            String cal_weight = txtCal_weight.Text;
            String teach_point = txtTeach_point.Text;
            String term = txtTerm.Text; ;
            theoryado.InsertTheory(id, course_id, cousre_seq, course_name, open_dep, t_id, teach_name, rank, teach_class, teach_hour, teach_number, number_weight, course_weight, desc_weight, rank_weight, spe_weight, qua_weight, cal_weight, teach_point, term);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
