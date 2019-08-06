using _29_07_19_test.Forms;
using _29_07_19_test.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29_07_19_test
{
    public partial class UserDashboard : Form
    {
        private masterEntities db;
        private Form _login;
        private Users _usr;
        
        public UserDashboard(Form login,Users usr)
        {
            InitializeComponent();
            db = new masterEntities();
            _login = login;
            _usr = usr;
        }



        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();
            string employeeName = db.Users.Where(u => u.Id == _usr.Id).Select(u => u.UserName + " " + u.Surname).FirstOrDefault();
         Employeename.Text = ($"Employee: {employeeName}");
        }

       

        private void AddMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BooksDashboard(this).Show();
        }

        private void MemberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.MembersDashboard(this).Show();
        }

        private void LendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LendingDashboard(this).Show();
        }
    }
}
