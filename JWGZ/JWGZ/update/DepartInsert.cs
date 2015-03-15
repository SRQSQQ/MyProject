using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JWGZ.bl;

namespace JWGZ.update
{
    public partial class DepartInsert : Form
    {
        DepartAdo departado = new DepartAdo();
        public static bool GlobalFlag;

        public DepartInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String depart_id = txtDepart_id.Text;
            String depart = txtDepart.Text;
            String school = txtSchool.Text;
            String status = txtStatus.Text;
            departado.InsertDepart(depart_id, depart, school, status);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
