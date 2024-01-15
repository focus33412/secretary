namespace secretary
{
    partial class rating
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
            this.comboBoxSpecialization3 = new System.Windows.Forms.ComboBox();
            this.incorectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretaryDataSet1 = new secretary.secretaryDataSet1();
            this.comboBoxSpecialization2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecialization1 = new System.Windows.Forms.ComboBox();
            this.incorectDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.incorectTableAdapter = new secretary.secretaryDataSet1TableAdapters.incorectTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рейтинги";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.comboBoxSpecialization3);
            this.panel2.Controls.Add(this.comboBoxSpecialization2);
            this.panel2.Controls.Add(this.comboBoxSpecialization1);
            this.panel2.Controls.Add(this.incorectDataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 445);
            this.panel2.TabIndex = 3;
            // 
            // comboBoxSpecialization3
            // 
            this.comboBoxSpecialization3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_3", true));
            this.comboBoxSpecialization3.FormattingEnabled = true;
            this.comboBoxSpecialization3.Location = new System.Drawing.Point(592, 405);
            this.comboBoxSpecialization3.Name = "comboBoxSpecialization3";
            this.comboBoxSpecialization3.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialization3.TabIndex = 59;
            // 
            // incorectBindingSource
            // 
            this.incorectBindingSource.DataMember = "incorect";
            this.incorectBindingSource.DataSource = this.secretaryDataSet1;
            // 
            // secretaryDataSet1
            // 
            this.secretaryDataSet1.DataSetName = "secretaryDataSet1";
            this.secretaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSpecialization2
            // 
            this.comboBoxSpecialization2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_2", true));
            this.comboBoxSpecialization2.FormattingEnabled = true;
            this.comboBoxSpecialization2.Location = new System.Drawing.Point(306, 405);
            this.comboBoxSpecialization2.Name = "comboBoxSpecialization2";
            this.comboBoxSpecialization2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialization2.TabIndex = 58;
            // 
            // comboBoxSpecialization1
            // 
            this.comboBoxSpecialization1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_1", true));
            this.comboBoxSpecialization1.FormattingEnabled = true;
            this.comboBoxSpecialization1.Location = new System.Drawing.Point(98, 406);
            this.comboBoxSpecialization1.Name = "comboBoxSpecialization1";
            this.comboBoxSpecialization1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialization1.TabIndex = 57;
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
            this.incorectDataGridView.DataSource = this.incorectBindingSource;
            this.incorectDataGridView.Location = new System.Drawing.Point(12, 35);
            this.incorectDataGridView.Name = "incorectDataGridView";
            this.incorectDataGridView.Size = new System.Drawing.Size(776, 336);
            this.incorectDataGridView.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "все";
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
            // incorectTableAdapter
            // 
            this.incorectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.incorectTableAdapter = this.incorectTableAdapter;
            this.tableAdapterManager.receivedTableAdapter = null;
            this.tableAdapterManager.registerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = secretary.secretaryDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // licenseDataGridViewCheckBoxColumn
            // 
            this.licenseDataGridViewCheckBoxColumn.DataPropertyName = "лицензия";
            this.licenseDataGridViewCheckBoxColumn.HeaderText = "license";
            this.licenseDataGridViewCheckBoxColumn.Name = "licenseDataGridViewCheckBoxColumn";
            this.licenseDataGridViewCheckBoxColumn.Width = 60;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 59;
            // 
            // datecreationDataGridViewTextBoxColumn
            // 
            this.datecreationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datecreationDataGridViewTextBoxColumn.DataPropertyName = "date_creation";
            this.datecreationDataGridViewTextBoxColumn.HeaderText = "дата создания";
            this.datecreationDataGridViewTextBoxColumn.Name = "datecreationDataGridViewTextBoxColumn";
            this.datecreationDataGridViewTextBoxColumn.Width = 97;
            // 
            // applicationstatusDataGridViewTextBoxColumn
            // 
            this.applicationstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.applicationstatusDataGridViewTextBoxColumn.DataPropertyName = "application_status";
            this.applicationstatusDataGridViewTextBoxColumn.HeaderText = "статус расмотрения";
            this.applicationstatusDataGridViewTextBoxColumn.Name = "applicationstatusDataGridViewTextBoxColumn";
            this.applicationstatusDataGridViewTextBoxColumn.Width = 124;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "номер паспорта";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 105;
            // 
            // fIOmomDataGridViewTextBoxColumn
            // 
            this.fIOmomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIOmomDataGridViewTextBoxColumn.DataPropertyName = "FIO_mom";
            this.fIOmomDataGridViewTextBoxColumn.HeaderText = "ФИО матери";
            this.fIOmomDataGridViewTextBoxColumn.Name = "fIOmomDataGridViewTextBoxColumn";
            this.fIOmomDataGridViewTextBoxColumn.Width = 91;
            // 
            // fIOdedDataGridViewTextBoxColumn
            // 
            this.fIOdedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fIOdedDataGridViewTextBoxColumn.DataPropertyName = "FIO_ded";
            this.fIOdedDataGridViewTextBoxColumn.HeaderText = "ФИО отца";
            this.fIOdedDataGridViewTextBoxColumn.Name = "fIOdedDataGridViewTextBoxColumn";
            this.fIOdedDataGridViewTextBoxColumn.Width = 79;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "Номер ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.Width = 86;
            // 
            // snilsDataGridViewTextBoxColumn
            // 
            this.snilsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.snilsDataGridViewTextBoxColumn.DataPropertyName = "snils";
            this.snilsDataGridViewTextBoxColumn.HeaderText = "номер снилс";
            this.snilsDataGridViewTextBoxColumn.Name = "snilsDataGridViewTextBoxColumn";
            this.snilsDataGridViewTextBoxColumn.Width = 89;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "средний бал";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 88;
            // 
            // photocertificateDataGridViewTextBoxColumn
            // 
            this.photocertificateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.photocertificateDataGridViewTextBoxColumn.DataPropertyName = "photo_certificate";
            this.photocertificateDataGridViewTextBoxColumn.HeaderText = "фото атестата";
            this.photocertificateDataGridViewTextBoxColumn.Name = "photocertificateDataGridViewTextBoxColumn";
            this.photocertificateDataGridViewTextBoxColumn.Width = 97;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "фотография";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // specialization1DataGridViewTextBoxColumn
            // 
            this.specialization1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specialization1DataGridViewTextBoxColumn.DataPropertyName = "specialization_1";
            this.specialization1DataGridViewTextBoxColumn.HeaderText = "направление 1";
            this.specialization1DataGridViewTextBoxColumn.Name = "specialization1DataGridViewTextBoxColumn";
            this.specialization1DataGridViewTextBoxColumn.Width = 98;
            // 
            // specialization2DataGridViewTextBoxColumn
            // 
            this.specialization2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specialization2DataGridViewTextBoxColumn.DataPropertyName = "specialization_2";
            this.specialization2DataGridViewTextBoxColumn.HeaderText = "направление 2";
            this.specialization2DataGridViewTextBoxColumn.Name = "specialization2DataGridViewTextBoxColumn";
            this.specialization2DataGridViewTextBoxColumn.Width = 98;
            // 
            // specialization3DataGridViewTextBoxColumn
            // 
            this.specialization3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specialization3DataGridViewTextBoxColumn.DataPropertyName = "specialization_3";
            this.specialization3DataGridViewTextBoxColumn.HeaderText = "направление 3";
            this.specialization3DataGridViewTextBoxColumn.Name = "specialization3DataGridViewTextBoxColumn";
            this.specialization3DataGridViewTextBoxColumn.Width = 98;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 93;
            // 
            // rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rating";
            this.Load += new System.EventHandler(this.rating_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView incorectDataGridView;
        private System.Windows.Forms.Label label2;
        private secretaryDataSet1 secretaryDataSet1;
        private System.Windows.Forms.BindingSource incorectBindingSource;
        private secretaryDataSet1TableAdapters.incorectTableAdapter incorectTableAdapter;
        private secretaryDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox comboBoxSpecialization1;
        private System.Windows.Forms.ComboBox comboBoxSpecialization3;
        private System.Windows.Forms.ComboBox comboBoxSpecialization2;
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