namespace bd
{
    partial class Rieltori
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
            this.iDRealtorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet8 = new bd.Agenstvo_nedvijemostiDataSet8();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.realtorTableAdapter = new bd.Agenstvo_nedvijemostiDataSet8TableAdapters.realtorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRealtorDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn,
            this.contactInformationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.realtorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 223);
            this.dataGridView1.TabIndex = 20;
            // 
            // iDRealtorDataGridViewTextBoxColumn
            // 
            this.iDRealtorDataGridViewTextBoxColumn.DataPropertyName = "ID realtor";
            this.iDRealtorDataGridViewTextBoxColumn.HeaderText = "ID realtor";
            this.iDRealtorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRealtorDataGridViewTextBoxColumn.Name = "iDRealtorDataGridViewTextBoxColumn";
            this.iDRealtorDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "passport data";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "passport data";
            this.passportDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            this.passportDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactInformationDataGridViewTextBoxColumn
            // 
            this.contactInformationDataGridViewTextBoxColumn.DataPropertyName = "contact information";
            this.contactInformationDataGridViewTextBoxColumn.HeaderText = "contact information";
            this.contactInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactInformationDataGridViewTextBoxColumn.Name = "contactInformationDataGridViewTextBoxColumn";
            this.contactInformationDataGridViewTextBoxColumn.Width = 125;
            // 
            // realtorBindingSource
            // 
            this.realtorBindingSource.DataMember = "realtor";
            this.realtorBindingSource.DataSource = this.agenstvo_nedvijemostiDataSet8;
            // 
            // agenstvo_nedvijemostiDataSet8
            // 
            this.agenstvo_nedvijemostiDataSet8.DataSetName = "Agenstvo_nedvijemostiDataSet8";
            this.agenstvo_nedvijemostiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 72);
            this.button2.TabIndex = 19;
            this.button2.Text = "Поиск из списка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 72);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить нового";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(164, 432);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вернуться обратно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Список доступных риелторов";
            // 
            // realtorTableAdapter
            // 
            this.realtorTableAdapter.ClearBeforeFill = true;
            // 
            // Rieltori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(498, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Rieltori";
            this.Text = "SpisokRieltorov";
            this.Load += new System.EventHandler(this.список_доступных_риелторов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Agenstvo_nedvijemostiDataSet8 agenstvo_nedvijemostiDataSet8;
        private System.Windows.Forms.BindingSource realtorBindingSource;
        private Agenstvo_nedvijemostiDataSet8TableAdapters.realtorTableAdapter realtorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRealtorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInformationDataGridViewTextBoxColumn;
    }
}