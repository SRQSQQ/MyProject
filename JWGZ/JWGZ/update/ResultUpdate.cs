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
    public partial class ResultUpdate : Form
    {
        ResultAdo resultado = new ResultAdo();
        public static bool GlobalFlag;

        public ResultUpdate()
        {
            InitializeComponent();
        }
        public ResultUpdate(String id, String t_id, String t_name, String rank, String is_tutor, String school, String depart, String card_id, String point_sum, String term)
        {
            InitializeComponent();
            txtID.Text = id;
            txtT_id.Text = t_id;
            txtT_name.Text = t_name;
            txt_Rank.Text = rank;
            txtIs_tutor.Text = is_tutor;
            txtSchool.Text = school;
            txtDepart.Text = depart;
            txtCard_id.Text = card_id;
            txtPoint_sum.Text = point_sum;
            txtTerm.Text = term;
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
            String point_sum = txtPoint_sum.Text;
            String term = txtTerm.Text;
            resultado.UpdateResult(id, t_id, t_name, rank, is_tutor, school, depart, card_id, point_sum, term);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
