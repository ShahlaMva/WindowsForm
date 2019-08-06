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
    public partial class BooksDashboard : Form
    {
        private UserDashboard _userDash;
        private masterEntities db;
        private Books bk;
        private Books books;


        public BooksDashboard(UserDashboard userDash)
        {
            InitializeComponent();
            _userDash = userDash;
            db = new masterEntities();
        }

        private void BooksDashboard_Load(object sender, EventArgs e)
        {

            UpdateDgvBooks();
            CmbGenreBook.DataSource = db.BookGenre.Select(bg => new CmbBooksClass { Id=bg.Id,GenreName=bg.GenreName}).ToList();
            db.SaveChanges();
            //CmbGenreBook.AutoCompleteMode = AutoCompleteMode.Suggest;
            //CmbGenreBook.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

       

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
          
            CheckBookInputs();

            db.Books.Add(bk);
            db.SaveChanges();
            DgvBooks.DataSource = null;
            UpdateDgvBooks();

            txtBookName.Text=null;
            txtBookCount.Text = null;
            txtBookPrice.Text = null;
            CmbGenreBook.Text = null;



        }

        private void CheckBookInputs()
        {
            string bookName = txtBookName.Text.Trim();
            int? genreId = (CmbGenreBook.SelectedItem as CmbBooksClass).Id;
            int? bookCount = int.Parse(txtBookCount.Text);
            float? bookPrice = float.Parse(txtBookPrice.Text);

            if (bookName == null || genreId == null || bookCount == null || bookPrice == null)
            {
                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               

            }
             
            
            else
            {
                bk = new Books { BookName = bookName, BookCount = bookCount, Price = bookPrice, GenreId = genreId };
               
                
            }
            
             
            
           
        }

        private void UpdateDgvBooks()
        {
          
            DgvBooks.DataSource = db.Books.Where(b=>b.Deleted==false).Select(b => new
            {
                b.Id,
                Name = b.BookName,
                Genre = b.BookGenre.GenreName,
                Count = b.BookCount,
                b.Price,
            }).OrderByDescending(b => b.Id).ToList();
        }

        private void DgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
            int id = (int)DgvBooks.Rows[e.RowIndex].Cells[0].Value;
            books = db.Books.Find(id);
            txtBookName.Text = books.BookName;
            txtBookCount.Text = books.BookCount.ToString();
            CmbGenreBook.Text =books.BookGenre.GenreName;
            txtBookPrice.Text = books.Price.ToString();
            btnAddBook.Visible = false;
            btnBookEdit.Visible = true;
           
        }

        private void BtnBookEdit_Click(object sender, EventArgs e)
        {
            CheckBookInputs();
           books.BookName = bk.BookName;
            books.BookCount = bk.BookCount;
            books.GenreId = bk.GenreId;
            books.Price = bk.Price;


            db.SaveChanges();
            DgvBooks.DataSource = null;
            UpdateDgvBooks();
        }

        
          
           

        private void BtnBookDelete_Click(object sender, EventArgs e)
        {
            CheckBookInputs();
            DialogResult result = MessageBox.Show($"Are you sure delete {bk.BookName} ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                books.Deleted = true;
            }
            

            db.SaveChanges();
            DgvBooks.DataSource = null;
            UpdateDgvBooks();
        }
    }
}
