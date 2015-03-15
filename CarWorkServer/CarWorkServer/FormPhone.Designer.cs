namespace CarWorkServer
{
    partial class FormPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhone));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPhono = new System.Windows.Forms.TextBox();
            this.comboBoxCarNo = new System.Windows.Forms.ComboBox();
            this.labelCarNo = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(60, 121);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 27);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "确定绑定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(163, 121);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 27);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPhono
            // 
            this.textBoxPhono.Location = new System.Drawing.Point(98, 80);
            this.textBoxPhono.Name = "textBoxPhono";
            this.textBoxPhono.Size = new System.Drawing.Size(121, 21);
            this.textBoxPhono.TabIndex = 3;
            // 
            // comboBoxCarNo
            // 
            this.comboBoxCarNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarNo.FormattingEnabled = true;
            this.comboBoxCarNo.Location = new System.Drawing.Point(98, 30);
            this.comboBoxCarNo.Name = "comboBoxCarNo";
            this.comboBoxCarNo.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCarNo.TabIndex = 4;
            // 
            // labelCarNo
            // 
            this.labelCarNo.AutoSize = true;
            this.labelCarNo.Location = new System.Drawing.Point(15, 33);
            this.labelCarNo.Name = "labelCarNo";
            this.labelCarNo.Size = new System.Drawing.Size(77, 12);
            this.labelCarNo.TabIndex = 5;
            this.labelCarNo.Text = "可选汽车号：";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(15, 89);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(77, 12);
            this.labelPhoto.TabIndex = 6;
            this.labelPhoto.Text = "绑定手机号：";
            // 
            // FormPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 164);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelCarNo);
            this.Controls.Add(this.comboBoxCarNo);
            this.Controls.Add(this.textBoxPhono);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 202);
            this.Name = "FormPhone";
            this.Text = "手机绑定连接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPhono;
        private System.Windows.Forms.ComboBox comboBoxCarNo;
        private System.Windows.Forms.Label labelCarNo;
        private System.Windows.Forms.Label labelPhoto;
    }
}