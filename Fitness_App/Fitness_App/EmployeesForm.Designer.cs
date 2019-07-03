namespace Fitness_App
{
    partial class EmployeesForm
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
            this.dgwEmployees = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbDefaulPassword = new System.Windows.Forms.Label();
            this.txtDefaulPassword = new System.Windows.Forms.TextBox();
            this.cmbPositions = new System.Windows.Forms.ComboBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cmbUpdateEmployee = new System.Windows.Forms.ComboBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbUpdateSurname = new System.Windows.Forms.Label();
            this.txtUpdateSurname = new System.Windows.Forms.TextBox();
            this.lbUpdateName = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lbUpdatePosition = new System.Windows.Forms.Label();
            this.cmbUpdatePosition = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbDelete = new System.Windows.Forms.Label();
            this.cmbDeleteEmployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEmployees
            // 
            this.dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployees.Location = new System.Drawing.Point(-47, 253);
            this.dgwEmployees.Name = "dgwEmployees";
            this.dgwEmployees.Size = new System.Drawing.Size(973, 166);
            this.dgwEmployees.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 20);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(128, 29);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(127, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(112, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(12, 88);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(15, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(80, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // lbDefaulPassword
            // 
            this.lbDefaulPassword.AutoSize = true;
            this.lbDefaulPassword.Location = new System.Drawing.Point(124, 88);
            this.lbDefaulPassword.Name = "lbDefaulPassword";
            this.lbDefaulPassword.Size = new System.Drawing.Size(90, 13);
            this.lbDefaulPassword.TabIndex = 8;
            this.lbDefaulPassword.Text = "Default Password";
            // 
            // txtDefaulPassword
            // 
            this.txtDefaulPassword.Location = new System.Drawing.Point(127, 104);
            this.txtDefaulPassword.Name = "txtDefaulPassword";
            this.txtDefaulPassword.Size = new System.Drawing.Size(112, 20);
            this.txtDefaulPassword.TabIndex = 7;
            // 
            // cmbPositions
            // 
            this.cmbPositions.FormattingEnabled = true;
            this.cmbPositions.Location = new System.Drawing.Point(16, 171);
            this.cmbPositions.Name = "cmbPositions";
            this.cmbPositions.Size = new System.Drawing.Size(243, 21);
            this.cmbPositions.TabIndex = 9;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(13, 155);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(44, 13);
            this.lbPosition.TabIndex = 10;
            this.lbPosition.Text = "Position";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 215);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(243, 32);
            this.btnAddEmployee.TabIndex = 11;
            this.btnAddEmployee.Text = "ADD EMPLOYEE";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // cmbUpdateEmployee
            // 
            this.cmbUpdateEmployee.FormattingEnabled = true;
            this.cmbUpdateEmployee.Location = new System.Drawing.Point(309, 44);
            this.cmbUpdateEmployee.Name = "cmbUpdateEmployee";
            this.cmbUpdateEmployee.Size = new System.Drawing.Size(149, 21);
            this.cmbUpdateEmployee.TabIndex = 12;
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(306, 29);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(42, 13);
            this.lbUpdate.TabIndex = 13;
            this.lbUpdate.Text = "Update";
            // 
            // lbUpdateSurname
            // 
            this.lbUpdateSurname.AutoSize = true;
            this.lbUpdateSurname.Location = new System.Drawing.Point(442, 88);
            this.lbUpdateSurname.Name = "lbUpdateSurname";
            this.lbUpdateSurname.Size = new System.Drawing.Size(49, 13);
            this.lbUpdateSurname.TabIndex = 17;
            this.lbUpdateSurname.Text = "Surname";
            // 
            // txtUpdateSurname
            // 
            this.txtUpdateSurname.Location = new System.Drawing.Point(445, 104);
            this.txtUpdateSurname.Name = "txtUpdateSurname";
            this.txtUpdateSurname.Size = new System.Drawing.Size(123, 20);
            this.txtUpdateSurname.TabIndex = 16;
            // 
            // lbUpdateName
            // 
            this.lbUpdateName.AutoSize = true;
            this.lbUpdateName.Location = new System.Drawing.Point(306, 88);
            this.lbUpdateName.Name = "lbUpdateName";
            this.lbUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lbUpdateName.TabIndex = 15;
            this.lbUpdateName.Text = "Name";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(309, 104);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(93, 20);
            this.txtUpdateName.TabIndex = 14;
            // 
            // lbUpdatePosition
            // 
            this.lbUpdatePosition.AutoSize = true;
            this.lbUpdatePosition.Location = new System.Drawing.Point(307, 155);
            this.lbUpdatePosition.Name = "lbUpdatePosition";
            this.lbUpdatePosition.Size = new System.Drawing.Size(44, 13);
            this.lbUpdatePosition.TabIndex = 19;
            this.lbUpdatePosition.Text = "Position";
            // 
            // cmbUpdatePosition
            // 
            this.cmbUpdatePosition.FormattingEnabled = true;
            this.cmbUpdatePosition.Location = new System.Drawing.Point(310, 171);
            this.cmbUpdatePosition.Name = "cmbUpdatePosition";
            this.cmbUpdatePosition.Size = new System.Drawing.Size(258, 21);
            this.cmbUpdatePosition.TabIndex = 18;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(310, 215);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(258, 32);
            this.btnUpdateEmployee.TabIndex = 20;
            this.btnUpdateEmployee.Text = "UPDATE EMPLOYEE";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(608, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 32);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE EMPLOYEE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbDelete.Location = new System.Drawing.Point(605, 29);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(38, 13);
            this.lbDelete.TabIndex = 22;
            this.lbDelete.Text = "Delete";
            // 
            // cmbDeleteEmployee
            // 
            this.cmbDeleteEmployee.FormattingEnabled = true;
            this.cmbDeleteEmployee.Location = new System.Drawing.Point(608, 44);
            this.cmbDeleteEmployee.Name = "cmbDeleteEmployee";
            this.cmbDeleteEmployee.Size = new System.Drawing.Size(149, 21);
            this.cmbDeleteEmployee.TabIndex = 21;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.cmbDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.lbUpdatePosition);
            this.Controls.Add(this.cmbUpdatePosition);
            this.Controls.Add(this.lbUpdateSurname);
            this.Controls.Add(this.txtUpdateSurname);
            this.Controls.Add(this.lbUpdateName);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.cmbUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.cmbPositions);
            this.Controls.Add(this.lbDefaulPassword);
            this.Controls.Add(this.txtDefaulPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgwEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbDefaulPassword;
        private System.Windows.Forms.TextBox txtDefaulPassword;
        private System.Windows.Forms.ComboBox cmbPositions;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbUpdateEmployee;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbUpdateSurname;
        private System.Windows.Forms.TextBox txtUpdateSurname;
        private System.Windows.Forms.Label lbUpdateName;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lbUpdatePosition;
        private System.Windows.Forms.ComboBox cmbUpdatePosition;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.ComboBox cmbDeleteEmployee;
    }
}