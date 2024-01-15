namespace secretary
{
    partial class admin
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label snilsLabel;
            System.Windows.Forms.Label scoreLabel;
            System.Windows.Forms.Label photo_certificateLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label specialization_1Label;
            System.Windows.Forms.Label specialization_2Label;
            System.Windows.Forms.Label specialization_3Label;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label licenseLabel;
            System.Windows.Forms.Label date_creationLabel;
            System.Windows.Forms.Label application_statusLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.application_status_comboBox1 = new System.Windows.Forms.ComboBox();
            this.licenseCheckBox = new System.Windows.Forms.CheckBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.incorectDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.photo_certificateTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.specialization_3TextBox = new System.Windows.Forms.TextBox();
            this.specialization_1TextBox = new System.Windows.Forms.TextBox();
            this.specialization_2TextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.incorectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretaryDataSet1 = new secretary.secretaryDataSet1();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectTableAdapter = new secretary.secretaryDataSet1TableAdapters.incorectTableAdapter();
            this.tableAdapterManager = new secretary.secretaryDataSet1TableAdapters.TableAdapterManager();
            fIOLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            snilsLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            photo_certificateLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            specialization_1Label = new System.Windows.Forms.Label();
            specialization_2Label = new System.Windows.Forms.Label();
            specialization_3Label = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            licenseLabel = new System.Windows.Forms.Label();
            date_creationLabel = new System.Windows.Forms.Label();
            application_statusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(24, 175);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 9;
            fIOLabel.Text = "ФИО:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(9, 10);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(53, 13);
            passportLabel.TabIndex = 15;
            passportLabel.Text = "Паспорт:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(9, 36);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(34, 13);
            iNNLabel.TabIndex = 21;
            iNNLabel.Text = "ИНН:";
            // 
            // snilsLabel
            // 
            snilsLabel.AutoSize = true;
            snilsLabel.Location = new System.Drawing.Point(9, 62);
            snilsLabel.Name = "snilsLabel";
            snilsLabel.Size = new System.Drawing.Size(41, 13);
            snilsLabel.TabIndex = 23;
            snilsLabel.Text = "Снилс:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(369, 13);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(74, 13);
            scoreLabel.TabIndex = 25;
            scoreLabel.Text = "Средний бал:";
            // 
            // photo_certificateLabel
            // 
            photo_certificateLabel.AutoSize = true;
            photo_certificateLabel.Location = new System.Drawing.Point(369, 39);
            photo_certificateLabel.Name = "photo_certificateLabel";
            photo_certificateLabel.Size = new System.Drawing.Size(86, 13);
            photo_certificateLabel.TabIndex = 27;
            photo_certificateLabel.Text = "Фото атестата:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(9, 88);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 29;
            photoLabel.Text = "Фото:";
            // 
            // specialization_1Label
            // 
            specialization_1Label.AutoSize = true;
            specialization_1Label.Location = new System.Drawing.Point(9, 113);
            specialization_1Label.Name = "specialization_1Label";
            specialization_1Label.Size = new System.Drawing.Size(96, 13);
            specialization_1Label.TabIndex = 31;
            specialization_1Label.Text = "специальность 1:";
            // 
            // specialization_2Label
            // 
            specialization_2Label.AutoSize = true;
            specialization_2Label.Location = new System.Drawing.Point(9, 139);
            specialization_2Label.Name = "specialization_2Label";
            specialization_2Label.Size = new System.Drawing.Size(97, 13);
            specialization_2Label.TabIndex = 33;
            specialization_2Label.Text = "Специальность 2:";
            // 
            // specialization_3Label
            // 
            specialization_3Label.AutoSize = true;
            specialization_3Label.Location = new System.Drawing.Point(9, 165);
            specialization_3Label.Name = "specialization_3Label";
            specialization_3Label.Size = new System.Drawing.Size(97, 13);
            specialization_3Label.TabIndex = 35;
            specialization_3Label.Text = "Специальность 3:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(371, 65);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(71, 13);
            noteLabel.TabIndex = 37;
            noteLabel.Text = "примечания:";
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new System.Drawing.Point(19, 147);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new System.Drawing.Size(58, 13);
            licenseLabel.TabIndex = 7;
            licenseLabel.Text = "лицензия:";
            // 
            // date_creationLabel
            // 
            date_creationLabel.AutoSize = true;
            date_creationLabel.Location = new System.Drawing.Point(488, 146);
            date_creationLabel.Name = "date_creationLabel";
            date_creationLabel.Size = new System.Drawing.Size(84, 13);
            date_creationLabel.TabIndex = 11;
            date_creationLabel.Text = "дата создания:";
            // 
            // application_statusLabel
            // 
            application_statusLabel.AutoSize = true;
            application_statusLabel.Location = new System.Drawing.Point(488, 171);
            application_statusLabel.Name = "application_statusLabel";
            application_statusLabel.Size = new System.Drawing.Size(83, 13);
            application_statusLabel.TabIndex = 13;
            application_statusLabel.Text = "Статус заявки:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 44);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Админ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.application_status_comboBox1);
            this.panel2.Controls.Add(this.licenseCheckBox);
            this.panel2.Controls.Add(this.fIOTextBox);
            this.panel2.Controls.Add(this.incorectDataGridView);
            this.panel2.Controls.Add(this.date_creationDateTimePicker);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(fIOLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(licenseLabel);
            this.panel2.Controls.Add(date_creationLabel);
            this.panel2.Controls.Add(application_statusLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 432);
            this.panel2.TabIndex = 46;
            // 
            // application_status_comboBox1
            // 
            this.application_status_comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "application_status", true));
            this.application_status_comboBox1.FormattingEnabled = true;
            this.application_status_comboBox1.Items.AddRange(new object[] {
            "одобренна",
            "в обработке",
            "отклонена"});
            this.application_status_comboBox1.Location = new System.Drawing.Point(591, 168);
            this.application_status_comboBox1.Name = "application_status_comboBox1";
            this.application_status_comboBox1.Size = new System.Drawing.Size(200, 21);
            this.application_status_comboBox1.TabIndex = 59;
            // 
            // licenseCheckBox
            // 
            this.licenseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.incorectBindingSource, "license", true));
            this.licenseCheckBox.Location = new System.Drawing.Point(83, 142);
            this.licenseCheckBox.Name = "licenseCheckBox";
            this.licenseCheckBox.Size = new System.Drawing.Size(20, 24);
            this.licenseCheckBox.TabIndex = 52;
            this.licenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(139, 171);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(200, 20);
            this.fIOTextBox.TabIndex = 54;
            // 
            // incorectDataGridView
            // 
            this.incorectDataGridView.AutoGenerateColumns = false;
            this.incorectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incorectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.score,
            this.dataGridViewTextBoxColumn18});
            this.incorectDataGridView.DataSource = this.incorectBindingSource;
            this.incorectDataGridView.Location = new System.Drawing.Point(15, 41);
            this.incorectDataGridView.Name = "incorectDataGridView";
            this.incorectDataGridView.Size = new System.Drawing.Size(776, 95);
            this.incorectDataGridView.TabIndex = 45;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "score";
            this.score.Name = "score";
            // 
            // date_creationDateTimePicker
            // 
            this.date_creationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incorectBindingSource, "date_creation", true));
            this.date_creationDateTimePicker.Location = new System.Drawing.Point(591, 142);
            this.date_creationDateTimePicker.Name = "date_creationDateTimePicker";
            this.date_creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_creationDateTimePicker.TabIndex = 56;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(621, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "рейтинги";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "все";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(702, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "отклоненные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(648, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(passportLabel);
            this.panel3.Controls.Add(iNNLabel);
            this.panel3.Controls.Add(snilsLabel);
            this.panel3.Controls.Add(scoreLabel);
            this.panel3.Controls.Add(photo_certificateLabel);
            this.panel3.Controls.Add(photoLabel);
            this.panel3.Controls.Add(specialization_1Label);
            this.panel3.Controls.Add(specialization_2Label);
            this.panel3.Controls.Add(specialization_3Label);
            this.panel3.Controls.Add(this.passportTextBox);
            this.panel3.Controls.Add(noteLabel);
            this.panel3.Controls.Add(this.iNNTextBox);
            this.panel3.Controls.Add(this.snilsTextBox);
            this.panel3.Controls.Add(this.scoreTextBox);
            this.panel3.Controls.Add(this.photo_certificateTextBox);
            this.panel3.Controls.Add(this.photoTextBox);
            this.panel3.Controls.Add(this.specialization_3TextBox);
            this.panel3.Controls.Add(this.specialization_1TextBox);
            this.panel3.Controls.Add(this.specialization_2TextBox);
            this.panel3.Controls.Add(this.noteTextBox);
            this.panel3.Location = new System.Drawing.Point(15, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 189);
            this.panel3.TabIndex = 39;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(124, 10);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(200, 20);
            this.passportTextBox.TabIndex = 60;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(124, 36);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(200, 20);
            this.iNNTextBox.TabIndex = 66;
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "snils", true));
            this.snilsTextBox.Location = new System.Drawing.Point(124, 62);
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(200, 20);
            this.snilsTextBox.TabIndex = 68;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "score", true));
            this.scoreTextBox.Location = new System.Drawing.Point(561, 10);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(200, 20);
            this.scoreTextBox.TabIndex = 70;
            // 
            // photo_certificateTextBox
            // 
            this.photo_certificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "photo_certificate", true));
            this.photo_certificateTextBox.Location = new System.Drawing.Point(561, 33);
            this.photo_certificateTextBox.Name = "photo_certificateTextBox";
            this.photo_certificateTextBox.Size = new System.Drawing.Size(200, 20);
            this.photo_certificateTextBox.TabIndex = 72;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(124, 88);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 20);
            this.photoTextBox.TabIndex = 74;
            // 
            // specialization_3TextBox
            // 
            this.specialization_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_3", true));
            this.specialization_3TextBox.Location = new System.Drawing.Point(124, 166);
            this.specialization_3TextBox.Name = "specialization_3TextBox";
            this.specialization_3TextBox.Size = new System.Drawing.Size(200, 20);
            this.specialization_3TextBox.TabIndex = 80;
            // 
            // specialization_1TextBox
            // 
            this.specialization_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_1", true));
            this.specialization_1TextBox.Location = new System.Drawing.Point(124, 114);
            this.specialization_1TextBox.Name = "specialization_1TextBox";
            this.specialization_1TextBox.Size = new System.Drawing.Size(200, 20);
            this.specialization_1TextBox.TabIndex = 76;
            // 
            // specialization_2TextBox
            // 
            this.specialization_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_2", true));
            this.specialization_2TextBox.Location = new System.Drawing.Point(124, 140);
            this.specialization_2TextBox.Name = "specialization_2TextBox";
            this.specialization_2TextBox.Size = new System.Drawing.Size(200, 20);
            this.specialization_2TextBox.TabIndex = 78;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "note", true));
            this.noteTextBox.Location = new System.Drawing.Point(561, 59);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 20);
            this.noteTextBox.TabIndex = 82;
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "license";
            this.dataGridViewCheckBoxColumn1.HeaderText = "license";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "FIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date_creation";
            this.dataGridViewTextBoxColumn5.HeaderText = "date_creation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "application_status";
            this.dataGridViewTextBoxColumn6.HeaderText = "application_status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn18.HeaderText = "note";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
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
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(813, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(829, 515);
            this.MinimumSize = new System.Drawing.Size(829, 515);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private secretaryDataSet1 secretaryDataSet1;
        private System.Windows.Forms.BindingSource incorectBindingSource;
        private secretaryDataSet1TableAdapters.incorectTableAdapter incorectTableAdapter;
        private secretaryDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox licenseCheckBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.DateTimePicker date_creationDateTimePicker;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox photo_certificateTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox specialization_1TextBox;
        private System.Windows.Forms.TextBox specialization_2TextBox;
        private System.Windows.Forms.TextBox specialization_3TextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DataGridView incorectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.ComboBox application_status_comboBox1;
    }
}