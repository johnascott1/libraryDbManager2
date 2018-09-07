namespace libraryDbManager
{
    partial class frmAddBorrowedBook
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
            System.Windows.Forms.Label titleLabel;
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new libraryDbManager.libraryDatabaseDataSet();
            this.dtpDateBorrowed = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDue = new System.Windows.Forms.DateTimePicker();
            this.cboReturnStatus = new System.Windows.Forms.ComboBox();
            this.btnConfirmBorrow = new System.Windows.Forms.Button();
            this.btnCancelBorrow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bookDataTableTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter();
            this.bookDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(569, 144);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 14);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Title:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(212, 110);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(161, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Borrowed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Due:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Return Status:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(212, 145);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "bookDataTable";
            this.bookDataTableBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "libraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDateBorrowed
            // 
            this.dtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBorrowed.Location = new System.Drawing.Point(212, 214);
            this.dtpDateBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateBorrowed.Name = "dtpDateBorrowed";
            this.dtpDateBorrowed.Size = new System.Drawing.Size(200, 20);
            this.dtpDateBorrowed.TabIndex = 9;
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDue.Location = new System.Drawing.Point(212, 247);
            this.dtpDateDue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateDue.TabIndex = 10;
            // 
            // cboReturnStatus
            // 
            this.cboReturnStatus.FormattingEnabled = true;
            this.cboReturnStatus.Items.AddRange(new object[] {
            "Returned",
            "Borrowed"});
            this.cboReturnStatus.Location = new System.Drawing.Point(212, 274);
            this.cboReturnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboReturnStatus.Name = "cboReturnStatus";
            this.cboReturnStatus.Size = new System.Drawing.Size(121, 21);
            this.cboReturnStatus.TabIndex = 11;
            // 
            // btnConfirmBorrow
            // 
            this.btnConfirmBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmBorrow.Location = new System.Drawing.Point(165, 304);
            this.btnConfirmBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmBorrow.Name = "btnConfirmBorrow";
            this.btnConfirmBorrow.Size = new System.Drawing.Size(132, 28);
            this.btnConfirmBorrow.TabIndex = 12;
            this.btnConfirmBorrow.Text = "&Confirm";
            this.btnConfirmBorrow.UseVisualStyleBackColor = true;
            this.btnConfirmBorrow.Click += new System.EventHandler(this.btnConfirmBorrow_Click);
            // 
            // btnCancelBorrow
            // 
            this.btnCancelBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelBorrow.Location = new System.Drawing.Point(393, 304);
            this.btnCancelBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBorrow.Name = "btnCancelBorrow";
            this.btnCancelBorrow.Size = new System.Drawing.Size(132, 28);
            this.btnCancelBorrow.TabIndex = 13;
            this.btnCancelBorrow.Text = "Cancel";
            this.btnCancelBorrow.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(806, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter the necessary data for the book and library member data in the following fi" +
    "elds:";
            // 
            // bookDataTableTableAdapter
            // 
            this.bookDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // bookDataTableBindingSource1
            // 
            this.bookDataTableBindingSource1.DataMember = "bookDataTable";
            this.bookDataTableBindingSource1.DataSource = this.libraryDatabaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookDataTableTableAdapter = this.bookDataTableTableAdapter;
            this.tableAdapterManager.libraryCatalogTableAdapter = null;
            this.tableAdapterManager.manageRentalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titleComboBox
            // 
            this.titleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Title", true));
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(617, 141);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(121, 21);
            this.titleComboBox.TabIndex = 16;
            // 
            // frmAddBorrowedBook
            // 
            this.AcceptButton = this.btnConfirmBorrow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(838, 366);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelBorrow);
            this.Controls.Add(this.btnConfirmBorrow);
            this.Controls.Add(this.cboReturnStatus);
            this.Controls.Add(this.dtpDateDue);
            this.Controls.Add(this.dtpDateBorrowed);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddBorrowedBook";
            this.Text = "John Scott Add Borrowed Book";
            this.Load += new System.EventHandler(this.frmAddBorrowedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpDateBorrowed;
        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.ComboBox cboReturnStatus;
        private System.Windows.Forms.Button btnConfirmBorrow;
        private System.Windows.Forms.Button btnCancelBorrow;
        private System.Windows.Forms.Label label7;
        private libraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter bookDataTableTableAdapter;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource1;
        private libraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox titleComboBox;
    }
}