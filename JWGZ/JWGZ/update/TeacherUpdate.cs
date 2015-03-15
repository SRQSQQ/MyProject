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
    public partial class TeacherUpdate : Form
    {
        TeacherAdo teacherado = new TeacherAdo();
        public static bool GlobalFlag;

        public TeacherUpdate()
        {
            InitializeComponent();
        }

        public TeacherUpdate(String t_id, String t_name, String depart, String rank,
            String card_id, String status, String school)
        {
            InitializeComponent();
            txtID.Text = t_id;
            txtTeachName.Text = t_name;
            txtDepart.Text = depart;
            txtRank.Text = rank;
            txtCard.Text = card_id;
            txtStatus.Text = status;
            txtSchool.Text = school;
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
            teacherado.UpdateTeacher(t_id, t_name, depart, rank, card_id, status, school);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
