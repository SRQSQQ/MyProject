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
    public partial class RankUpdate : Form
    {
        RankAdo rankado = new RankAdo();
        public static bool GlobalFlag;

        public RankUpdate()
        {
            InitializeComponent();
        }
        public RankUpdate(String rank_id, String rank, String rank_weight)
        {
            InitializeComponent();
            txtRank_id.Text = rank_id;
            txtRank.Text = rank;
            txtRank_wei.Text = rank_weight;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String rank_id = txtRank_id.Text;
            String rank = txtRank.Text;
            String rank_weight = txtRank_wei.Text;
            rankado.UpdateRank(rank_id, rank, rank_weight);
            GlobalFlag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
