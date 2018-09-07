using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Books.v1.Data;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using HtmlAgilityPack;

namespace libraryDbManager
{
    public partial class frmAddBook : Form
    {

        public frmAddBook()
        {
            InitializeComponent();
            InitTable();
        }
        LibraryDBValidation newBookValidation = new LibraryDBValidation();
        DataTable bookTable;
        BookAPIClass apiBookClass = new BookAPIClass();
        private void InitTable()
        {
            //table = new DataTable("TestTable");
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Score", typeof(string));
            bookTable = new DataTable("Books");
            bookTable.Columns.Add("ISBN", typeof(string));
            bookTable.Columns.Add("Title", typeof(string));
            bookTable.Columns.Add("Subtitle", typeof(string));
            bookTable.Columns.Add("Authors", typeof(string));
            bookTable.Columns.Add("Publisher", typeof(string));
            bookTable.Columns.Add("Date Published", typeof(DateTime));
            bookTable.Columns.Add("Print", typeof(string));
            
            searchResDataGridView.DataSource = bookTable;

            //bookDataGridView.DataSource = table;
        }
        private void btnCancelBook_Click(object sender, EventArgs e) { this.Close(); }


        //API Key: AIzaSyDGTdhLmZXUvkoncKB6Ik9g-tC6jOXues8
        private void btnConfirmBook_Click(object sender, EventArgs e)
        {   //Any publication prior to the year 2007 requires a 10-digit ISBN, whereas any publication during or following 2007 requires a 13-digit ISBN. 
            //(txtISBN.TextLength == 10 && Convert.ToInt16(txtYearPublished.Text) < 2007) || (txtISBN.TextLength == 13 && Convert.ToInt16(txtYearPublished.Text) >= 2007)
            //if (!(newBookValidation.TextIsValid(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtGenre.Text, cboPhysicalFormat.Text,
            //    txtPublisher.Text, txtYearPublished.Text, nudQtyAvailable.Value.ToString())))
            //{
            //    MessageBox.Show("The book data you provided is invalid. Please ensure that no fields are left empty, and that the ISBN, year published, " +
            //        "and quantity available contain only numeric values.", "Invalid Book Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (!(newBookValidation.CorrectISBNLength(txtISBN.Text, txtYearPublished.Text)))
            //{
            //    MessageBox.Show("The ISBN you entered did not meet the necessary length requirements. Please include a 10-digit ISBN for any publications before 2007," +
            //        " and a 13-digit ISBN for any publications during or after 2007", "Invalid ISBN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //    DialogResult mbConfirmNewBook = MessageBox.Show("Are you sure you want to add that book?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    if (mbConfirmNewBook.Equals(DialogResult.Yes))
            //    {   //The text from each textbox is added to this string.
            //        String returnString = txtISBN.Text + ";" + txtTitle.Text + ";" + txtAuthor.Text + ";" + txtGenre.Text + ";" + cboPhysicalFormat.Text + ";"
            //        + txtPublisher.Text + ";" + txtYearPublished.Text + ";" + nudQtyAvailable.Value;
            //        //The string is then converted into an array via split method, and returned to the homepage.
            //        this.Tag = returnString.Split(';');
            //        this.DialogResult = DialogResult.OK;
            //    }
            //    else if (mbConfirmNewBook.Equals(DialogResult.No))
            //    { this.Close(); }
            //}
            DialogResult mbConfirmNewBook = MessageBox.Show("Are you sure you want to add that book?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (mbConfirmNewBook.Equals(DialogResult.Yes))
            {   //The text from each textbox is added to this string.
                //String dateString = dtDatePublished.Value.ToShortDateString();
                //dateString.Trim();
                //for(int x = 0; x <= dateString.Length; x++)
                //{
                //    if(dateString[x].Equals(" "))
                //    {
                //        dateString.;
                //    }
                //}
                String returnString = txtISBN.Text + ";" + txtTitle.Text + ";" + txtSubtitle.Text + ";" +  txtAuthor.Text + ";" + txtPublisher.Text + ";"
                + dtDatePublished.Value.ToShortDateString() + ";" + cboPhysicalFormat.Text  + ";" + nudQtyAvailable.Value;
                //The string is then converted into an array via split method, and returned to the homepage.
                this.Tag = returnString.Split(';');
                this.DialogResult = DialogResult.OK;
            }
            else if (mbConfirmNewBook.Equals(DialogResult.No))
            { this.Close(); }


        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearchGoogleBooks_Click(object sender, EventArgs e)
        {
            //DateTime sampleDate = 3/3/2014;
            Tuple<int?, List<VolumeInfo>> testTitle = apiBookClass.SearchMethod(txtSearchGoogleBooks.Text, 0, 10);
            foreach (VolumeInfo item in testTitle.Item2)
            {
                string authorString = "";
                //string genreString = "";
                foreach (string author in item.Authors)
                {

                    authorString += " " + author;
                }

                bookTable.Rows.Add(item.IndustryIdentifiers, item.Title, item.Subtitle, authorString, item.Publisher, DateTime.Today, item.Print );
            }

        }

        private void searchResDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtTitle.Text = searchResDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void searchResDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtISBN.Text = searchResDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = searchResDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtSubtitle.Text = searchResDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtAuthor.Text = searchResDataGridView.CurrentRow.Cells[3].Value.ToString();
            txtPublisher.Text = searchResDataGridView.CurrentRow.Cells[4].Value.ToString();
            dtDatePublished.Value = Convert.ToDateTime(searchResDataGridView.CurrentRow.Cells[5].Value);
            txtYearPublished.Text = searchResDataGridView.CurrentRow.Cells[5].Value.ToString();
            cboPhysicalFormat.Text = searchResDataGridView.CurrentRow.Cells[6].Value.ToString();


        }
    }
    
}
