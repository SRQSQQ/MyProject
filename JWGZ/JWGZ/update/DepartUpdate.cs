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
    public partial class DepartUpdate : Form
    {
        DepartAdo departado = new DepartAdo();
        public static bool GlobalFlag;

        public DepartUpdate()
        {
            InitializeComponent();
        }
        public DepartUpdate(String depart_id, String depart, String school, String status)
        {
            InitializeComponent();
            txtDepart_id.Text = depart_id;
            txtDepart.Text = depart;
            txtSchool.Text = school;
            txtStatus.Text = status;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String depart_id = txtDepart_id.Text;
            String depart = txtDepart.Text;
            String school = txtSchool.Text;
            String status = txtStatus.Text;
            departado.UpdateDepart(depart_id, depart, school, status);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
