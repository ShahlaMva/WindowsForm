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
    public partial class Login : Form
    {
        private masterEntities db;
       

        private Users usr;
        public Login()
        {
            InitializeComponent();
            db = new masterEntities();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
        Register reg = new Register(this);
            reg.Show();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string parol = txtPassword.Text.Trim();

            if ( CheckLogin(email, parol))
            {
                if (usr.Levels==true)
                {
                    new AdminDashboard(this,usr).Show();
                }
                else
                {
                    new UserDashboard(this,usr).Show();
                }
                
                

            }

        }
            private bool CheckLogin(string email,string parol){

            string hashpass = Helper.HashPaswword(parol);

            if (email == "" || parol == "")
            {
                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            usr = db.Users.Where(u=>u.Email==email).Where(u=>u.Password==hashpass).FirstOrDefault();
            if (usr == null)
            {
                MessageBox.Show("User not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
          

           

            if (usr.Staus == false)
            {
                MessageBox.Show("User not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           

           
            return true;
            
        }
    }
}
