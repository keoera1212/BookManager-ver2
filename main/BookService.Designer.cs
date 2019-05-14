namespace main
{
    partial class BookService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookService));
            this.AddBookbtn = new System.Windows.Forms.Button();
            this.BookEdit = new System.Windows.Forms.GroupBox();
            this.Pagetbx = new System.Windows.Forms.TextBox();
            this.Pubtbx = new System.Windows.Forms.TextBox();
            this.BookNametbx = new System.Windows.Forms.TextBox();
            this.BookIsbntbx = new System.Windows.Forms.TextBox();
            this.BookPage = new System.Windows.Forms.Label();
            this.BookPublisher = new System.Windows.Forms.Label();
            this.Bookname = new System.Windows.Forms.Label();
            this.Bookisbn = new System.Windows.Forms.Label();
            this.BookDeletebtn = new System.Windows.Forms.Button();
            this.BookUpdatebtn = new System.Windows.Forms.Button();
            this.BookEdition = new System.Windows.Forms.GroupBox();
            this.EditionData = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManagerDataSet2 = new main.BookManagerDataSet2();
            this.bookTableAdapter = new main.BookManagerDataSet2TableAdapters.BookTableAdapter();
            this.bookManagerDataSet1 = new main.BookManagerDataSet();
            this.BookEdit.SuspendLayout();
            this.BookEdition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBookbtn
            // 
            this.AddBookbtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBookbtn.ForeColor = System.Drawing.Color.Black;
            this.AddBookbtn.Location = new System.Drawing.Point(20, 232);
            this.AddBookbtn.Name = "AddBookbtn";
            this.AddBookbtn.Size = new System.Drawing.Size(103, 40);
            this.AddBookbtn.TabIndex = 0;
            this.AddBookbtn.Text = "추가";
            this.AddBookbtn.UseVisualStyleBackColor = false;
            this.AddBookbtn.Click += new System.EventHandler(this.AddBookbtn_Click);
            // 
            // BookEdit
            // 
            this.BookEdit.BackColor = System.Drawing.Color.Transparent;
            this.BookEdit.Controls.Add(this.Pagetbx);
            this.BookEdit.Controls.Add(this.Pubtbx);
            this.BookEdit.Controls.Add(this.BookNametbx);
            this.BookEdit.Controls.Add(this.BookIsbntbx);
            this.BookEdit.Controls.Add(this.BookPage);
            this.BookEdit.Controls.Add(this.BookPublisher);
            this.BookEdit.Controls.Add(this.Bookname);
            this.BookEdit.Controls.Add(this.Bookisbn);
            this.BookEdit.Controls.Add(this.BookDeletebtn);
            this.BookEdit.Controls.Add(this.BookUpdatebtn);
            this.BookEdit.Controls.Add(this.AddBookbtn);
            this.BookEdit.ForeColor = System.Drawing.Color.Snow;
            this.BookEdit.Location = new System.Drawing.Point(12, 12);
            this.BookEdit.Name = "BookEdit";
            this.BookEdit.Size = new System.Drawing.Size(428, 296);
            this.BookEdit.TabIndex = 1;
            this.BookEdit.TabStop = false;
            this.BookEdit.Text = "도서 추가 / 수정 / 삭제";
            // 
            // Pagetbx
            // 
            this.Pagetbx.Location = new System.Drawing.Point(159, 176);
            this.Pagetbx.Name = "Pagetbx";
            this.Pagetbx.Size = new System.Drawing.Size(176, 25);
            this.Pagetbx.TabIndex = 10;
            // 
            // Pubtbx
            // 
            this.Pubtbx.Location = new System.Drawing.Point(159, 136);
            this.Pubtbx.Name = "Pubtbx";
            this.Pubtbx.Size = new System.Drawing.Size(176, 25);
            this.Pubtbx.TabIndex = 9;
            // 
            // BookNametbx
            // 
            this.BookNametbx.Location = new System.Drawing.Point(159, 92);
            this.BookNametbx.Name = "BookNametbx";
            this.BookNametbx.Size = new System.Drawing.Size(176, 25);
            this.BookNametbx.TabIndex = 8;
            // 
            // BookIsbntbx
            // 
            this.BookIsbntbx.Location = new System.Drawing.Point(159, 49);
            this.BookIsbntbx.Name = "BookIsbntbx";
            this.BookIsbntbx.Size = new System.Drawing.Size(176, 25);
            this.BookIsbntbx.TabIndex = 7;
            // 
            // BookPage
            // 
            this.BookPage.AutoSize = true;
            this.BookPage.Location = new System.Drawing.Point(37, 176);
            this.BookPage.Name = "BookPage";
            this.BookPage.Size = new System.Drawing.Size(52, 15);
            this.BookPage.TabIndex = 6;
            this.BookPage.Text = "페이지";
            // 
            // BookPublisher
            // 
            this.BookPublisher.AutoSize = true;
            this.BookPublisher.Location = new System.Drawing.Point(37, 136);
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.Size = new System.Drawing.Size(52, 15);
            this.BookPublisher.TabIndex = 5;
            this.BookPublisher.Text = "출판사";
            // 
            // Bookname
            // 
            this.Bookname.AutoSize = true;
            this.Bookname.Location = new System.Drawing.Point(37, 92);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(72, 15);
            this.Bookname.TabIndex = 4;
            this.Bookname.Text = "도서 이름";
            // 
            // Bookisbn
            // 
            this.Bookisbn.AutoSize = true;
            this.Bookisbn.Location = new System.Drawing.Point(37, 49);
            this.Bookisbn.Name = "Bookisbn";
            this.Bookisbn.Size = new System.Drawing.Size(34, 15);
            this.Bookisbn.TabIndex = 3;
            this.Bookisbn.Text = "Isbn";
            // 
            // BookDeletebtn
            // 
            this.BookDeletebtn.BackColor = System.Drawing.SystemColors.Control;
            this.BookDeletebtn.ForeColor = System.Drawing.Color.Black;
            this.BookDeletebtn.Location = new System.Drawing.Point(293, 232);
            this.BookDeletebtn.Name = "BookDeletebtn";
            this.BookDeletebtn.Size = new System.Drawing.Size(103, 40);
            this.BookDeletebtn.TabIndex = 2;
            this.BookDeletebtn.Text = "삭제";
            this.BookDeletebtn.UseVisualStyleBackColor = false;
            this.BookDeletebtn.Click += new System.EventHandler(this.BookDeletebtn_Click);
            // 
            // BookUpdatebtn
            // 
            this.BookUpdatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.BookUpdatebtn.ForeColor = System.Drawing.Color.Black;
            this.BookUpdatebtn.Location = new System.Drawing.Point(159, 232);
            this.BookUpdatebtn.Name = "BookUpdatebtn";
            this.BookUpdatebtn.Size = new System.Drawing.Size(103, 40);
            this.BookUpdatebtn.TabIndex = 1;
            this.BookUpdatebtn.Text = "수정";
            this.BookUpdatebtn.UseVisualStyleBackColor = false;
            this.BookUpdatebtn.Click += new System.EventHandler(this.BookUpdatebtn_Click);
            // 
            // BookEdition
            // 
            this.BookEdition.BackColor = System.Drawing.Color.Transparent;
            this.BookEdition.Controls.Add(this.EditionData);
            this.BookEdition.Location = new System.Drawing.Point(12, 326);
            this.BookEdition.Name = "BookEdition";
            this.BookEdition.Size = new System.Drawing.Size(1017, 471);
            this.BookEdition.TabIndex = 2;
            this.BookEdition.TabStop = false;
            this.BookEdition.Text = "도서 현황";
            // 
            // EditionData
            // 
            this.EditionData.AutoGenerateColumns = false;
            this.EditionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn});
            this.EditionData.DataSource = this.bookBindingSource;
            this.EditionData.Location = new System.Drawing.Point(20, 24);
            this.EditionData.Name = "EditionData";
            this.EditionData.RowTemplate.Height = 27;
            this.EditionData.Size = new System.Drawing.Size(976, 431);
            this.EditionData.TabIndex = 0;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 150;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.bookManagerDataSet2;
            // 
            // bookManagerDataSet2
            // 
            this.bookManagerDataSet2.DataSetName = "BookManagerDataSet2";
            this.bookManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookManagerDataSet1
            // 
            this.bookManagerDataSet1.DataSetName = "BookManagerDataSet";
            this.bookManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BookService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 809);
            this.Controls.Add(this.BookEdition);
            this.Controls.Add(this.BookEdit);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "BookService";
            this.Text = "도서 관리";
            this.Load += new System.EventHandler(this.BookService_Load);
            this.BookEdit.ResumeLayout(false);
            this.BookEdit.PerformLayout();
            this.BookEdition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBookbtn;
        private System.Windows.Forms.GroupBox BookEdit;
        private System.Windows.Forms.Label BookPage;
        private System.Windows.Forms.Label BookPublisher;
        private System.Windows.Forms.Label Bookname;
        private System.Windows.Forms.Label Bookisbn;
        private System.Windows.Forms.Button BookDeletebtn;
        private System.Windows.Forms.Button BookUpdatebtn;
        private System.Windows.Forms.TextBox Pagetbx;
        private System.Windows.Forms.TextBox Pubtbx;
        private System.Windows.Forms.TextBox BookNametbx;
        private System.Windows.Forms.TextBox BookIsbntbx;
        private System.Windows.Forms.GroupBox BookEdition;
        private System.Windows.Forms.DataGridView EditionData;
        private BookManagerDataSet2 bookManagerDataSet2;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookManagerDataSet2TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private BookManagerDataSet bookManagerDataSet1;
    }
}