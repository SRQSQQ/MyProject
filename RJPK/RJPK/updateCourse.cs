using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RJPK.ADO;

namespace RJPK
{
    public partial class updateCourse : Form
    {
        CourseAdo courseado = new CourseAdo();
        public static bool GlobalFlag = false;

        public updateCourse()
        {
            InitializeComponent();
        }
        public updateCourse(String id, String course_id, String course_name, String number, String theoryTime, String experimentTime, String practiceTime)
        {
            InitializeComponent();
            txtID.Text = id;
            txtCourse_id.Text = course_id;
            txtCourse_name.Text = course_name;
            txt_number.Text = number;
            txt_theoryTime.Text = theoryTime;
            txt_experimentTime.Text = experimentTime;
            txt_practiceTime.Text = practiceTime;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text.Trim();
            String number = txt_number.Text.Trim();
            String theoryTime = txt_theoryTime.Text.Trim();
            String experimentTime = txt_experimentTime.Text.Trim();
            String practiceTime = txt_practiceTime.Text.Trim();
            courseado.UpdateCoures(id, number, theoryTime, experimentTime, practiceTime);
            GlobalFlag = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
