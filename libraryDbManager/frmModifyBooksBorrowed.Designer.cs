namespace libraryDbManager
{
    partial class frmModifyBooksBorrowed
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
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label date_BorrowedLabel;
            System.Windows.Forms.Label date_DueLabel;
            System.Windows.Forms.Label return_StatusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label titleLabel1;
            this.manageRentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new libraryDbManager.libraryDatabaseDataSet();
            this.manageRentalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_NameTextBox = new System.Windows.Forms.TextBox();
            this.date_BorrowedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_DueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.return_StatusComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelModBookBorrowed = new System.Windows.Forms.Button();
            this.btnDeleteBookBorrowed = new System.Windows.Forms.Button();
            this.btnModBookBorrowed = new System.Windows.Forms.Button();
            this.manageRentalsTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.manageRentalsTableAdapter();
            this.tableAdapterManager = new libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataTableTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            customer_NameLabel = new System.Windows.Forms.Label();
            date_BorrowedLabel = new System.Windows.Forms.Label();
            date_DueLabel = new System.Windows.Forms.Label();
            return_StatusLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.Location = new System.Drawing.Point(37, 51);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(117, 14);
            customer_NameLabel.TabIndex = 2;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // date_BorrowedLabel
            // 
            date_BorrowedLabel.AutoSize = true;
            date_BorrowedLabel.Location = new System.Drawing.Point(37, 96);
            date_BorrowedLabel.Name = "date_BorrowedLabel";
            date_BorrowedLabel.Size = new System.Drawing.Size(112, 14);
            date_BorrowedLabel.TabIndex = 8;
            date_BorrowedLabel.Text = "Date Borrowed:";
            // 
            // date_DueLabel
            // 
            date_DueLabel.AutoSize = true;
            date_DueLabel.Location = new System.Drawing.Point(377, 96);
            date_DueLabel.Name = "date_DueLabel";
            date_DueLabel.Size = new System.Drawing.Size(74, 14);
            date_DueLabel.TabIndex = 10;
            date_DueLabel.Text = "Date Due:";
            // 
            // return_StatusLabel
            // 
            return_StatusLabel.AutoSize = true;
            return_StatusLabel.Location = new System.Drawing.Point(657, 51);
            return_StatusLabel.Name = "return_StatusLabel";
            return_StatusLabel.Size = new System.Drawing.Size(106, 14);
            return_StatusLabel.TabIndex = 12;
            return_StatusLabel.Text = "Return Status:";
            // 
            // manageRentalsBindingSource
            // 
            this.manageRentalsBindingSource.DataMember = "manageRentals";
            this.manageRentalsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "libraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manageRentalsDataGridView
            // 
            this.manageRentalsDataGridView.AutoGenerateColumns = false;
            this.manageRentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageRentalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.manageRentalsDataGridView.DataSource = this.manageRentalsBindingSource;
            this.manageRentalsDataGridView.Location = new System.Drawing.Point(97, 278);
            this.manageRentalsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageRentalsDataGridView.Name = "manageRentalsDataGridView";
            this.manageRentalsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageRentalsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.manageRentalsDataGridView.RowTemplate.Height = 24;
            this.manageRentalsDataGridView.Size = new System.Drawing.Size(843, 212);
            this.manageRentalsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date Borrowed";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Borrowed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date Due";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Due";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Return Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Return Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // customer_NameTextBox
            // 
            this.customer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageRentalsBindingSource, "Customer Name", true));
            this.customer_NameTextBox.Location = new System.Drawing.Point(156, 49);
            this.customer_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_NameTextBox.Name = "customer_NameTextBox";
            this.customer_NameTextBox.Size = new System.Drawing.Size(161, 20);
            this.customer_NameTextBox.TabIndex = 3;
            // 
            // date_BorrowedDateTimePicker
            // 
            this.date_BorrowedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manageRentalsBindingSource, "Date Borrowed", true));
            this.date_BorrowedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_BorrowedDateTimePicker.Location = new System.Drawing.Point(149, 93);
            this.date_BorrowedDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_BorrowedDateTimePicker.Name = "date_BorrowedDateTimePicker";
            this.date_BorrowedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_BorrowedDateTimePicker.TabIndex = 9;
            // 
            // date_DueDateTimePicker
            // 
            this.date_DueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manageRentalsBindingSource, "Date Due", true));
            this.date_DueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_DueDateTimePicker.Location = new System.Drawing.Point(455, 93);
            this.date_DueDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_DueDateTimePicker.Name = "date_DueDateTimePicker";
            this.date_DueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_DueDateTimePicker.TabIndex = 11;
            // 
            // return_StatusComboBox
            // 
            this.return_StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manageRentalsBindingSource, "Return Status", true));
            this.return_StatusComboBox.FormattingEnabled = true;
            this.return_StatusComboBox.Items.AddRange(new object[] {
            "Returned",
            "Borrowed"});
            this.return_StatusComboBox.Location = new System.Drawing.Point(762, 48);
            this.return_StatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.return_StatusComboBox.Name = "return_StatusComboBox";
            this.return_StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.return_StatusComboBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(titleLabel1);
            this.groupBox1.Controls.Add(this.titleComboBox);
            this.groupBox1.Controls.Add(this.btnCancelModBookBorrowed);
            this.groupBox1.Controls.Add(this.btnDeleteBookBorrowed);
            this.groupBox1.Controls.Add(this.btnModBookBorrowed);
            this.groupBox1.Controls.Add(date_BorrowedLabel);
            this.groupBox1.Controls.Add(return_StatusLabel);
            this.groupBox1.Controls.Add(this.return_StatusComboBox);
            this.groupBox1.Controls.Add(this.date_BorrowedDateTimePicker);
            this.groupBox1.Controls.Add(date_DueLabel);
            this.groupBox1.Controls.Add(customer_NameLabel);
            this.groupBox1.Controls.Add(this.customer_NameTextBox);
            this.groupBox1.Controls.Add(this.date_DueDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(32, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1045, 173);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCancelModBookBorrowed
            // 
            this.btnCancelModBookBorrowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelModBookBorrowed.Location = new System.Drawing.Point(605, 125);
            this.btnCancelModBookBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelModBookBorrowed.Name = "btnCancelModBookBorrowed";
            this.btnCancelModBookBorrowed.Size = new System.Drawing.Size(132, 28);
            this.btnCancelModBookBorrowed.TabIndex = 16;
            this.btnCancelModBookBorrowed.Text = "Cancel";
            this.btnCancelModBookBorrowed.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBookBorrowed
            // 
            this.btnDeleteBookBorrowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteBookBorrowed.Location = new System.Drawing.Point(398, 125);
            this.btnDeleteBookBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBookBorrowed.Name = "btnDeleteBookBorrowed";
            this.btnDeleteBookBorrowed.Size = new System.Drawing.Size(132, 28);
            this.btnDeleteBookBorrowed.TabIndex = 15;
            this.btnDeleteBookBorrowed.Text = "Delete";
            this.btnDeleteBookBorrowed.UseVisualStyleBackColor = true;
            this.btnDeleteBookBorrowed.Click += new System.EventHandler(this.btnDeleteBookBorrowed_Click);
            // 
            // btnModBookBorrowed
            // 
            this.btnModBookBorrowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModBookBorrowed.Location = new System.Drawing.Point(199, 125);
            this.btnModBookBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModBookBorrowed.Name = "btnModBookBorrowed";
            this.btnModBookBorrowed.Size = new System.Drawing.Size(132, 28);
            this.btnModBookBorrowed.TabIndex = 14;
            this.btnModBookBorrowed.Text = "Update";
            this.btnModBookBorrowed.UseVisualStyleBackColor = true;
            this.btnModBookBorrowed.Click += new System.EventHandler(this.btnModBookBorrowed_Click);
            // 
            // manageRentalsTableAdapter
            // 
            this.manageRentalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookDataTableTableAdapter = null;
            this.tableAdapterManager.libraryCatalogTableAdapter = null;
            this.tableAdapterManager.manageRentalsTableAdapter = this.manageRentalsTableAdapter;
            this.tableAdapterManager.UpdateOrder = libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modify Borrowed Books";
            // 
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "bookDataTable";
            this.bookDataTableBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // bookDataTableTableAdapter
            // 
            this.bookDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(395, 49);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(42, 14);
            titleLabel1.TabIndex = 17;
            titleLabel1.Text = "Title:";
            // 
            // titleComboBox
            // 
            this.titleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Title", true));
            this.titleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookDataTableBindingSource, "Title", true));
            this.titleComboBox.DataSource = this.bookDataTableBindingSource;
            this.titleComboBox.DisplayMember = "Title";
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(443, 46);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(121, 21);
            this.titleComboBox.TabIndex = 18;
            this.titleComboBox.ValueMember = "Title";
            // 
            // frmModifyBooksBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1132, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manageRentalsDataGridView);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmModifyBooksBorrowed";
            this.Text = "frmModifyBooksBorrowed";
            this.Load += new System.EventHandler(this.frmModifyBooksBorrowed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageRentalsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource manageRentalsBindingSource;
        private libraryDatabaseDataSetTableAdapters.manageRentalsTableAdapter manageRentalsTableAdapter;
        private libraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView manageRentalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox customer_NameTextBox;
        private System.Windows.Forms.DateTimePicker date_BorrowedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_DueDateTimePicker;
        private System.Windows.Forms.ComboBox return_StatusComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelModBookBorrowed;
        private System.Windows.Forms.Button btnDeleteBookBorrowed;
        private System.Windows.Forms.Button btnModBookBorrowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter bookDataTableTableAdapter;
        private System.Windows.Forms.ComboBox titleComboBox;
    }
}