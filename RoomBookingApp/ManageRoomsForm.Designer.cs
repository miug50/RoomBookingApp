﻿namespace RoomBookingApp
{
    partial class ManageRoomsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonClearRoom = new System.Windows.Forms.Button();
            this.labelIDRoom = new System.Windows.Forms.Label();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.TextBoxIDRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewRoom = new System.Windows.Forms.Button();
            this.TextBoxNameRoom = new System.Windows.Forms.TextBox();
            this.TextBoxCapacityRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.groupBoxRooms);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 716);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxRooms
            // 
            this.groupBoxRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupBoxRooms.Controls.Add(this.buttonEditRoom);
            this.groupBoxRooms.Controls.Add(this.buttonClearRoom);
            this.groupBoxRooms.Controls.Add(this.labelIDRoom);
            this.groupBoxRooms.Controls.Add(this.buttonRemoveRoom);
            this.groupBoxRooms.Controls.Add(this.TextBoxIDRoom);
            this.groupBoxRooms.Controls.Add(this.label2);
            this.groupBoxRooms.Controls.Add(this.buttonNewRoom);
            this.groupBoxRooms.Controls.Add(this.TextBoxNameRoom);
            this.groupBoxRooms.Controls.Add(this.TextBoxCapacityRoom);
            this.groupBoxRooms.Controls.Add(this.label3);
            this.groupBoxRooms.Location = new System.Drawing.Point(61, 163);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(480, 500);
            this.groupBoxRooms.TabIndex = 18;
            this.groupBoxRooms.TabStop = false;
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.Location = new System.Drawing.Point(221, 200);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(100, 25);
            this.buttonEditRoom.TabIndex = 15;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.ButtonEditRoom_Click);
            // 
            // buttonClearRoom
            // 
            this.buttonClearRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearRoom.Location = new System.Drawing.Point(44, 200);
            this.buttonClearRoom.Name = "buttonClearRoom";
            this.buttonClearRoom.Size = new System.Drawing.Size(150, 25);
            this.buttonClearRoom.TabIndex = 17;
            this.buttonClearRoom.Text = "Clear Fields";
            this.buttonClearRoom.UseVisualStyleBackColor = true;
            this.buttonClearRoom.Click += new System.EventHandler(this.ButtonClearRoom_Click);
            // 
            // labelIDRoom
            // 
            this.labelIDRoom.AutoSize = true;
            this.labelIDRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIDRoom.Location = new System.Drawing.Point(179, 45);
            this.labelIDRoom.Name = "labelIDRoom";
            this.labelIDRoom.Size = new System.Drawing.Size(42, 29);
            this.labelIDRoom.TabIndex = 6;
            this.labelIDRoom.Text = "ID:";
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRoom.Location = new System.Drawing.Point(344, 200);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(100, 25);
            this.buttonRemoveRoom.TabIndex = 16;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.ButtonRemoveRoom_Click);
            // 
            // TextBoxIDRoom
            // 
            this.TextBoxIDRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxIDRoom.Location = new System.Drawing.Point(231, 49);
            this.TextBoxIDRoom.Name = "TextBoxIDRoom";
            this.TextBoxIDRoom.ReadOnly = true;
            this.TextBoxIDRoom.Size = new System.Drawing.Size(213, 26);
            this.TextBoxIDRoom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room Name:";
            // 
            // buttonNewRoom
            // 
            this.buttonNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRoom.Location = new System.Drawing.Point(44, 239);
            this.buttonNewRoom.Name = "buttonNewRoom";
            this.buttonNewRoom.Size = new System.Drawing.Size(400, 25);
            this.buttonNewRoom.TabIndex = 14;
            this.buttonNewRoom.Text = "Add New Room";
            this.buttonNewRoom.UseVisualStyleBackColor = true;
            this.buttonNewRoom.Click += new System.EventHandler(this.ButtonNewRoom_Click);
            // 
            // TextBoxNameRoom
            // 
            this.TextBoxNameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxNameRoom.Location = new System.Drawing.Point(231, 97);
            this.TextBoxNameRoom.Name = "TextBoxNameRoom";
            this.TextBoxNameRoom.Size = new System.Drawing.Size(213, 26);
            this.TextBoxNameRoom.TabIndex = 9;
            // 
            // TextBoxCapacityRoom
            // 
            this.TextBoxCapacityRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxCapacityRoom.Location = new System.Drawing.Point(231, 143);
            this.TextBoxCapacityRoom.Name = "TextBoxCapacityRoom";
            this.TextBoxCapacityRoom.Size = new System.Drawing.Size(213, 26);
            this.TextBoxCapacityRoom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Room Capacity:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 500);
            this.dataGridView1.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(603, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 716);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 755);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxRooms.ResumeLayout(false);
            this.groupBoxRooms.PerformLayout();
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
        private System.Windows.Forms.TextBox TextBoxCapacityRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNameRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxIDRoom;
        private System.Windows.Forms.Label labelIDRoom;
        private System.Windows.Forms.Button buttonClearRoom;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonNewRoom;
        private System.Windows.Forms.GroupBox groupBoxRooms;
    }
}