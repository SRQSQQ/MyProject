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

namespace JWGZ
{
    public partial class TeacherInsert : Form
    {
        TeacherAdo teacherado = new TeacherAdo();
        public static bool GlobalFlag;

        public TeacherInsert()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String t_id = txtID.Text;
            String t_name = txtTeachName.Text;
            String depart = txtDepart.Text;
            String rank = txtRank.Text;
            String card_id = txtCard.Text;
            String status = txtStatus.Text;
            String school = txtSchool.Text;
            teacherado.InsertTeacher(t_id, t_name, depart, rank, card_id, status, school);
            GlobalFlag = true;
            this.Hide();
        }
    }
}
