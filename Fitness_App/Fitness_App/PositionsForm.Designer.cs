namespace Fitness_App
{
    partial class PositionsForm
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
            this.lbAddPosition = new System.Windows.Forms.Label();
            this.txtAddPosition = new System.Windows.Forms.TextBox();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.dgwPositions = new System.Windows.Forms.DataGridView();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.lbDeletePosition = new System.Windows.Forms.Label();
            this.cmbDeletePosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddPosition
            // 
            this.lbAddPosition.AutoSize = true;
            this.lbAddPosition.Location = new System.Drawing.Point(36, 53);
            this.lbAddPosition.Name = "lbAddPosition";
            this.lbAddPosition.Size = new System.Drawing.Size(88, 13);
            this.lbAddPosition.TabIndex = 0;
            this.lbAddPosition.Text = "Add new position";
            // 
            // txtAddPosition
            // 
            this.txtAddPosition.Location = new System.Drawing.Point(39, 69);
            this.txtAddPosition.Name = "txtAddPosition";
            this.txtAddPosition.Size = new System.Drawing.Size(100, 20);
            this.txtAddPosition.TabIndex = 1;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(39, 95);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(100, 35);
            this.btnAddPosition.TabIndex = 2;
            this.btnAddPosition.Text = "Add Position";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.BtnAddPosition_Click);
            // 
            // dgwPositions
            // 
            this.dgwPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPositions.Location = new System.Drawing.Point(3, 263);
            this.dgwPositions.Name = "dgwPositions";
            this.dgwPositions.Size = new System.Drawing.Size(756, 150);
            this.dgwPositions.TabIndex = 3;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Location = new System.Drawing.Point(235, 95);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(100, 35);
            this.btnDeletePosition.TabIndex = 6;
            this.btnDeletePosition.Text = "DeletePosition";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.BtnDeletePosition_Click);
            // 
            // lbDeletePosition
            // 
            this.lbDeletePosition.AutoSize = true;
            this.lbDeletePosition.Location = new System.Drawing.Point(232, 53);
            this.lbDeletePosition.Name = "lbDeletePosition";
            this.lbDeletePosition.Size = new System.Drawing.Size(78, 13);
            this.lbDeletePosition.TabIndex = 4;
            this.lbDeletePosition.Text = "Delete Position";
            // 
            // cmbDeletePosition
            // 
            this.cmbDeletePosition.FormattingEnabled = true;
            this.cmbDeletePosition.Location = new System.Drawing.Point(235, 68);
            this.cmbDeletePosition.Name = "cmbDeletePosition";
            this.cmbDeletePosition.Size = new System.Drawing.Size(121, 21);
            this.cmbDeletePosition.TabIndex = 7;
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDeletePosition);
            this.Controls.Add(this.btnDeletePosition);
            this.Controls.Add(this.lbDeletePosition);
            this.Controls.Add(this.dgwPositions);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.txtAddPosition);
            this.Controls.Add(this.lbAddPosition);
            this.Name = "PositionsForm";
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.PositionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddPosition;
        private System.Windows.Forms.TextBox txtAddPosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.DataGridView dgwPositions;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Label lbDeletePosition;
        private System.Windows.Forms.ComboBox cmbDeletePosition;
    }
}