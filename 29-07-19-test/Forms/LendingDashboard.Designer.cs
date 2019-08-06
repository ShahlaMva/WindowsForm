namespace _29_07_19_test.Forms
{
    partial class LendingDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LendingDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPassportId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combBookName = new System.Windows.Forms.ComboBox();
            this.txtReturnedTime = new System.Windows.Forms.TextBox();
            this.btnCreateLending = new System.Windows.Forms.Button();
            this.DgvLending = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLending)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member PassportId";
            // 
            // cmbPassportId
            // 
            this.cmbPassportId.FormattingEnabled = true;
            this.cmbPassportId.Location = new System.Drawing.Point(45, 57);
            this.cmbPassportId.Name = "cmbPassportId";
            this.cmbPassportId.Size = new System.Drawing.Size(121, 21);
            this.cmbPassportId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(341, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Returned Time";
            // 
            // combBookName
            // 
            this.combBookName.FormattingEnabled = true;
            this.combBookName.Location = new System.Drawing.Point(192, 57);
            this.combBookName.Name = "combBookName";
            this.combBookName.Size = new System.Drawing.Size(121, 21);
            this.combBookName.TabIndex = 4;
            // 
            // txtReturnedTime
            // 
            this.txtReturnedTime.Location = new System.Drawing.Point(344, 56);
            this.txtReturnedTime.Name = "txtReturnedTime";
            this.txtReturnedTime.Size = new System.Drawing.Size(100, 21);
            this.txtReturnedTime.TabIndex = 5;
            // 
            // btnCreateLending
            // 
            this.btnCreateLending.Location = new System.Drawing.Point(491, 54);
            this.btnCreateLending.Name = "btnCreateLending";
            this.btnCreateLending.Size = new System.Drawing.Size(75, 23);
            this.btnCreateLending.TabIndex = 6;
            this.btnCreateLending.Text = "CREATE";
            this.btnCreateLending.UseVisualStyleBackColor = true;
            this.btnCreateLending.Click += new System.EventHandler(this.BtnCreateLending_Click);
            // 
            // DgvLending
            // 
            this.DgvLending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLending.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DgvLending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLending.Location = new System.Drawing.Point(-1, 156);
            this.DgvLending.Name = "DgvLending";
            this.DgvLending.RowTemplate.Height = 23;
            this.DgvLending.Size = new System.Drawing.Size(800, 297);
            this.DgvLending.TabIndex = 7;
            // 
            // LendingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvLending);
            this.Controls.Add(this.btnCreateLending);
            this.Controls.Add(this.txtReturnedTime);
            this.Controls.Add(this.combBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPassportId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LendingDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lending";
            this.Load += new System.EventHandler(this.LendingDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPassportId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combBookName;
        private System.Windows.Forms.TextBox txtReturnedTime;
        private System.Windows.Forms.Button btnCreateLending;
        private System.Windows.Forms.DataGridView DgvLending;
    }
}