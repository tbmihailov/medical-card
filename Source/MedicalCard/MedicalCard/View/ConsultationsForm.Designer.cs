namespace MedicalCard.View
{
    partial class ConsultationsForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPatientsSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.ColumnScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBoxPatientsSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(304, 31);
            this.lblMessage.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 31);
            this.panel1.TabIndex = 8;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonEdit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(400, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(269, 31);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.Location = new System.Drawing.Point(176, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 31);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.Location = new System.Drawing.Point(88, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 31);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonEdit.Location = new System.Drawing.Point(0, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 31);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Редактирай";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(451, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Търсене";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxPatientsSearch
            // 
            this.groupBoxPatientsSearch.Controls.Add(this.dateTimePickerTo);
            this.groupBoxPatientsSearch.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxPatientsSearch.Controls.Add(this.buttonSearch);
            this.groupBoxPatientsSearch.Controls.Add(this.label3);
            this.groupBoxPatientsSearch.Controls.Add(this.label1);
            this.groupBoxPatientsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatientsSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPatientsSearch.Name = "groupBoxPatientsSearch";
            this.groupBoxPatientsSearch.Size = new System.Drawing.Size(669, 52);
            this.groupBoxPatientsSearch.TabIndex = 5;
            this.groupBoxPatientsSearch.TabStop = false;
            this.groupBoxPatientsSearch.Text = "Търсене";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(279, 20);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerTo.TabIndex = 10;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(66, 20);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "до дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "От дата";
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Location = new System.Drawing.Point(0, 412);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(669, 22);
            this.statusStripBottom.TabIndex = 6;
            this.statusStripBottom.Text = "statusStripBottom";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnScheduleDate,
            this.ColumnDoctor,
            this.ColumnPatientName,
            this.ColumnReason,
            this.ColumnConclusion});
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 52);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.Size = new System.Drawing.Size(669, 329);
            this.dataGridViewResult.TabIndex = 9;
            // 
            // ColumnScheduleDate
            // 
            this.ColumnScheduleDate.DataPropertyName = "ScheduleDate";
            this.ColumnScheduleDate.HeaderText = "Дата";
            this.ColumnScheduleDate.Name = "ColumnScheduleDate";
            this.ColumnScheduleDate.ReadOnly = true;
            // 
            // ColumnDoctor
            // 
            this.ColumnDoctor.DataPropertyName = "DoctorName";
            this.ColumnDoctor.HeaderText = "Лекар";
            this.ColumnDoctor.Name = "ColumnDoctor";
            this.ColumnDoctor.ReadOnly = true;
            // 
            // ColumnPatientName
            // 
            this.ColumnPatientName.DataPropertyName = "PatientName";
            this.ColumnPatientName.HeaderText = "Пациент";
            this.ColumnPatientName.Name = "ColumnPatientName";
            this.ColumnPatientName.ReadOnly = true;
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
            // ConsultationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 434);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxPatientsSearch);
            this.Controls.Add(this.statusStripBottom);
            this.Name = "ConsultationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консултации";
            this.panel1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.groupBoxPatientsSearch.ResumeLayout(false);
            this.groupBoxPatientsSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxPatientsSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConclusion;
    }
}