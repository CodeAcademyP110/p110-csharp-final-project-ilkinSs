namespace Fitness_App
{
    partial class Services
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
            this.dgwService = new System.Windows.Forms.DataGridView();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lbAddServices = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lbPriceHour = new System.Windows.Forms.Label();
            this.nmrPerHour = new System.Windows.Forms.NumericUpDown();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.cmbDeleteService = new System.Windows.Forms.ComboBox();
            this.lbDeleteService = new System.Windows.Forms.Label();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUpdateService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrUpdateTime = new System.Windows.Forms.ComboBox();
            this.nmrUpdateHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpdateHour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwService
            // 
            this.dgwService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwService.Location = new System.Drawing.Point(-3, 276);
            this.dgwService.Name = "dgwService";
            this.dgwService.Size = new System.Drawing.Size(791, 150);
            this.dgwService.TabIndex = 0;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(23, 37);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(187, 20);
            this.txtServiceName.TabIndex = 1;
            // 
            // lbAddServices
            // 
            this.lbAddServices.AutoSize = true;
            this.lbAddServices.Location = new System.Drawing.Point(20, 21);
            this.lbAddServices.Name = "lbAddServices";
            this.lbAddServices.Size = new System.Drawing.Size(74, 13);
            this.lbAddServices.TabIndex = 2;
            this.lbAddServices.Text = "Service Name";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(19, 116);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // lbPriceHour
            // 
            this.lbPriceHour.AutoSize = true;
            this.lbPriceHour.Location = new System.Drawing.Point(21, 64);
            this.lbPriceHour.Name = "lbPriceHour";
            this.lbPriceHour.Size = new System.Drawing.Size(73, 13);
            this.lbPriceHour.TabIndex = 5;
            this.lbPriceHour.Text = "Price per hour";
            // 
            // nmrPerHour
            // 
            this.nmrPerHour.Location = new System.Drawing.Point(23, 80);
            this.nmrPerHour.Name = "nmrPerHour";
            this.nmrPerHour.Size = new System.Drawing.Size(71, 20);
            this.nmrPerHour.TabIndex = 6;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(125, 80);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(85, 21);
            this.cmbTime.TabIndex = 7;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(122, 64);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(30, 13);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Time";
            // 
            // cmbDeleteService
            // 
            this.cmbDeleteService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteService.FormattingEnabled = true;
            this.cmbDeleteService.Location = new System.Drawing.Point(470, 36);
            this.cmbDeleteService.Name = "cmbDeleteService";
            this.cmbDeleteService.Size = new System.Drawing.Size(121, 21);
            this.cmbDeleteService.TabIndex = 9;
            // 
            // lbDeleteService
            // 
            this.lbDeleteService.AutoSize = true;
            this.lbDeleteService.Location = new System.Drawing.Point(467, 20);
            this.lbDeleteService.Name = "lbDeleteService";
            this.lbDeleteService.Size = new System.Drawing.Size(77, 13);
            this.lbDeleteService.TabIndex = 10;
            this.lbDeleteService.Text = "Delete Service";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(470, 77);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteService.TabIndex = 11;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(251, 164);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateService.TabIndex = 14;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Update Service";
            // 
            // cmbUpdateService
            // 
            this.cmbUpdateService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateService.FormattingEnabled = true;
            this.cmbUpdateService.Location = new System.Drawing.Point(252, 36);
            this.cmbUpdateService.Name = "cmbUpdateService";
            this.cmbUpdateService.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateService.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Time";
            // 
            // nmrUpdateTime
            // 
            this.nmrUpdateTime.FormattingEnabled = true;
            this.nmrUpdateTime.Location = new System.Drawing.Point(353, 128);
            this.nmrUpdateTime.Name = "nmrUpdateTime";
            this.nmrUpdateTime.Size = new System.Drawing.Size(85, 21);
            this.nmrUpdateTime.TabIndex = 19;
            // 
            // nmrUpdateHour
            // 
            this.nmrUpdateHour.Location = new System.Drawing.Point(251, 128);
            this.nmrUpdateHour.Name = "nmrUpdateHour";
            this.nmrUpdateHour.Size = new System.Drawing.Size(71, 20);
            this.nmrUpdateHour.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price per hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Service Name";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(251, 89);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(187, 20);
            this.txtUpdateName.TabIndex = 15;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrUpdateTime);
            this.Controls.Add(this.nmrUpdateHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUpdateService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.lbDeleteService);
            this.Controls.Add(this.cmbDeleteService);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.nmrPerHour);
            this.Controls.Add(this.lbPriceHour);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lbAddServices);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.dgwService);
            this.Name = "Services";
            this.Text = "dat";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpdateHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwService;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lbAddServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label lbPriceHour;
        private System.Windows.Forms.NumericUpDown nmrPerHour;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ComboBox cmbDeleteService;
        private System.Windows.Forms.Label lbDeleteService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUpdateService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nmrUpdateTime;
        private System.Windows.Forms.NumericUpDown nmrUpdateHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateName;
    }
}