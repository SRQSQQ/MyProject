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
    public partial class PracticeUpdate : Form
    {
        PracticeAdo practiceado = new PracticeAdo();
        public static bool GlobalFlag;

        public PracticeUpdate()
        {
            InitializeComponent();
        }
        public PracticeUpdate(String id, String course_id, String course_name, String open_dep, String t_id, String teach_name, String rank, String prac_point, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtCourse_id.Text = course_id;
            txtCourse_name.Text = course_name;
            txtOpen_dep.Text = open_dep;
            txtT_id.Text = t_id;
            txtTeach_name.Text = teach_name;
            txtRank.Text = rank;
            txtPrac_point.Text = prac_point;
            txtTerm.Text = term;
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
            String prac_point = txtPrac_point.Text;
            String term = txtTerm.Text;
            practiceado.UpdatePractice(id, course_id, course_name, open_dep, t_id, teach_name, rank, prac_point, term);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
