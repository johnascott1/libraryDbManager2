using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace libraryDbManager
{
    class LibraryDBValidation
    {
        public LibraryDBValidation() { }

        //MessageBox for sql data provider exceptions
        public void SQLServerError(SqlException ex)
        {
            MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());

        }

        //Messagebox for concurrency errors.
        public void ConcurrencyMB()
        { MessageBox.Show("A concurrency error occurred.\n Some rows were not updated.", "Concurrency Exception", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        //Messagebox for Ado.Net exceptions.
        public void dataExceptionMB(DataException ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Messagebox for when a user tries to modify an item without selecting a row.
        public void NothingSelectedMB()
        { MessageBox.Show("Please select a row.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        //MessageBox for formatting exceptions
        public void FormatExceptionMB()
        {
            MessageBox.Show("A formatting exception occurred.", "Format Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UnknownErrorMB()
        {
            MessageBox.Show("An unknown error occurred.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Messagebox for empty textboxes
        public void EmptyText()
        {
            MessageBox.Show("One of the required fields is missing.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Messagebox for non-numeric prices.
        public Boolean IsDecimal(String priceString)
        {
            decimal number = 0m;
            if (Decimal.TryParse(priceString, out number))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        //Messagebox for non-numeric quantity values.
        public Boolean IsInt(String qtyString)
        {
            Int64 number = 0;
            if (Int64.TryParse(qtyString, out number))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public Boolean CorrectISBNLength(string isbnTextBox, string yearPublishedTextbox)
        {
            if ((isbnTextBox.Length == 10 && Convert.ToInt16(yearPublishedTextbox) < 2007) || (isbnTextBox.Length == 13 && Convert.ToInt16(yearPublishedTextbox) >= 2007))
            { return true; }
            else { return false; }
        }

        public Boolean NotEmpty(String argString)
        {
            if (argString == "")
            { return false; }
            else { return true; }
        }

        public DialogResult AddConfirmationMB()
        {
            return MessageBox.Show("Are you sure you want to add this item?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult DeleteConfirmation()
        {
            return MessageBox.Show("Are you sure you want to delete this item?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult ModifyConfirmation()
        {
            return MessageBox.Show("Are you sure you want to modify this item?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public bool TextIsValid(String isbnNo, String titleString, String authorString, String genreString, String physicalFormatString, String publisherString,
            String yearPublishedString, String qtyAvailableString)
        {
            return
                IsInt(isbnNo) && NotEmpty(titleString) && NotEmpty(authorString) && NotEmpty(genreString) && NotEmpty(physicalFormatString) 
                && NotEmpty(publisherString) && IsInt(qtyAvailableString);
        }

    }
}
