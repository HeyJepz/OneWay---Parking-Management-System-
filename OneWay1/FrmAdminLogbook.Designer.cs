namespace OneWay1
{
    partial class FrmAdminLogbook
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
            this.dbAccountsDatabaseDataSet2 = new OneWay1.dbAccountsDatabaseDataSet2();
            this.tblAdminLogbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAdminLogbookTableAdapter = new OneWay1.dbAccountsDatabaseDataSet2TableAdapters.tblAdminLogbookTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoffTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAccountsDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdminLogbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.loginTimeDataGridViewTextBoxColumn,
            this.logoffTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAdminLogbookBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 546);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbAccountsDatabaseDataSet2
            // 
            this.dbAccountsDatabaseDataSet2.DataSetName = "dbAccountsDatabaseDataSet2";
            this.dbAccountsDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAdminLogbookBindingSource
            // 
            this.tblAdminLogbookBindingSource.DataMember = "tblAdminLogbook";
            this.tblAdminLogbookBindingSource.DataSource = this.dbAccountsDatabaseDataSet2;
            // 
            // tblAdminLogbookTableAdapter
            // 
            this.tblAdminLogbookTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // loginTimeDataGridViewTextBoxColumn
            // 
            this.loginTimeDataGridViewTextBoxColumn.DataPropertyName = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.HeaderText = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.Name = "loginTimeDataGridViewTextBoxColumn";
            this.loginTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // logoffTimeDataGridViewTextBoxColumn
            // 
            this.logoffTimeDataGridViewTextBoxColumn.DataPropertyName = "LogoffTime";
            this.logoffTimeDataGridViewTextBoxColumn.HeaderText = "LogoffTime";
            this.logoffTimeDataGridViewTextBoxColumn.Name = "logoffTimeDataGridViewTextBoxColumn";
            this.logoffTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // FrmAdminLogbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 546);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAdminLogbook";
            this.Text = "FrmAdminLogbook";
            this.Load += new System.EventHandler(this.FrmAdminLogbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAccountsDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAdminLogbookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbAccountsDatabaseDataSet2 dbAccountsDatabaseDataSet2;
        private System.Windows.Forms.BindingSource tblAdminLogbookBindingSource;
        private dbAccountsDatabaseDataSet2TableAdapters.tblAdminLogbookTableAdapter tblAdminLogbookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoffTimeDataGridViewTextBoxColumn;
    }
}