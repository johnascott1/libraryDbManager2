using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using Google.Apis.Books.v1.Data;
using System.Diagnostics;



namespace libraryDbManager
{
    public partial class frmHomePage : Form
    {
        BooksService bookApi = new BooksService();
        //BookAPIClass apiBookClass = new BookAPIClass();

        LibraryDBValidation validationClass = new LibraryDBValidation();
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void libraryCatalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libraryCatalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
            
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.bookDataTable' table. You can move, or remove it, as needed.
            this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);

            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.libraryCatalog' table. You can move, or remove it, as needed.
            //this.libraryCatalogTableAdapter.Fill(this.libraryDatabaseDataSet.libraryCatalog);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.manageRentals' table. You can move, or remove it, as needed.
            this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
            
            
            isOverdue();

        }

        private List<string> isbnValidationList()
        {
            //List<string> isbnList = new List<string>();
            //foreach (DataGridViewRow item in homeLibraryCatalogDataGridView.Rows)
            //{
            //    if (item.Cells[0].Value != null) { isbnList.Add(item.Cells[0].Value.ToString()); }


            //}
            List<string> isbnList = new List<string>();
            
            foreach (DataGridViewRow item in bookDataTableDataGridView.Rows)
            {
                if (item.Cells[0].Value != null) { isbnList.Add(item.Cells[0].Value.ToString()); }
                

            }

            return isbnList;
        }

        private List<string> PrintTypeValidationList()
        {
            List<string> printTypeString = new List<string>();
            foreach (DataGridViewRow item in bookDataTableDataGridView.Rows)
            {
                if (item.Cells[6].Value != null) { printTypeString.Add(item.Cells[6].Value.ToString()); }

            }
            return printTypeString;
        }
        //This method should change the color of a row to red if the current date is greater than the due date.
        public void isOverdue()
        {
            this.manageRentalsTableAdapter.IsOverdue();
            this.manageRentalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
            this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
            //List<string> isbnList = new List<string>();
            //foreach (DataGridViewRow item in homeLibraryCatalogDataGridView.Rows)
            //{
            //    if (item.Cells[0].Value != null) { isbnList.Add(item.Cells[0].Value.ToString()); }


            //}



            //int i = 0;
            //DateTime dueDateCell = Convert.ToDateTime(this.homeManageRentalsDataGridView.Rows[i].Cells[4].Value.ToString());
            //DateTime rightNow = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            //for (; i < homeManageRentalsDataGridView.RowCount; i++)
            //{


            //    if (dueDateCell < rightNow)
            //    {
            //        this.homeManageRentalsDataGridView.Rows[i].Cells[5].Value = "Overdue";
            //        for (int c = 0; c < this.homeManageRentalsDataGridView.ColumnCount; c++)
            //        {
            //            this.homeManageRentalsDataGridView.Rows[i].Cells[c].Style.BackColor = Color.Red;

            //        }
            //        this.homeManageRentalsDataGridView.InvalidateRow(i);

            //    }


            //}
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            try
            {   //Retrieves a list of all ISBNs from the isbnValidationListMethod.
                List<string> bookISBNValidationList = isbnValidationList();
                List<string> bookPrintTypeValidationList = PrintTypeValidationList();
                Form addBookForm = new frmAddBook();
                DialogResult selectedButton = addBookForm.ShowDialog();
                if (selectedButton == DialogResult.OK)
                {
                    String[] bookString = (String[])addBookForm.Tag;
                    //If the list already contains the user-specified ISBN, the following message box will appear.
                    if (bookISBNValidationList.Contains(bookString[0]) && bookPrintTypeValidationList.Contains(bookString[6]))
                    {
                        MessageBox.Show("The publication you specified already exists in the database", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Otherwise, the book will be added to the catalog.
                    else
                    {
                        ////The ISBN number is converted to a 64-bit integer.
                        //Int64 isbnText = Convert.ToInt64(bookString[0]);
                        ////The book is added to the added libraryCatalog table through it's table adapter's Insert query.
                        //this.libraryCatalogTableAdapter.InsertBook(isbnText, bookString[1], bookString[2], bookString[3], bookString[4], bookString[5],
                        //    Convert.ToInt32(bookString[6]), Convert.ToInt64(bookString[7]), 0);
                        //this.libraryCatalogBindingSource.EndEdit();
                        //this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
                        //this.libraryCatalogTableAdapter.Fill(this.libraryDatabaseDataSet.libraryCatalog);

//                        INSERT INTO bookDataTable
//                  (ISBN, Title, Subtitle, Authors, Publisher, [Publication Date], [Print Type], [Quantity Available], [Quantity Checked Out])
//VALUES(@ISBN, @Title, @Subtitle, @Authors, @Publisher, @Publication_Date, @Print_Type, @Quantity_Available, @Quantity_Checked_Out)

                        //The ISBN number is converted to a 64-bit integer.
                        Int64 isbnText = Convert.ToInt64(bookString[0]);
                        //DateTime pubDateString = DateTime.ParseExact("MM/dd/yyyy", bookString[5], CultureInfo.InvariantCulture);
                        //The book is added to the added libraryCatalog table through it's table adapter's Insert query.
                        string dateString = bookString[5];
                        this.bookDataTableTableAdapter.Insert(isbnText, bookString[1], "none", bookString[3], bookString[4], Convert.ToDateTime(bookString[5]), bookString[6],
                             Convert.ToInt64(bookString[7]), 0);
                        this.bookDataTableBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
                        this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
                    }

                }
            }
            catch (SqlException ex)
            {

                validationClass.SQLServerError(ex);
            }
            catch (DBConcurrencyException)
            {
                validationClass.ConcurrencyMB();
            }
            catch (DataException ex)
            {
                validationClass.dataExceptionMB(ex);
            }
            //catch (FormatException)
            //{
            //    validationClass.FormatExceptionMB();
            //}
        }

        //The 'Update' button on tab 1.
        private void btnModifyCatalog_Click(object sender, EventArgs e)
        {

            try
            {
                //txtTestResult.Text = Convert.ToString(bookApi.Volumes.List(txtTestSearch.Text));

                //new instance of the form where you can modify or delete items in the catalog.
                Form frmModifyCatalogInstance = new frmModifyCatalog();
                DialogResult modSelectedButton = frmModifyCatalogInstance.ShowDialog();
                if (modSelectedButton == DialogResult.OK)
                {
                    this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
                }

            }
            catch (SqlException ex)
            {

                validationClass.SQLServerError(ex);
            }
            catch (DBConcurrencyException ex)
            {
                validationClass.ConcurrencyMB();
            }
            catch (DataException ex)
            {
                validationClass.dataExceptionMB(ex);
            }
            catch (FormatException)
            {
                validationClass.FormatExceptionMB();
            }
            catch
            {
                validationClass.UnknownErrorMB();
            }

        }

        private void btnAddBorrowedBook_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmAddBorrowedBookInstance = new frmAddBorrowedBook();
                DialogResult selectedBorrowButton = frmAddBorrowedBookInstance.ShowDialog();
                if (selectedBorrowButton == DialogResult.OK)
                {
                    //This array will hold the values for the new row.
                    String[] rentalString = (String[])frmAddBorrowedBookInstance.Tag;
                    //ISBN numbers are between 10-13 digits, so the standard 32-bit integer data type won't do.
                   // Int64 isbnText = Convert.ToInt64(rentalString[2]);
                    if (rentalString[4] == "Borrowed" || rentalString[4] == "Overdue")
                    {
                        this.libraryCatalogTableAdapter.addBookBorrowed(rentalString[1]);
                        this.libraryCatalogBindingSource.EndEdit();
                    }
                    //Each element from 'rental string' is passed to each parameter of the Insert query for the 'manageRentals' data table. 
                    this.manageRentalsTableAdapter.InsertBorrow(rentalString[0], rentalString[1], rentalString[2], rentalString[3], rentalString[4]);
                    this.manageRentalsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
                    this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
                    this.libraryCatalogTableAdapter.Fill(this.libraryDatabaseDataSet.libraryCatalog);
                    
                }
            }
            catch (SqlException ex)
            {

                validationClass.SQLServerError(ex);
            }
            catch (DBConcurrencyException ex)
            {
                validationClass.ConcurrencyMB();
            }
            catch (DataException ex)
            {
                validationClass.dataExceptionMB(ex);
            }
            catch (FormatException)
            {
                validationClass.FormatExceptionMB();
            }
            catch
            {
                validationClass.UnknownErrorMB();
            }
        }

        private void btnModBookBorrowed_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmModifyBooksBorrowedInstance = new frmModifyBooksBorrowed();
                DialogResult selectedModBorrowBtn = frmModifyBooksBorrowedInstance.ShowDialog();
                if (selectedModBorrowBtn == DialogResult.OK)
                {
                    this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
                }
            }
            catch (SqlException ex)
            {

                validationClass.SQLServerError(ex);
            }
            catch (DBConcurrencyException ex)
            {
                validationClass.ConcurrencyMB();
            }
            catch (DataException ex)
            {
                validationClass.dataExceptionMB(ex);
            }
            catch (FormatException)
            {
                validationClass.FormatExceptionMB();
            }
            catch
            {
                validationClass.UnknownErrorMB();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSearchBy.Text == "Title")
            {
                this.bookDataTableTableAdapter.FillByTitle(libraryDatabaseDataSet.bookDataTable, txtSearch.Text);
            }
            //else if (cboSearchBy.Text == "Author")
            //{
            //    this.bookDataTableTableAdapter.FillByAuthor(libraryDatabaseDataSet.bookDataTable, txtSearch.Text);
            //}
            else if (cboSearchBy.Text == "Physical Format")
            {
                this.bookDataTableTableAdapter.FillByPrintType(libraryDatabaseDataSet.bookDataTable, txtSearch.Text);
            }
            else if (cboSearchBy.Text == "Publisher")
            {
                this.bookDataTableTableAdapter.FillByPublisher(libraryDatabaseDataSet.bookDataTable, txtSearch.Text);
            }
            //else if (cboSearchBy.Text == "Year Published")
            //{
            //    this.bookDataTableTableAdapter.FillByPublishedDate(libraryDatabaseDataSet.bookDataTable, Convert.ToInt32(txtSearch.Text));
            //}
            else { MessageBox.Show("Your search query is empty.", "Empty Search Query", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSearchTest_Click(object sender, EventArgs e)
        {
            //This is a seperate class designed to work with the api.

            //BookAPIClass apiBookClass = new BookAPIClass();
            
            //The first argument is my query to the api, the second is the starting index for the search results, 
            //and the third is the maximum number of search results I want.

            //Tuple<int?, List<VolumeInfo>> bookTuple = apiBookClass.SearchMethod("isbn:0062662899", 0, 10);
           
            //List<Tuple<int?, List<VolumeInfo>>> tupleList = new List<Tuple<int?, List<VolumeInfo>>>();
            //This is suppossed to be where I add the search results to the listbox.
            //foreach (Tuple<int?, List<VolumeInfo>> y in bookTuple)
            //{
            //    int? firstItem = y.Item1;
            //    List<VolumeInfo> secondItem = y.Item2;
            //    lstTest.Items.Add(y.Item2);
            //}
            //string testISBN = "0062662899";
            //var testOutput = BookAPIClass.SearchISBN(testISBN);
            ////Debug.Assert.AreEqual(testOutput.Result != null, true);
            //var result = testOutput.Result;
            //Trace.WriteLine("\nBook Name: " + result.VolumeInfo.Title);
            //Trace.WriteLine("Author: " + result.VolumeInfo.Authors.FirstOrDefault());
            //Trace.WriteLine("Publisher: " + result.VolumeInfo.Publisher);
            //txtTest.Text = (string)result.VolumeInfo.Title;
            //BookAPIClass apiBookClass = new BookAPIClass();
            //apiBookClass.SearchMethod("isbn:0062662899", 0, 10);
            ////Console.ReadLine;
            //foreach (KeyValuePair<int?, List<VolumeInfo>> y in bookTuple)
            //{
            //    lstTest.Items.Add(y.Value);
            //}


            //https://www.googleapis.com/books/v1/volumes?q=Goodnight+isbn:0062662899
        }
    }
}
