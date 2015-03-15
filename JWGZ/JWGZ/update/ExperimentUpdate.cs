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
    public partial class ExperimentUpdate : Form
    {
        ExperimentAdo experimentado = new ExperimentAdo();
        public static bool GlobalFlag;

        public ExperimentUpdate()
        {
            InitializeComponent();
        }
        public ExperimentUpdate(String id, String t_id, String t_name, String rank, String exp_ori, String exp_point, String depart_name, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtT_id.Text = t_id;
            txtT_name.Text = t_name;
            txtRank.Text = rank;
            txtExp_ori.Text = exp_ori;
            txtExp_point.Text = exp_point;
            txtDepart_name.Text = depart_name;
            txtTerm.Text = term;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String t_id = txtT_id.Text;
            String t_name = txtT_name.Text;
            String rank = txtRank.Text;
            String exp_ori = txtExp_ori.Text;
            String exp_point = txtExp_point.Text;
            String depart_name = txtDepart_name.Text;
            String term = txtTerm.Text;
            experimentado.UpdateExperiment(id, t_id, t_name, rank, exp_ori, exp_point, depart_name, term);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
