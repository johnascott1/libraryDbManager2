namespace libraryDbManager
{
    partial class frmAddBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQtyAvailable = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmBook = new System.Windows.Forms.Button();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.cboPhysicalFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchGoogleBooks = new System.Windows.Forms.Button();
            this.txtSearchGoogleBooks = new System.Windows.Forms.TextBox();
            this.searchResDataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.Subtitle = new System.Windows.Forms.Label();
            this.dtDatePublished = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(174, 96);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(141, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(174, 131);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(141, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(174, 204);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(141, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(1061, 90);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(141, 20);
            this.txtGenre.TabIndex = 6;
            this.txtGenre.Visible = false;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(174, 239);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(141, 20);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(1061, 47);
            this.txtYearPublished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(141, 20);
            this.txtYearPublished.TabIndex = 9;
            this.txtYearPublished.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(899, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genre:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Physical Format:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Publisher:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(899, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year Published";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity Available:";
            // 
            // nudQtyAvailable
            // 
            this.nudQtyAvailable.Location = new System.Drawing.Point(174, 348);
            this.nudQtyAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQtyAvailable.Name = "nudQtyAvailable";
            this.nudQtyAvailable.Size = new System.Drawing.Size(105, 20);
            this.nudQtyAvailable.TabIndex = 17;
            // 
            // btnConfirmBook
            // 
            this.btnConfirmBook.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmBook.Location = new System.Drawing.Point(15, 436);
            this.btnConfirmBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmBook.Name = "btnConfirmBook";
            this.btnConfirmBook.Size = new System.Drawing.Size(66, 28);
            this.btnConfirmBook.TabIndex = 18;
            this.btnConfirmBook.Text = "Confirm";
            this.btnConfirmBook.UseVisualStyleBackColor = true;
            this.btnConfirmBook.Click += new System.EventHandler(this.btnConfirmBook_Click);
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.ForeColor = System.Drawing.Color.Black;
            this.btnCancelBook.Location = new System.Drawing.Point(168, 435);
            this.btnCancelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(66, 28);
            this.btnCancelBook.TabIndex = 19;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = true;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // cboPhysicalFormat
            // 
            this.cboPhysicalFormat.FormattingEnabled = true;
            this.cboPhysicalFormat.Items.AddRange(new object[] {
            "Hardback",
            "Paperback",
            "Audio",
            "Braille",
            "Electronic"});
            this.cboPhysicalFormat.Location = new System.Drawing.Point(174, 314);
            this.cboPhysicalFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPhysicalFormat.Name = "cboPhysicalFormat";
            this.cboPhysicalFormat.Size = new System.Drawing.Size(106, 21);
            this.cboPhysicalFormat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(413, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Enter the book data in the following fields:";
            // 
            // btnSearchGoogleBooks
            // 
            this.btnSearchGoogleBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchGoogleBooks.Location = new System.Drawing.Point(397, 90);
            this.btnSearchGoogleBooks.Name = "btnSearchGoogleBooks";
            this.btnSearchGoogleBooks.Size = new System.Drawing.Size(65, 29);
            this.btnSearchGoogleBooks.TabIndex = 22;
            this.btnSearchGoogleBooks.Text = "Search";
            this.btnSearchGoogleBooks.UseVisualStyleBackColor = true;
            this.btnSearchGoogleBooks.Click += new System.EventHandler(this.btnSearchGoogleBooks_Click);
            // 
            // txtSearchGoogleBooks
            // 
            this.txtSearchGoogleBooks.Location = new System.Drawing.Point(507, 99);
            this.txtSearchGoogleBooks.Name = "txtSearchGoogleBooks";
            this.txtSearchGoogleBooks.Size = new System.Drawing.Size(141, 20);
            this.txtSearchGoogleBooks.TabIndex = 23;
            // 
            // searchResDataGridView
            // 
            this.searchResDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchResDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchResDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchResDataGridView.Location = new System.Drawing.Point(397, 152);
            this.searchResDataGridView.Name = "searchResDataGridView";
            this.searchResDataGridView.RowTemplate.Height = 24;
            this.searchResDataGridView.Size = new System.Drawing.Size(1140, 311);
            this.searchResDataGridView.TabIndex = 24;
            this.searchResDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResDataGridView_RowEnter);
            this.searchResDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResDataGridView_RowHeaderMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Date Published:";
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.Location = new System.Drawing.Point(174, 168);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(100, 20);
            this.txtSubtitle.TabIndex = 27;
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(15, 170);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(72, 17);
            this.Subtitle.TabIndex = 28;
            this.Subtitle.Text = "Subtitle";
            // 
            // dtDatePublished
            // 
            this.dtDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePublished.Location = new System.Drawing.Point(174, 277);
            this.dtDatePublished.Name = "dtDatePublished";
            this.dtDatePublished.Size = new System.Drawing.Size(200, 20);
            this.dtDatePublished.TabIndex = 29;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1565, 490);
            this.Controls.Add(this.dtDatePublished);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.txtSubtitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchResDataGridView);
            this.Controls.Add(this.txtSearchGoogleBooks);
            this.Controls.Add(this.btnSearchGoogleBooks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboPhysicalFormat);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.btnConfirmBook);
            this.Controls.Add(this.nudQtyAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYearPublished);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddBook";
            this.Text = "frmAddBook";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtyAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudQtyAvailable;
        private System.Windows.Forms.Button btnConfirmBook;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.ComboBox cboPhysicalFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchGoogleBooks;
        private System.Windows.Forms.TextBox txtSearchGoogleBooks;
        private System.Windows.Forms.DataGridView searchResDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtitle;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.DateTimePicker dtDatePublished;
    }
}