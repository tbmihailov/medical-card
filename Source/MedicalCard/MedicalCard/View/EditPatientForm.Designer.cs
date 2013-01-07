namespace MedicalCard.View
{
    partial class EditPatientForm
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
            this.tabControlAdditionalInfo = new System.Windows.Forms.TabControl();
            this.tabPageConsultations = new System.Windows.Forms.TabPage();
            this.panelConsultationsOperations = new System.Windows.Forms.Panel();
            this.panelConsultationButtons = new System.Windows.Forms.Panel();
            this.buttonDeleteConsultation = new System.Windows.Forms.Button();
            this.buttonEditConsultation = new System.Windows.Forms.Button();
            this.buttonAddConsultation = new System.Windows.Forms.Button();
            this.dataGridViewConsultations = new System.Windows.Forms.DataGridView();
            this.ColumnScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScheduleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageDiagnosis = new System.Windows.Forms.TabPage();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeaderText = new System.Windows.Forms.Label();
            this.pictureBoxHeaderImage = new System.Windows.Forms.PictureBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDiagnoses = new System.Windows.Forms.DataGridView();
            this.ColumnDiagnosticationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiagnoseDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDeleteDiagnosis = new System.Windows.Forms.Button();
            this.buttonEditDiagnosis = new System.Windows.Forms.Button();
            this.buttonAddDiagnosis = new System.Windows.Forms.Button();
            this.tabControlAdditionalInfo.SuspendLayout();
            this.tabPageConsultations.SuspendLayout();
            this.panelConsultationsOperations.SuspendLayout();
            this.panelConsultationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).BeginInit();
            this.tabPageDiagnosis.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderImage)).BeginInit();
            this.groupBoxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnoses)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdditionalInfo
            // 
            this.tabControlAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdditionalInfo.Controls.Add(this.tabPageConsultations);
            this.tabControlAdditionalInfo.Controls.Add(this.tabPageDiagnosis);
            this.tabControlAdditionalInfo.Location = new System.Drawing.Point(0, 236);
            this.tabControlAdditionalInfo.Name = "tabControlAdditionalInfo";
            this.tabControlAdditionalInfo.SelectedIndex = 0;
            this.tabControlAdditionalInfo.Size = new System.Drawing.Size(729, 331);
            this.tabControlAdditionalInfo.TabIndex = 3;
            // 
            // tabPageConsultations
            // 
            this.tabPageConsultations.Controls.Add(this.panelConsultationsOperations);
            this.tabPageConsultations.Controls.Add(this.dataGridViewConsultations);
            this.tabPageConsultations.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultations.Name = "tabPageConsultations";
            this.tabPageConsultations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultations.Size = new System.Drawing.Size(721, 305);
            this.tabPageConsultations.TabIndex = 0;
            this.tabPageConsultations.Text = "Прегледи";
            this.tabPageConsultations.UseVisualStyleBackColor = true;
            // 
            // panelConsultationsOperations
            // 
            this.panelConsultationsOperations.Controls.Add(this.panelConsultationButtons);
            this.panelConsultationsOperations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsultationsOperations.Location = new System.Drawing.Point(3, 264);
            this.panelConsultationsOperations.Name = "panelConsultationsOperations";
            this.panelConsultationsOperations.Size = new System.Drawing.Size(715, 38);
            this.panelConsultationsOperations.TabIndex = 2;
            // 
            // panelConsultationButtons
            // 
            this.panelConsultationButtons.Controls.Add(this.buttonDeleteConsultation);
            this.panelConsultationButtons.Controls.Add(this.buttonEditConsultation);
            this.panelConsultationButtons.Controls.Add(this.buttonAddConsultation);
            this.panelConsultationButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConsultationButtons.Location = new System.Drawing.Point(474, 0);
            this.panelConsultationButtons.Name = "panelConsultationButtons";
            this.panelConsultationButtons.Size = new System.Drawing.Size(241, 38);
            this.panelConsultationButtons.TabIndex = 0;
            // 
            // buttonDeleteConsultation
            // 
            this.buttonDeleteConsultation.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeleteConsultation.Location = new System.Drawing.Point(12, 0);
            this.buttonDeleteConsultation.Name = "buttonDeleteConsultation";
            this.buttonDeleteConsultation.Size = new System.Drawing.Size(61, 38);
            this.buttonDeleteConsultation.TabIndex = 8;
            this.buttonDeleteConsultation.Text = "Изтрий";
            this.buttonDeleteConsultation.UseVisualStyleBackColor = true;
            this.buttonDeleteConsultation.Click += new System.EventHandler(this.buttonDeleteConsultation_Click);
            // 
            // buttonEditConsultation
            // 
            this.buttonEditConsultation.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEditConsultation.Location = new System.Drawing.Point(73, 0);
            this.buttonEditConsultation.Name = "buttonEditConsultation";
            this.buttonEditConsultation.Size = new System.Drawing.Size(79, 38);
            this.buttonEditConsultation.TabIndex = 7;
            this.buttonEditConsultation.Text = "Редактирай";
            this.buttonEditConsultation.UseVisualStyleBackColor = true;
            this.buttonEditConsultation.Click += new System.EventHandler(this.buttonEditConsultation_Click);
            // 
            // buttonAddConsultation
            // 
            this.buttonAddConsultation.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddConsultation.Location = new System.Drawing.Point(152, 0);
            this.buttonAddConsultation.Name = "buttonAddConsultation";
            this.buttonAddConsultation.Size = new System.Drawing.Size(89, 38);
            this.buttonAddConsultation.TabIndex = 6;
            this.buttonAddConsultation.Text = "Насрочи нова";
            this.buttonAddConsultation.UseVisualStyleBackColor = true;
            this.buttonAddConsultation.Click += new System.EventHandler(this.buttonAddConsultation_Click);
            // 
            // dataGridViewConsultations
            // 
            this.dataGridViewConsultations.AllowUserToAddRows = false;
            this.dataGridViewConsultations.AllowUserToDeleteRows = false;
            this.dataGridViewConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnScheduleDate,
            this.ColumnScheduleTime,
            this.ColumnReason,
            this.ColumnConclusion,
            this.ColumnDoctor});
            this.dataGridViewConsultations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConsultations.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConsultations.Name = "dataGridViewConsultations";
            this.dataGridViewConsultations.ReadOnly = true;
            this.dataGridViewConsultations.Size = new System.Drawing.Size(715, 299);
            this.dataGridViewConsultations.TabIndex = 1;
            // 
            // ColumnScheduleDate
            // 
            this.ColumnScheduleDate.DataPropertyName = "ScheduleDate";
            this.ColumnScheduleDate.HeaderText = "Дата";
            this.ColumnScheduleDate.Name = "ColumnScheduleDate";
            this.ColumnScheduleDate.ReadOnly = true;
            // 
            // ColumnScheduleTime
            // 
            this.ColumnScheduleTime.DataPropertyName = "Time";
            this.ColumnScheduleTime.HeaderText = "Час";
            this.ColumnScheduleTime.Name = "ColumnScheduleTime";
            this.ColumnScheduleTime.ReadOnly = true;
            this.ColumnScheduleTime.Visible = false;
            // 
            // ColumnReason
            // 
            this.ColumnReason.DataPropertyName = "Reason";
            this.ColumnReason.HeaderText = "Причина";
            this.ColumnReason.Name = "ColumnReason";
            this.ColumnReason.ReadOnly = true;
            // 
            // ColumnConclusion
            // 
            this.ColumnConclusion.DataPropertyName = "Conclusion";
            this.ColumnConclusion.HeaderText = "Заключение";
            this.ColumnConclusion.Name = "ColumnConclusion";
            this.ColumnConclusion.ReadOnly = true;
            // 
            // ColumnDoctor
            // 
            this.ColumnDoctor.DataPropertyName = "DoctorName";
            this.ColumnDoctor.HeaderText = "Лекар";
            this.ColumnDoctor.Name = "ColumnDoctor";
            this.ColumnDoctor.ReadOnly = true;
            // 
            // tabPageDiagnosis
            // 
            this.tabPageDiagnosis.Controls.Add(this.panel2);
            this.tabPageDiagnosis.Controls.Add(this.dataGridViewDiagnoses);
            this.tabPageDiagnosis.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiagnosis.Name = "tabPageDiagnosis";
            this.tabPageDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiagnosis.Size = new System.Drawing.Size(721, 305);
            this.tabPageDiagnosis.TabIndex = 1;
            this.tabPageDiagnosis.Text = "Диагнози";
            this.tabPageDiagnosis.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 573);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(729, 34);
            this.panelBottom.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(531, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 34);
            this.panel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClose.Location = new System.Drawing.Point(75, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Откажи и затвори";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Запиши";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeaderText);
            this.panelHeader.Controls.Add(this.pictureBoxHeaderImage);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(729, 54);
            this.panelHeader.TabIndex = 8;
            // 
            // labelHeaderText
            // 
            this.labelHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderText.Location = new System.Drawing.Point(61, 0);
            this.labelHeaderText.Margin = new System.Windows.Forms.Padding(5);
            this.labelHeaderText.Name = "labelHeaderText";
            this.labelHeaderText.Size = new System.Drawing.Size(668, 39);
            this.labelHeaderText.TabIndex = 1;
            this.labelHeaderText.Text = "Преглед и редакция на пациент";
            this.labelHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxHeaderImage
            // 
            this.pictureBoxHeaderImage.BackgroundImage = global::MedicalCard.Properties.Resources.patient_large;
            this.pictureBoxHeaderImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHeaderImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHeaderImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeaderImage.Name = "pictureBoxHeaderImage";
            this.pictureBoxHeaderImage.Size = new System.Drawing.Size(61, 54);
            this.pictureBoxHeaderImage.TabIndex = 0;
            this.pictureBoxHeaderImage.TabStop = false;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.label8);
            this.groupBoxInformation.Controls.Add(this.label7);
            this.groupBoxInformation.Controls.Add(this.labelMessage);
            this.groupBoxInformation.Controls.Add(this.labelId);
            this.groupBoxInformation.Controls.Add(this.label6);
            this.groupBoxInformation.Controls.Add(this.dateTimePickerBirthdate);
            this.groupBoxInformation.Controls.Add(this.label5);
            this.groupBoxInformation.Controls.Add(this.textBoxAddress);
            this.groupBoxInformation.Controls.Add(this.label4);
            this.groupBoxInformation.Controls.Add(this.textBoxPhone);
            this.groupBoxInformation.Controls.Add(this.label3);
            this.groupBoxInformation.Controls.Add(this.textBoxNumber);
            this.groupBoxInformation.Controls.Add(this.label2);
            this.groupBoxInformation.Controls.Add(this.textBoxName);
            this.groupBoxInformation.Controls.Add(this.label1);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInformation.Location = new System.Drawing.Point(0, 54);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(729, 176);
            this.groupBoxInformation.TabIndex = 9;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Инфромация за пациента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(272, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(272, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "*";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.Location = new System.Drawing.Point(249, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(468, 20);
            this.labelMessage.TabIndex = 12;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(56, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(13, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No.";
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(395, 65);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerBirthdate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата на раждане";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(59, 117);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(347, 49);
            this.textBoxAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адрес";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(59, 91);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(208, 20);
            this.textBoxPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тел";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(59, 65);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(208, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЕГН";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(59, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // dataGridViewDiagnoses
            // 
            this.dataGridViewDiagnoses.AllowUserToAddRows = false;
            this.dataGridViewDiagnoses.AllowUserToDeleteRows = false;
            this.dataGridViewDiagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiagnoses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDiagnosticationDate,
            this.ColumnSubject,
            this.ColumnNotes,
            this.ColumnPrescription,
            this.ColumnDiagnoseDoctor});
            this.dataGridViewDiagnoses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiagnoses.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDiagnoses.Name = "dataGridViewDiagnoses";
            this.dataGridViewDiagnoses.ReadOnly = true;
            this.dataGridViewDiagnoses.Size = new System.Drawing.Size(715, 299);
            this.dataGridViewDiagnoses.TabIndex = 1;
            // 
            // ColumnDiagnosticationDate
            // 
            this.ColumnDiagnosticationDate.DataPropertyName = "DiagnosticationDate";
            this.ColumnDiagnosticationDate.HeaderText = "Дата";
            this.ColumnDiagnosticationDate.Name = "ColumnDiagnosticationDate";
            this.ColumnDiagnosticationDate.ReadOnly = true;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.DataPropertyName = "Subject";
            this.ColumnSubject.HeaderText = "Диагноза";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.DataPropertyName = "Notes";
            this.ColumnNotes.HeaderText = "Бележки";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.ReadOnly = true;
            // 
            // ColumnPrescription
            // 
            this.ColumnPrescription.DataPropertyName = "Prescription";
            this.ColumnPrescription.HeaderText = "Предписание";
            this.ColumnPrescription.Name = "ColumnPrescription";
            this.ColumnPrescription.ReadOnly = true;
            // 
            // ColumnDiagnoseDoctor
            // 
            this.ColumnDiagnoseDoctor.DataPropertyName = "DoctorId";
            this.ColumnDiagnoseDoctor.HeaderText = "Лекар";
            this.ColumnDiagnoseDoctor.Name = "ColumnDiagnoseDoctor";
            this.ColumnDiagnoseDoctor.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 38);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDeleteDiagnosis);
            this.panel3.Controls.Add(this.buttonEditDiagnosis);
            this.panel3.Controls.Add(this.buttonAddDiagnosis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(474, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 38);
            this.panel3.TabIndex = 0;
            // 
            // buttonDeleteDiagnosis
            // 
            this.buttonDeleteDiagnosis.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeleteDiagnosis.Location = new System.Drawing.Point(12, 0);
            this.buttonDeleteDiagnosis.Name = "buttonDeleteDiagnosis";
            this.buttonDeleteDiagnosis.Size = new System.Drawing.Size(61, 38);
            this.buttonDeleteDiagnosis.TabIndex = 8;
            this.buttonDeleteDiagnosis.Text = "Изтрий";
            this.buttonDeleteDiagnosis.UseVisualStyleBackColor = true;
            this.buttonDeleteDiagnosis.Click += new System.EventHandler(this.buttonDeleteDiagnoses_Click);
            // 
            // buttonEditDiagnosis
            // 
            this.buttonEditDiagnosis.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEditDiagnosis.Location = new System.Drawing.Point(73, 0);
            this.buttonEditDiagnosis.Name = "buttonEditDiagnosis";
            this.buttonEditDiagnosis.Size = new System.Drawing.Size(79, 38);
            this.buttonEditDiagnosis.TabIndex = 7;
            this.buttonEditDiagnosis.Text = "Редактирай";
            this.buttonEditDiagnosis.UseVisualStyleBackColor = true;
            this.buttonEditDiagnosis.Click += new System.EventHandler(this.buttonEditDiagnoses_Click);
            // 
            // buttonAddDiagnosis
            // 
            this.buttonAddDiagnosis.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddDiagnosis.Location = new System.Drawing.Point(152, 0);
            this.buttonAddDiagnosis.Name = "buttonAddDiagnosis";
            this.buttonAddDiagnosis.Size = new System.Drawing.Size(89, 38);
            this.buttonAddDiagnosis.TabIndex = 6;
            this.buttonAddDiagnosis.Text = "Насрочи нова";
            this.buttonAddDiagnosis.UseVisualStyleBackColor = true;
            this.buttonAddDiagnosis.Click += new System.EventHandler(this.buttonAddDiagnoses_Click);
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 607);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.tabControlAdditionalInfo);
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преглед и редакция на пациент";
            this.tabControlAdditionalInfo.ResumeLayout(false);
            this.tabPageConsultations.ResumeLayout(false);
            this.panelConsultationsOperations.ResumeLayout(false);
            this.panelConsultationButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultations)).EndInit();
            this.tabPageDiagnosis.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderImage)).EndInit();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnoses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdditionalInfo;
        private System.Windows.Forms.TabPage tabPageConsultations;
        private System.Windows.Forms.TabPage tabPageDiagnosis;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeaderText;
        private System.Windows.Forms.PictureBox pictureBoxHeaderImage;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConsultationsOperations;
        private System.Windows.Forms.DataGridView dataGridViewConsultations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheduleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoctor;
        private System.Windows.Forms.Panel panelConsultationButtons;
        private System.Windows.Forms.Button buttonDeleteConsultation;
        private System.Windows.Forms.Button buttonEditConsultation;
        private System.Windows.Forms.Button buttonAddConsultation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDeleteDiagnosis;
        private System.Windows.Forms.Button buttonEditDiagnosis;
        private System.Windows.Forms.Button buttonAddDiagnosis;
        private System.Windows.Forms.DataGridView dataGridViewDiagnoses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnosticationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiagnoseDoctor;
    }
}