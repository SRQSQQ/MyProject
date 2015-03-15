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
    public partial class MasterUpdate : Form
    {
        MasterAdo masterado = new MasterAdo();
        public static bool GlobalFlag;

        public MasterUpdate()
        {
            InitializeComponent();
        }
        public MasterUpdate(String id, String t_id, String t_name, String mas_hour, String mas_point, String tut_point, String goal_point, String sum, String is_tutor, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtT_id.Text = t_id;
            txtT_name.Text = t_name;
            txtMas_hour.Text = mas_hour;
            txtMas_point.Text = mas_point;
            txtTut_point.Text = tut_point;
            txtGoal_point.Text = goal_point;
            txtSum.Text = sum;
            txtIs_tutor.Text = is_tutor;
            txtTerm.Text = term;                
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String t_id = txtT_id.Text;
            String t_name = txtT_name.Text;
            String mas_hour = txtMas_hour.Text;
            String mas_point = txtMas_point.Text;
            String tut_point = txtTut_point.Text;
            String goal_point = txtGoal_point.Text;
            String sum = txtSum.Text;
            String is_tutor = txtIs_tutor.Text;
            String term = txtTerm.Text;
            masterado.UpdateMaster(id, t_id, t_name, mas_hour, mas_point, tut_point, goal_point, sum, is_tutor, term);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
