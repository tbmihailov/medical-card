namespace MedicalCard.View
{
    partial class DiagnosesForm
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
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxPatientsSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBoxPatientsSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Location = new System.Drawing.Point(0, 363);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(638, 22);
            this.statusStripBottom.TabIndex = 11;
            this.statusStripBottom.Text = "statusStripBottom";
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
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnPatientName,
            this.ColumnScheduleDate,
            this.ColumnDoctor,
            this.ColumnNotes,
            this.ColumnPrescription});
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 52);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.Size = new System.Drawing.Size(638, 333);
            this.dataGridViewResult.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 31);
            this.panel1.TabIndex = 12;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(304, 31);
            this.lblMessage.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonEdit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(369, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(269, 31);
            this.panelButtons.TabIndex = 0;
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
            // groupBoxPatientsSearch
            // 
            this.groupBoxPatientsSearch.Controls.Add(this.textBoxSubject);
            this.groupBoxPatientsSearch.Controls.Add(this.buttonSearch);
            this.groupBoxPatientsSearch.Controls.Add(this.label1);
            this.groupBoxPatientsSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPatientsSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPatientsSearch.Name = "groupBoxPatientsSearch";
            this.groupBoxPatientsSearch.Size = new System.Drawing.Size(638, 52);
            this.groupBoxPatientsSearch.TabIndex = 10;
            this.groupBoxPatientsSearch.TabStop = false;
            this.groupBoxPatientsSearch.Text = "Търсене";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диагноза(съдържащ)";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(137, 17);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(288, 20);
            this.textBoxSubject.TabIndex = 9;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Диагноза";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnPatientName
            // 
            this.ColumnPatientName.DataPropertyName = "PatientName";
            this.ColumnPatientName.HeaderText = "Пациент";
            this.ColumnPatientName.Name = "ColumnPatientName";
            this.ColumnPatientName.ReadOnly = true;
            // 
            // ColumnScheduleDate
            // 
            this.ColumnScheduleDate.DataPropertyName = "DiagnosticationDate";
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
            // DiagnosesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 416);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxPatientsSearch);
            this.Name = "DiagnosesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диагнози";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.groupBoxPatientsSearch.ResumeLayout(false);
            this.groupBoxPatientsSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBoxPatientsSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrescription;
    }
}