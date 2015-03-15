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
    public partial class RankInsert : Form
    {
        RankAdo rankado = new RankAdo();
        public static bool GlobalFlag;

        public RankInsert()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String rank_id = txtRank_id.Text;
            String rank = txtRank.Text;
            String rank_weight = txtRank_wei.Text;
            rankado.InsertRank(rank_id, rank, rank_weight);
            GlobalFlag = true;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
