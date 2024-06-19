namespace bd
{
    partial class Kvartiri
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
            this.iDRealtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfPropertyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livingAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonresidentialAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favoriteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.theRealEstateObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenstvo_nedvijemostiDataSet5 = new bd.Agenstvo_nedvijemostiDataSet5();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.the_real_estate_objectTableAdapter = new bd.Agenstvo_nedvijemostiDataSet5TableAdapters.the_real_estate_objectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theRealEstateObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRealtyDataGridViewTextBoxColumn,
            this.typeOfPropertyDataGridViewTextBoxColumn,
            this.livingAreaDataGridViewTextBoxColumn,
            this.repairDataGridViewTextBoxColumn,
            this.nonresidentialAreaDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.numberOfRoomsDataGridViewTextBoxColumn,
            this.favoriteDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.theRealEstateObjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 223);
            this.dataGridView1.TabIndex = 15;
            // 
            // iDRealtyDataGridViewTextBoxColumn
            // 
            this.iDRealtyDataGridViewTextBoxColumn.DataPropertyName = "ID realty";
            this.iDRealtyDataGridViewTextBoxColumn.HeaderText = "ID realty";
            this.iDRealtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRealtyDataGridViewTextBoxColumn.Name = "iDRealtyDataGridViewTextBoxColumn";
            this.iDRealtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRealtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeOfPropertyDataGridViewTextBoxColumn
            // 
            this.typeOfPropertyDataGridViewTextBoxColumn.DataPropertyName = "type of property";
            this.typeOfPropertyDataGridViewTextBoxColumn.HeaderText = "type of property";
            this.typeOfPropertyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeOfPropertyDataGridViewTextBoxColumn.Name = "typeOfPropertyDataGridViewTextBoxColumn";
            this.typeOfPropertyDataGridViewTextBoxColumn.Width = 125;
            // 
            // livingAreaDataGridViewTextBoxColumn
            // 
            this.livingAreaDataGridViewTextBoxColumn.DataPropertyName = "living area";
            this.livingAreaDataGridViewTextBoxColumn.HeaderText = "living area";
            this.livingAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livingAreaDataGridViewTextBoxColumn.Name = "livingAreaDataGridViewTextBoxColumn";
            this.livingAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // repairDataGridViewTextBoxColumn
            // 
            this.repairDataGridViewTextBoxColumn.DataPropertyName = "repair";
            this.repairDataGridViewTextBoxColumn.HeaderText = "repair";
            this.repairDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repairDataGridViewTextBoxColumn.Name = "repairDataGridViewTextBoxColumn";
            this.repairDataGridViewTextBoxColumn.Width = 125;
            // 
            // nonresidentialAreaDataGridViewTextBoxColumn
            // 
            this.nonresidentialAreaDataGridViewTextBoxColumn.DataPropertyName = "non-residential area";
            this.nonresidentialAreaDataGridViewTextBoxColumn.HeaderText = "non-residential area";
            this.nonresidentialAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nonresidentialAreaDataGridViewTextBoxColumn.Name = "nonresidentialAreaDataGridViewTextBoxColumn";
            this.nonresidentialAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "floor";
            this.floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfRoomsDataGridViewTextBoxColumn
            // 
            this.numberOfRoomsDataGridViewTextBoxColumn.DataPropertyName = "number of rooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.HeaderText = "number of rooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfRoomsDataGridViewTextBoxColumn.Name = "numberOfRoomsDataGridViewTextBoxColumn";
            this.numberOfRoomsDataGridViewTextBoxColumn.Width = 125;
            // 
            // favoriteDataGridViewCheckBoxColumn
            // 
            this.favoriteDataGridViewCheckBoxColumn.DataPropertyName = "favorite";
            this.favoriteDataGridViewCheckBoxColumn.HeaderText = "favorite";
            this.favoriteDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.favoriteDataGridViewCheckBoxColumn.Name = "favoriteDataGridViewCheckBoxColumn";
            this.favoriteDataGridViewCheckBoxColumn.Width = 125;
            // 
            // theRealEstateObjectBindingSource
            // 
            this.theRealEstateObjectBindingSource.DataMember = "the real estate object";
            this.theRealEstateObjectBindingSource.DataSource = this.agenstvo_nedvijemostiDataSet5;
            // 
            // agenstvo_nedvijemostiDataSet5
            // 
            this.agenstvo_nedvijemostiDataSet5.DataSetName = "Agenstvo_nedvijemostiDataSet5";
            this.agenstvo_nedvijemostiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 72);
            this.button2.TabIndex = 14;
            this.button2.Text = "Поиск города";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 72);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить новую";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(181, 447);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вернуться обратно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Список доступных квартир (по городам)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // the_real_estate_objectTableAdapter
            // 
            this.the_real_estate_objectTableAdapter.ClearBeforeFill = true;
            // 
            // Kvartiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(523, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Kvartiri";
            this.Text = "SpisocKvartir";
            this.Load += new System.EventHandler(this.список_доступных_квартир__по_городам__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theRealEstateObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenstvo_nedvijemostiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Agenstvo_nedvijemostiDataSet5 agenstvo_nedvijemostiDataSet5;
        private System.Windows.Forms.BindingSource theRealEstateObjectBindingSource;
        private Agenstvo_nedvijemostiDataSet5TableAdapters.the_real_estate_objectTableAdapter the_real_estate_objectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRealtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfPropertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livingAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonresidentialAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn favoriteDataGridViewCheckBoxColumn;
    }
}