namespace Fitness_App
{
    partial class VerifyPasswordForm
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txtVerifyPassword = new System.Windows.Forms.TextBox();
            this.lbVerifyPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(91, 310);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(161, 42);
            this.btnVerify.TabIndex = 9;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(91, 167);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(161, 20);
            this.txtNewPassword.TabIndex = 8;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(88, 151);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lbNewPassword.TabIndex = 7;
            this.lbNewPassword.Text = "New Password";
            // 
            // txtVerifyPassword
            // 
            this.txtVerifyPassword.Location = new System.Drawing.Point(91, 108);
            this.txtVerifyPassword.Name = "txtVerifyPassword";
            this.txtVerifyPassword.Size = new System.Drawing.Size(161, 20);
            this.txtVerifyPassword.TabIndex = 6;
            // 
            // lbVerifyPassword
            // 
            this.lbVerifyPassword.AutoSize = true;
            this.lbVerifyPassword.Location = new System.Drawing.Point(88, 92);
            this.lbVerifyPassword.Name = "lbVerifyPassword";
            this.lbVerifyPassword.Size = new System.Drawing.Size(79, 13);
            this.lbVerifyPassword.TabIndex = 5;
            this.lbVerifyPassword.Text = "VerifyPassword";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(91, 223);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(161, 20);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Location = new System.Drawing.Point(88, 207);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(91, 13);
            this.lbConfirm.TabIndex = 10;
            this.lbConfirm.Text = "Confirm Password";
            // 
            // VerifyPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lbConfirm);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.txtVerifyPassword);
            this.Controls.Add(this.lbVerifyPassword);
            this.Name = "VerifyPasswordForm";
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox txtVerifyPassword;
        private System.Windows.Forms.Label lbVerifyPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lbConfirm;
    }
}