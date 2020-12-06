namespace RoomBookingApp
{
    partial class ManageMeetingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMeetingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMeetings = new System.Windows.Forms.GroupBox();
            this.textBoxMeetingDesc = new System.Windows.Forms.TextBox();
            this.dateTimePickerMeetingEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerMeetingStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomMeeting = new System.Windows.Forms.ComboBox();
            this.textBoxIDMeeting = new System.Windows.Forms.TextBox();
            this.buttonClearMeeting = new System.Windows.Forms.Button();
            this.buttonNewMeeting = new System.Windows.Forms.Button();
            this.buttonRemoveMeeting = new System.Windows.Forms.Button();
            this.buttonEditMeeting = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxMeetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.groupBoxMeetings);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 716);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMeetings
            // 
            this.groupBoxMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMeetings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupBoxMeetings.Controls.Add(this.textBoxMeetingDesc);
            this.groupBoxMeetings.Controls.Add(this.dateTimePickerMeetingEnd);
            this.groupBoxMeetings.Controls.Add(this.label2);
            this.groupBoxMeetings.Controls.Add(this.dateTimePickerMeetingStart);
            this.groupBoxMeetings.Controls.Add(this.label3);
            this.groupBoxMeetings.Controls.Add(this.label6);
            this.groupBoxMeetings.Controls.Add(this.label4);
            this.groupBoxMeetings.Controls.Add(this.label5);
            this.groupBoxMeetings.Controls.Add(this.comboBoxRoomMeeting);
            this.groupBoxMeetings.Controls.Add(this.textBoxIDMeeting);
            this.groupBoxMeetings.Controls.Add(this.buttonClearMeeting);
            this.groupBoxMeetings.Controls.Add(this.buttonNewMeeting);
            this.groupBoxMeetings.Controls.Add(this.buttonRemoveMeeting);
            this.groupBoxMeetings.Controls.Add(this.buttonEditMeeting);
            this.groupBoxMeetings.Location = new System.Drawing.Point(50, 163);
            this.groupBoxMeetings.Name = "groupBoxMeetings";
            this.groupBoxMeetings.Size = new System.Drawing.Size(480, 500);
            this.groupBoxMeetings.TabIndex = 31;
            this.groupBoxMeetings.TabStop = false;
            // 
            // textBoxMeetingDesc
            // 
            this.textBoxMeetingDesc.Location = new System.Drawing.Point(229, 185);
            this.textBoxMeetingDesc.Multiline = true;
            this.textBoxMeetingDesc.Name = "textBoxMeetingDesc";
            this.textBoxMeetingDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMeetingDesc.Size = new System.Drawing.Size(211, 171);
            this.textBoxMeetingDesc.TabIndex = 27;
            // 
            // dateTimePickerMeetingEnd
            // 
            this.dateTimePickerMeetingEnd.CustomFormat = "HH:mm";
            this.dateTimePickerMeetingEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMeetingEnd.Location = new System.Drawing.Point(228, 138);
            this.dateTimePickerMeetingEnd.Name = "dateTimePickerMeetingEnd";
            this.dateTimePickerMeetingEnd.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerMeetingEnd.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, -30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID:";
            // 
            // dateTimePickerMeetingStart
            // 
            this.dateTimePickerMeetingStart.CustomFormat = "HH:mm";
            this.dateTimePickerMeetingStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMeetingStart.Location = new System.Drawing.Point(228, 89);
            this.dateTimePickerMeetingStart.Name = "dateTimePickerMeetingStart";
            this.dateTimePickerMeetingStart.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerMeetingStart.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(134, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(51, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Meeting Desc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Meeting Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(63, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Meeting End:";
            // 
            // comboBoxRoomMeeting
            // 
            this.comboBoxRoomMeeting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomMeeting.FormattingEnabled = true;
            this.comboBoxRoomMeeting.Location = new System.Drawing.Point(228, 42);
            this.comboBoxRoomMeeting.Name = "comboBoxRoomMeeting";
            this.comboBoxRoomMeeting.Size = new System.Drawing.Size(213, 21);
            this.comboBoxRoomMeeting.TabIndex = 26;
            // 
            // textBoxIDMeeting
            // 
            this.textBoxIDMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDMeeting.Location = new System.Drawing.Point(204, -26);
            this.textBoxIDMeeting.Name = "textBoxIDMeeting";
            this.textBoxIDMeeting.ReadOnly = true;
            this.textBoxIDMeeting.Size = new System.Drawing.Size(213, 26);
            this.textBoxIDMeeting.TabIndex = 18;
            // 
            // buttonClearMeeting
            // 
            this.buttonClearMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearMeeting.Location = new System.Drawing.Point(68, 377);
            this.buttonClearMeeting.Name = "buttonClearMeeting";
            this.buttonClearMeeting.Size = new System.Drawing.Size(150, 25);
            this.buttonClearMeeting.TabIndex = 25;
            this.buttonClearMeeting.Text = "Clear Fields";
            this.buttonClearMeeting.UseVisualStyleBackColor = true;
            this.buttonClearMeeting.Click += new System.EventHandler(this.ButtonClearMeeting_Click);
            // 
            // buttonNewMeeting
            // 
            this.buttonNewMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewMeeting.Location = new System.Drawing.Point(68, 412);
            this.buttonNewMeeting.Name = "buttonNewMeeting";
            this.buttonNewMeeting.Size = new System.Drawing.Size(373, 25);
            this.buttonNewMeeting.TabIndex = 22;
            this.buttonNewMeeting.Text = "Add New Meeting";
            this.buttonNewMeeting.UseVisualStyleBackColor = true;
            this.buttonNewMeeting.Click += new System.EventHandler(this.ButtonNewMeeting_Click);
            // 
            // buttonRemoveMeeting
            // 
            this.buttonRemoveMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveMeeting.Location = new System.Drawing.Point(341, 377);
            this.buttonRemoveMeeting.Name = "buttonRemoveMeeting";
            this.buttonRemoveMeeting.Size = new System.Drawing.Size(100, 25);
            this.buttonRemoveMeeting.TabIndex = 24;
            this.buttonRemoveMeeting.Text = "Remove";
            this.buttonRemoveMeeting.UseVisualStyleBackColor = true;
            this.buttonRemoveMeeting.Click += new System.EventHandler(this.ButtonRemoveMeeting_Click);
            // 
            // buttonEditMeeting
            // 
            this.buttonEditMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditMeeting.Location = new System.Drawing.Point(228, 377);
            this.buttonEditMeeting.Name = "buttonEditMeeting";
            this.buttonEditMeeting.Size = new System.Drawing.Size(100, 25);
            this.buttonEditMeeting.TabIndex = 23;
            this.buttonEditMeeting.Text = "Edit";
            this.buttonEditMeeting.UseVisualStyleBackColor = true;
            this.buttonEditMeeting.Click += new System.EventHandler(this.ButtonEditMeeting_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 500);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
            this.label1.Location = new System.Drawing.Point(604, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Meetings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageMeetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 716);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 755);
            this.Name = "ManageMeetingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMeetingsForm";
            this.Load += new System.EventHandler(this.ManageMeetingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxMeetings.ResumeLayout(false);
            this.groupBoxMeetings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClearMeeting;
        private System.Windows.Forms.Button buttonRemoveMeeting;
        private System.Windows.Forms.Button buttonEditMeeting;
        private System.Windows.Forms.Button buttonNewMeeting;
        private System.Windows.Forms.TextBox textBoxIDMeeting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMeetingDesc;
        private System.Windows.Forms.ComboBox comboBoxRoomMeeting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerMeetingEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerMeetingStart;
        private System.Windows.Forms.GroupBox groupBoxMeetings;
    }
}