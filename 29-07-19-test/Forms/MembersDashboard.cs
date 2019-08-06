using _29_07_19_test.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29_07_19_test.Forms
{
    public partial class MembersDashboard : Form
    {
        private masterEntities db;
        private UserDashboard _userDash;
        private Members member;
        public MembersDashboard(UserDashboard userDash)
        {
            InitializeComponent();
            _userDash = userDash;
            db = new masterEntities();
        }

        private void Members_Load(object sender, EventArgs e)
        {

            UpdateMembersDgv();
            
            db.SaveChanges();
        }

        private void AllMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMembersDgv();

        }

        private void BtnMemberAdd_Click(object sender, EventArgs e)
        {
            CheckMemberInfo();
            db.Members.Add(member);
            db.SaveChanges();

            UpdateMembersDgv();
        }

        private void CheckMemberInfo()
        {
            
            


            string memberName = txtMemberName.Text.Trim();
            string memberSurname = txtMemberSurname.Text.Trim();
            string passportId = txtPassportId.Text.Trim();
       
         

            if (memberName == null || memberSurname == null || passportId == null  )
            {
                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                member = new Members
                {
                    MemberName = memberName,
                    MemberSurname = memberSurname,
                    PassportId = passportId,
                  

                };
  

}

        }

       private void UpdateMembersDgv()
        {
            DgvMembers.DataSource = null;
            DgvMembers.DataSource = db.Members.Select(mb => new
            {
                mb.Id,
                mb.MemberName,
                mb.MemberSurname,
                mb.PassportId,
               
            
               
            }).OrderByDescending(mb => mb.Id).ToList();
        }

       


       
    }
}
