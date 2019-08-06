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
  
    public partial class AdminDashboard : Form
    {
        private Form _login;
        private Users _usr;
        private masterEntities db;
       
        

        public AdminDashboard(Form login,Users usr)
        {
            InitializeComponent();
            db = new masterEntities();
            _login = login;
            _usr = usr;
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
            CurrentEmployees();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();
          string employeeName = db.Users.Where(u => u.Id == _usr.Id).Select(u => u.UserName+" "+ u.Surname).FirstOrDefault();
           UsersName.Text = ($"Manager: {employeeName}");

            UpdateNewEmployeeCount();
 }

    private void DgVUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DgVUsers.Rows[e.RowIndex].Cells[0].Value;
            Users usr = db.Users.Find(id);

            DialogResult result = MessageBox.Show($"Are you sure confirm {usr.UserName} {usr.Surname}?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result ==DialogResult.Yes)
            {
                usr.Staus = true;
            }
            else if(result==DialogResult.No)
            {
                usr.Deleted = true;
               
            }
            db.SaveChanges();

            DgvUpdateNewEmployee();
            UpdateNewEmployeeCount();



        }

        private void DontConfirmToolStripMenuItem_Click(object sender, EventArgs e)

        {

            DgvUpdateNewEmployee();
        }


          
        
            private void DgvUpdateNewEmployee()
            {

                DgVUsers.DataSource = null;
                DgVUsers.DataSource = db.Users.Where(u => u.Deleted == false).Where(u => u.Staus == false).Select(u => new
                {
                    u.Id,
                    Fullname = u.UserName + " " + u.Surname,
                    u.Levels,
                    u.Staus
                }).OrderByDescending(u => u.Id).ToList();
            
        }

        private void UpdateNewEmployeeCount()
        {
            int confirmCount = db.Users.Where(u => u.Staus == false).Where(u => u.Deleted == false).Count();
            DontConfirmMenu.Text = ($"New Employee:{ confirmCount}");


        }

        


        private void CurrentEmployees()
        {
            DgVUsers.DataSource = db.Users.Where(u => u.Deleted == false).Select(u => new
            {
                u.Id,
                Fullname = u.UserName + " " + u.Surname,
                u.Levels,
                u.Staus
            }).OrderByDescending(u => u.Id).ToList();
        }

        private void EmployeersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentEmployees();
        }
    }
}

