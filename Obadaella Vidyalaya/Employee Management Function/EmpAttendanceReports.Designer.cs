﻿
namespace Obadaella_Vidyalaya
{
    partial class EmpAttendanceReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpAttendanceReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchCREMPAttendance = new System.Windows.Forms.TextBox();
            this.btnEmpAttendanceCR = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.dgvEmployeeAttendanceCR = new System.Windows.Forms.DataGridView();
            this.ATTENDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendanceCR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchCREMPAttendance
            // 
            this.txtSearchCREMPAttendance.Location = new System.Drawing.Point(11, 584);
            this.txtSearchCREMPAttendance.Name = "txtSearchCREMPAttendance";
            this.txtSearchCREMPAttendance.Size = new System.Drawing.Size(10, 20);
            this.txtSearchCREMPAttendance.TabIndex = 1;
            this.txtSearchCREMPAttendance.Visible = false;
            // 
            // btnEmpAttendanceCR
            // 
            this.btnEmpAttendanceCR.Location = new System.Drawing.Point(11, 568);
            this.btnEmpAttendanceCR.Name = "btnEmpAttendanceCR";
            this.btnEmpAttendanceCR.Size = new System.Drawing.Size(10, 10);
            this.btnEmpAttendanceCR.TabIndex = 2;
            this.btnEmpAttendanceCR.Text = "button1";
            this.btnEmpAttendanceCR.UseVisualStyleBackColor = true;
            this.btnEmpAttendanceCR.Visible = false;
            this.btnEmpAttendanceCR.Click += new System.EventHandler(this.btnEmpAttendanceCR_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 111);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1114, 524);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MaximumSize = new System.Drawing.Size(1115, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 112);
            this.panel3.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ඕබඩඇල්ල විද්‍යාලය,බණ්ඩාරවෙල";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(511, 2);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox19.MaximumSize = new System.Drawing.Size(91, 89);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(77, 63);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            // 
            // dgvEmployeeAttendanceCR
            // 
            this.dgvEmployeeAttendanceCR.AllowUserToDeleteRows = false;
            this.dgvEmployeeAttendanceCR.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmployeeAttendanceCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeAttendanceCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ATTENDID,
            this.EMPCODE,
            this.EMPNAME,
            this.DESIGNATION,
            this.STATUS,
            this.DATE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeAttendanceCR.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeAttendanceCR.Location = new System.Drawing.Point(11, 534);
            this.dgvEmployeeAttendanceCR.Name = "dgvEmployeeAttendanceCR";
            this.dgvEmployeeAttendanceCR.ReadOnly = true;
            this.dgvEmployeeAttendanceCR.RowHeadersVisible = false;
            this.dgvEmployeeAttendanceCR.Size = new System.Drawing.Size(10, 10);
            this.dgvEmployeeAttendanceCR.TabIndex = 68;
            this.dgvEmployeeAttendanceCR.Visible = false;
            // 
            // ATTENDID
            // 
            this.ATTENDID.DataPropertyName = "ATTENDID";
            this.ATTENDID.HeaderText = "AttendID";
            this.ATTENDID.Name = "ATTENDID";
            this.ATTENDID.ReadOnly = true;
            this.ATTENDID.Visible = false;
            // 
            // EMPCODE
            // 
            this.EMPCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPCODE.DataPropertyName = "EMPCODE";
            this.EMPCODE.HeaderText = "Employee ID";
            this.EMPCODE.Name = "EMPCODE";
            this.EMPCODE.ReadOnly = true;
            // 
            // EMPNAME
            // 
            this.EMPNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPNAME.DataPropertyName = "EMPNAME";
            this.EMPNAME.HeaderText = "Name";
            this.EMPNAME.Name = "EMPNAME";
            this.EMPNAME.ReadOnly = true;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESIGNATION.DataPropertyName = "DESIGNATION";
            this.DESIGNATION.HeaderText = "Designation";
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // EmpAttendanceReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.dgvEmployeeAttendanceCR);
            this.Controls.Add(this.btnEmpAttendanceCR);
            this.Controls.Add(this.txtSearchCREMPAttendance);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel3);
            this.MinimizeBox = false;
            this.Name = "EmpAttendanceReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpAttendanceReports";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendanceCR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchCREMPAttendance;
        private System.Windows.Forms.Button btnEmpAttendanceCR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvEmployeeAttendanceCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATTENDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}