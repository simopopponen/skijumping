namespace SKiJumping
{
    partial class FrmSkijumping
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
            this.components = new System.ComponentModel.Container();
            this.grpJudge = new System.Windows.Forms.GroupBox();
            this.nudJudge5 = new System.Windows.Forms.NumericUpDown();
            this.nudJudge4 = new System.Windows.Forms.NumericUpDown();
            this.nudJudge3 = new System.Windows.Forms.NumericUpDown();
            this.nudJudge2 = new System.Windows.Forms.NumericUpDown();
            this.nudJudge1 = new System.Windows.Forms.NumericUpDown();
            this.lblJudgePoints = new System.Windows.Forms.Label();
            this.txtJudgePoints = new System.Windows.Forms.TextBox();
            this.lblJudge5 = new System.Windows.Forms.Label();
            this.lblJudge4 = new System.Windows.Forms.Label();
            this.lblJudge3 = new System.Windows.Forms.Label();
            this.lblJudge2 = new System.Windows.Forms.Label();
            this.lblJudge1 = new System.Windows.Forms.Label();
            this.grpSolidData = new System.Windows.Forms.GroupBox();
            this.lblHillName = new System.Windows.Forms.Label();
            this.lblHill = new System.Windows.Forms.Label();
            this.txtcreditscore = new System.Windows.Forms.TextBox();
            this.btnHill = new System.Windows.Forms.Button();
            this.txtkpoint = new System.Windows.Forms.TextBox();
            this.lblcreditscore = new System.Windows.Forms.Label();
            this.lblkpoint = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLengthpoints = new System.Windows.Forms.Label();
            this.txtLengthpoints = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.grpStageImpact = new System.Windows.Forms.GroupBox();
            this.lblStagepoints = new System.Windows.Forms.Label();
            this.txtStagepoints = new System.Windows.Forms.TextBox();
            this.lblStageImpact = new System.Windows.Forms.Label();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.grpWind = new System.Windows.Forms.GroupBox();
            this.lblWindpoints = new System.Windows.Forms.Label();
            this.txtWindpoints = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxJumper = new System.Windows.Forms.GroupBox();
            this.cboJumper = new System.Windows.Forms.ComboBox();
            this.rdbtnRound2 = new System.Windows.Forms.RadioButton();
            this.rdbtnRound1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skiJumpingDataSet = new SKiJumping.SkiJumpingDataSet();
            this.skiJumpingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skiJumpingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.openJumperDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnReadJumpers = new System.Windows.Forms.Button();
            this.grpRound = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpJudge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge1)).BeginInit();
            this.grpSolidData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpStageImpact.SuspendLayout();
            this.grpWind.SuspendLayout();
            this.grpBoxJumper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSetBindingSource1)).BeginInit();
            this.grpRound.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpJudge
            // 
            this.grpJudge.Controls.Add(this.nudJudge5);
            this.grpJudge.Controls.Add(this.nudJudge4);
            this.grpJudge.Controls.Add(this.nudJudge3);
            this.grpJudge.Controls.Add(this.nudJudge2);
            this.grpJudge.Controls.Add(this.nudJudge1);
            this.grpJudge.Controls.Add(this.lblJudgePoints);
            this.grpJudge.Controls.Add(this.txtJudgePoints);
            this.grpJudge.Controls.Add(this.lblJudge5);
            this.grpJudge.Controls.Add(this.lblJudge4);
            this.grpJudge.Controls.Add(this.lblJudge3);
            this.grpJudge.Controls.Add(this.lblJudge2);
            this.grpJudge.Controls.Add(this.lblJudge1);
            this.grpJudge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpJudge.Location = new System.Drawing.Point(22, 248);
            this.grpJudge.Name = "grpJudge";
            this.grpJudge.Size = new System.Drawing.Size(393, 102);
            this.grpJudge.TabIndex = 4;
            this.grpJudge.TabStop = false;
            this.grpJudge.Text = "Tuomarien pisteet:";
            // 
            // nudJudge5
            // 
            this.nudJudge5.DecimalPlaces = 1;
            this.nudJudge5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudJudge5.Location = new System.Drawing.Point(245, 49);
            this.nudJudge5.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudJudge5.Name = "nudJudge5";
            this.nudJudge5.Size = new System.Drawing.Size(42, 20);
            this.nudJudge5.TabIndex = 10;
            this.nudJudge5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudJudge4
            // 
            this.nudJudge4.DecimalPlaces = 1;
            this.nudJudge4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudJudge4.Location = new System.Drawing.Point(186, 49);
            this.nudJudge4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudJudge4.Name = "nudJudge4";
            this.nudJudge4.Size = new System.Drawing.Size(42, 20);
            this.nudJudge4.TabIndex = 9;
            this.nudJudge4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudJudge3
            // 
            this.nudJudge3.DecimalPlaces = 1;
            this.nudJudge3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudJudge3.Location = new System.Drawing.Point(128, 50);
            this.nudJudge3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudJudge3.Name = "nudJudge3";
            this.nudJudge3.Size = new System.Drawing.Size(42, 20);
            this.nudJudge3.TabIndex = 8;
            this.nudJudge3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudJudge2
            // 
            this.nudJudge2.DecimalPlaces = 1;
            this.nudJudge2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudJudge2.Location = new System.Drawing.Point(67, 49);
            this.nudJudge2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudJudge2.Name = "nudJudge2";
            this.nudJudge2.Size = new System.Drawing.Size(42, 20);
            this.nudJudge2.TabIndex = 7;
            this.nudJudge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudJudge1
            // 
            this.nudJudge1.DecimalPlaces = 1;
            this.nudJudge1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudJudge1.Location = new System.Drawing.Point(9, 50);
            this.nudJudge1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudJudge1.Name = "nudJudge1";
            this.nudJudge1.Size = new System.Drawing.Size(42, 20);
            this.nudJudge1.TabIndex = 6;
            this.nudJudge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJudgePoints
            // 
            this.lblJudgePoints.AutoSize = true;
            this.lblJudgePoints.Location = new System.Drawing.Point(302, 16);
            this.lblJudgePoints.Name = "lblJudgePoints";
            this.lblJudgePoints.Size = new System.Drawing.Size(79, 13);
            this.lblJudgePoints.TabIndex = 11;
            this.lblJudgePoints.Text = "Tuomaripisteet:";
            // 
            // txtJudgePoints
            // 
            this.txtJudgePoints.Enabled = false;
            this.txtJudgePoints.Location = new System.Drawing.Point(305, 49);
            this.txtJudgePoints.Name = "txtJudgePoints";
            this.txtJudgePoints.Size = new System.Drawing.Size(76, 20);
            this.txtJudgePoints.TabIndex = 1;
            this.txtJudgePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJudge5
            // 
            this.lblJudge5.AutoSize = true;
            this.lblJudge5.Location = new System.Drawing.Point(242, 16);
            this.lblJudge5.Name = "lblJudge5";
            this.lblJudge5.Size = new System.Drawing.Size(57, 13);
            this.lblJudge5.TabIndex = 8;
            this.lblJudge5.Text = "Tuomari 5:";
            // 
            // lblJudge4
            // 
            this.lblJudge4.AutoSize = true;
            this.lblJudge4.Location = new System.Drawing.Point(183, 16);
            this.lblJudge4.Name = "lblJudge4";
            this.lblJudge4.Size = new System.Drawing.Size(57, 13);
            this.lblJudge4.TabIndex = 6;
            this.lblJudge4.Text = "Tuomari 4:";
            // 
            // lblJudge3
            // 
            this.lblJudge3.AutoSize = true;
            this.lblJudge3.Location = new System.Drawing.Point(125, 16);
            this.lblJudge3.Name = "lblJudge3";
            this.lblJudge3.Size = new System.Drawing.Size(57, 13);
            this.lblJudge3.TabIndex = 4;
            this.lblJudge3.Text = "Tuomari 3:";
            // 
            // lblJudge2
            // 
            this.lblJudge2.AutoSize = true;
            this.lblJudge2.Location = new System.Drawing.Point(64, 16);
            this.lblJudge2.Name = "lblJudge2";
            this.lblJudge2.Size = new System.Drawing.Size(57, 13);
            this.lblJudge2.TabIndex = 2;
            this.lblJudge2.Text = "Tuomari 2:";
            // 
            // lblJudge1
            // 
            this.lblJudge1.AutoSize = true;
            this.lblJudge1.Location = new System.Drawing.Point(6, 16);
            this.lblJudge1.Name = "lblJudge1";
            this.lblJudge1.Size = new System.Drawing.Size(57, 13);
            this.lblJudge1.TabIndex = 0;
            this.lblJudge1.Text = "Tuomari 1:";
            // 
            // grpSolidData
            // 
            this.grpSolidData.Controls.Add(this.lblHillName);
            this.grpSolidData.Controls.Add(this.lblHill);
            this.grpSolidData.Controls.Add(this.txtcreditscore);
            this.grpSolidData.Controls.Add(this.btnHill);
            this.grpSolidData.Controls.Add(this.txtkpoint);
            this.grpSolidData.Controls.Add(this.lblcreditscore);
            this.grpSolidData.Controls.Add(this.lblkpoint);
            this.grpSolidData.Location = new System.Drawing.Point(22, 21);
            this.grpSolidData.Name = "grpSolidData";
            this.grpSolidData.Size = new System.Drawing.Size(393, 123);
            this.grpSolidData.TabIndex = 0;
            this.grpSolidData.TabStop = false;
            this.grpSolidData.Text = "Lähtöarvot:";
            // 
            // lblHillName
            // 
            this.lblHillName.AutoSize = true;
            this.lblHillName.Location = new System.Drawing.Point(21, 56);
            this.lblHillName.Name = "lblHillName";
            this.lblHillName.Size = new System.Drawing.Size(30, 13);
            this.lblHillName.TabIndex = 3;
            this.lblHillName.Text = "Lahti";
            // 
            // lblHill
            // 
            this.lblHill.AutoSize = true;
            this.lblHill.Location = new System.Drawing.Point(21, 20);
            this.lblHill.Name = "lblHill";
            this.lblHill.Size = new System.Drawing.Size(33, 13);
            this.lblHill.TabIndex = 2;
            this.lblHill.Text = "Mäki:";
            // 
            // txtcreditscore
            // 
            this.txtcreditscore.Location = new System.Drawing.Point(230, 56);
            this.txtcreditscore.Name = "txtcreditscore";
            this.txtcreditscore.Size = new System.Drawing.Size(62, 20);
            this.txtcreditscore.TabIndex = 1;
            this.txtcreditscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHill
            // 
            this.btnHill.Location = new System.Drawing.Point(18, 86);
            this.btnHill.Margin = new System.Windows.Forms.Padding(2);
            this.btnHill.Name = "btnHill";
            this.btnHill.Size = new System.Drawing.Size(91, 23);
            this.btnHill.TabIndex = 13;
            this.btnHill.Text = "Mäen valinta";
            this.btnHill.UseVisualStyleBackColor = true;
            this.btnHill.Click += new System.EventHandler(this.btnHill_Click);
            // 
            // txtkpoint
            // 
            this.txtkpoint.Location = new System.Drawing.Point(155, 56);
            this.txtkpoint.Name = "txtkpoint";
            this.txtkpoint.Size = new System.Drawing.Size(62, 20);
            this.txtkpoint.TabIndex = 0;
            this.txtkpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcreditscore
            // 
            this.lblcreditscore.AutoSize = true;
            this.lblcreditscore.Location = new System.Drawing.Point(227, 20);
            this.lblcreditscore.Name = "lblcreditscore";
            this.lblcreditscore.Size = new System.Drawing.Size(110, 13);
            this.lblcreditscore.TabIndex = 1;
            this.lblcreditscore.Text = "Hyvityspisteen määrä:";
            // 
            // lblkpoint
            // 
            this.lblkpoint.AutoSize = true;
            this.lblkpoint.Location = new System.Drawing.Point(152, 20);
            this.lblkpoint.Name = "lblkpoint";
            this.lblkpoint.Size = new System.Drawing.Size(42, 13);
            this.lblkpoint.TabIndex = 0;
            this.lblkpoint.Text = "K-piste:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(22, 543);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Laske";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalPoints);
            this.groupBox1.Location = new System.Drawing.Point(22, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yhteispisteet:";
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.Enabled = false;
            this.txtTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPoints.Location = new System.Drawing.Point(343, 19);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.Size = new System.Drawing.Size(114, 29);
            this.txtTotalPoints.TabIndex = 11;
            this.txtTotalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPoints.TextChanged += new System.EventHandler(this.txtTotalPoints_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLengthpoints);
            this.groupBox2.Controls.Add(this.txtLengthpoints);
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Location = new System.Drawing.Point(427, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hypyn pituus:";
            // 
            // lblLengthpoints
            // 
            this.lblLengthpoints.AutoSize = true;
            this.lblLengthpoints.Location = new System.Drawing.Point(172, 16);
            this.lblLengthpoints.Name = "lblLengthpoints";
            this.lblLengthpoints.Size = new System.Drawing.Size(70, 13);
            this.lblLengthpoints.TabIndex = 12;
            this.lblLengthpoints.Text = "Pituuspisteet:";
            // 
            // txtLengthpoints
            // 
            this.txtLengthpoints.Enabled = false;
            this.txtLengthpoints.Location = new System.Drawing.Point(175, 39);
            this.txtLengthpoints.Name = "txtLengthpoints";
            this.txtLengthpoints.Size = new System.Drawing.Size(62, 20);
            this.txtLengthpoints.TabIndex = 1;
            this.txtLengthpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(12, 39);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(62, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStage
            // 
            this.txtStage.Location = new System.Drawing.Point(12, 56);
            this.txtStage.Name = "txtStage";
            this.txtStage.Size = new System.Drawing.Size(62, 20);
            this.txtStage.TabIndex = 2;
            this.txtStage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(6, 20);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(57, 13);
            this.lblStage.TabIndex = 5;
            this.lblStage.Text = "Lähtölava:";
            // 
            // grpStageImpact
            // 
            this.grpStageImpact.Controls.Add(this.lblStagepoints);
            this.grpStageImpact.Controls.Add(this.txtStagepoints);
            this.grpStageImpact.Controls.Add(this.lblStageImpact);
            this.grpStageImpact.Controls.Add(this.txtMeters);
            this.grpStageImpact.Controls.Add(this.lblStage);
            this.grpStageImpact.Controls.Add(this.txtStage);
            this.grpStageImpact.Location = new System.Drawing.Point(427, 21);
            this.grpStageImpact.Name = "grpStageImpact";
            this.grpStageImpact.Size = new System.Drawing.Size(268, 123);
            this.grpStageImpact.TabIndex = 1;
            this.grpStageImpact.TabStop = false;
            this.grpStageImpact.Text = "Lähtölavan vaikutus:";
            // 
            // lblStagepoints
            // 
            this.lblStagepoints.AutoSize = true;
            this.lblStagepoints.Location = new System.Drawing.Point(172, 20);
            this.lblStagepoints.Name = "lblStagepoints";
            this.lblStagepoints.Size = new System.Drawing.Size(88, 13);
            this.lblStagepoints.TabIndex = 9;
            this.lblStagepoints.Text = "Lähtölavapisteet:";
            // 
            // txtStagepoints
            // 
            this.txtStagepoints.Enabled = false;
            this.txtStagepoints.Location = new System.Drawing.Point(175, 56);
            this.txtStagepoints.Name = "txtStagepoints";
            this.txtStagepoints.Size = new System.Drawing.Size(62, 20);
            this.txtStagepoints.TabIndex = 8;
            this.txtStagepoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStageImpact
            // 
            this.lblStageImpact.AutoSize = true;
            this.lblStageImpact.Location = new System.Drawing.Point(91, 20);
            this.lblStageImpact.Name = "lblStageImpact";
            this.lblStageImpact.Size = new System.Drawing.Size(83, 13);
            this.lblStageImpact.TabIndex = 7;
            this.lblStageImpact.Text = "Lavan vaikutus:";
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(91, 56);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(62, 20);
            this.txtMeters.TabIndex = 3;
            this.txtMeters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWind
            // 
            this.grpWind.Controls.Add(this.lblWindpoints);
            this.grpWind.Controls.Add(this.txtWindpoints);
            this.grpWind.Controls.Add(this.txtWind);
            this.grpWind.Location = new System.Drawing.Point(427, 150);
            this.grpWind.Name = "grpWind";
            this.grpWind.Size = new System.Drawing.Size(268, 85);
            this.grpWind.TabIndex = 3;
            this.grpWind.TabStop = false;
            this.grpWind.Text = "Tuulen vaikutus:";
            // 
            // lblWindpoints
            // 
            this.lblWindpoints.AutoSize = true;
            this.lblWindpoints.Location = new System.Drawing.Point(173, 16);
            this.lblWindpoints.Name = "lblWindpoints";
            this.lblWindpoints.Size = new System.Drawing.Size(64, 13);
            this.lblWindpoints.TabIndex = 11;
            this.lblWindpoints.Text = "Tuulipisteet:";
            // 
            // txtWindpoints
            // 
            this.txtWindpoints.Enabled = false;
            this.txtWindpoints.Location = new System.Drawing.Point(175, 39);
            this.txtWindpoints.Name = "txtWindpoints";
            this.txtWindpoints.Size = new System.Drawing.Size(62, 20);
            this.txtWindpoints.TabIndex = 10;
            this.txtWindpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(12, 39);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(62, 20);
            this.txtWind.TabIndex = 5;
            this.txtWind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(690, 543);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBoxJumper
            // 
            this.grpBoxJumper.Controls.Add(this.cboJumper);
            this.grpBoxJumper.Location = new System.Drawing.Point(22, 150);
            this.grpBoxJumper.Name = "grpBoxJumper";
            this.grpBoxJumper.Size = new System.Drawing.Size(393, 85);
            this.grpBoxJumper.TabIndex = 16;
            this.grpBoxJumper.TabStop = false;
            this.grpBoxJumper.Text = "Hyppääjä:";
            // 
            // cboJumper
            // 
            this.cboJumper.FormattingEnabled = true;
            this.cboJumper.Location = new System.Drawing.Point(9, 19);
            this.cboJumper.Name = "cboJumper";
            this.cboJumper.Size = new System.Drawing.Size(372, 21);
            this.cboJumper.TabIndex = 0;
            // 
            // rdbtnRound2
            // 
            this.rdbtnRound2.AutoSize = true;
            this.rdbtnRound2.Location = new System.Drawing.Point(6, 106);
            this.rdbtnRound2.Name = "rdbtnRound2";
            this.rdbtnRound2.Size = new System.Drawing.Size(66, 17);
            this.rdbtnRound2.TabIndex = 2;
            this.rdbtnRound2.Text = "Kierros 2";
            this.rdbtnRound2.UseVisualStyleBackColor = true;
            this.rdbtnRound2.Click += new System.EventHandler(this.rdbtnRound2_Click);
            // 
            // rdbtnRound1
            // 
            this.rdbtnRound1.AutoSize = true;
            this.rdbtnRound1.Checked = true;
            this.rdbtnRound1.Location = new System.Drawing.Point(6, 28);
            this.rdbtnRound1.Name = "rdbtnRound1";
            this.rdbtnRound1.Size = new System.Drawing.Size(66, 17);
            this.rdbtnRound1.TabIndex = 1;
            this.rdbtnRound1.TabStop = true;
            this.rdbtnRound1.Text = "Kierros 1";
            this.rdbtnRound1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 100);
            this.dataGridView1.TabIndex = 17;
            // 
            // skiJumpingDataSet
            // 
            this.skiJumpingDataSet.DataSetName = "SkiJumpingDataSet";
            this.skiJumpingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skiJumpingDataSetBindingSource
            // 
            this.skiJumpingDataSetBindingSource.DataSource = this.skiJumpingDataSet;
            this.skiJumpingDataSetBindingSource.Position = 0;
            // 
            // skiJumpingDataSetBindingSource1
            // 
            this.skiJumpingDataSetBindingSource1.DataSource = this.skiJumpingDataSet;
            this.skiJumpingDataSetBindingSource1.Position = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(379, 543);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Tyhjennä tiedot";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openJumperDialog
            // 
            this.openJumperDialog.FileName = "openJumperDialog";
            // 
            // btnReadJumpers
            // 
            this.btnReadJumpers.Location = new System.Drawing.Point(486, 542);
            this.btnReadJumpers.Name = "btnReadJumpers";
            this.btnReadJumpers.Size = new System.Drawing.Size(94, 23);
            this.btnReadJumpers.TabIndex = 19;
            this.btnReadJumpers.Text = "Lue hyppääjät...";
            this.btnReadJumpers.UseVisualStyleBackColor = true;
            this.btnReadJumpers.Click += new System.EventHandler(this.btnReadJumpers_Click);
            // 
            // grpRound
            // 
            this.grpRound.Controls.Add(this.rdbtnRound1);
            this.grpRound.Controls.Add(this.rdbtnRound2);
            this.grpRound.Location = new System.Drawing.Point(701, 21);
            this.grpRound.Name = "grpRound";
            this.grpRound.Size = new System.Drawing.Size(116, 329);
            this.grpRound.TabIndex = 3;
            this.grpRound.TabStop = false;
            this.grpRound.Text = "Kierros";
            // 
            // FrmSkijumping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 587);
            this.Controls.Add(this.grpRound);
            this.Controls.Add(this.btnReadJumpers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBoxJumper);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpWind);
            this.Controls.Add(this.grpStageImpact);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpSolidData);
            this.Controls.Add(this.grpJudge);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "appl");
            this.Name = "FrmSkijumping";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Mäkihyppy";
            this.grpJudge.ResumeLayout(false);
            this.grpJudge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJudge1)).EndInit();
            this.grpSolidData.ResumeLayout(false);
            this.grpSolidData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpStageImpact.ResumeLayout(false);
            this.grpStageImpact.PerformLayout();
            this.grpWind.ResumeLayout(false);
            this.grpWind.PerformLayout();
            this.grpBoxJumper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSetBindingSource1)).EndInit();
            this.grpRound.ResumeLayout(false);
            this.grpRound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpJudge;
        private System.Windows.Forms.Label lblJudge5;
        private System.Windows.Forms.Label lblJudge4;
        private System.Windows.Forms.Label lblJudge3;
        private System.Windows.Forms.Label lblJudge2;
        private System.Windows.Forms.Label lblJudge1;
        private System.Windows.Forms.GroupBox grpSolidData;
        private System.Windows.Forms.TextBox txtcreditscore;
        private System.Windows.Forms.TextBox txtkpoint;
        private System.Windows.Forms.Label lblcreditscore;
        private System.Windows.Forms.Label lblkpoint;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.GroupBox grpStageImpact;
        private System.Windows.Forms.Label lblStageImpact;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.GroupBox grpWind;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.Button btnHill;
        private System.Windows.Forms.Label lblJudgePoints;
        private System.Windows.Forms.TextBox txtJudgePoints;
        private System.Windows.Forms.Label lblLengthpoints;
        private System.Windows.Forms.TextBox txtLengthpoints;
        private System.Windows.Forms.Label lblStagepoints;
        private System.Windows.Forms.TextBox txtStagepoints;
        private System.Windows.Forms.Label lblWindpoints;
        private System.Windows.Forms.TextBox txtWindpoints;
        private System.Windows.Forms.NumericUpDown nudJudge5;
        private System.Windows.Forms.NumericUpDown nudJudge4;
        private System.Windows.Forms.NumericUpDown nudJudge3;
        private System.Windows.Forms.NumericUpDown nudJudge2;
        private System.Windows.Forms.NumericUpDown nudJudge1;
        private System.Windows.Forms.Label lblHillName;
        private System.Windows.Forms.Label lblHill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxJumper;
        private System.Windows.Forms.ComboBox cboJumper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource skiJumpingDataSetBindingSource;
        private SkiJumpingDataSet skiJumpingDataSet;
        private System.Windows.Forms.BindingSource skiJumpingDataSetBindingSource1;
        private System.Windows.Forms.RadioButton rdbtnRound2;
        private System.Windows.Forms.RadioButton rdbtnRound1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openJumperDialog;
        private System.Windows.Forms.Button btnReadJumpers;
        private System.Windows.Forms.GroupBox grpRound;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

