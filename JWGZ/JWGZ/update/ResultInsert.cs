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
    public partial class ResultInsert : Form
    {
        ResultAdo resultado = new ResultAdo();
        public static bool GlobalFlag;

        public ResultInsert()
        {
            InitializeComponent();
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
            String mas_hour = txtMas_hour.Text;
            String mas_point = txtMas_point.Text;
            String tut_point = txtTut_point.Text;
            String goal_point = txtGoal_point.Text;
            String adult_point = txtAdult_point.Text;
            String teach_hour = txtTeach_hour.Text;
            String teach_point = txtTeach_point.Text;
            String prac_week = txtPrac_week.Text;
            String prac_point = txtPrac_point.Text;
            String dean_point = txtDean_point.Text;
            String exp_ori = txtExp_ori.Text;
            String exp_point = txtExp_point.Text;
            String exp_allow_point = txtExp_allow_point.Text;
            String point_sum = txtPoint_sum.Text;
            String term = txtTerm.Text;
            resultado.InsertResult(id, t_id, t_name, rank, is_tutor, school, depart, card_id, mas_hour, mas_point, tut_point, goal_point, adult_point, teach_hour, teach_point, prac_week, prac_point, dean_point, exp_ori, exp_point, exp_allow_point, point_sum, term);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
