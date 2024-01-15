namespace secretary
{
    partial class secret
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
            System.Windows.Forms.Label fIO_momLabel;
            System.Windows.Forms.Label fIO_dedLabel;
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
            System.Windows.Forms.Label user_idLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.incorectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secretaryDataSet1 = new secretary.secretaryDataSet1();
            this.licenseCheckBox = new System.Windows.Forms.CheckBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.date_creationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.incorectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.fIO_momTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.fIO_dedTextBox = new System.Windows.Forms.TextBox();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.specialization_1TextBox = new System.Windows.Forms.TextBox();
            this.specialization_3TextBox = new System.Windows.Forms.TextBox();
            this.specialization_2TextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.photo_certificateTextBox = new System.Windows.Forms.TextBox();
            this.incorectTableAdapter = new secretary.secretaryDataSet1TableAdapters.incorectTableAdapter();
            this.tableAdapterManager = new secretary.secretaryDataSet1TableAdapters.TableAdapterManager();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            fIOLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            fIO_momLabel = new System.Windows.Forms.Label();
            fIO_dedLabel = new System.Windows.Forms.Label();
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
            user_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(21, 169);
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
            // fIO_momLabel
            // 
            fIO_momLabel.AutoSize = true;
            fIO_momLabel.Location = new System.Drawing.Point(369, 10);
            fIO_momLabel.Name = "fIO_momLabel";
            fIO_momLabel.Size = new System.Drawing.Size(77, 13);
            fIO_momLabel.TabIndex = 17;
            fIO_momLabel.Text = "ФИО матери:";
            // 
            // fIO_dedLabel
            // 
            fIO_dedLabel.AutoSize = true;
            fIO_dedLabel.Location = new System.Drawing.Point(369, 36);
            fIO_dedLabel.Name = "fIO_dedLabel";
            fIO_dedLabel.Size = new System.Drawing.Size(63, 13);
            fIO_dedLabel.TabIndex = 19;
            fIO_dedLabel.Text = "ФИО отца:";
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
            scoreLabel.Location = new System.Drawing.Point(369, 65);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(74, 13);
            scoreLabel.TabIndex = 25;
            scoreLabel.Text = "Средний бал:";
            // 
            // photo_certificateLabel
            // 
            photo_certificateLabel.AutoSize = true;
            photo_certificateLabel.Location = new System.Drawing.Point(369, 91);
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
            noteLabel.Location = new System.Drawing.Point(371, 117);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(71, 13);
            noteLabel.TabIndex = 37;
            noteLabel.Text = "примечания:";
            // 
            // licenseLabel
            // 
            licenseLabel.AutoSize = true;
            licenseLabel.Location = new System.Drawing.Point(16, 141);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new System.Drawing.Size(58, 13);
            licenseLabel.TabIndex = 7;
            licenseLabel.Text = "лицензия:";
            // 
            // date_creationLabel
            // 
            date_creationLabel.AutoSize = true;
            date_creationLabel.Location = new System.Drawing.Point(485, 140);
            date_creationLabel.Name = "date_creationLabel";
            date_creationLabel.Size = new System.Drawing.Size(84, 13);
            date_creationLabel.TabIndex = 11;
            date_creationLabel.Text = "дата создания:";
            // 
            // application_statusLabel
            // 
            application_statusLabel.AutoSize = true;
            application_statusLabel.Location = new System.Drawing.Point(485, 165);
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
            this.panel1.Size = new System.Drawing.Size(808, 53);
            this.panel1.TabIndex = 1;
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
            this.label1.Text = "Секретарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(user_idLabel);
            this.panel2.Controls.Add(this.user_idTextBox);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.licenseCheckBox);
            this.panel2.Controls.Add(this.fIOTextBox);
            this.panel2.Controls.Add(this.date_creationDateTimePicker);
            this.panel2.Controls.Add(this.incorectDataGridView);
            this.panel2.Controls.Add(fIOLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.received);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(licenseLabel);
            this.panel2.Controls.Add(date_creationLabel);
            this.panel2.Controls.Add(application_statusLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 425);
            this.panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "application_status", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "одобрена",
            "в обработке",
            "отклонена"});
            this.comboBox1.Location = new System.Drawing.Point(575, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 70;
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
            // licenseCheckBox
            // 
            this.licenseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.incorectBindingSource, "license", true));
            this.licenseCheckBox.Location = new System.Drawing.Point(78, 136);
            this.licenseCheckBox.Name = "licenseCheckBox";
            this.licenseCheckBox.Size = new System.Drawing.Size(13, 24);
            this.licenseCheckBox.TabIndex = 63;
            this.licenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fIOTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(64, 165);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(336, 13);
            this.fIOTextBox.TabIndex = 65;
            // 
            // date_creationDateTimePicker
            // 
            this.date_creationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incorectBindingSource, "date_creation", true));
            this.date_creationDateTimePicker.Location = new System.Drawing.Point(575, 133);
            this.date_creationDateTimePicker.Name = "date_creationDateTimePicker";
            this.date_creationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_creationDateTimePicker.TabIndex = 67;
            // 
            // incorectDataGridView
            // 
            this.incorectDataGridView.AutoGenerateColumns = false;
            this.incorectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incorectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn18});
            this.incorectDataGridView.DataSource = this.incorectBindingSource;
            this.incorectDataGridView.Location = new System.Drawing.Point(12, 35);
            this.incorectDataGridView.Name = "incorectDataGridView";
            this.incorectDataGridView.Size = new System.Drawing.Size(776, 85);
            this.incorectDataGridView.TabIndex = 56;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "license";
            this.dataGridViewCheckBoxColumn1.HeaderText = "лицензия";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 60;
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
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn12.HeaderText = "score";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn18.HeaderText = "note";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
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
            // received
            // 
            this.received.Cursor = System.Windows.Forms.Cursors.Hand;
            this.received.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.received.Location = new System.Drawing.Point(699, 6);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(89, 23);
            this.received.TabIndex = 42;
            this.received.Text = "отклоненные";
            this.received.UseVisualStyleBackColor = true;
            this.received.Click += new System.EventHandler(this.received_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(468, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(632, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(passportLabel);
            this.panel3.Controls.Add(fIO_momLabel);
            this.panel3.Controls.Add(fIO_dedLabel);
            this.panel3.Controls.Add(iNNLabel);
            this.panel3.Controls.Add(snilsLabel);
            this.panel3.Controls.Add(scoreLabel);
            this.panel3.Controls.Add(photo_certificateLabel);
            this.panel3.Controls.Add(this.passportTextBox);
            this.panel3.Controls.Add(photoLabel);
            this.panel3.Controls.Add(specialization_1Label);
            this.panel3.Controls.Add(specialization_2Label);
            this.panel3.Controls.Add(this.fIO_momTextBox);
            this.panel3.Controls.Add(this.iNNTextBox);
            this.panel3.Controls.Add(specialization_3Label);
            this.panel3.Controls.Add(this.fIO_dedTextBox);
            this.panel3.Controls.Add(this.snilsTextBox);
            this.panel3.Controls.Add(noteLabel);
            this.panel3.Controls.Add(this.specialization_1TextBox);
            this.panel3.Controls.Add(this.specialization_3TextBox);
            this.panel3.Controls.Add(this.specialization_2TextBox);
            this.panel3.Controls.Add(this.photoTextBox);
            this.panel3.Controls.Add(this.noteTextBox);
            this.panel3.Controls.Add(this.scoreTextBox);
            this.panel3.Controls.Add(this.photo_certificateTextBox);
            this.panel3.Location = new System.Drawing.Point(12, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 189);
            this.panel3.TabIndex = 39;
            // 
            // passportTextBox
            // 
            this.passportTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(147, 6);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(200, 13);
            this.passportTextBox.TabIndex = 71;
            // 
            // fIO_momTextBox
            // 
            this.fIO_momTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fIO_momTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fIO_momTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "FIO_mom", true));
            this.fIO_momTextBox.Location = new System.Drawing.Point(456, 3);
            this.fIO_momTextBox.Name = "fIO_momTextBox";
            this.fIO_momTextBox.Size = new System.Drawing.Size(305, 13);
            this.fIO_momTextBox.TabIndex = 73;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iNNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(147, 32);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(200, 13);
            this.iNNTextBox.TabIndex = 77;
            // 
            // fIO_dedTextBox
            // 
            this.fIO_dedTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fIO_dedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fIO_dedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "FIO_ded", true));
            this.fIO_dedTextBox.Location = new System.Drawing.Point(456, 29);
            this.fIO_dedTextBox.Name = "fIO_dedTextBox";
            this.fIO_dedTextBox.Size = new System.Drawing.Size(305, 13);
            this.fIO_dedTextBox.TabIndex = 75;
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.snilsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.snilsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "snils", true));
            this.snilsTextBox.Location = new System.Drawing.Point(147, 58);
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(200, 13);
            this.snilsTextBox.TabIndex = 79;
            // 
            // specialization_1TextBox
            // 
            this.specialization_1TextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialization_1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialization_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_1", true));
            this.specialization_1TextBox.Location = new System.Drawing.Point(147, 110);
            this.specialization_1TextBox.Name = "specialization_1TextBox";
            this.specialization_1TextBox.Size = new System.Drawing.Size(200, 13);
            this.specialization_1TextBox.TabIndex = 87;
            // 
            // specialization_3TextBox
            // 
            this.specialization_3TextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialization_3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialization_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_3", true));
            this.specialization_3TextBox.Location = new System.Drawing.Point(147, 162);
            this.specialization_3TextBox.Name = "specialization_3TextBox";
            this.specialization_3TextBox.Size = new System.Drawing.Size(200, 13);
            this.specialization_3TextBox.TabIndex = 91;
            // 
            // specialization_2TextBox
            // 
            this.specialization_2TextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.specialization_2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialization_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "specialization_2", true));
            this.specialization_2TextBox.Location = new System.Drawing.Point(147, 136);
            this.specialization_2TextBox.Name = "specialization_2TextBox";
            this.specialization_2TextBox.Size = new System.Drawing.Size(200, 13);
            this.specialization_2TextBox.TabIndex = 89;
            // 
            // photoTextBox
            // 
            this.photoTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.photoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(147, 84);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(200, 13);
            this.photoTextBox.TabIndex = 85;
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "note", true));
            this.noteTextBox.Location = new System.Drawing.Point(456, 110);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(305, 68);
            this.noteTextBox.TabIndex = 93;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "score", true));
            this.scoreTextBox.Location = new System.Drawing.Point(456, 58);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(305, 13);
            this.scoreTextBox.TabIndex = 81;
            // 
            // photo_certificateTextBox
            // 
            this.photo_certificateTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.photo_certificateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.photo_certificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "photo_certificate", true));
            this.photo_certificateTextBox.Location = new System.Drawing.Point(456, 84);
            this.photo_certificateTextBox.Name = "photo_certificateTextBox";
            this.photo_certificateTextBox.Size = new System.Drawing.Size(305, 13);
            this.photo_certificateTextBox.TabIndex = 83;
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
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Location = new System.Drawing.Point(185, 393);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(41, 13);
            user_idLabel.TabIndex = 70;
            user_idLabel.Text = "user id:";
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incorectBindingSource, "user_id", true));
            this.user_idTextBox.Location = new System.Drawing.Point(232, 390);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_idTextBox.TabIndex = 71;
            // 
            // secret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(824, 517);
            this.MinimumSize = new System.Drawing.Size(824, 517);
            this.Name = "secret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incorectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incorectDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button received;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private secretaryDataSet1 secretaryDataSet1;
        private System.Windows.Forms.BindingSource incorectBindingSource;
        private secretaryDataSet1TableAdapters.incorectTableAdapter incorectTableAdapter;
        private secretaryDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView incorectDataGridView;
        private System.Windows.Forms.CheckBox licenseCheckBox;
        private System.Windows.Forms.DateTimePicker date_creationDateTimePicker;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox fIO_momTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox fIO_dedTextBox;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox specialization_1TextBox;
        private System.Windows.Forms.TextBox specialization_3TextBox;
        private System.Windows.Forms.TextBox specialization_2TextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox photo_certificateTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox user_idTextBox;
    }
}