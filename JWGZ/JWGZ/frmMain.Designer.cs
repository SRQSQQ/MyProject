namespace JWGZ
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Theory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Practice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Experiment = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Master = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btn_SC = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Class = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Rank = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Depart = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Teacher = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_History = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Result = new System.Windows.Forms.Button();
            this.tpMaster = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btnInsertMaster = new System.Windows.Forms.Button();
            this.btnDeleteMaster = new System.Windows.Forms.Button();
            this.btnUpdateMaster = new System.Windows.Forms.Button();
            this.btnSelectMasterOne = new System.Windows.Forms.Button();
            this.txtMaster_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DgvMaster = new System.Windows.Forms.DataGridView();
            this.tpExperiment = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btnInsertExperiment = new System.Windows.Forms.Button();
            this.btnDeleteExperiment = new System.Windows.Forms.Button();
            this.btnUpdateExperiment = new System.Windows.Forms.Button();
            this.btnSelectExperimentTwo = new System.Windows.Forms.Button();
            this.btnSelectExperimentOne = new System.Windows.Forms.Button();
            this.txtExperiment_Depart = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExperiment_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DgvExperiment = new System.Windows.Forms.DataGridView();
            this.tpPractice = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnInsertPractice = new System.Windows.Forms.Button();
            this.btnDeletePractice = new System.Windows.Forms.Button();
            this.btnUpdatePractice = new System.Windows.Forms.Button();
            this.btnCalculatePractice = new System.Windows.Forms.Button();
            this.btnSelectPracticeTwo = new System.Windows.Forms.Button();
            this.btnSelectPracticeOne = new System.Windows.Forms.Button();
            this.txtPractice_Depart = new System.Windows.Forms.TextBox();
            this.txtPractice_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvPractice = new System.Windows.Forms.DataGridView();
            this.tpTheory = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnInsertTheory = new System.Windows.Forms.Button();
            this.btnDeleteTheory = new System.Windows.Forms.Button();
            this.btnUpdateTheory = new System.Windows.Forms.Button();
            this.btnCalculateTheory = new System.Windows.Forms.Button();
            this.btnSelectTheoryTwo = new System.Windows.Forms.Button();
            this.btnSelectTheoryOne = new System.Windows.Forms.Button();
            this.txtTheory_Depart = new System.Windows.Forms.TextBox();
            this.txtTheory_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvTheory = new System.Windows.Forms.DataGridView();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btnInsertClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnSelectClassTwo = new System.Windows.Forms.Button();
            this.btnSelectClassOne = new System.Windows.Forms.Button();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClass_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DgvClass = new System.Windows.Forms.DataGridView();
            this.tpRank = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnInsertRank = new System.Windows.Forms.Button();
            this.btnDeleteRank = new System.Windows.Forms.Button();
            this.btnUpdateRank = new System.Windows.Forms.Button();
            this.btnSelectRankTwo = new System.Windows.Forms.Button();
            this.btnSelectRankOne = new System.Windows.Forms.Button();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRank_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvRank = new System.Windows.Forms.DataGridView();
            this.tpDepart = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.btnInsertDepart = new System.Windows.Forms.Button();
            this.btnDeleteDepart = new System.Windows.Forms.Button();
            this.btnUpdateDepart = new System.Windows.Forms.Button();
            this.btnSelectDepartTwo = new System.Windows.Forms.Button();
            this.btnSelectDepartOne = new System.Windows.Forms.Button();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepart_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvDepart = new System.Windows.Forms.DataGridView();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnInsertTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnSelectTeacherTwo = new System.Windows.Forms.Button();
            this.btnSelectTeacherOne = new System.Windows.Forms.Button();
            this.txtTeacher_Depart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeacher_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTeacher = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDean_allowance = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btnInsertDean = new System.Windows.Forms.Button();
            this.btnDeleteDean = new System.Windows.Forms.Button();
            this.btnUpdateDean = new System.Windows.Forms.Button();
            this.btnSelectDeanOne = new System.Windows.Forms.Button();
            this.txtDean_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.DgvDean_allowance = new System.Windows.Forms.DataGridView();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.btnInsertResult = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.btnUpdateResult = new System.Windows.Forms.Button();
            this.btnSelectResultOne = new System.Windows.Forms.Button();
            this.txtResult_name = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.tpHistory = new System.Windows.Forms.TabPage();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnUpdateHistory = new System.Windows.Forms.Button();
            this.btnSelectHistory = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbox_TermH = new System.Windows.Forms.ComboBox();
            this.cbox_YearH = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Dean_allowance = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tpMaster.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaster)).BeginInit();
            this.tpExperiment.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExperiment)).BeginInit();
            this.tpPractice.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPractice)).BeginInit();
            this.tpTheory.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTheory)).BeginInit();
            this.tpClass.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClass)).BeginInit();
            this.tpRank.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRank)).BeginInit();
            this.tpDepart.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepart)).BeginInit();
            this.tpTeacher.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTeacher)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDean_allowance.SuspendLayout();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDean_allowance)).BeginInit();
            this.tpResult.SuspendLayout();
            this.groupBox22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.tpHistory.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate_Theory);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "理论工作量";
            // 
            // btnUpdate_Theory
            // 
            this.btnUpdate_Theory.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Theory.Name = "btnUpdate_Theory";
            this.btnUpdate_Theory.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Theory.TabIndex = 1;
            this.btnUpdate_Theory.Text = "管 理";
            this.btnUpdate_Theory.UseVisualStyleBackColor = true;
            this.btnUpdate_Theory.Click += new System.EventHandler(this.btnUpdate_Theory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate_Practice);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "实践工作量";
            // 
            // btnUpdate_Practice
            // 
            this.btnUpdate_Practice.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Practice.Name = "btnUpdate_Practice";
            this.btnUpdate_Practice.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Practice.TabIndex = 1;
            this.btnUpdate_Practice.Text = "管 理";
            this.btnUpdate_Practice.UseVisualStyleBackColor = true;
            this.btnUpdate_Practice.Click += new System.EventHandler(this.btnUpdate_Practice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate_Experiment);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(6, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实验工作量";
            // 
            // btnUpdate_Experiment
            // 
            this.btnUpdate_Experiment.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Experiment.Name = "btnUpdate_Experiment";
            this.btnUpdate_Experiment.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Experiment.TabIndex = 1;
            this.btnUpdate_Experiment.Text = "管 理";
            this.btnUpdate_Experiment.UseVisualStyleBackColor = true;
            this.btnUpdate_Experiment.Click += new System.EventHandler(this.btnUpdate_Experiment_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate_Master);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(6, 499);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 109);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "研究生工作量";
            // 
            // btnUpdate_Master
            // 
            this.btnUpdate_Master.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Master.Name = "btnUpdate_Master";
            this.btnUpdate_Master.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Master.TabIndex = 0;
            this.btnUpdate_Master.Text = "管 理";
            this.btnUpdate_Master.UseVisualStyleBackColor = true;
            this.btnUpdate_Master.Click += new System.EventHandler(this.btnUpdate_Master_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox25);
            this.groupBox6.Controls.Add(this.groupBox24);
            this.groupBox6.Controls.Add(this.groupBox14);
            this.groupBox6.Controls.Add(this.groupBox13);
            this.groupBox6.Controls.Add(this.groupBox12);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(6, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1288, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "系统管理";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.lblTerm);
            this.groupBox25.Controls.Add(this.label25);
            this.groupBox25.Controls.Add(this.label18);
            this.groupBox25.Controls.Add(this.lblYear);
            this.groupBox25.Location = new System.Drawing.Point(1046, 19);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(234, 81);
            this.groupBox25.TabIndex = 7;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "当前学期";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTerm.Location = new System.Drawing.Point(142, 39);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(19, 19);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = " ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(167, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 19);
            this.label25.TabIndex = 0;
            this.label25.Text = "季";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(84, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "年";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYear.Location = new System.Drawing.Point(39, 39);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 19);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "   ";
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btn_SC);
            this.groupBox24.Location = new System.Drawing.Point(88, 19);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(187, 81);
            this.groupBox24.TabIndex = 6;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "上传表";
            // 
            // btn_SC
            // 
            this.btn_SC.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SC.Location = new System.Drawing.Point(53, 27);
            this.btn_SC.Name = "btn_SC";
            this.btn_SC.Size = new System.Drawing.Size(80, 31);
            this.btn_SC.TabIndex = 0;
            this.btn_SC.Text = "上 传";
            this.btn_SC.UseVisualStyleBackColor = true;
            this.btn_SC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.btnUpdate_Class);
            this.groupBox14.Location = new System.Drawing.Point(682, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(139, 81);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "班级信息";
            // 
            // btnUpdate_Class
            // 
            this.btnUpdate_Class.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate_Class.Location = new System.Drawing.Point(29, 27);
            this.btnUpdate_Class.Name = "btnUpdate_Class";
            this.btnUpdate_Class.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate_Class.TabIndex = 1;
            this.btnUpdate_Class.Text = "管 理";
            this.btnUpdate_Class.UseVisualStyleBackColor = true;
            this.btnUpdate_Class.Click += new System.EventHandler(this.btnUpdate_Class_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnUpdate_Rank);
            this.groupBox13.Location = new System.Drawing.Point(500, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(139, 81);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "职称信息";
            // 
            // btnUpdate_Rank
            // 
            this.btnUpdate_Rank.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate_Rank.Location = new System.Drawing.Point(29, 27);
            this.btnUpdate_Rank.Name = "btnUpdate_Rank";
            this.btnUpdate_Rank.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate_Rank.TabIndex = 1;
            this.btnUpdate_Rank.Text = "管 理";
            this.btnUpdate_Rank.UseVisualStyleBackColor = true;
            this.btnUpdate_Rank.Click += new System.EventHandler(this.btnUpdate_Rank_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnUpdate_Depart);
            this.groupBox12.Location = new System.Drawing.Point(318, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(139, 81);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "系所信息";
            // 
            // btnUpdate_Depart
            // 
            this.btnUpdate_Depart.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate_Depart.Location = new System.Drawing.Point(29, 27);
            this.btnUpdate_Depart.Name = "btnUpdate_Depart";
            this.btnUpdate_Depart.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate_Depart.TabIndex = 1;
            this.btnUpdate_Depart.Text = "管 理";
            this.btnUpdate_Depart.UseVisualStyleBackColor = true;
            this.btnUpdate_Depart.Click += new System.EventHandler(this.btnUpdate_Depart_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnUpdate_Teacher);
            this.groupBox7.Location = new System.Drawing.Point(864, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(139, 81);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "教师信息";
            // 
            // btnUpdate_Teacher
            // 
            this.btnUpdate_Teacher.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate_Teacher.Location = new System.Drawing.Point(29, 27);
            this.btnUpdate_Teacher.Name = "btnUpdate_Teacher";
            this.btnUpdate_Teacher.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate_Teacher.TabIndex = 1;
            this.btnUpdate_Teacher.Text = "管 理";
            this.btnUpdate_Teacher.UseVisualStyleBackColor = true;
            this.btnUpdate_Teacher.Click += new System.EventHandler(this.btnUpdate_Teacher_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 978);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1298, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel1.Text = "欢迎使用本系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1169, 20);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnUpdate_History);
            this.groupBox9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(5, 856);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(176, 109);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "历史工作量";
            // 
            // btnUpdate_History
            // 
            this.btnUpdate_History.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_History.Name = "btnUpdate_History";
            this.btnUpdate_History.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_History.TabIndex = 0;
            this.btnUpdate_History.Text = "管 理";
            this.btnUpdate_History.UseVisualStyleBackColor = true;
            this.btnUpdate_History.Click += new System.EventHandler(this.btnUpdate_History_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnUpdate_Result);
            this.groupBox11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox11.Location = new System.Drawing.Point(6, 737);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(176, 109);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "汇总工作量";
            // 
            // btnUpdate_Result
            // 
            this.btnUpdate_Result.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Result.Name = "btnUpdate_Result";
            this.btnUpdate_Result.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Result.TabIndex = 1;
            this.btnUpdate_Result.Text = "管 理";
            this.btnUpdate_Result.UseVisualStyleBackColor = true;
            this.btnUpdate_Result.Click += new System.EventHandler(this.btnUpdate_Result_Click);
            // 
            // tpMaster
            // 
            this.tpMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpMaster.Controls.Add(this.groupBox19);
            this.tpMaster.Location = new System.Drawing.Point(4, 31);
            this.tpMaster.Name = "tpMaster";
            this.tpMaster.Size = new System.Drawing.Size(1098, 827);
            this.tpMaster.TabIndex = 7;
            this.tpMaster.Text = "研究生工作量";
            this.tpMaster.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox19.Controls.Add(this.btnInsertMaster);
            this.groupBox19.Controls.Add(this.btnDeleteMaster);
            this.groupBox19.Controls.Add(this.btnUpdateMaster);
            this.groupBox19.Controls.Add(this.btnSelectMasterOne);
            this.groupBox19.Controls.Add(this.txtMaster_name);
            this.groupBox19.Controls.Add(this.label16);
            this.groupBox19.Controls.Add(this.DgvMaster);
            this.groupBox19.Location = new System.Drawing.Point(-1, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1095, 820);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "研究生工作量管理";
            // 
            // btnInsertMaster
            // 
            this.btnInsertMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertMaster.Location = new System.Drawing.Point(1019, 20);
            this.btnInsertMaster.Name = "btnInsertMaster";
            this.btnInsertMaster.Size = new System.Drawing.Size(75, 28);
            this.btnInsertMaster.TabIndex = 15;
            this.btnInsertMaster.Text = "插入";
            this.btnInsertMaster.UseVisualStyleBackColor = true;
            this.btnInsertMaster.Click += new System.EventHandler(this.btnInsertMaster_Click);
            // 
            // btnDeleteMaster
            // 
            this.btnDeleteMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMaster.Location = new System.Drawing.Point(938, 20);
            this.btnDeleteMaster.Name = "btnDeleteMaster";
            this.btnDeleteMaster.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteMaster.TabIndex = 14;
            this.btnDeleteMaster.Text = "删除";
            this.btnDeleteMaster.UseVisualStyleBackColor = true;
            this.btnDeleteMaster.Click += new System.EventHandler(this.btnDeleteMaster_Click);
            // 
            // btnUpdateMaster
            // 
            this.btnUpdateMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMaster.Location = new System.Drawing.Point(857, 20);
            this.btnUpdateMaster.Name = "btnUpdateMaster";
            this.btnUpdateMaster.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateMaster.TabIndex = 13;
            this.btnUpdateMaster.Text = "修改";
            this.btnUpdateMaster.UseVisualStyleBackColor = true;
            this.btnUpdateMaster.Click += new System.EventHandler(this.btnUpdateMaster_Click);
            // 
            // btnSelectMasterOne
            // 
            this.btnSelectMasterOne.Location = new System.Drawing.Point(191, 20);
            this.btnSelectMasterOne.Name = "btnSelectMasterOne";
            this.btnSelectMasterOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectMasterOne.TabIndex = 11;
            this.btnSelectMasterOne.Text = "查询";
            this.btnSelectMasterOne.UseVisualStyleBackColor = true;
            this.btnSelectMasterOne.Click += new System.EventHandler(this.btnSelectMasterOne_Click);
            // 
            // txtMaster_name
            // 
            this.txtMaster_name.Location = new System.Drawing.Point(85, 20);
            this.txtMaster_name.MaxLength = 7;
            this.txtMaster_name.Name = "txtMaster_name";
            this.txtMaster_name.Size = new System.Drawing.Size(100, 28);
            this.txtMaster_name.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "教师名:";
            // 
            // DgvMaster
            // 
            this.DgvMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaster.Location = new System.Drawing.Point(3, 56);
            this.DgvMaster.Name = "DgvMaster";
            this.DgvMaster.RowTemplate.Height = 27;
            this.DgvMaster.Size = new System.Drawing.Size(1091, 764);
            this.DgvMaster.TabIndex = 0;
            // 
            // tpExperiment
            // 
            this.tpExperiment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpExperiment.Controls.Add(this.groupBox18);
            this.tpExperiment.Location = new System.Drawing.Point(4, 31);
            this.tpExperiment.Name = "tpExperiment";
            this.tpExperiment.Size = new System.Drawing.Size(1098, 827);
            this.tpExperiment.TabIndex = 6;
            this.tpExperiment.Text = "实验工作量";
            this.tpExperiment.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox18.Controls.Add(this.btnInsertExperiment);
            this.groupBox18.Controls.Add(this.btnDeleteExperiment);
            this.groupBox18.Controls.Add(this.btnUpdateExperiment);
            this.groupBox18.Controls.Add(this.btnSelectExperimentTwo);
            this.groupBox18.Controls.Add(this.btnSelectExperimentOne);
            this.groupBox18.Controls.Add(this.txtExperiment_Depart);
            this.groupBox18.Controls.Add(this.label13);
            this.groupBox18.Controls.Add(this.txtExperiment_name);
            this.groupBox18.Controls.Add(this.label14);
            this.groupBox18.Controls.Add(this.DgvExperiment);
            this.groupBox18.Location = new System.Drawing.Point(3, 3);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1090, 818);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "实验工作量管理";
            // 
            // btnInsertExperiment
            // 
            this.btnInsertExperiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertExperiment.Location = new System.Drawing.Point(1015, 19);
            this.btnInsertExperiment.Name = "btnInsertExperiment";
            this.btnInsertExperiment.Size = new System.Drawing.Size(75, 28);
            this.btnInsertExperiment.TabIndex = 14;
            this.btnInsertExperiment.Text = "插入";
            this.btnInsertExperiment.UseVisualStyleBackColor = true;
            this.btnInsertExperiment.Click += new System.EventHandler(this.btnInsertExperiment_Click);
            // 
            // btnDeleteExperiment
            // 
            this.btnDeleteExperiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteExperiment.Location = new System.Drawing.Point(934, 19);
            this.btnDeleteExperiment.Name = "btnDeleteExperiment";
            this.btnDeleteExperiment.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteExperiment.TabIndex = 13;
            this.btnDeleteExperiment.Text = "删除";
            this.btnDeleteExperiment.UseVisualStyleBackColor = true;
            this.btnDeleteExperiment.Click += new System.EventHandler(this.btnDeleteExperiment_Click);
            // 
            // btnUpdateExperiment
            // 
            this.btnUpdateExperiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateExperiment.Location = new System.Drawing.Point(853, 19);
            this.btnUpdateExperiment.Name = "btnUpdateExperiment";
            this.btnUpdateExperiment.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateExperiment.TabIndex = 12;
            this.btnUpdateExperiment.Text = "修改";
            this.btnUpdateExperiment.UseVisualStyleBackColor = true;
            this.btnUpdateExperiment.Click += new System.EventHandler(this.btnUpdateExperiment_Click);
            // 
            // btnSelectExperimentTwo
            // 
            this.btnSelectExperimentTwo.Location = new System.Drawing.Point(500, 19);
            this.btnSelectExperimentTwo.Name = "btnSelectExperimentTwo";
            this.btnSelectExperimentTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectExperimentTwo.TabIndex = 10;
            this.btnSelectExperimentTwo.Text = "查询";
            this.btnSelectExperimentTwo.UseVisualStyleBackColor = true;
            this.btnSelectExperimentTwo.Click += new System.EventHandler(this.btnSelectExperimentTwo_Click);
            // 
            // btnSelectExperimentOne
            // 
            this.btnSelectExperimentOne.Location = new System.Drawing.Point(191, 19);
            this.btnSelectExperimentOne.Name = "btnSelectExperimentOne";
            this.btnSelectExperimentOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectExperimentOne.TabIndex = 9;
            this.btnSelectExperimentOne.Text = "查询";
            this.btnSelectExperimentOne.UseVisualStyleBackColor = true;
            this.btnSelectExperimentOne.Click += new System.EventHandler(this.btnSelectExperimentOne_Click);
            // 
            // txtExperiment_Depart
            // 
            this.txtExperiment_Depart.Location = new System.Drawing.Point(394, 19);
            this.txtExperiment_Depart.Name = "txtExperiment_Depart";
            this.txtExperiment_Depart.Size = new System.Drawing.Size(100, 28);
            this.txtExperiment_Depart.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "院系：";
            // 
            // txtExperiment_name
            // 
            this.txtExperiment_name.Location = new System.Drawing.Point(85, 20);
            this.txtExperiment_name.MaxLength = 7;
            this.txtExperiment_name.Name = "txtExperiment_name";
            this.txtExperiment_name.Size = new System.Drawing.Size(100, 28);
            this.txtExperiment_name.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "教师名:";
            // 
            // DgvExperiment
            // 
            this.DgvExperiment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvExperiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExperiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExperiment.Location = new System.Drawing.Point(0, 53);
            this.DgvExperiment.Name = "DgvExperiment";
            this.DgvExperiment.RowTemplate.Height = 27;
            this.DgvExperiment.Size = new System.Drawing.Size(1090, 765);
            this.DgvExperiment.TabIndex = 0;
            // 
            // tpPractice
            // 
            this.tpPractice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPractice.Controls.Add(this.groupBox10);
            this.tpPractice.Location = new System.Drawing.Point(4, 31);
            this.tpPractice.Name = "tpPractice";
            this.tpPractice.Size = new System.Drawing.Size(1098, 827);
            this.tpPractice.TabIndex = 2;
            this.tpPractice.Text = "实践工作量";
            this.tpPractice.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.btnInsertPractice);
            this.groupBox10.Controls.Add(this.btnDeletePractice);
            this.groupBox10.Controls.Add(this.btnUpdatePractice);
            this.groupBox10.Controls.Add(this.btnCalculatePractice);
            this.groupBox10.Controls.Add(this.btnSelectPracticeTwo);
            this.groupBox10.Controls.Add(this.btnSelectPracticeOne);
            this.groupBox10.Controls.Add(this.txtPractice_Depart);
            this.groupBox10.Controls.Add(this.txtPractice_name);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.DgvPractice);
            this.groupBox10.Location = new System.Drawing.Point(0, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1097, 821);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "实践工作量管理";
            // 
            // btnInsertPractice
            // 
            this.btnInsertPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertPractice.Location = new System.Drawing.Point(1016, 22);
            this.btnInsertPractice.Name = "btnInsertPractice";
            this.btnInsertPractice.Size = new System.Drawing.Size(75, 28);
            this.btnInsertPractice.TabIndex = 22;
            this.btnInsertPractice.Text = "插入";
            this.btnInsertPractice.UseVisualStyleBackColor = true;
            this.btnInsertPractice.Click += new System.EventHandler(this.btnInsertPractice_Click);
            // 
            // btnDeletePractice
            // 
            this.btnDeletePractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePractice.Location = new System.Drawing.Point(935, 22);
            this.btnDeletePractice.Name = "btnDeletePractice";
            this.btnDeletePractice.Size = new System.Drawing.Size(75, 28);
            this.btnDeletePractice.TabIndex = 21;
            this.btnDeletePractice.Text = "删除";
            this.btnDeletePractice.UseVisualStyleBackColor = true;
            this.btnDeletePractice.Click += new System.EventHandler(this.btnDeletePractice_Click);
            // 
            // btnUpdatePractice
            // 
            this.btnUpdatePractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatePractice.Location = new System.Drawing.Point(854, 22);
            this.btnUpdatePractice.Name = "btnUpdatePractice";
            this.btnUpdatePractice.Size = new System.Drawing.Size(75, 28);
            this.btnUpdatePractice.TabIndex = 20;
            this.btnUpdatePractice.Text = "修改";
            this.btnUpdatePractice.UseVisualStyleBackColor = true;
            this.btnUpdatePractice.Click += new System.EventHandler(this.btnUpdatePractice_Click);
            // 
            // btnCalculatePractice
            // 
            this.btnCalculatePractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculatePractice.Location = new System.Drawing.Point(755, 22);
            this.btnCalculatePractice.Name = "btnCalculatePractice";
            this.btnCalculatePractice.Size = new System.Drawing.Size(93, 28);
            this.btnCalculatePractice.TabIndex = 18;
            this.btnCalculatePractice.Text = "核算";
            this.btnCalculatePractice.UseVisualStyleBackColor = true;
            this.btnCalculatePractice.Click += new System.EventHandler(this.btnCalculatePractice_Click);
            // 
            // btnSelectPracticeTwo
            // 
            this.btnSelectPracticeTwo.Location = new System.Drawing.Point(501, 22);
            this.btnSelectPracticeTwo.Name = "btnSelectPracticeTwo";
            this.btnSelectPracticeTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectPracticeTwo.TabIndex = 13;
            this.btnSelectPracticeTwo.Text = "查询";
            this.btnSelectPracticeTwo.UseVisualStyleBackColor = true;
            this.btnSelectPracticeTwo.Click += new System.EventHandler(this.btnSelectPracticeTwo_Click);
            // 
            // btnSelectPracticeOne
            // 
            this.btnSelectPracticeOne.Location = new System.Drawing.Point(195, 22);
            this.btnSelectPracticeOne.Name = "btnSelectPracticeOne";
            this.btnSelectPracticeOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectPracticeOne.TabIndex = 12;
            this.btnSelectPracticeOne.Text = "查询";
            this.btnSelectPracticeOne.UseVisualStyleBackColor = true;
            this.btnSelectPracticeOne.Click += new System.EventHandler(this.btnSelectPracticeOne_Click);
            // 
            // txtPractice_Depart
            // 
            this.txtPractice_Depart.Location = new System.Drawing.Point(393, 22);
            this.txtPractice_Depart.Name = "txtPractice_Depart";
            this.txtPractice_Depart.Size = new System.Drawing.Size(100, 28);
            this.txtPractice_Depart.TabIndex = 11;
            // 
            // txtPractice_name
            // 
            this.txtPractice_name.Location = new System.Drawing.Point(84, 22);
            this.txtPractice_name.MaxLength = 7;
            this.txtPractice_name.Name = "txtPractice_name";
            this.txtPractice_name.Size = new System.Drawing.Size(100, 28);
            this.txtPractice_name.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "院系：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "教师名:";
            // 
            // DgvPractice
            // 
            this.DgvPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPractice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPractice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPractice.Location = new System.Drawing.Point(0, 58);
            this.DgvPractice.Name = "DgvPractice";
            this.DgvPractice.RowTemplate.Height = 27;
            this.DgvPractice.Size = new System.Drawing.Size(1093, 763);
            this.DgvPractice.TabIndex = 0;
            // 
            // tpTheory
            // 
            this.tpTheory.BackColor = System.Drawing.SystemColors.Control;
            this.tpTheory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTheory.Controls.Add(this.groupBox8);
            this.tpTheory.Location = new System.Drawing.Point(4, 31);
            this.tpTheory.Name = "tpTheory";
            this.tpTheory.Padding = new System.Windows.Forms.Padding(3);
            this.tpTheory.Size = new System.Drawing.Size(1098, 827);
            this.tpTheory.TabIndex = 1;
            this.tpTheory.Text = "理论工作量";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.btnInsertTheory);
            this.groupBox8.Controls.Add(this.btnDeleteTheory);
            this.groupBox8.Controls.Add(this.btnUpdateTheory);
            this.groupBox8.Controls.Add(this.btnCalculateTheory);
            this.groupBox8.Controls.Add(this.btnSelectTheoryTwo);
            this.groupBox8.Controls.Add(this.btnSelectTheoryOne);
            this.groupBox8.Controls.Add(this.txtTheory_Depart);
            this.groupBox8.Controls.Add(this.txtTheory_name);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.DgvTheory);
            this.groupBox8.Location = new System.Drawing.Point(2, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1095, 821);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "理论工作量管理";
            // 
            // btnInsertTheory
            // 
            this.btnInsertTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertTheory.Location = new System.Drawing.Point(1014, 21);
            this.btnInsertTheory.Name = "btnInsertTheory";
            this.btnInsertTheory.Size = new System.Drawing.Size(75, 28);
            this.btnInsertTheory.TabIndex = 18;
            this.btnInsertTheory.Text = "插入";
            this.btnInsertTheory.UseVisualStyleBackColor = true;
            this.btnInsertTheory.Click += new System.EventHandler(this.btnInsertTheory_Click_1);
            // 
            // btnDeleteTheory
            // 
            this.btnDeleteTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTheory.Location = new System.Drawing.Point(933, 21);
            this.btnDeleteTheory.Name = "btnDeleteTheory";
            this.btnDeleteTheory.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteTheory.TabIndex = 17;
            this.btnDeleteTheory.Text = "删除";
            this.btnDeleteTheory.UseVisualStyleBackColor = true;
            this.btnDeleteTheory.Click += new System.EventHandler(this.btnDeleteTheory_Click_1);
            // 
            // btnUpdateTheory
            // 
            this.btnUpdateTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTheory.Location = new System.Drawing.Point(852, 21);
            this.btnUpdateTheory.Name = "btnUpdateTheory";
            this.btnUpdateTheory.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateTheory.TabIndex = 16;
            this.btnUpdateTheory.Text = "修改";
            this.btnUpdateTheory.UseVisualStyleBackColor = true;
            this.btnUpdateTheory.Click += new System.EventHandler(this.btnUpdateTheory_Click_1);
            // 
            // btnCalculateTheory
            // 
            this.btnCalculateTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculateTheory.Location = new System.Drawing.Point(753, 21);
            this.btnCalculateTheory.Name = "btnCalculateTheory";
            this.btnCalculateTheory.Size = new System.Drawing.Size(93, 28);
            this.btnCalculateTheory.TabIndex = 14;
            this.btnCalculateTheory.Text = "核算";
            this.btnCalculateTheory.UseVisualStyleBackColor = true;
            this.btnCalculateTheory.Click += new System.EventHandler(this.btnCalculateTheory_Click);
            // 
            // btnSelectTheoryTwo
            // 
            this.btnSelectTheoryTwo.Location = new System.Drawing.Point(500, 21);
            this.btnSelectTheoryTwo.Name = "btnSelectTheoryTwo";
            this.btnSelectTheoryTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectTheoryTwo.TabIndex = 9;
            this.btnSelectTheoryTwo.Text = "查询";
            this.btnSelectTheoryTwo.UseVisualStyleBackColor = true;
            this.btnSelectTheoryTwo.Click += new System.EventHandler(this.btnSelectTheoryTwo_Click);
            // 
            // btnSelectTheoryOne
            // 
            this.btnSelectTheoryOne.Location = new System.Drawing.Point(191, 22);
            this.btnSelectTheoryOne.Name = "btnSelectTheoryOne";
            this.btnSelectTheoryOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectTheoryOne.TabIndex = 8;
            this.btnSelectTheoryOne.Text = "查询";
            this.btnSelectTheoryOne.UseVisualStyleBackColor = true;
            this.btnSelectTheoryOne.Click += new System.EventHandler(this.btnSelectTheoryOne_Click);
            // 
            // txtTheory_Depart
            // 
            this.txtTheory_Depart.Location = new System.Drawing.Point(394, 22);
            this.txtTheory_Depart.Name = "txtTheory_Depart";
            this.txtTheory_Depart.Size = new System.Drawing.Size(100, 28);
            this.txtTheory_Depart.TabIndex = 7;
            // 
            // txtTheory_name
            // 
            this.txtTheory_name.Location = new System.Drawing.Point(85, 22);
            this.txtTheory_name.MaxLength = 7;
            this.txtTheory_name.Name = "txtTheory_name";
            this.txtTheory_name.Size = new System.Drawing.Size(100, 28);
            this.txtTheory_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "院系：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "教师名:";
            // 
            // DgvTheory
            // 
            this.DgvTheory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTheory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTheory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTheory.Location = new System.Drawing.Point(0, 58);
            this.DgvTheory.Name = "DgvTheory";
            this.DgvTheory.RowTemplate.Height = 27;
            this.DgvTheory.Size = new System.Drawing.Size(1095, 767);
            this.DgvTheory.TabIndex = 0;
            // 
            // tpClass
            // 
            this.tpClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpClass.Controls.Add(this.groupBox17);
            this.tpClass.Location = new System.Drawing.Point(4, 31);
            this.tpClass.Name = "tpClass";
            this.tpClass.Size = new System.Drawing.Size(1098, 827);
            this.tpClass.TabIndex = 5;
            this.tpClass.Text = "班级信息";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox17.Controls.Add(this.btnInsertClass);
            this.groupBox17.Controls.Add(this.btnDeleteClass);
            this.groupBox17.Controls.Add(this.btnUpdateClass);
            this.groupBox17.Controls.Add(this.btnSelectClassTwo);
            this.groupBox17.Controls.Add(this.btnSelectClassOne);
            this.groupBox17.Controls.Add(this.txtSchool);
            this.groupBox17.Controls.Add(this.label11);
            this.groupBox17.Controls.Add(this.txtClass_name);
            this.groupBox17.Controls.Add(this.label12);
            this.groupBox17.Controls.Add(this.DgvClass);
            this.groupBox17.Location = new System.Drawing.Point(3, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1091, 819);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "班级信息管理";
            // 
            // btnInsertClass
            // 
            this.btnInsertClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertClass.Location = new System.Drawing.Point(1012, 19);
            this.btnInsertClass.Name = "btnInsertClass";
            this.btnInsertClass.Size = new System.Drawing.Size(75, 28);
            this.btnInsertClass.TabIndex = 22;
            this.btnInsertClass.Text = "插入";
            this.btnInsertClass.UseVisualStyleBackColor = true;
            this.btnInsertClass.Click += new System.EventHandler(this.btnInsertClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClass.Location = new System.Drawing.Point(931, 19);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteClass.TabIndex = 21;
            this.btnDeleteClass.Text = "删除";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateClass.Location = new System.Drawing.Point(850, 19);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateClass.TabIndex = 20;
            this.btnUpdateClass.Text = "修改";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnSelectClassTwo
            // 
            this.btnSelectClassTwo.Location = new System.Drawing.Point(506, 19);
            this.btnSelectClassTwo.Name = "btnSelectClassTwo";
            this.btnSelectClassTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectClassTwo.TabIndex = 18;
            this.btnSelectClassTwo.Text = "查询";
            this.btnSelectClassTwo.UseVisualStyleBackColor = true;
            this.btnSelectClassTwo.Click += new System.EventHandler(this.btnSelectClassTwo_Click);
            // 
            // btnSelectClassOne
            // 
            this.btnSelectClassOne.Location = new System.Drawing.Point(195, 19);
            this.btnSelectClassOne.Name = "btnSelectClassOne";
            this.btnSelectClassOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectClassOne.TabIndex = 17;
            this.btnSelectClassOne.Text = "查询";
            this.btnSelectClassOne.UseVisualStyleBackColor = true;
            this.btnSelectClassOne.Click += new System.EventHandler(this.btnSelectClassOne_Click);
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(400, 19);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(100, 28);
            this.txtSchool.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "院系：";
            // 
            // txtClass_name
            // 
            this.txtClass_name.Location = new System.Drawing.Point(89, 19);
            this.txtClass_name.MaxLength = 7;
            this.txtClass_name.Name = "txtClass_name";
            this.txtClass_name.Size = new System.Drawing.Size(100, 28);
            this.txtClass_name.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "班级名:";
            // 
            // DgvClass
            // 
            this.DgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClass.Location = new System.Drawing.Point(0, 53);
            this.DgvClass.Name = "DgvClass";
            this.DgvClass.RowTemplate.Height = 27;
            this.DgvClass.Size = new System.Drawing.Size(1088, 765);
            this.DgvClass.TabIndex = 0;
            // 
            // tpRank
            // 
            this.tpRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpRank.Controls.Add(this.groupBox16);
            this.tpRank.Location = new System.Drawing.Point(4, 31);
            this.tpRank.Name = "tpRank";
            this.tpRank.Size = new System.Drawing.Size(1098, 827);
            this.tpRank.TabIndex = 4;
            this.tpRank.Text = "职称信息";
            this.tpRank.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox16.Controls.Add(this.btnInsertRank);
            this.groupBox16.Controls.Add(this.btnDeleteRank);
            this.groupBox16.Controls.Add(this.btnUpdateRank);
            this.groupBox16.Controls.Add(this.btnSelectRankTwo);
            this.groupBox16.Controls.Add(this.btnSelectRankOne);
            this.groupBox16.Controls.Add(this.txtRank);
            this.groupBox16.Controls.Add(this.label9);
            this.groupBox16.Controls.Add(this.txtRank_name);
            this.groupBox16.Controls.Add(this.label10);
            this.groupBox16.Controls.Add(this.DgvRank);
            this.groupBox16.Location = new System.Drawing.Point(3, 3);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1091, 818);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "职称信息管理";
            // 
            // btnInsertRank
            // 
            this.btnInsertRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertRank.Location = new System.Drawing.Point(1016, 18);
            this.btnInsertRank.Name = "btnInsertRank";
            this.btnInsertRank.Size = new System.Drawing.Size(75, 28);
            this.btnInsertRank.TabIndex = 18;
            this.btnInsertRank.Text = "插入";
            this.btnInsertRank.UseVisualStyleBackColor = true;
            this.btnInsertRank.Click += new System.EventHandler(this.btnInsertRank_Click);
            // 
            // btnDeleteRank
            // 
            this.btnDeleteRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRank.Location = new System.Drawing.Point(935, 18);
            this.btnDeleteRank.Name = "btnDeleteRank";
            this.btnDeleteRank.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteRank.TabIndex = 17;
            this.btnDeleteRank.Text = "删除";
            this.btnDeleteRank.UseVisualStyleBackColor = true;
            this.btnDeleteRank.Click += new System.EventHandler(this.btnDeleteRank_Click);
            // 
            // btnUpdateRank
            // 
            this.btnUpdateRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRank.Location = new System.Drawing.Point(854, 18);
            this.btnUpdateRank.Name = "btnUpdateRank";
            this.btnUpdateRank.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateRank.TabIndex = 16;
            this.btnUpdateRank.Text = "修改";
            this.btnUpdateRank.UseVisualStyleBackColor = true;
            this.btnUpdateRank.Click += new System.EventHandler(this.btnUpdateRank_Click);
            // 
            // btnSelectRankTwo
            // 
            this.btnSelectRankTwo.Location = new System.Drawing.Point(509, 18);
            this.btnSelectRankTwo.Name = "btnSelectRankTwo";
            this.btnSelectRankTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectRankTwo.TabIndex = 14;
            this.btnSelectRankTwo.Text = "查询";
            this.btnSelectRankTwo.UseVisualStyleBackColor = true;
            this.btnSelectRankTwo.Click += new System.EventHandler(this.btnSelectRankTwo_Click);
            // 
            // btnSelectRankOne
            // 
            this.btnSelectRankOne.Location = new System.Drawing.Point(195, 18);
            this.btnSelectRankOne.Name = "btnSelectRankOne";
            this.btnSelectRankOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectRankOne.TabIndex = 13;
            this.btnSelectRankOne.Text = "查询";
            this.btnSelectRankOne.UseVisualStyleBackColor = true;
            this.btnSelectRankOne.Click += new System.EventHandler(this.btnSelectRankOne_Click);
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(400, 18);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(100, 28);
            this.txtRank.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "职称：";
            // 
            // txtRank_name
            // 
            this.txtRank_name.Location = new System.Drawing.Point(89, 18);
            this.txtRank_name.MaxLength = 7;
            this.txtRank_name.Name = "txtRank_name";
            this.txtRank_name.Size = new System.Drawing.Size(100, 28);
            this.txtRank_name.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "职称名:";
            // 
            // DgvRank
            // 
            this.DgvRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRank.Location = new System.Drawing.Point(-1, 52);
            this.DgvRank.Name = "DgvRank";
            this.DgvRank.RowTemplate.Height = 27;
            this.DgvRank.Size = new System.Drawing.Size(1095, 765);
            this.DgvRank.TabIndex = 0;
            // 
            // tpDepart
            // 
            this.tpDepart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDepart.Controls.Add(this.groupBox15);
            this.tpDepart.Location = new System.Drawing.Point(4, 31);
            this.tpDepart.Name = "tpDepart";
            this.tpDepart.Size = new System.Drawing.Size(1098, 827);
            this.tpDepart.TabIndex = 3;
            this.tpDepart.Text = "系所信息";
            this.tpDepart.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.Controls.Add(this.btnInsertDepart);
            this.groupBox15.Controls.Add(this.btnDeleteDepart);
            this.groupBox15.Controls.Add(this.btnUpdateDepart);
            this.groupBox15.Controls.Add(this.btnSelectDepartTwo);
            this.groupBox15.Controls.Add(this.btnSelectDepartOne);
            this.groupBox15.Controls.Add(this.txtDepart);
            this.groupBox15.Controls.Add(this.label7);
            this.groupBox15.Controls.Add(this.txtDepart_name);
            this.groupBox15.Controls.Add(this.label8);
            this.groupBox15.Controls.Add(this.DgvDepart);
            this.groupBox15.Location = new System.Drawing.Point(2, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1092, 824);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "系所信息管理";
            // 
            // btnInsertDepart
            // 
            this.btnInsertDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertDepart.Location = new System.Drawing.Point(1014, 20);
            this.btnInsertDepart.Name = "btnInsertDepart";
            this.btnInsertDepart.Size = new System.Drawing.Size(75, 28);
            this.btnInsertDepart.TabIndex = 14;
            this.btnInsertDepart.Text = "插入";
            this.btnInsertDepart.UseVisualStyleBackColor = true;
            this.btnInsertDepart.Click += new System.EventHandler(this.btnInsertDepart_Click);
            // 
            // btnDeleteDepart
            // 
            this.btnDeleteDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDepart.Location = new System.Drawing.Point(933, 20);
            this.btnDeleteDepart.Name = "btnDeleteDepart";
            this.btnDeleteDepart.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteDepart.TabIndex = 13;
            this.btnDeleteDepart.Text = "删除";
            this.btnDeleteDepart.UseVisualStyleBackColor = true;
            this.btnDeleteDepart.Click += new System.EventHandler(this.btnDeleteDepart_Click);
            // 
            // btnUpdateDepart
            // 
            this.btnUpdateDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDepart.Location = new System.Drawing.Point(852, 20);
            this.btnUpdateDepart.Name = "btnUpdateDepart";
            this.btnUpdateDepart.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateDepart.TabIndex = 12;
            this.btnUpdateDepart.Text = "修改";
            this.btnUpdateDepart.UseVisualStyleBackColor = true;
            this.btnUpdateDepart.Click += new System.EventHandler(this.btnUpdateDepart_Click);
            // 
            // btnSelectDepartTwo
            // 
            this.btnSelectDepartTwo.Location = new System.Drawing.Point(506, 20);
            this.btnSelectDepartTwo.Name = "btnSelectDepartTwo";
            this.btnSelectDepartTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectDepartTwo.TabIndex = 10;
            this.btnSelectDepartTwo.Text = "查询";
            this.btnSelectDepartTwo.UseVisualStyleBackColor = true;
            this.btnSelectDepartTwo.Click += new System.EventHandler(this.btnSelectDepartTwo_Click);
            // 
            // btnSelectDepartOne
            // 
            this.btnSelectDepartOne.Location = new System.Drawing.Point(176, 20);
            this.btnSelectDepartOne.Name = "btnSelectDepartOne";
            this.btnSelectDepartOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectDepartOne.TabIndex = 9;
            this.btnSelectDepartOne.Text = "查询";
            this.btnSelectDepartOne.UseVisualStyleBackColor = true;
            this.btnSelectDepartOne.Click += new System.EventHandler(this.btnSelectDepartOne_Click);
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(400, 21);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(100, 28);
            this.txtDepart.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "院系：";
            // 
            // txtDepart_name
            // 
            this.txtDepart_name.Location = new System.Drawing.Point(70, 21);
            this.txtDepart_name.MaxLength = 7;
            this.txtDepart_name.Name = "txtDepart_name";
            this.txtDepart_name.Size = new System.Drawing.Size(100, 28);
            this.txtDepart_name.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "系名:";
            // 
            // DgvDepart
            // 
            this.DgvDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepart.Location = new System.Drawing.Point(1, 54);
            this.DgvDepart.Name = "DgvDepart";
            this.DgvDepart.RowTemplate.Height = 27;
            this.DgvDepart.Size = new System.Drawing.Size(1088, 767);
            this.DgvDepart.TabIndex = 0;
            // 
            // tpTeacher
            // 
            this.tpTeacher.BackColor = System.Drawing.SystemColors.Control;
            this.tpTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTeacher.Controls.Add(this.groupBox5);
            this.tpTeacher.Location = new System.Drawing.Point(4, 31);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeacher.Size = new System.Drawing.Size(1098, 827);
            this.tpTeacher.TabIndex = 0;
            this.tpTeacher.Text = "教师信息";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnInsertTeacher);
            this.groupBox5.Controls.Add(this.btnDeleteTeacher);
            this.groupBox5.Controls.Add(this.btnUpdateTeacher);
            this.groupBox5.Controls.Add(this.btnSelectTeacherTwo);
            this.groupBox5.Controls.Add(this.btnSelectTeacherOne);
            this.groupBox5.Controls.Add(this.txtTeacher_Depart);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtTeacher_name);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.DgvTeacher);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1092, 824);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "教师信息管理";
            // 
            // btnInsertTeacher
            // 
            this.btnInsertTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertTeacher.Location = new System.Drawing.Point(1014, 20);
            this.btnInsertTeacher.Name = "btnInsertTeacher";
            this.btnInsertTeacher.Size = new System.Drawing.Size(75, 28);
            this.btnInsertTeacher.TabIndex = 20;
            this.btnInsertTeacher.Text = "插入";
            this.btnInsertTeacher.UseVisualStyleBackColor = true;
            this.btnInsertTeacher.Click += new System.EventHandler(this.btnInsertTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTeacher.Location = new System.Drawing.Point(934, 20);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteTeacher.TabIndex = 19;
            this.btnDeleteTeacher.Text = "删除";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTeacher.Location = new System.Drawing.Point(853, 20);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateTeacher.TabIndex = 18;
            this.btnUpdateTeacher.Text = "修改";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click_1);
            // 
            // btnSelectTeacherTwo
            // 
            this.btnSelectTeacherTwo.Location = new System.Drawing.Point(500, 20);
            this.btnSelectTeacherTwo.Name = "btnSelectTeacherTwo";
            this.btnSelectTeacherTwo.Size = new System.Drawing.Size(75, 28);
            this.btnSelectTeacherTwo.TabIndex = 17;
            this.btnSelectTeacherTwo.Text = "查询";
            this.btnSelectTeacherTwo.UseVisualStyleBackColor = true;
            this.btnSelectTeacherTwo.Click += new System.EventHandler(this.btnSelectTeacherTwo_Click);
            // 
            // btnSelectTeacherOne
            // 
            this.btnSelectTeacherOne.Location = new System.Drawing.Point(191, 20);
            this.btnSelectTeacherOne.Name = "btnSelectTeacherOne";
            this.btnSelectTeacherOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectTeacherOne.TabIndex = 6;
            this.btnSelectTeacherOne.Text = "查询";
            this.btnSelectTeacherOne.UseVisualStyleBackColor = true;
            this.btnSelectTeacherOne.Click += new System.EventHandler(this.btnSelectTeacherOne_Click);
            // 
            // txtTeacher_Depart
            // 
            this.txtTeacher_Depart.Location = new System.Drawing.Point(394, 19);
            this.txtTeacher_Depart.Name = "txtTeacher_Depart";
            this.txtTeacher_Depart.Size = new System.Drawing.Size(100, 28);
            this.txtTeacher_Depart.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "院系：";
            // 
            // txtTeacher_name
            // 
            this.txtTeacher_name.Location = new System.Drawing.Point(85, 20);
            this.txtTeacher_name.MaxLength = 7;
            this.txtTeacher_name.Name = "txtTeacher_name";
            this.txtTeacher_name.Size = new System.Drawing.Size(100, 28);
            this.txtTeacher_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师名:";
            // 
            // DgvTeacher
            // 
            this.DgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTeacher.Location = new System.Drawing.Point(0, 54);
            this.DgvTeacher.Name = "DgvTeacher";
            this.DgvTeacher.RowTemplate.Height = 27;
            this.DgvTeacher.Size = new System.Drawing.Size(1092, 767);
            this.DgvTeacher.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tpTeacher);
            this.tabControl1.Controls.Add(this.tpDepart);
            this.tabControl1.Controls.Add(this.tpRank);
            this.tabControl1.Controls.Add(this.tpClass);
            this.tabControl1.Controls.Add(this.tpTheory);
            this.tabControl1.Controls.Add(this.tpPractice);
            this.tabControl1.Controls.Add(this.tpExperiment);
            this.tabControl1.Controls.Add(this.tpMaster);
            this.tabControl1.Controls.Add(this.tpDean_allowance);
            this.tabControl1.Controls.Add(this.tpResult);
            this.tabControl1.Controls.Add(this.tpHistory);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(192, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 862);
            this.tabControl1.TabIndex = 7;
            // 
            // tpDean_allowance
            // 
            this.tpDean_allowance.Controls.Add(this.groupBox21);
            this.tpDean_allowance.Location = new System.Drawing.Point(4, 31);
            this.tpDean_allowance.Name = "tpDean_allowance";
            this.tpDean_allowance.Size = new System.Drawing.Size(1098, 827);
            this.tpDean_allowance.TabIndex = 8;
            this.tpDean_allowance.Text = "系主任津贴";
            this.tpDean_allowance.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox21.Controls.Add(this.btnInsertDean);
            this.groupBox21.Controls.Add(this.btnDeleteDean);
            this.groupBox21.Controls.Add(this.btnUpdateDean);
            this.groupBox21.Controls.Add(this.btnSelectDeanOne);
            this.groupBox21.Controls.Add(this.txtDean_name);
            this.groupBox21.Controls.Add(this.label19);
            this.groupBox21.Controls.Add(this.DgvDean_allowance);
            this.groupBox21.Location = new System.Drawing.Point(3, 3);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(1095, 824);
            this.groupBox21.TabIndex = 0;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "系主任津贴管理";
            // 
            // btnInsertDean
            // 
            this.btnInsertDean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertDean.Location = new System.Drawing.Point(1016, 21);
            this.btnInsertDean.Name = "btnInsertDean";
            this.btnInsertDean.Size = new System.Drawing.Size(75, 28);
            this.btnInsertDean.TabIndex = 19;
            this.btnInsertDean.Text = "插入";
            this.btnInsertDean.UseVisualStyleBackColor = true;
            this.btnInsertDean.Click += new System.EventHandler(this.btnInsertDean_Click);
            // 
            // btnDeleteDean
            // 
            this.btnDeleteDean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDean.Location = new System.Drawing.Point(935, 21);
            this.btnDeleteDean.Name = "btnDeleteDean";
            this.btnDeleteDean.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteDean.TabIndex = 18;
            this.btnDeleteDean.Text = "删除";
            this.btnDeleteDean.UseVisualStyleBackColor = true;
            this.btnDeleteDean.Click += new System.EventHandler(this.btnDeleteDean_Click);
            // 
            // btnUpdateDean
            // 
            this.btnUpdateDean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDean.Location = new System.Drawing.Point(854, 21);
            this.btnUpdateDean.Name = "btnUpdateDean";
            this.btnUpdateDean.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateDean.TabIndex = 17;
            this.btnUpdateDean.Text = "修改";
            this.btnUpdateDean.UseVisualStyleBackColor = true;
            this.btnUpdateDean.Click += new System.EventHandler(this.btnUpdateDean_Click);
            // 
            // btnSelectDeanOne
            // 
            this.btnSelectDeanOne.Location = new System.Drawing.Point(190, 23);
            this.btnSelectDeanOne.Name = "btnSelectDeanOne";
            this.btnSelectDeanOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectDeanOne.TabIndex = 13;
            this.btnSelectDeanOne.Text = "查询";
            this.btnSelectDeanOne.UseVisualStyleBackColor = true;
            this.btnSelectDeanOne.Click += new System.EventHandler(this.btnSelectDeanOne_Click);
            // 
            // txtDean_name
            // 
            this.txtDean_name.Location = new System.Drawing.Point(84, 23);
            this.txtDean_name.MaxLength = 7;
            this.txtDean_name.Name = "txtDean_name";
            this.txtDean_name.Size = new System.Drawing.Size(100, 28);
            this.txtDean_name.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 19);
            this.label19.TabIndex = 10;
            this.label19.Text = "教师名:";
            // 
            // DgvDean_allowance
            // 
            this.DgvDean_allowance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDean_allowance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDean_allowance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDean_allowance.Location = new System.Drawing.Point(0, 57);
            this.DgvDean_allowance.Name = "DgvDean_allowance";
            this.DgvDean_allowance.RowTemplate.Height = 27;
            this.DgvDean_allowance.Size = new System.Drawing.Size(1092, 764);
            this.DgvDean_allowance.TabIndex = 0;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.groupBox22);
            this.tpResult.Location = new System.Drawing.Point(4, 31);
            this.tpResult.Name = "tpResult";
            this.tpResult.Size = new System.Drawing.Size(1098, 827);
            this.tpResult.TabIndex = 9;
            this.tpResult.Text = "汇总工作量";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // groupBox22
            // 
            this.groupBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox22.Controls.Add(this.btnSaveHistory);
            this.groupBox22.Controls.Add(this.btnCalculateResult);
            this.groupBox22.Controls.Add(this.btnInsertResult);
            this.groupBox22.Controls.Add(this.btnDeleteResult);
            this.groupBox22.Controls.Add(this.btnUpdateResult);
            this.groupBox22.Controls.Add(this.btnSelectResultOne);
            this.groupBox22.Controls.Add(this.txtResult_name);
            this.groupBox22.Controls.Add(this.label20);
            this.groupBox22.Controls.Add(this.DgvResult);
            this.groupBox22.Location = new System.Drawing.Point(4, 4);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(1091, 820);
            this.groupBox22.TabIndex = 0;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "汇总工作量管理";
            // 
            // btnSaveHistory
            // 
            this.btnSaveHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHistory.Location = new System.Drawing.Point(648, 20);
            this.btnSaveHistory.Name = "btnSaveHistory";
            this.btnSaveHistory.Size = new System.Drawing.Size(98, 28);
            this.btnSaveHistory.TabIndex = 25;
            this.btnSaveHistory.Text = "入历史库";
            this.btnSaveHistory.UseVisualStyleBackColor = true;
            this.btnSaveHistory.Click += new System.EventHandler(this.btnSaveHistory_Click);
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculateResult.Location = new System.Drawing.Point(752, 20);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(93, 28);
            this.btnCalculateResult.TabIndex = 24;
            this.btnCalculateResult.Text = "核算";
            this.btnCalculateResult.UseVisualStyleBackColor = true;
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // btnInsertResult
            // 
            this.btnInsertResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertResult.Location = new System.Drawing.Point(1013, 20);
            this.btnInsertResult.Name = "btnInsertResult";
            this.btnInsertResult.Size = new System.Drawing.Size(75, 28);
            this.btnInsertResult.TabIndex = 23;
            this.btnInsertResult.Text = "插入";
            this.btnInsertResult.UseVisualStyleBackColor = true;
            this.btnInsertResult.Click += new System.EventHandler(this.btnInsertResult_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteResult.Location = new System.Drawing.Point(932, 20);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteResult.TabIndex = 22;
            this.btnDeleteResult.Text = "删除";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // btnUpdateResult
            // 
            this.btnUpdateResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateResult.Location = new System.Drawing.Point(851, 20);
            this.btnUpdateResult.Name = "btnUpdateResult";
            this.btnUpdateResult.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateResult.TabIndex = 21;
            this.btnUpdateResult.Text = "修改";
            this.btnUpdateResult.UseVisualStyleBackColor = true;
            this.btnUpdateResult.Click += new System.EventHandler(this.btnUpdateResult_Click);
            // 
            // btnSelectResultOne
            // 
            this.btnSelectResultOne.Location = new System.Drawing.Point(188, 22);
            this.btnSelectResultOne.Name = "btnSelectResultOne";
            this.btnSelectResultOne.Size = new System.Drawing.Size(75, 28);
            this.btnSelectResultOne.TabIndex = 16;
            this.btnSelectResultOne.Text = "查询";
            this.btnSelectResultOne.UseVisualStyleBackColor = true;
            this.btnSelectResultOne.Click += new System.EventHandler(this.btnSelectResultOne_Click);
            // 
            // txtResult_name
            // 
            this.txtResult_name.Location = new System.Drawing.Point(82, 22);
            this.txtResult_name.MaxLength = 7;
            this.txtResult_name.Name = "txtResult_name";
            this.txtResult_name.Size = new System.Drawing.Size(100, 28);
            this.txtResult_name.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 19);
            this.label20.TabIndex = 14;
            this.label20.Text = "教师名:";
            // 
            // DgvResult
            // 
            this.DgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResult.Location = new System.Drawing.Point(0, 56);
            this.DgvResult.Name = "DgvResult";
            this.DgvResult.RowTemplate.Height = 27;
            this.DgvResult.Size = new System.Drawing.Size(1091, 764);
            this.DgvResult.TabIndex = 0;
            // 
            // tpHistory
            // 
            this.tpHistory.Controls.Add(this.groupBox23);
            this.tpHistory.Location = new System.Drawing.Point(4, 31);
            this.tpHistory.Name = "tpHistory";
            this.tpHistory.Size = new System.Drawing.Size(1098, 827);
            this.tpHistory.TabIndex = 10;
            this.tpHistory.Text = "历史工作量";
            this.tpHistory.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox23.Controls.Add(this.btnDetail);
            this.groupBox23.Controls.Add(this.btnUpdateHistory);
            this.groupBox23.Controls.Add(this.btnSelectHistory);
            this.groupBox23.Controls.Add(this.label23);
            this.groupBox23.Controls.Add(this.label22);
            this.groupBox23.Controls.Add(this.cbox_TermH);
            this.groupBox23.Controls.Add(this.cbox_YearH);
            this.groupBox23.Controls.Add(this.label21);
            this.groupBox23.Controls.Add(this.DgvHistory);
            this.groupBox23.Location = new System.Drawing.Point(4, 4);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(1091, 820);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "历史工作量管理";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.Location = new System.Drawing.Point(1010, 21);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 28);
            this.btnDetail.TabIndex = 9;
            this.btnDetail.Text = "明细";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnUpdateHistory
            // 
            this.btnUpdateHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateHistory.Location = new System.Drawing.Point(929, 21);
            this.btnUpdateHistory.Name = "btnUpdateHistory";
            this.btnUpdateHistory.Size = new System.Drawing.Size(75, 28);
            this.btnUpdateHistory.TabIndex = 8;
            this.btnUpdateHistory.Text = "修改";
            this.btnUpdateHistory.UseVisualStyleBackColor = true;
            this.btnUpdateHistory.Click += new System.EventHandler(this.btnUpdateHistory_Click);
            // 
            // btnSelectHistory
            // 
            this.btnSelectHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectHistory.Location = new System.Drawing.Point(848, 21);
            this.btnSelectHistory.Name = "btnSelectHistory";
            this.btnSelectHistory.Size = new System.Drawing.Size(75, 28);
            this.btnSelectHistory.TabIndex = 7;
            this.btnSelectHistory.Text = "查询";
            this.btnSelectHistory.UseVisualStyleBackColor = true;
            this.btnSelectHistory.Click += new System.EventHandler(this.btnSelectHistory_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(290, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 19);
            this.label23.TabIndex = 6;
            this.label23.Text = "季";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(178, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 19);
            this.label22.TabIndex = 4;
            this.label22.Text = "年";
            // 
            // cbox_TermH
            // 
            this.cbox_TermH.BackColor = System.Drawing.SystemColors.Window;
            this.cbox_TermH.FormattingEnabled = true;
            this.cbox_TermH.Items.AddRange(new object[] {
            "秋",
            "春"});
            this.cbox_TermH.Location = new System.Drawing.Point(236, 28);
            this.cbox_TermH.Name = "cbox_TermH";
            this.cbox_TermH.Size = new System.Drawing.Size(48, 26);
            this.cbox_TermH.TabIndex = 3;
            // 
            // cbox_YearH
            // 
            this.cbox_YearH.BackColor = System.Drawing.SystemColors.Window;
            this.cbox_YearH.FormattingEnabled = true;
            this.cbox_YearH.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbox_YearH.Location = new System.Drawing.Point(107, 26);
            this.cbox_YearH.Name = "cbox_YearH";
            this.cbox_YearH.Size = new System.Drawing.Size(65, 26);
            this.cbox_YearH.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 19);
            this.label21.TabIndex = 1;
            this.label21.Text = "学期选择:";
            // 
            // DgvHistory
            // 
            this.DgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.Location = new System.Drawing.Point(0, 56);
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.RowTemplate.Height = 27;
            this.DgvHistory.Size = new System.Drawing.Size(1091, 767);
            this.DgvHistory.TabIndex = 0;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btnUpdate_Dean_allowance);
            this.groupBox20.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox20.Location = new System.Drawing.Point(6, 618);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(176, 109);
            this.groupBox20.TabIndex = 9;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "系主任津贴统计";
            // 
            // btnUpdate_Dean_allowance
            // 
            this.btnUpdate_Dean_allowance.Location = new System.Drawing.Point(40, 38);
            this.btnUpdate_Dean_allowance.Name = "btnUpdate_Dean_allowance";
            this.btnUpdate_Dean_allowance.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate_Dean_allowance.TabIndex = 1;
            this.btnUpdate_Dean_allowance.Text = "管 理";
            this.btnUpdate_Dean_allowance.UseVisualStyleBackColor = true;
            this.btnUpdate_Dean_allowance.Click += new System.EventHandler(this.btnUpdate_Dean_allowance_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 1003);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "哈尔滨理工大学工作量管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tpMaster.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaster)).EndInit();
            this.tpExperiment.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExperiment)).EndInit();
            this.tpPractice.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPractice)).EndInit();
            this.tpTheory.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTheory)).EndInit();
            this.tpClass.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClass)).EndInit();
            this.tpRank.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRank)).EndInit();
            this.tpDepart.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepart)).EndInit();
            this.tpTeacher.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTeacher)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDean_allowance.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDean_allowance)).EndInit();
            this.tpResult.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.tpHistory.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpdate_Teacher;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnUpdate_Theory;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnUpdate_Practice;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnUpdate_Class;
        private System.Windows.Forms.Button btnUpdate_Rank;
        private System.Windows.Forms.Button btnUpdate_Depart;
        private System.Windows.Forms.Button btnUpdate_Experiment;
        private System.Windows.Forms.Button btnUpdate_Master;
        private System.Windows.Forms.TabPage tpMaster;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.DataGridView DgvMaster;
        private System.Windows.Forms.TabPage tpExperiment;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnSelectPracticeTwo;
        private System.Windows.Forms.Button btnSelectPracticeOne;
        private System.Windows.Forms.TextBox txtPractice_Depart;
        private System.Windows.Forms.TextBox txtPractice_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvPractice;
        private System.Windows.Forms.TabPage tpTheory;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSelectTheoryTwo;
        private System.Windows.Forms.Button btnSelectTheoryOne;
        private System.Windows.Forms.TextBox txtTheory_Depart;
        private System.Windows.Forms.TextBox txtTheory_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvTheory;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.DataGridView DgvClass;
        private System.Windows.Forms.TabPage tpRank;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DataGridView DgvRank;
        private System.Windows.Forms.TabPage tpDepart;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button btnInsertDepart;
        private System.Windows.Forms.Button btnDeleteDepart;
        private System.Windows.Forms.Button btnUpdateDepart;
        private System.Windows.Forms.Button btnSelectDepartTwo;
        private System.Windows.Forms.Button btnSelectDepartOne;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepart_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvDepart;
        private System.Windows.Forms.TabPage tpTeacher;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnInsertTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnSelectTeacherTwo;
        private System.Windows.Forms.Button btnSelectTeacherOne;
        private System.Windows.Forms.TextBox txtTeacher_Depart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeacher_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertRank;
        private System.Windows.Forms.Button btnDeleteRank;
        private System.Windows.Forms.Button btnUpdateRank;
        private System.Windows.Forms.Button btnSelectRankTwo;
        private System.Windows.Forms.Button btnSelectRankOne;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRank_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClass_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInsertClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnSelectClassTwo;
        private System.Windows.Forms.Button btnSelectClassOne;
        private System.Windows.Forms.TextBox txtExperiment_Depart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExperiment_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnInsertExperiment;
        private System.Windows.Forms.Button btnDeleteExperiment;
        private System.Windows.Forms.Button btnUpdateExperiment;
        private System.Windows.Forms.Button btnSelectExperimentTwo;
        private System.Windows.Forms.Button btnSelectExperimentOne;
        private System.Windows.Forms.Button btnInsertMaster;
        private System.Windows.Forms.Button btnDeleteMaster;
        private System.Windows.Forms.Button btnUpdateMaster;
        private System.Windows.Forms.Button btnSelectMasterOne;
        private System.Windows.Forms.TextBox txtMaster_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCalculateTheory;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btnCalculatePractice;
        private System.Windows.Forms.Button btnUpdate_Result;
        private System.Windows.Forms.Button btnUpdate_Dean_allowance;
        private System.Windows.Forms.TabPage tpDean_allowance;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.TabPage tpHistory;
        private System.Windows.Forms.Button btnUpdate_History;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.DataGridView DgvDean_allowance;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.DataGridView DgvHistory;
        private System.Windows.Forms.Button btnInsertTheory;
        private System.Windows.Forms.Button btnDeleteTheory;
        private System.Windows.Forms.Button btnUpdateTheory;
        private System.Windows.Forms.Button btnInsertPractice;
        private System.Windows.Forms.Button btnDeletePractice;
        private System.Windows.Forms.Button btnUpdatePractice;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btn_SC;
        public System.Windows.Forms.DataGridView DgvExperiment;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tpPractice;
        private System.Windows.Forms.Button btnInsertDean;
        private System.Windows.Forms.Button btnDeleteDean;
        private System.Windows.Forms.Button btnUpdateDean;
        private System.Windows.Forms.Button btnSelectDeanOne;
        private System.Windows.Forms.TextBox txtDean_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCalculateResult;
        private System.Windows.Forms.Button btnInsertResult;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.Button btnUpdateResult;
        private System.Windows.Forms.Button btnSelectResultOne;
        private System.Windows.Forms.TextBox txtResult_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbox_TermH;
        private System.Windows.Forms.ComboBox cbox_YearH;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSelectHistory;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnSaveHistory;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.DataGridView DgvTeacher;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnUpdateHistory;
    }
}

