namespace JWGZ
{
    partial class frmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDetail = new System.Windows.Forms.DataGridView();
            this.gboxT_detail = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).BeginInit();
            this.gboxT_detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDetail
            // 
            this.DgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetail.Location = new System.Drawing.Point(10, 24);
            this.DgvDetail.Name = "DgvDetail";
            this.DgvDetail.RowTemplate.Height = 27;
            this.DgvDetail.Size = new System.Drawing.Size(1314, 165);
            this.DgvDetail.TabIndex = 0;
            // 
            // gboxT_detail
            // 
            this.gboxT_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxT_detail.Controls.Add(this.DgvDetail);
            this.gboxT_detail.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxT_detail.Location = new System.Drawing.Point(2, 3);
            this.gboxT_detail.Name = "gboxT_detail";
            this.gboxT_detail.Size = new System.Drawing.Size(1333, 198);
            this.gboxT_detail.TabIndex = 1;
            this.gboxT_detail.TabStop = false;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 204);
            this.Controls.Add(this.gboxT_detail);
            this.Name = "frmDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "明细";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetail)).EndInit();
            this.gboxT_detail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetail;
        private System.Windows.Forms.GroupBox gboxT_detail;
    }
}