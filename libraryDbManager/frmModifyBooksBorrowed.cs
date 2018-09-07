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
    public partial class frmModifyBooksBorrowed : Form
    {
        public frmModifyBooksBorrowed()
        {
            InitializeComponent();
        }

        private void manageRentalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manageRentalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);

        }

        private Dictionary<Int64, String> returnStatusChanged()
        {
            Dictionary<Int64, String> returnStatusList = new Dictionary<Int64, String>();
            int x = 0;
            foreach (DataGridViewRow item in manageRentalsDataGridView.Rows)
            {
                if (item.Cells[0].Value != null) { returnStatusList.Add(x, item.Cells[4].Value.ToString()); }
                x++;

            }

            return returnStatusList;
        }

        private void frmModifyBooksBorrowed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.bookDataTable' table. You can move, or remove it, as needed.
            this.bookDataTableTableAdapter.Fill(this.libraryDatabaseDataSet.bookDataTable);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.manageRentals' table. You can move, or remove it, as needed.
            this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);

            //for (int i = 0; i < manageRentalsDataGridView.RowCount; i++)
            //{
            //    if (Convert.ToDateTime(this.manageRentalsDataGridView.Columns[4]) < DateTime.Today)
            //    {
            //        for (int c = 0; c < this.manageRentalsDataGridView.ColumnCount; c++)
            //        {
            //            this.manageRentalsDataGridView.Rows[i].Cells[c].Style.BackColor = Color.Red;
            //        }
            //        this.manageRentalsDataGridView.Rows[i].Cells[5].Value = "Overdue";
            //    }
            //}

        }

        private void btnModBookBorrowed_Click(object sender, EventArgs e)
        {
            //Dictionary<Int64, String> checkReturnStatus = returnStatusChanged();
            
            //int selectedIndex = manageRentalsDataGridView.CurrentCell.RowIndex;
            //if (checkReturnStatus[selectedIndex] == "Borrowed" && return_StatusComboBox.Text != "Borrowed")
            //{
            

            //}
            
            this.Validate();
            this.manageRentalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
            this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
            this.DialogResult = DialogResult.OK;
        }

        private void btnDeleteBookBorrowed_Click(object sender, EventArgs e)
        {
            int selectedIndex = manageRentalsDataGridView.CurrentCell.RowIndex;
            this.manageRentalsDataGridView.Rows.RemoveAt(selectedIndex);
            this.manageRentalsDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDatabaseDataSet);
            this.manageRentalsTableAdapter.Fill(this.libraryDatabaseDataSet.manageRentals);
            this.DialogResult = DialogResult.OK;

        }


    }
}
