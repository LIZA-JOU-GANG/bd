namespace bd
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.otziviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet3 = new bd.Agenstvo_nedvijemostiDataSet3();
            this.otziviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet2 = new bd.Agenstvo_nedvijemostiDataSet2();
            this.agenstvo_nedvijemostiDataSet1 = new bd.Agenstvo_nedvijemostiDataSet1();
            this.otziviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otziviTableAdapter = new bd.Agenstvo_nedvijemostiDataSet1TableAdapters.OtziviTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.otziviTableAdapter1 = new bd.Agenstvo_nedvijemostiDataSet2TableAdapters.OtziviTableAdapter();
            this.otziviTableAdapter2 = new bd.Agenstvo_nedvijemostiDataSet3TableAdapters.OtziviTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otziviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otziviBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet4 = new bd.Agenstvo_nedvijemostiDataSet4();
            this.otziviTableAdapter3 = new bd.Agenstvo_nedvijemostiDataSet4TableAdapters.OtziviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отзывы на продавца";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 399);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 51);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(212, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 16);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вернуться обратно";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // otziviBindingSource2
            // 
            this.otziviBindingSource2.DataMember = "Otzivi";
            this.otziviBindingSource2.DataSource = this.agenstvo_nedvijemostiDataSet3;
            // 
            // agenstvo_nedvijemostiDataSet3
            // 
            this.agenstvo_nedvijemostiDataSet3.DataSetName = "Agenstvo_nedvijemostiDataSet3";
            this.agenstvo_nedvijemostiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otziviBindingSource1
            // 
            this.otziviBindingSource1.DataMember = "Otzivi";
            this.otziviBindingSource1.DataSource = this.agenstvo_nedvijemostiDataSet2;
            // 
            // agenstvo_nedvijemostiDataSet2
            // 
            this.agenstvo_nedvijemostiDataSet2.DataSetName = "Agenstvo_nedvijemostiDataSet2";
            this.agenstvo_nedvijemostiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenstvo_nedvijemostiDataSet1
            // 
            this.agenstvo_nedvijemostiDataSet1.DataSetName = "Agenstvo_nedvijemostiDataSet1";
            this.agenstvo_nedvijemostiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otziviBindingSource
            // 
            this.otziviBindingSource.DataMember = "Otzivi";
            this.otziviBindingSource.DataSource = this.agenstvo_nedvijemostiDataSet1;
            // 
            // otziviTableAdapter
            // 
            this.otziviTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 61);
            this.button1.TabIndex = 21;
            this.button1.Text = "Оставить отзыв";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // otziviTableAdapter1
            // 
            this.otziviTableAdapter1.ClearBeforeFill = true;
            // 
            // otziviTableAdapter2
            // 
            this.otziviTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.otziviDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otziviBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 243);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // otziviDataGridViewTextBoxColumn
            // 
            this.otziviDataGridViewTextBoxColumn.DataPropertyName = "Otzivi";
            this.otziviDataGridViewTextBoxColumn.HeaderText = "Otzivi";
            this.otziviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otziviDataGridViewTextBoxColumn.Name = "otziviDataGridViewTextBoxColumn";
            this.otziviDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // otziviBindingSource3
            // 
            this.otziviBindingSource3.DataMember = "Otzivi";
            this.otziviBindingSource3.DataSource = this.agenstvo_nedvijemostiDataSet4;
            // 
            // agenstvo_nedvijemostiDataSet4
            // 
            this.agenstvo_nedvijemostiDataSet4.DataSetName = "Agenstvo_nedvijemostiDataSet4";
            this.agenstvo_nedvijemostiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otziviTableAdapter3
            // 
            this.otziviTableAdapter3.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Otzivi";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otziviBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public Agenstvo_nedvijemostiDataSet1 agenstvo_nedvijemostiDataSet1;
        public System.Windows.Forms.BindingSource otziviBindingSource;
        public Agenstvo_nedvijemostiDataSet1TableAdapters.OtziviTableAdapter otziviTableAdapter;
        public System.Windows.Forms.Button button1;
        public Agenstvo_nedvijemostiDataSet2 agenstvo_nedvijemostiDataSet2;
        public System.Windows.Forms.BindingSource otziviBindingSource1;
        public Agenstvo_nedvijemostiDataSet2TableAdapters.OtziviTableAdapter otziviTableAdapter1;
        public Agenstvo_nedvijemostiDataSet3 agenstvo_nedvijemostiDataSet3;
        public System.Windows.Forms.BindingSource otziviBindingSource2;
        public Agenstvo_nedvijemostiDataSet3TableAdapters.OtziviTableAdapter otziviTableAdapter2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public Agenstvo_nedvijemostiDataSet4 agenstvo_nedvijemostiDataSet4;
        public System.Windows.Forms.BindingSource otziviBindingSource3;
        public Agenstvo_nedvijemostiDataSet4TableAdapters.OtziviTableAdapter otziviTableAdapter3;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn otziviDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
    }
}