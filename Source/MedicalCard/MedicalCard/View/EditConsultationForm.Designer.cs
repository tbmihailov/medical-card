namespace MedicalCard.View
{
    partial class EditConsultationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxConclusion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.labelReason = new System.Windows.Forms.Label();
            this.dateTimePickerScheduleTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.labelScheduleTime = new System.Windows.Forms.Label();
            this.labelScheduleDate = new System.Windows.Forms.Label();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.buttonLoadPatient = new System.Windows.Forms.Button();
            this.textBoxPatientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDoctor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.buttonLoadDoctor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.panelDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(386, 0);
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
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 381);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(584, 34);
            this.panelBottom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "No.";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(99, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(13, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "0";
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.Location = new System.Drawing.Point(251, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(323, 20);
            this.labelMessage.TabIndex = 12;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.panelDoctor);
            this.groupBoxInformation.Controls.Add(this.label7);
            this.groupBoxInformation.Controls.Add(this.label5);
            this.groupBoxInformation.Controls.Add(this.textBoxConclusion);
            this.groupBoxInformation.Controls.Add(this.label4);
            this.groupBoxInformation.Controls.Add(this.textBoxNotes);
            this.groupBoxInformation.Controls.Add(this.labelNotes);
            this.groupBoxInformation.Controls.Add(this.textBoxReason);
            this.groupBoxInformation.Controls.Add(this.labelReason);
            this.groupBoxInformation.Controls.Add(this.dateTimePickerScheduleTime);
            this.groupBoxInformation.Controls.Add(this.dateTimePickerScheduleDate);
            this.groupBoxInformation.Controls.Add(this.labelScheduleTime);
            this.groupBoxInformation.Controls.Add(this.labelScheduleDate);
            this.groupBoxInformation.Controls.Add(this.labelDoctor);
            this.groupBoxInformation.Controls.Add(this.labelPatient);
            this.groupBoxInformation.Controls.Add(this.panelPatient);
            this.groupBoxInformation.Controls.Add(this.labelMessage);
            this.groupBoxInformation.Controls.Add(this.labelId);
            this.groupBoxInformation.Controls.Add(this.label6);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInformation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(584, 301);
            this.groupBoxInformation.TabIndex = 5;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Инфромация за консултацията";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(235, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(554, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // textBoxConclusion
            // 
            this.textBoxConclusion.Location = new System.Drawing.Point(97, 237);
            this.textBoxConclusion.Multiline = true;
            this.textBoxConclusion.Name = "textBoxConclusion";
            this.textBoxConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConclusion.Size = new System.Drawing.Size(453, 48);
            this.textBoxConclusion.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Заключение";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(97, 183);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(453, 48);
            this.textBoxNotes.TabIndex = 24;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(39, 183);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(52, 13);
            this.labelNotes.TabIndex = 23;
            this.labelNotes.Text = "Бележки";
            this.labelNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(97, 129);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReason.Size = new System.Drawing.Size(453, 48);
            this.textBoxReason.TabIndex = 22;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(6, 129);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(85, 26);
            this.labelReason.TabIndex = 21;
            this.labelReason.Text = "Причина за\r\n консултацията";
            this.labelReason.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerScheduleTime
            // 
            this.dateTimePickerScheduleTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerScheduleTime.Location = new System.Drawing.Point(310, 103);
            this.dateTimePickerScheduleTime.Name = "dateTimePickerScheduleTime";
            this.dateTimePickerScheduleTime.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerScheduleTime.TabIndex = 20;
            this.dateTimePickerScheduleTime.Visible = false;
            // 
            // dateTimePickerScheduleDate
            // 
            this.dateTimePickerScheduleDate.Location = new System.Drawing.Point(97, 103);
            this.dateTimePickerScheduleDate.Name = "dateTimePickerScheduleDate";
            this.dateTimePickerScheduleDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerScheduleDate.TabIndex = 19;
            // 
            // labelScheduleTime
            // 
            this.labelScheduleTime.AutoSize = true;
            this.labelScheduleTime.Location = new System.Drawing.Point(282, 103);
            this.labelScheduleTime.Name = "labelScheduleTime";
            this.labelScheduleTime.Size = new System.Drawing.Size(27, 13);
            this.labelScheduleTime.TabIndex = 18;
            this.labelScheduleTime.Text = "Час";
            this.labelScheduleTime.Visible = false;
            // 
            // labelScheduleDate
            // 
            this.labelScheduleDate.AutoSize = true;
            this.labelScheduleDate.Location = new System.Drawing.Point(58, 103);
            this.labelScheduleDate.Name = "labelScheduleDate";
            this.labelScheduleDate.Size = new System.Drawing.Size(33, 13);
            this.labelScheduleDate.TabIndex = 17;
            this.labelScheduleDate.Text = "Дата";
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(52, 42);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(39, 13);
            this.labelDoctor.TabIndex = 15;
            this.labelDoctor.Text = "Лекар";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(41, 68);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(50, 13);
            this.labelPatient.TabIndex = 14;
            this.labelPatient.Text = "Пациент";
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.buttonLoadPatient);
            this.panelPatient.Controls.Add(this.textBoxPatientNumber);
            this.panelPatient.Controls.Add(this.label2);
            this.panelPatient.Controls.Add(this.textBoxPatientName);
            this.panelPatient.Controls.Add(this.label1);
            this.panelPatient.Location = new System.Drawing.Point(97, 65);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(453, 27);
            this.panelPatient.TabIndex = 13;
            // 
            // buttonLoadPatient
            // 
            this.buttonLoadPatient.Location = new System.Drawing.Point(372, 0);
            this.buttonLoadPatient.Name = "buttonLoadPatient";
            this.buttonLoadPatient.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadPatient.TabIndex = 22;
            this.buttonLoadPatient.Text = "Избери";
            this.buttonLoadPatient.UseVisualStyleBackColor = true;
            this.buttonLoadPatient.Visible = false;
            this.buttonLoadPatient.Click += new System.EventHandler(this.buttonLoadPatient_Click);
            // 
            // textBoxPatientNumber
            // 
            this.textBoxPatientNumber.Location = new System.Drawing.Point(280, 3);
            this.textBoxPatientNumber.Name = "textBoxPatientNumber";
            this.textBoxPatientNumber.ReadOnly = true;
            this.textBoxPatientNumber.Size = new System.Drawing.Size(86, 20);
            this.textBoxPatientNumber.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ЕГН";
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Location = new System.Drawing.Point(32, 3);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.ReadOnly = true;
            this.textBoxPatientName.Size = new System.Drawing.Size(208, 20);
            this.textBoxPatientName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Име";
            // 
            // panelDoctor
            // 
            this.panelDoctor.Controls.Add(this.buttonLoadDoctor);
            this.panelDoctor.Controls.Add(this.label3);
            this.panelDoctor.Controls.Add(this.textBoxDoctorName);
            this.panelDoctor.Location = new System.Drawing.Point(94, 36);
            this.panelDoctor.Name = "panelDoctor";
            this.panelDoctor.Size = new System.Drawing.Size(381, 26);
            this.panelDoctor.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(246, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(3, 3);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.ReadOnly = true;
            this.textBoxDoctorName.Size = new System.Drawing.Size(240, 20);
            this.textBoxDoctorName.TabIndex = 28;
            // 
            // buttonLoadDoctor
            // 
            this.buttonLoadDoctor.Location = new System.Drawing.Point(259, 3);
            this.buttonLoadDoctor.Name = "buttonLoadDoctor";
            this.buttonLoadDoctor.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadDoctor.TabIndex = 30;
            this.buttonLoadDoctor.Text = "Избери";
            this.buttonLoadDoctor.UseVisualStyleBackColor = true;
            this.buttonLoadDoctor.Click += new System.EventHandler(this.buttonLoadDoctor_Click);
            // 
            // EditConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 415);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.panelBottom);
            this.Name = "EditConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консултация";
            this.panel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.panelDoctor.ResumeLayout(false);
            this.panelDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button buttonLoadPatient;
        private System.Windows.Forms.TextBox textBoxPatientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelScheduleTime;
        private System.Windows.Forms.Label labelScheduleDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduleTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduleDate;
        private System.Windows.Forms.TextBox textBoxConclusion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDoctor;
        private System.Windows.Forms.Button buttonLoadDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDoctorName;
    }
}