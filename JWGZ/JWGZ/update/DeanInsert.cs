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
    public partial class DeanInsert : Form
    {
        Dean_allowanceAdo dean_allowanceado = new Dean_allowanceAdo();
        public static bool GlobalFlag;

        public DeanInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            String t_id = txtT_id.Text;
            String t_name = txtT_name.Text;
            String exp_allow_point = txtExp_allow_point.Text;
            String statement = txtStatement.Text;
            String term = txtTerm.Text;
            dean_allowanceado.InsertDean_allowance(id, t_id, t_name, exp_allow_point, statement, term);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
