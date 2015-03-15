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
    public partial class ExperimentInsert : Form
    {
        ExperimentAdo experimentado = new ExperimentAdo();
        public static bool GlobalFlag;

        public ExperimentInsert()
        {
            InitializeComponent();
        }
        private void btn_OK_Click_1(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String t_id = txtT_id.Text;
            String t_name = txtT_name.Text;
            String rank = txtRank.Text;
            String exp_ori = txtExp_ori.Text;
            String exp_point = txtExp_point.Text;
            String depart_name = txtDepart_name.Text;
            String term = txtTerm.Text;
            experimentado.InsertExperiment(id, t_id, t_name, rank, exp_ori, exp_point, depart_name, term);
            GlobalFlag = true;
            this.Hide();
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
