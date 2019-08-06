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
    public partial class LendingDashboard : Form
    {
        private UserDashboard _userDash;
        private masterEntities db;
        private Lending lending;
        public LendingDashboard(UserDashboard userdash)
        {
            InitializeComponent();
            _userDash = userdash;
            db = new masterEntities();
        }

        private void LendingDashboard_Load(object sender, EventArgs e)
        {
            DgvLending.DataSource = db.Lending.Select(lend => new
            {
                lend.Id,
                lend.Members.MemberName,
                lend.Members.MemberSurname,
                lend.LentedUsername,
                lend.DataTimeBorrowed,
                lend.DataTimeReturned,
               PasssportId= lend.Members.PassportId


            }).OrderByDescending(lend=>lend.Id).ToList();


            cmbPassportId.DataSource = db.Members.Select(ps => new PassportClass { Id = ps.Id, PassportId = ps.PassportId }).ToList();
            cmbPassportId.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbPassportId.AutoCompleteSource = AutoCompleteSource.ListItems;

            combBookName.DataSource = db.Books.Select(cmb => new CmbBooksClass { Id = cmb.Id, GenreName = cmb.BookName }).ToList();
            db.SaveChanges();
        }


        private void CheckCreateLend()
        {
            string passportId = (cmbPassportId.SelectedItem as CmbBooksClass).ToString();
            string bookNames = (combBookName.SelectedItem as CmbBooksClass).ToString();
            DateTime? returnTime = Convert.ToDateTime(txtReturnedTime.Text);

            if (passportId == null || bookNames == null || returnTime == null)
            {
                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           


        }

        private void BtnCreateLending_Click(object sender, EventArgs e)
        {
            CheckCreateLend();
        }

       
    }
}
