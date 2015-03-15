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
    public partial class ClassUpdate : Form
    {
        ClassAdo classado = new ClassAdo();
        public static bool GlobalFlag;

        public ClassUpdate()
        {
            InitializeComponent();
        }
        public ClassUpdate(String class_id, String class_name, String school)
        {
            InitializeComponent();
            txtClass_id.Text = class_id;
            txtClass.Text = class_name;
            txtSchool.Text = school;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String class_id = txtClass_id.Text;
            String class_name = txtClass.Text;
            String school = txtSchool.Text;
            classado.UpdateClass(class_id, class_name, school);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
