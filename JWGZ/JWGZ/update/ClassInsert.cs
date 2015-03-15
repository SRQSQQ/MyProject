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
    public partial class ClassInsert : Form
    {
        ClassAdo classado = new ClassAdo();
        public static bool GlobalFlag;

        public ClassInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String class_id = txtClass_id.Text;
            String class_name = txtClass.Text;
            String school = txtSchool.Text;
            classado.InsertClass(class_id, class_name, school);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
