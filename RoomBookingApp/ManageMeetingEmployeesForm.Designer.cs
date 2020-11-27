﻿namespace RoomBookingApp
{
    partial class ManageMeetingEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMeetingEmployeesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMeetingEmployeeLst = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBoxMeetings = new System.Windows.Forms.ComboBox();
            this.buttonClearMeetingEMP = new System.Windows.Forms.Button();
            this.buttonRemoveMeetingEMP = new System.Windows.Forms.Button();
            this.buttonNewMeetingEMP = new System.Windows.Forms.Button();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelMeetingID = new System.Windows.Forms.Label();
            this.TextBoxIDMeetingEmployees = new System.Windows.Forms.TextBox();
            this.labelIDMeetingEmployee = new System.Windows.Forms.Label();
            this.dataGridViewManageEmployees = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetingEmployeeLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.dataGridViewMeetingEmployeeLst);
            this.panel1.Controls.Add(this.comboBoxMeetings);
            this.panel1.Controls.Add(this.buttonClearMeetingEMP);
            this.panel1.Controls.Add(this.buttonRemoveMeetingEMP);
            this.panel1.Controls.Add(this.buttonNewMeetingEMP);
            this.panel1.Controls.Add(this.labelEmployeeID);
            this.panel1.Controls.Add(this.labelMeetingID);
            this.panel1.Controls.Add(this.TextBoxIDMeetingEmployees);
            this.panel1.Controls.Add(this.labelIDMeetingEmployee);
            this.panel1.Controls.Add(this.dataGridViewManageEmployees);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 716);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewMeetingEmployeeLst
            // 
            this.dataGridViewMeetingEmployeeLst.AllowUserToAddRows = false;
            this.dataGridViewMeetingEmployeeLst.AllowUserToDeleteRows = false;
            this.dataGridViewMeetingEmployeeLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeetingEmployeeLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridViewMeetingEmployeeLst.Location = new System.Drawing.Point(78, 304);
            this.dataGridViewMeetingEmployeeLst.Name = "dataGridViewMeetingEmployeeLst";
            this.dataGridViewMeetingEmployeeLst.Size = new System.Drawing.Size(410, 236);
            this.dataGridViewMeetingEmployeeLst.TabIndex = 30;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Width = 50;
            // 
            // comboBoxMeetings
            // 
            this.comboBoxMeetings.FormattingEnabled = true;
            this.comboBoxMeetings.Location = new System.Drawing.Point(223, 219);
            this.comboBoxMeetings.Name = "comboBoxMeetings";
            this.comboBoxMeetings.Size = new System.Drawing.Size(213, 21);
            this.comboBoxMeetings.TabIndex = 29;
            // 
            // buttonClearMeetingEMP
            // 
            this.buttonClearMeetingEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearMeetingEMP.Location = new System.Drawing.Point(88, 559);
            this.buttonClearMeetingEMP.Name = "buttonClearMeetingEMP";
            this.buttonClearMeetingEMP.Size = new System.Drawing.Size(186, 25);
            this.buttonClearMeetingEMP.TabIndex = 27;
            this.buttonClearMeetingEMP.Text = "Clear Fields";
            this.buttonClearMeetingEMP.UseVisualStyleBackColor = true;
            this.buttonClearMeetingEMP.Click += new System.EventHandler(this.buttonClearMeetingEMP_Click);
            // 
            // buttonRemoveMeetingEMP
            // 
            this.buttonRemoveMeetingEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveMeetingEMP.Location = new System.Drawing.Point(301, 559);
            this.buttonRemoveMeetingEMP.Name = "buttonRemoveMeetingEMP";
            this.buttonRemoveMeetingEMP.Size = new System.Drawing.Size(187, 25);
            this.buttonRemoveMeetingEMP.TabIndex = 26;
            this.buttonRemoveMeetingEMP.Text = "Remove";
            this.buttonRemoveMeetingEMP.UseVisualStyleBackColor = true;
            this.buttonRemoveMeetingEMP.Click += new System.EventHandler(this.buttonRemoveMeetingEMP_Click);
            // 
            // buttonNewMeetingEMP
            // 
            this.buttonNewMeetingEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewMeetingEMP.Location = new System.Drawing.Point(88, 598);
            this.buttonNewMeetingEMP.Name = "buttonNewMeetingEMP";
            this.buttonNewMeetingEMP.Size = new System.Drawing.Size(400, 25);
            this.buttonNewMeetingEMP.TabIndex = 24;
            this.buttonNewMeetingEMP.Text = "Add New Room";
            this.buttonNewMeetingEMP.UseVisualStyleBackColor = true;
            this.buttonNewMeetingEMP.Click += new System.EventHandler(this.buttonNewMeetingEMP_Click);
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmployeeID.Location = new System.Drawing.Point(73, 258);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(140, 29);
            this.labelEmployeeID.TabIndex = 22;
            this.labelEmployeeID.Text = "Employees:";
            // 
            // labelMeetingID
            // 
            this.labelMeetingID.AutoSize = true;
            this.labelMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeetingID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMeetingID.Location = new System.Drawing.Point(78, 211);
            this.labelMeetingID.Name = "labelMeetingID";
            this.labelMeetingID.Size = new System.Drawing.Size(135, 29);
            this.labelMeetingID.TabIndex = 20;
            this.labelMeetingID.Text = "Meeting ID:";
            // 
            // TextBoxIDMeetingEmployees
            // 
            this.TextBoxIDMeetingEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxIDMeetingEmployees.Location = new System.Drawing.Point(223, 167);
            this.TextBoxIDMeetingEmployees.Name = "TextBoxIDMeetingEmployees";
            this.TextBoxIDMeetingEmployees.ReadOnly = true;
            this.TextBoxIDMeetingEmployees.Size = new System.Drawing.Size(213, 26);
            this.TextBoxIDMeetingEmployees.TabIndex = 19;
            // 
            // labelIDMeetingEmployee
            // 
            this.labelIDMeetingEmployee.AutoSize = true;
            this.labelIDMeetingEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMeetingEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIDMeetingEmployee.Location = new System.Drawing.Point(171, 163);
            this.labelIDMeetingEmployee.Name = "labelIDMeetingEmployee";
            this.labelIDMeetingEmployee.Size = new System.Drawing.Size(42, 29);
            this.labelIDMeetingEmployee.TabIndex = 18;
            this.labelIDMeetingEmployee.Text = "ID:";
            // 
            // dataGridViewManageEmployees
            // 
            this.dataGridViewManageEmployees.AllowUserToAddRows = false;
            this.dataGridViewManageEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewManageEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManageEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageEmployees.Location = new System.Drawing.Point(564, 158);
            this.dataGridViewManageEmployees.Name = "dataGridViewManageEmployees";
            this.dataGridViewManageEmployees.ReadOnly = true;
            this.dataGridViewManageEmployees.Size = new System.Drawing.Size(850, 500);
            this.dataGridViewManageEmployees.TabIndex = 11;
            this.dataGridViewManageEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageEmployees_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1484, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(555, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Meeting Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageMeetingEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 716);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 755);
            this.Name = "ManageMeetingEmployeesForm";
            this.Text = "ManageMeetingEmployeesForm";
            this.Load += new System.EventHandler(this.ManageMeetingEmployeesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeetingEmployeeLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageEmployees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewManageEmployees;
        private System.Windows.Forms.Button buttonClearMeetingEMP;
        private System.Windows.Forms.Button buttonRemoveMeetingEMP;
        private System.Windows.Forms.Button buttonNewMeetingEMP;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelMeetingID;
        private System.Windows.Forms.TextBox TextBoxIDMeetingEmployees;
        private System.Windows.Forms.Label labelIDMeetingEmployee;
        private System.Windows.Forms.ComboBox comboBoxMeetings;
        private System.Windows.Forms.DataGridView dataGridViewMeetingEmployeeLst;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}