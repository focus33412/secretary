namespace secretary
{
    partial class received
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.incorectDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.secretaryDataSet1 = new secretary.secretaryDataSet1();
            this.receivedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receivedTableAdapter = new secretary.secretaryDataSet1TableAdapters.receivedTableAdapter();
            this.tableAdapterManager = new secretary.secretaryDataSet1TableAdapters.TableAdapterManager();
            this.licenseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOmomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOdedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photocertificateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отклоненные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.incorectDataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 414);
            this.panel2.TabIndex = 3;
            // 
            // incorectDataGridView
            // 
            this.incorectDataGridView.AutoGenerateColumns = false;
            this.incorectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incorectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.licenseDataGridViewCheckBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.datecreationDataGridViewTextBoxColumn,
            this.applicationstatusDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.fIOmomDataGridViewTextBoxColumn,
            this.fIOdedDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.snilsDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.photocertificateDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.specialization1DataGridViewTextBoxColumn,
            this.specialization2DataGridViewTextBoxColumn,
            this.specialization3DataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.incorectDataGridView.DataSource = this.receivedBindingSource;
            this.incorectDataGridView.Location = new System.Drawing.Point(12, 35);
            this.incorectDataGridView.Name = "incorectDataGridView";
            this.incorectDataGridView.Size = new System.Drawing.Size(776, 367);
            this.incorectDataGridView.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 43;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(699, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 23);
            this.back.TabIndex = 42;
            this.back.Text = "обратно";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // secretaryDataSet1
            // 
            this.secretaryDataSet1.DataSetName = "secretaryDataSet1";
            this.secretaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receivedBindingSource
            // 
            this.receivedBindingSource.DataMember = "received";
            this.receivedBindingSource.DataSource = this.secretaryDataSet1;
            // 
            // receivedTableAdapter
            // 
            this.receivedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.incorectTableAdapter = null;
            this.tableAdapterManager.receivedTableAdapter = this.receivedTableAdapter;
            this.tableAdapterManager.UpdateOrder = secretary.secretaryDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // licenseDataGridViewCheckBoxColumn
            // 
            this.licenseDataGridViewCheckBoxColumn.DataPropertyName = "license";
            this.licenseDataGridViewCheckBoxColumn.HeaderText = "license";
            this.licenseDataGridViewCheckBoxColumn.Name = "licenseDataGridViewCheckBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // datecreationDataGridViewTextBoxColumn
            // 
            this.datecreationDataGridViewTextBoxColumn.DataPropertyName = "date_creation";
            this.datecreationDataGridViewTextBoxColumn.HeaderText = "date_creation";
            this.datecreationDataGridViewTextBoxColumn.Name = "datecreationDataGridViewTextBoxColumn";
            // 
            // applicationstatusDataGridViewTextBoxColumn
            // 
            this.applicationstatusDataGridViewTextBoxColumn.DataPropertyName = "application_status";
            this.applicationstatusDataGridViewTextBoxColumn.HeaderText = "application_status";
            this.applicationstatusDataGridViewTextBoxColumn.Name = "applicationstatusDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // fIOmomDataGridViewTextBoxColumn
            // 
            this.fIOmomDataGridViewTextBoxColumn.DataPropertyName = "FIO_mom";
            this.fIOmomDataGridViewTextBoxColumn.HeaderText = "FIO_mom";
            this.fIOmomDataGridViewTextBoxColumn.Name = "fIOmomDataGridViewTextBoxColumn";
            // 
            // fIOdedDataGridViewTextBoxColumn
            // 
            this.fIOdedDataGridViewTextBoxColumn.DataPropertyName = "FIO_ded";
            this.fIOdedDataGridViewTextBoxColumn.HeaderText = "FIO_ded";
            this.fIOdedDataGridViewTextBoxColumn.Name = "fIOdedDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "snils";
            this.snilsDataGridViewTextBoxColumn.HeaderText = "snils";
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // photocertificateDataGridViewTextBoxColumn
            // 
            this.photocertificateDataGridViewTextBoxColumn.DataPropertyName = "photo_certificate";
            this.photocertificateDataGridViewTextBoxColumn.HeaderText = "photo_certificate";
            this.photocertificateDataGridViewTextBoxColumn.Name = "photocertificateDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // specialization1DataGridViewTextBoxColumn
            // 
            this.specialization1DataGridViewTextBoxColumn.DataPropertyName = "specialization_1";
            this.specialization1DataGridViewTextBoxColumn.HeaderText = "specialization_1";
            this.specialization1DataGridViewTextBoxColumn.Name = "specialization1DataGridViewTextBoxColumn";
            // 
            // specialization2DataGridViewTextBoxColumn
            // 
            this.specialization2DataGridViewTextBoxColumn.DataPropertyName = "specialization_2";
            this.specialization2DataGridViewTextBoxColumn.HeaderText = "specialization_2";
            this.specialization2DataGridViewTextBoxColumn.Name = "specialization2DataGridViewTextBoxColumn";
            // 
            // specialization3DataGridViewTextBoxColumn
            // 
            this.specialization3DataGridViewTextBoxColumn.DataPropertyName = "specialization_3";
            this.specialization3DataGridViewTextBoxColumn.HeaderText = "specialization_3";
            this.specialization3DataGridViewTextBoxColumn.Name = "specialization3DataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "received";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "received";
            this.Load += new System.EventHandler(this.received_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView incorectDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private secretaryDataSet1 secretaryDataSet1;
        private System.Windows.Forms.BindingSource receivedBindingSource;
        private secretaryDataSet1TableAdapters.receivedTableAdapter receivedTableAdapter;
        private secretaryDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn licenseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOmomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOdedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photocertificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}