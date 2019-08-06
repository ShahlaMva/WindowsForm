using _29_07_19_test.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace _29_07_19_test
{
    public partial class Register : Form
    {
        private Form _login;
        private masterEntities db;
   
        public Register(Form login)
        {
            InitializeComponent();
            _login =login;
            db = new masterEntities();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
            
        }

        private void BtnRegis_Click(object sender, EventArgs e)
        {
            string name = txtUserNAme.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string password = txtPass.Text.Trim();
            string conpassword = txtConfPas.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (CheckRegistr(name, surname, password, conpassword, email))
            {
                string hashPassword = Helper.HashPaswword(password);


                Users users = new Users()
                {
                    UserName = name,
                    Surname = surname,
                    Password = hashPassword,
                    Email=email
                    };
                db.Users.Add(users);
                db.SaveChanges();

                MessageBox.Show("Registration is successfully,please wait admin confirmation");

            }

           

        }

        private bool CheckRegistr(string name, string surname, string password, string conpassword, string email)
        {
            if (name == "" || surname == "" || password == "" || conpassword == "" || email == "")
            {

                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password != conpassword)
            {
                MessageBox.Show("Please password correctly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password.Length < 8 )
            {
                MessageBox.Show("Password must be minimum 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show("This email no exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (db.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("Email already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            txtUserNAme.Text = null;
            txtSurname.Text = null;
            txtEmail.Text = null;
            txtPass.Text = null;
            txtConfPas.Text = null;
            return true;
            


        }

       
    }
}
