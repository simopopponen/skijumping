namespace SKiJumping
{
    partial class frmHill
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
            this.dataGridHill = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skiJumpingDataSet = new SKiJumping.SkiJumpingDataSet();
            this.hillsTableAdapter = new SKiJumping.SkiJumpingDataSetTableAdapters.HillsTableAdapter();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHill
            // 
            this.dataGridHill.AllowUserToAddRows = false;
            this.dataGridHill.AllowUserToDeleteRows = false;
            this.dataGridHill.AutoGenerateColumns = false;
            this.dataGridHill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.kPointDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn});
            this.dataGridHill.DataSource = this.hillsBindingSource;
            this.dataGridHill.Location = new System.Drawing.Point(37, 47);
            this.dataGridHill.Name = "dataGridHill";
            this.dataGridHill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHill.Size = new System.Drawing.Size(443, 150);
            this.dataGridHill.TabIndex = 0;
            this.dataGridHill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHill_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // kPointDataGridViewTextBoxColumn
            // 
            this.kPointDataGridViewTextBoxColumn.DataPropertyName = "KPoint";
            this.kPointDataGridViewTextBoxColumn.HeaderText = "KPoint";
            this.kPointDataGridViewTextBoxColumn.Name = "kPointDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            // 
            // hillsBindingSource
            // 
            this.hillsBindingSource.DataMember = "Hills";
            this.hillsBindingSource.DataSource = this.skiJumpingDataSet;
            // 
            // skiJumpingDataSet
            // 
            this.skiJumpingDataSet.DataSetName = "SkiJumpingDataSet";
            this.skiJumpingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hillsTableAdapter
            // 
            this.hillsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(37, 282);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Valitse";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmHill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 376);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridHill);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHill";
            this.Text = "Hills";
            this.Load += new System.EventHandler(this.frmHill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiJumpingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHill;
        private SkiJumpingDataSet skiJumpingDataSet;
        private System.Windows.Forms.BindingSource hillsBindingSource;
        private SkiJumpingDataSetTableAdapters.HillsTableAdapter hillsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
    }
}