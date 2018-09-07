namespace libraryDbManager
{
    partial class frmModifyCatalog
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
            System.Windows.Forms.Label iSBNLabel1;
            System.Windows.Forms.Label subtitleLabel;
            System.Windows.Forms.Label authorsLabel;
            System.Windows.Forms.Label publisherLabel1;
            System.Windows.Forms.Label publication_DateLabel;
            System.Windows.Forms.Label print_TypeLabel;
            System.Windows.Forms.Label quantity_AvailableLabel1;
            System.Windows.Forms.Label quantity_Checked_OutLabel;
            System.Windows.Forms.Label titleLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmCatalogDeletion = new System.Windows.Forms.Button();
            this.btnConfirmCatalogUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.libraryCatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new libraryDbManager.libraryDatabaseDataSet();
            this.libraryCatalogTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.libraryCatalogTableAdapter();
            this.tableAdapterManager = new libraryDbManager.libraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataTableTableAdapter = new libraryDbManager.libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter();
            this.bookDataTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.quantity_Checked_OutTextBox = new System.Windows.Forms.TextBox();
            this.quantity_AvailableTextBox = new System.Windows.Forms.TextBox();
            this.print_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.publication_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.publisherTextBox1 = new System.Windows.Forms.TextBox();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.subtitleTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox1 = new System.Windows.Forms.TextBox();
            iSBNLabel1 = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            authorsLabel = new System.Windows.Forms.Label();
            publisherLabel1 = new System.Windows.Forms.Label();
            publication_DateLabel = new System.Windows.Forms.Label();
            print_TypeLabel = new System.Windows.Forms.Label();
            quantity_AvailableLabel1 = new System.Windows.Forms.Label();
            quantity_Checked_OutLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryCatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBNLabel1
            // 
            iSBNLabel1.AutoSize = true;
            iSBNLabel1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel1.ForeColor = System.Drawing.Color.Aqua;
            iSBNLabel1.Location = new System.Drawing.Point(10, 39);
            iSBNLabel1.Name = "iSBNLabel1";
            iSBNLabel1.Size = new System.Drawing.Size(52, 17);
            iSBNLabel1.TabIndex = 0;
            iSBNLabel1.Text = "ISBN:";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subtitleLabel.ForeColor = System.Drawing.Color.Aqua;
            subtitleLabel.Location = new System.Drawing.Point(6, 123);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new System.Drawing.Size(76, 17);
            subtitleLabel.TabIndex = 4;
            subtitleLabel.Text = "Subtitle:";
            // 
            // authorsLabel
            // 
            authorsLabel.AutoSize = true;
            authorsLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authorsLabel.ForeColor = System.Drawing.Color.Aqua;
            authorsLabel.Location = new System.Drawing.Point(259, 39);
            authorsLabel.Name = "authorsLabel";
            authorsLabel.Size = new System.Drawing.Size(77, 17);
            authorsLabel.TabIndex = 6;
            authorsLabel.Text = "Authors:";
            // 
            // publisherLabel1
            // 
            publisherLabel1.AutoSize = true;
            publisherLabel1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publisherLabel1.ForeColor = System.Drawing.Color.Aqua;
            publisherLabel1.Location = new System.Drawing.Point(256, 82);
            publisherLabel1.Name = "publisherLabel1";
            publisherLabel1.Size = new System.Drawing.Size(88, 17);
            publisherLabel1.TabIndex = 8;
            publisherLabel1.Text = "Publisher:";
            // 
            // publication_DateLabel
            // 
            publication_DateLabel.AutoSize = true;
            publication_DateLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publication_DateLabel.ForeColor = System.Drawing.Color.Aqua;
            publication_DateLabel.Location = new System.Drawing.Point(552, 143);
            publication_DateLabel.Name = "publication_DateLabel";
            publication_DateLabel.Size = new System.Drawing.Size(147, 17);
            publication_DateLabel.TabIndex = 10;
            publication_DateLabel.Text = "Publication Date:";
            // 
            // print_TypeLabel
            // 
            print_TypeLabel.AutoSize = true;
            print_TypeLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            print_TypeLabel.ForeColor = System.Drawing.Color.Aqua;
            print_TypeLabel.Location = new System.Drawing.Point(259, 132);
            print_TypeLabel.Name = "print_TypeLabel";
            print_TypeLabel.Size = new System.Drawing.Size(97, 17);
            print_TypeLabel.TabIndex = 12;
            print_TypeLabel.Text = "Print Type:";
            // 
            // quantity_AvailableLabel1
            // 
            quantity_AvailableLabel1.AutoSize = true;
            quantity_AvailableLabel1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantity_AvailableLabel1.ForeColor = System.Drawing.Color.Aqua;
            quantity_AvailableLabel1.Location = new System.Drawing.Point(552, 94);
            quantity_AvailableLabel1.Name = "quantity_AvailableLabel1";
            quantity_AvailableLabel1.Size = new System.Drawing.Size(161, 17);
            quantity_AvailableLabel1.TabIndex = 14;
            quantity_AvailableLabel1.Text = "Quantity Available:";
            // 
            // quantity_Checked_OutLabel
            // 
            quantity_Checked_OutLabel.AutoSize = true;
            quantity_Checked_OutLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantity_Checked_OutLabel.ForeColor = System.Drawing.Color.Aqua;
            quantity_Checked_OutLabel.Location = new System.Drawing.Point(552, 33);
            quantity_Checked_OutLabel.Name = "quantity_Checked_OutLabel";
            quantity_Checked_OutLabel.Size = new System.Drawing.Size(194, 17);
            quantity_Checked_OutLabel.TabIndex = 16;
            quantity_Checked_OutLabel.Text = "Quantity Checked Out:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.Aqua;
            titleLabel.Location = new System.Drawing.Point(6, 82);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(50, 17);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Title:";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(232, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmCatalogDeletion
            // 
            this.btnConfirmCatalogDeletion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmCatalogDeletion.Location = new System.Drawing.Point(130, 219);
            this.btnConfirmCatalogDeletion.Name = "btnConfirmCatalogDeletion";
            this.btnConfirmCatalogDeletion.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCatalogDeletion.TabIndex = 17;
            this.btnConfirmCatalogDeletion.Text = "Delete";
            this.btnConfirmCatalogDeletion.UseVisualStyleBackColor = true;
            this.btnConfirmCatalogDeletion.Click += new System.EventHandler(this.btnConfirmCatalogDeletion_Click);
            // 
            // btnConfirmCatalogUpdate
            // 
            this.btnConfirmCatalogUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmCatalogUpdate.Location = new System.Drawing.Point(13, 219);
            this.btnConfirmCatalogUpdate.Name = "btnConfirmCatalogUpdate";
            this.btnConfirmCatalogUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCatalogUpdate.TabIndex = 16;
            this.btnConfirmCatalogUpdate.Text = "Update";
            this.btnConfirmCatalogUpdate.UseVisualStyleBackColor = true;
            this.btnConfirmCatalogUpdate.Click += new System.EventHandler(this.btnConfirmCatalogUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modify Catalog";
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
            // bookDataTableBindingSource
            // 
            this.bookDataTableBindingSource.DataMember = "bookDataTable";
            this.bookDataTableBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // bookDataTableTableAdapter
            // 
            this.bookDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // bookDataTableDataGridView
            // 
            this.bookDataTableDataGridView.AutoGenerateColumns = false;
            this.bookDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.bookDataTableDataGridView.DataSource = this.bookDataTableBindingSource;
            this.bookDataTableDataGridView.Location = new System.Drawing.Point(21, 359);
            this.bookDataTableDataGridView.Name = "bookDataTableDataGridView";
            this.bookDataTableDataGridView.RowTemplate.Height = 24;
            this.bookDataTableDataGridView.Size = new System.Drawing.Size(1125, 292);
            this.bookDataTableDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn10.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn11.HeaderText = "Title";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Subtitle";
            this.dataGridViewTextBoxColumn12.HeaderText = "Subtitle";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Authors";
            this.dataGridViewTextBoxColumn13.HeaderText = "Authors";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Publisher";
            this.dataGridViewTextBoxColumn14.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Publication Date";
            this.dataGridViewTextBoxColumn15.HeaderText = "Publication Date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Print Type";
            this.dataGridViewTextBoxColumn16.HeaderText = "Print Type";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Quantity Available";
            this.dataGridViewTextBoxColumn17.HeaderText = "Quantity Available";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Quantity Checked Out";
            this.dataGridViewTextBoxColumn18.HeaderText = "Quantity Checked Out";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(titleLabel);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(quantity_Checked_OutLabel);
            this.groupBox1.Controls.Add(this.btnConfirmCatalogDeletion);
            this.groupBox1.Controls.Add(this.quantity_Checked_OutTextBox);
            this.groupBox1.Controls.Add(this.btnConfirmCatalogUpdate);
            this.groupBox1.Controls.Add(quantity_AvailableLabel1);
            this.groupBox1.Controls.Add(this.quantity_AvailableTextBox);
            this.groupBox1.Controls.Add(print_TypeLabel);
            this.groupBox1.Controls.Add(this.print_TypeComboBox);
            this.groupBox1.Controls.Add(publication_DateLabel);
            this.groupBox1.Controls.Add(this.publication_DateDateTimePicker);
            this.groupBox1.Controls.Add(publisherLabel1);
            this.groupBox1.Controls.Add(this.publisherTextBox1);
            this.groupBox1.Controls.Add(authorsLabel);
            this.groupBox1.Controls.Add(this.authorsTextBox);
            this.groupBox1.Controls.Add(subtitleLabel);
            this.groupBox1.Controls.Add(this.subtitleTextBox);
            this.groupBox1.Controls.Add(iSBNLabel1);
            this.groupBox1.Controls.Add(this.iSBNTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 265);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(59, 98);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(158, 22);
            this.titleTextBox.TabIndex = 20;
            // 
            // quantity_Checked_OutTextBox
            // 
            this.quantity_Checked_OutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Quantity Checked Out", true));
            this.quantity_Checked_OutTextBox.Location = new System.Drawing.Point(638, 59);
            this.quantity_Checked_OutTextBox.Name = "quantity_Checked_OutTextBox";
            this.quantity_Checked_OutTextBox.Size = new System.Drawing.Size(158, 22);
            this.quantity_Checked_OutTextBox.TabIndex = 17;
            // 
            // quantity_AvailableTextBox
            // 
            this.quantity_AvailableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Quantity Available", true));
            this.quantity_AvailableTextBox.Location = new System.Drawing.Point(638, 118);
            this.quantity_AvailableTextBox.Name = "quantity_AvailableTextBox";
            this.quantity_AvailableTextBox.Size = new System.Drawing.Size(158, 22);
            this.quantity_AvailableTextBox.TabIndex = 15;
            // 
            // print_TypeComboBox
            // 
            this.print_TypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Print Type", true));
            this.print_TypeComboBox.FormattingEnabled = true;
            this.print_TypeComboBox.Location = new System.Drawing.Point(361, 152);
            this.print_TypeComboBox.Name = "print_TypeComboBox";
            this.print_TypeComboBox.Size = new System.Drawing.Size(158, 24);
            this.print_TypeComboBox.TabIndex = 13;
            // 
            // publication_DateDateTimePicker
            // 
            this.publication_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookDataTableBindingSource, "Publication Date", true));
            this.publication_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.publication_DateDateTimePicker.Location = new System.Drawing.Point(638, 166);
            this.publication_DateDateTimePicker.Name = "publication_DateDateTimePicker";
            this.publication_DateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.publication_DateDateTimePicker.TabIndex = 11;
            // 
            // publisherTextBox1
            // 
            this.publisherTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Publisher", true));
            this.publisherTextBox1.Location = new System.Drawing.Point(361, 98);
            this.publisherTextBox1.Name = "publisherTextBox1";
            this.publisherTextBox1.Size = new System.Drawing.Size(158, 22);
            this.publisherTextBox1.TabIndex = 9;
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Authors", true));
            this.authorsTextBox.Location = new System.Drawing.Point(361, 59);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.Size = new System.Drawing.Size(158, 22);
            this.authorsTextBox.TabIndex = 7;
            // 
            // subtitleTextBox
            // 
            this.subtitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "Subtitle", true));
            this.subtitleTextBox.Location = new System.Drawing.Point(59, 152);
            this.subtitleTextBox.Name = "subtitleTextBox";
            this.subtitleTextBox.Size = new System.Drawing.Size(158, 22);
            this.subtitleTextBox.TabIndex = 5;
            // 
            // iSBNTextBox1
            // 
            this.iSBNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookDataTableBindingSource, "ISBN", true));
            this.iSBNTextBox1.Location = new System.Drawing.Point(59, 59);
            this.iSBNTextBox1.Name = "iSBNTextBox1";
            this.iSBNTextBox1.Size = new System.Drawing.Size(158, 22);
            this.iSBNTextBox1.TabIndex = 1;
            // 
            // frmModifyCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1234, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookDataTableDataGridView);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmModifyCatalog";
            this.Text = "John Scott Modify Catalog";
            this.Load += new System.EventHandler(this.frmModifyCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryCatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTableDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource libraryCatalogBindingSource;
        private libraryDatabaseDataSetTableAdapters.libraryCatalogTableAdapter libraryCatalogTableAdapter;
        private libraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmCatalogDeletion;
        private System.Windows.Forms.Button btnConfirmCatalogUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bookDataTableBindingSource;
        private libraryDatabaseDataSetTableAdapters.bookDataTableTableAdapter bookDataTableTableAdapter;
        private System.Windows.Forms.DataGridView bookDataTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox quantity_Checked_OutTextBox;
        private System.Windows.Forms.TextBox quantity_AvailableTextBox;
        private System.Windows.Forms.ComboBox print_TypeComboBox;
        private System.Windows.Forms.DateTimePicker publication_DateDateTimePicker;
        private System.Windows.Forms.TextBox publisherTextBox1;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.TextBox subtitleTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox1;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}