namespace _29_07_19_test.Forms
{
    partial class MembersDashboard
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
            this.DgvMembers = new System.Windows.Forms.DataGridView();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtorMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finedMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.txtPassportId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMembers
            // 
            this.DgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMembers.Location = new System.Drawing.Point(0, 190);
            this.DgvMembers.Name = "DgvMembers";
            this.DgvMembers.RowTemplate.Height = 23;
            this.DgvMembers.Size = new System.Drawing.Size(798, 259);
            this.DgvMembers.TabIndex = 0;
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(468, 67);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMemberAdd.TabIndex = 1;
            this.btnMemberAdd.Text = "ADD";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.BtnMemberAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMembersToolStripMenuItem,
            this.debtorMembersToolStripMenuItem,
            this.finedMembersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allMembersToolStripMenuItem
            // 
            this.allMembersToolStripMenuItem.Name = "allMembersToolStripMenuItem";
            this.allMembersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.allMembersToolStripMenuItem.Text = "All Members";
            this.allMembersToolStripMenuItem.Click += new System.EventHandler(this.AllMembersToolStripMenuItem_Click);
            // 
            // debtorMembersToolStripMenuItem
            // 
            this.debtorMembersToolStripMenuItem.Name = "debtorMembersToolStripMenuItem";
            this.debtorMembersToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.debtorMembersToolStripMenuItem.Text = "Debtor Members";
            // 
            // finedMembersToolStripMenuItem
            // 
            this.finedMembersToolStripMenuItem.Name = "finedMembersToolStripMenuItem";
            this.finedMembersToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.finedMembersToolStripMenuItem.Text = "Fined Members";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(29, 67);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(121, 21);
            this.txtMemberName.TabIndex = 5;
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(171, 67);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(121, 21);
            this.txtMemberSurname.TabIndex = 6;
            // 
            // txtPassportId
            // 
            this.txtPassportId.Location = new System.Drawing.Point(307, 67);
            this.txtPassportId.Name = "txtPassportId";
            this.txtPassportId.Size = new System.Drawing.Size(117, 21);
            this.txtPassportId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Passport Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(166, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Surname:";
            // 
            // MembersDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassportId);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.btnMemberAdd);
            this.Controls.Add(this.DgvMembers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MembersDashboard";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMembers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMembers;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtorMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finedMembersToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.TextBox txtPassportId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}