namespace RoomBookingApp
{
    partial class ManageEmployeesForm
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
            this.buttonClearEmp = new System.Windows.Forms.Button();
            this.buttonRemoveEmp = new System.Windows.Forms.Button();
            this.buttonEditEmp = new System.Windows.Forms.Button();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxEmailEmp = new System.Windows.Forms.TextBox();
            this.textBoxLnameEmp = new System.Windows.Forms.TextBox();
            this.textBoxFnameEmp = new System.Windows.Forms.TextBox();
            this.textBoxIDEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.buttonClearEmp);
            this.panel1.Controls.Add(this.buttonRemoveEmp);
            this.panel1.Controls.Add(this.buttonEditEmp);
            this.panel1.Controls.Add(this.buttonNewEmployee);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxEmailEmp);
            this.panel1.Controls.Add(this.textBoxLnameEmp);
            this.panel1.Controls.Add(this.textBoxFnameEmp);
            this.panel1.Controls.Add(this.textBoxIDEmp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 716);
            this.panel1.TabIndex = 0;
            // 
            // buttonClearEmp
            // 
            this.buttonClearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEmp.Location = new System.Drawing.Point(69, 430);
            this.buttonClearEmp.Name = "buttonClearEmp";
            this.buttonClearEmp.Size = new System.Drawing.Size(150, 25);
            this.buttonClearEmp.TabIndex = 13;
            this.buttonClearEmp.Text = "Clear Fields";
            this.buttonClearEmp.UseVisualStyleBackColor = true;
            this.buttonClearEmp.Click += new System.EventHandler(this.ButtonClearEmp_Click);
            // 
            // buttonRemoveEmp
            // 
            this.buttonRemoveEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveEmp.Location = new System.Drawing.Point(342, 430);
            this.buttonRemoveEmp.Name = "buttonRemoveEmp";
            this.buttonRemoveEmp.Size = new System.Drawing.Size(100, 25);
            this.buttonRemoveEmp.TabIndex = 12;
            this.buttonRemoveEmp.Text = "Remove";
            this.buttonRemoveEmp.UseVisualStyleBackColor = true;
            this.buttonRemoveEmp.Click += new System.EventHandler(this.ButtonRemoveEmp_Click);
            // 
            // buttonEditEmp
            // 
            this.buttonEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditEmp.Location = new System.Drawing.Point(229, 430);
            this.buttonEditEmp.Name = "buttonEditEmp";
            this.buttonEditEmp.Size = new System.Drawing.Size(100, 25);
            this.buttonEditEmp.TabIndex = 11;
            this.buttonEditEmp.Text = "Edit";
            this.buttonEditEmp.UseVisualStyleBackColor = true;
            this.buttonEditEmp.Click += new System.EventHandler(this.ButtonEditEmp_Click);
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewEmployee.Location = new System.Drawing.Point(69, 465);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(373, 25);
            this.buttonNewEmployee.TabIndex = 10;
            this.buttonNewEmployee.Text = "Add New Employee";
            this.buttonNewEmployee.UseVisualStyleBackColor = true;
            this.buttonNewEmployee.Click += new System.EventHandler(this.ButtonNewEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 500);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // textBoxEmailEmp
            // 
            this.textBoxEmailEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailEmp.Location = new System.Drawing.Point(229, 370);
            this.textBoxEmailEmp.Name = "textBoxEmailEmp";
            this.textBoxEmailEmp.Size = new System.Drawing.Size(213, 26);
            this.textBoxEmailEmp.TabIndex = 8;
            this.textBoxEmailEmp.TextChanged += new System.EventHandler(this.TextBoxEmailEmp_TextChanged);
            // 
            // textBoxLnameEmp
            // 
            this.textBoxLnameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLnameEmp.Location = new System.Drawing.Point(229, 321);
            this.textBoxLnameEmp.Name = "textBoxLnameEmp";
            this.textBoxLnameEmp.Size = new System.Drawing.Size(213, 26);
            this.textBoxLnameEmp.TabIndex = 7;
            this.textBoxLnameEmp.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBoxFnameEmp
            // 
            this.textBoxFnameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFnameEmp.Location = new System.Drawing.Point(229, 271);
            this.textBoxFnameEmp.Name = "textBoxFnameEmp";
            this.textBoxFnameEmp.Size = new System.Drawing.Size(213, 26);
            this.textBoxFnameEmp.TabIndex = 6;
            // 
            // textBoxIDEmp
            // 
            this.textBoxIDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDEmp.Location = new System.Drawing.Point(229, 225);
            this.textBoxIDEmp.Name = "textBoxIDEmp";
            this.textBoxIDEmp.ReadOnly = true;
            this.textBoxIDEmp.Size = new System.Drawing.Size(213, 26);
            this.textBoxIDEmp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(139, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(85, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(82, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
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
            this.label1.Size = new System.Drawing.Size(297, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employees";
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 716);
            this.Controls.Add(this.panel1);
            this.Name = "ManageEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployeesForm";
            this.Load += new System.EventHandler(this.ManageEmployeesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmailEmp;
        private System.Windows.Forms.TextBox textBoxLnameEmp;
        private System.Windows.Forms.TextBox textBoxFnameEmp;
        private System.Windows.Forms.TextBox textBoxIDEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonClearEmp;
        private System.Windows.Forms.Button buttonRemoveEmp;
        private System.Windows.Forms.Button buttonEditEmp;
        private System.Windows.Forms.Button buttonNewEmployee;
    }
}