namespace RJPK
{
    partial class frmNumber
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
            this.Dgv_Number = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Number
            // 
            this.Dgv_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Number.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Number.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseNumber});
            this.Dgv_Number.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Number.Name = "Dgv_Number";
            this.Dgv_Number.RowTemplate.Height = 27;
            this.Dgv_Number.Size = new System.Drawing.Size(537, 350);
            this.Dgv_Number.TabIndex = 0;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "课程名称";
            this.CourseName.Name = "CourseName";
            // 
            // CourseNumber
            // 
            this.CourseNumber.HeaderText = "剩余人数";
            this.CourseNumber.Name = "CourseNumber";
            // 
            // frmNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 374);
            this.Controls.Add(this.Dgv_Number);
            this.Name = "frmNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNumber";
            this.Load += new System.EventHandler(this.frmNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
    }
}