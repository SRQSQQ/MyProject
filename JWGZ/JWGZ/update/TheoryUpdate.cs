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
    public partial class TheoryUpdate : Form
    {
        TheoryAdo theoryado = new TheoryAdo();
        public static bool GlobalFlag;

        public TheoryUpdate()
        {
            InitializeComponent();
        }
        public TheoryUpdate(String id, String course_id, String course_name, String open_dep, String t_id, String teach_name, String rank, String teach_class, String teach_hour, String teach_number, String teach_point, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtCourse_id.Text = course_id;
            txtCourse_name.Text = course_name;
            txtOpen_dep.Text = open_dep;
            txtT_id.Text = t_id;
            txtTeach_name.Text = teach_name;
            txtRank.Text = rank;
            txtTeach_class.Text = teach_class;
            txtTeach_hour.Text = teach_hour;
            txtTeach_number.Text = teach_number;
            txtTeach_point.Text = teach_point;
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
            String teach_class = txtTeach_class.Text;
            String teach_hour = txtTeach_hour.Text;
            String teach_number = txtTeach_number.Text;
            String teach_point = txtTeach_point.Text;
            String term = txtTerm.Text;
            theoryado.UpdateTheory(id, course_id, course_name, open_dep, t_id, teach_name, rank, teach_class, teach_hour, teach_number, teach_point, term);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
