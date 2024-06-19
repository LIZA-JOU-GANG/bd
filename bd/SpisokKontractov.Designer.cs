namespace bd
{
    partial class SpisokKontractov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRealtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOwnersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRealtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet6 = new bd.Agenstvo_nedvijemostiDataSet6();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.contractTableAdapter = new bd.Agenstvo_nedvijemostiDataSet6TableAdapters.ContractTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDContractDataGridViewTextBoxColumn,
            this.iDRealtyDataGridViewTextBoxColumn,
            this.iDOwnersDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn,
            this.iDRealtorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 223);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDContractDataGridViewTextBoxColumn
            // 
            this.iDContractDataGridViewTextBoxColumn.DataPropertyName = "ID Contract";
            this.iDContractDataGridViewTextBoxColumn.HeaderText = "ID Contract";
            this.iDContractDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDContractDataGridViewTextBoxColumn.Name = "iDContractDataGridViewTextBoxColumn";
            this.iDContractDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDContractDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRealtyDataGridViewTextBoxColumn
            // 
            this.iDRealtyDataGridViewTextBoxColumn.DataPropertyName = "ID Realty";
            this.iDRealtyDataGridViewTextBoxColumn.HeaderText = "ID Realty";
            this.iDRealtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRealtyDataGridViewTextBoxColumn.Name = "iDRealtyDataGridViewTextBoxColumn";
            this.iDRealtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDOwnersDataGridViewTextBoxColumn
            // 
            this.iDOwnersDataGridViewTextBoxColumn.DataPropertyName = "ID Owners";
            this.iDOwnersDataGridViewTextBoxColumn.HeaderText = "ID Owners";
            this.iDOwnersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDOwnersDataGridViewTextBoxColumn.Name = "iDOwnersDataGridViewTextBoxColumn";
            this.iDOwnersDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID Client";
            this.iDClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRealtorDataGridViewTextBoxColumn
            // 
            this.iDRealtorDataGridViewTextBoxColumn.DataPropertyName = "ID Realtor";
            this.iDRealtorDataGridViewTextBoxColumn.HeaderText = "ID Realtor";
            this.iDRealtorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRealtorDataGridViewTextBoxColumn.Name = "iDRealtorDataGridViewTextBoxColumn";
            this.iDRealtorDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.agenstvo_nedvijemostiDataSet6;
            // 
            // agenstvo_nedvijemostiDataSet6
            // 
            this.agenstvo_nedvijemostiDataSet6.DataSetName = "Agenstvo_nedvijemostiDataSet6";
            this.agenstvo_nedvijemostiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 72);
            this.button2.TabIndex = 24;
            this.button2.Text = "Поиск из списка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 72);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить новый контракт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(190, 429);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вернуться обратно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Список контрактов";
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // SpisokKontractov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "SpisokKontractov";
            this.Text = "SpisokKontractov";
            this.Load += new System.EventHandler(this.SpisokKontractov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label label1;
        public Agenstvo_nedvijemostiDataSet6 agenstvo_nedvijemostiDataSet6;
        public System.Windows.Forms.BindingSource contractBindingSource;
        public Agenstvo_nedvijemostiDataSet6TableAdapters.ContractTableAdapter contractTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDContractDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDRealtyDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDOwnersDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDRealtorDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
    }
}