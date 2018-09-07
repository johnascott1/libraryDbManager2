namespace libraryDbManager
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.libraryCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new libraryDbManager.libraryDatabaseDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bookDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModifyCatalog = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModBookBorrowed = new System.Windows.Forms.Button();
            this.btnAddBorrowedBook = new System.Windows.Forms.Button();
            this.homeManageRentalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageRentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.libraryCatalogTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.libraryCatalogTableAdapter();
            this.tableAdapterManager = new libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.manageRentalsTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.manageRentalsTableAdapter();
            this.bookDataTableTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeManageRentalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryCatalogBindingSource
            // 
            this.libraryCatalogBindingSource.DataMember = "libraryCatalog";
            this.libraryCatalogBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "libraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 561);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.bookDataTableDataGridView);
            this.tabPage1.Controls.Add(this.btnSearchTest);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboSearchBy);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.btnModifyCatalog);
            this.tabPage1.Controls.Add(this.btnAddBooks);
            this.tabPage1.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1368, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Catalog";
            // 
            // bookDataTableDataGridView
            // 
            this.bookDataTableDataGridView.AutoGenerateColumns = false;
            this.bookDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.bookDataTableDataGridView.DataSource = this.bookDataTableBindingSource;
            this.bookDataTableDataGridView.Location = new System.Drawing.Point(227, 180);
            this.bookDataTableDataGridView.Name = "bookDataTableDataGridView";
            this.bookDataTableDataGridView.RowTemplate.Height = 24;
            this.bookDataTableDataGridView.Size = new System.Drawing.Size(1113, 220);
            this.bookDataTableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn16.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn17.HeaderText = "Title";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Subtitle";
            this.dataGridViewTextBoxColumn18.HeaderText = "Subtitle";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Authors";
            this.dataGridViewTextBoxColumn19.HeaderText = "Authors";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn20.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Publication Date";
            this.dataGridViewTextBoxColumn21.HeaderText = "Publication Date";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Print Type";
            this.dataGridViewTextBoxColumn22.HeaderText = "Print Type";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Quantity Available";
            this.dataGridViewTextBoxColumn23.HeaderText = "Quantity Available";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Quantity Checked Out";
            this.dataGridViewTextBoxColumn24.HeaderText = "Quantity Checked Out";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "bookDataTable";
            this.bookDataTableBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // btnSearchTest
            // 
            this.btnSearchTest.Location = new System.Drawing.Point(44, 77);
            this.btnSearchTest.Name = "btnSearchTest";
            this.btnSearchTest.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTest.TabIndex = 11;
            this.btnSearchTest.Text = "Test";
            this.btnSearchTest.UseVisualStyleBackColor = true;
            this.btnSearchTest.Visible = false;
            this.btnSearchTest.Click += new System.EventHandler(this.btnSearchTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(430, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Library Catalog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Search Field:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Physical Format",
            "Publisher",
            "Year Published"});
            this.cboSearchBy.Location = new System.Drawing.Point(547, 94);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(121, 21);
            this.cboSearchBy.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(892, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1032, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModifyCatalog
            // 
            this.btnModifyCatalog.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyCatalog.Location = new System.Drawing.Point(555, 474);
            this.btnModifyCatalog.Name = "btnModifyCatalog";
            this.btnModifyCatalog.Size = new System.Drawing.Size(131, 34);
            this.btnModifyCatalog.TabIndex = 3;
            this.btnModifyCatalog.Text = "Modify Catalog";
            this.btnModifyCatalog.UseVisualStyleBackColor = true;
            this.btnModifyCatalog.Click += new System.EventHandler(this.btnModifyCatalog_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.Location = new System.Drawing.Point(280, 474);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(132, 34);
            this.btnAddBooks.TabIndex = 2;
            this.btnAddBooks.Text = "&Add Book";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnModBookBorrowed);
            this.tabPage2.Controls.Add(this.btnAddBorrowedBook);
            this.tabPage2.Controls.Add(this.homeManageRentalsDataGridView);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1368, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Borrowed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Books Borrowed";
            // 
            // btnModBookBorrowed
            // 
            this.btnModBookBorrowed.Location = new System.Drawing.Point(555, 445);
            this.btnModBookBorrowed.Name = "btnModBookBorrowed";
            this.btnModBookBorrowed.Size = new System.Drawing.Size(132, 34);
            this.btnModBookBorrowed.TabIndex = 2;
            this.btnModBookBorrowed.Text = "Modify";
            this.btnModBookBorrowed.UseVisualStyleBackColor = true;
            this.btnModBookBorrowed.Click += new System.EventHandler(this.btnModBookBorrowed_Click);
            // 
            // btnAddBorrowedBook
            // 
            this.btnAddBorrowedBook.Location = new System.Drawing.Point(236, 445);
            this.btnAddBorrowedBook.Name = "btnAddBorrowedBook";
            this.btnAddBorrowedBook.Size = new System.Drawing.Size(132, 34);
            this.btnAddBorrowedBook.TabIndex = 1;
            this.btnAddBorrowedBook.Text = "Add";
            this.btnAddBorrowedBook.UseVisualStyleBackColor = true;
            this.btnAddBorrowedBook.Click += new System.EventHandler(this.btnAddBorrowedBook_Click);
            // 
            // homeManageRentalsDataGridView
            // 
            this.homeManageRentalsDataGridView.AutoGenerateColumns = false;
            this.homeManageRentalsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.homeManageRentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeManageRentalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.homeManageRentalsDataGridView.DataSource = this.manageRentalsBindingSource;
            this.homeManageRentalsDataGridView.Location = new System.Drawing.Point(108, 114);
            this.homeManageRentalsDataGridView.Name = "homeManageRentalsDataGridView";
            this.homeManageRentalsDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeManageRentalsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.homeManageRentalsDataGridView.RowTemplate.Height = 24;
            this.homeManageRentalsDataGridView.Size = new System.Drawing.Size(1196, 302);
            this.homeManageRentalsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 127;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn11.HeaderText = "Title";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 64;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date Borrowed";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date Borrowed";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Date Due";
            this.dataGridViewTextBoxColumn14.HeaderText = "Date Due";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 90;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Return Status";
            this.dataGridViewTextBoxColumn15.HeaderText = "Return Status";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 114;
            // 
            // manageRentalsBindingSource
            // 
            this.manageRentalsBindingSource.DataMember = "manageRentals";
            this.manageRentalsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(41, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(979, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Book Mage Library Database Management System v0.1";
            // 
            // libraryCatalogTableAdapter
            // 
            this.libraryCatalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookDataTableTableAdapter = null;
            this.tableAdapterManager.libraryCatalogTableAdapter = this.libraryCatalogTableAdapter;
            this.tableAdapterManager.manageRentalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manageRentalsTableAdapter
            // 
            this.manageRentalsTableAdapter.ClearBeforeFill = true;
            // 
            // bookDataTableTableAdapter
            // 
            this.bookDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1396, 662);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHomePage";
            this.Text = "John Scott Home Page";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeManageRentalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource libraryCatalogBindingSource;
        private libraryDatabaseDataSetTableAdapters.libraryCatalogTableAdapter libraryCatalogTableAdapter;
        private libraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnModifyCatalog;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource manageRentalsBindingSource;
        private libraryDatabaseDataSetTableAdapters.manageRentalsTableAdapter manageRentalsTableAdapter;
        private System.Windows.Forms.Button btnModBookBorrowed;
        private System.Windows.Forms.Button btnAddBorrowedBook;
        private System.Windows.Forms.DataGridView homeManageRentalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchTest;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter bookDataTableTableAdapter;
        private System.Windows.Forms.DataGridView bookDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}

