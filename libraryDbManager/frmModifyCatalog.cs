using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace libraryDbManager
{
    public partial class frmModifyCatalog : Form
    {
        LibraryDBValidation ModBookValidation = new LibraryDBValidation();
        public frmModifyCatalog()
        {
            InitializeComponent();
        }
        


        private void libraryCatalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libraryCatalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);

        }

        private void frmModifyCatalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.bookDataTable' table. You can move, or remove it, as needed.
            this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.libraryCatalog' table. You can move, or remove it, as needed.
            //this.libraryCatalogTableAdapter.Fill(this.libraryDatabaseDataSet.libraryCatalog);

        }

        private void btnConfirmCatalogUpdate_Click(object sender, EventArgs e)
        {
            
                DialogResult mbConfirmUpdate = MessageBox.Show("You are about to make changes to the database. Continue?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (mbConfirmUpdate.Equals(DialogResult.Yes))
                {
                    //int selectedIndex = bookDataTableDataGridView.CurrentCell.RowIndex;
                    this.Validate();
                    //this.bookDataTableDataGridView.EndEdit();
                    this.bookDataTableBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
                    this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
                    this.DialogResult = DialogResult.OK;

                }

                else if (mbConfirmUpdate.Equals(DialogResult.No)) { this.Close(); }
            
                
        }

        private void btnConfirmCatalogDeletion_Click(object sender, EventArgs e)
        {
            DialogResult mbConfirmUpdate = MessageBox.Show("You are about to make changes to the database. Continue?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (mbConfirmUpdate.Equals(DialogResult.Yes))
            {
                int selectedIndex = bookDataTableDataGridView.CurrentCell.RowIndex;
                bookDataTableDataGridView.Rows.RemoveAt(selectedIndex);
                this.libraryCatalogBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
                this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
                this.DialogResult = DialogResult.OK;
            }

            else if (mbConfirmUpdate.Equals(DialogResult.No)) { this.Close(); }
        }
    }
}
