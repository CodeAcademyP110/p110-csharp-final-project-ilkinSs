namespace Fitness_App
{
    partial class CasierForm
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
            this.lbCasierName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerSurname = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCasierName
            // 
            this.lbCasierName.AutoSize = true;
            this.lbCasierName.Location = new System.Drawing.Point(344, 9);
            this.lbCasierName.Name = "lbCasierName";
            this.lbCasierName.Size = new System.Drawing.Size(36, 13);
            this.lbCasierName.TabIndex = 0;
            this.lbCasierName.Text = "Casier";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(21, 103);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(232, 103);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerSurname.TabIndex = 2;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(18, 76);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lbCustomerName.TabIndex = 3;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // lbCustomerSurname
            // 
            this.lbCustomerSurname.AutoSize = true;
            this.lbCustomerSurname.Location = new System.Drawing.Point(229, 76);
            this.lbCustomerSurname.Name = "lbCustomerSurname";
            this.lbCustomerSurname.Size = new System.Drawing.Size(96, 13);
            this.lbCustomerSurname.TabIndex = 4;
            this.lbCustomerSurname.Text = "Customer Surname";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(21, 178);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(156, 47);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "ADD CUSTOMER";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // CasierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lbCustomerSurname);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lbCasierName);
            this.Name = "CasierForm";
            this.Text = "Casier";
            this.Load += new System.EventHandler(this.CasierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCasierName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerSurname;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}