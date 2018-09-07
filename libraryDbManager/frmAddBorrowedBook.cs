using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryDbManager
{
   
    public partial class frmAddBorrowedBook : Form
    {
        LibraryDBValidation AddBorrowValidation = new LibraryDBValidation();
        public frmAddBorrowedBook()
        {
            InitializeComponent();
        }

        List<Int64> isbnList;
       

        private void frmAddBorrowedBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.bookDataTable' table. You can move, or remove it, as needed.
            this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
            //using (SqlConnection newConnection = new SqlConnection("Data Source=DESKTOP-6HID3P7;Initial Catalog=libraryDatabase;Integrated Security=True"))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    SqlDataReader reader;
            //    cmd.CommandText = "Select ISBN, Title From bookDataTable";
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Connection = newConnection;
            //    newConnection.Open();
            //    reader = cmd.ExecuteReader();
            //    List<Int64> isbnList = (from IDataRecord r in reader select (Int64)r["ISBN"]).ToList();
            //    newConnection.Close();
            //}
            //everyISBN();
            
        }

        private void everyISBN()
        {
            //List<Int64> isbnList;
            using (SqlConnection newConnection = new SqlConnection("Data Source=DESKTOP-6HID3P7;Initial Catalog=libraryDatabase;Integrated Security=True"))
            {
                //SqlCommand cmd = new SqlCommand();
                //SqlDataReader reader;
                //cmd.CommandText = "Select ISBN, Title From bookDataTable";
                //cmd.CommandType = CommandType.Text;
                //cmd.Connection = newConnection;
                //newConnection.Open();
                //reader = cmd.ExecuteReader();
                //isbnList = (from IDataRecord r in reader select (Int64)r["ISBN"]).ToList();
                //List<String> titleList = (from IDataRecord r in reader select (String)r["Title"]).ToList();
                //newConnection.Close();
                //foreach (string x in titleList)
                //{
                //    cboTitle.Items.Add(x);
                //}
            }
            //return isbnList;
        }

        private void btnConfirmBorrow_Click(object sender, EventArgs e)
        {
            //List<Int64> isbnValidationList = everyISBN();
            if (AddBorrowValidation.NotEmpty(txtTitle.Text) && AddBorrowValidation.NotEmpty(txtCustomerName.Text))
            {
                DialogResult mbConfirmBorrowedBook = MessageBox.Show("The changes you are about to make will automatically be saved. Continue?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (mbConfirmBorrowedBook.Equals(DialogResult.Yes))
                    {
                        String returnString = txtCustomerName.Text + ";" + txtTitle.Text + ";" + dtpDateBorrowed.Value.ToShortDateString() + ";" + dtpDateDue.Value.ToShortDateString() + ";"
                        + cboReturnStatus.Text;
                        this.Tag = returnString.Split(';');
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (mbConfirmBorrowedBook.Equals(DialogResult.No)) { this.Close(); }
                
                else { MessageBox.Show("The ISBN you specified doesn't exist", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
                
            
        }
    }
}
