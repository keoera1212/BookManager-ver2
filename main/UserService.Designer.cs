namespace main
{
    partial class UserService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserService));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManagerDataSet6 = new main.BookManagerDataSet6();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserDelBtn = new System.Windows.Forms.Button();
            this.UserUdtBtn = new System.Windows.Forms.Button();
            this.UserAddBtn = new System.Windows.Forms.Button();
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.IDTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new main.BookManagerDataSet6TableAdapters.CustomerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.UserGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 현황";
            // 
            // UserGrid
            // 
            this.UserGrid.AutoGenerateColumns = false;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.UserGrid.DataSource = this.customerBindingSource;
            this.UserGrid.Location = new System.Drawing.Point(17, 24);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.RowTemplate.Height = 27;
            this.UserGrid.Size = new System.Drawing.Size(423, 522);
            this.UserGrid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bookManagerDataSet6;
            // 
            // bookManagerDataSet6
            // 
            this.bookManagerDataSet6.DataSetName = "BookManagerDataSet6";
            this.bookManagerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.UserDelBtn);
            this.groupBox2.Controls.Add(this.UserUdtBtn);
            this.groupBox2.Controls.Add(this.UserAddBtn);
            this.groupBox2.Controls.Add(this.NameTbox);
            this.groupBox2.Controls.Add(this.IDTbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자 추가 / 수정 / 삭제";
            // 
            // UserDelBtn
            // 
            this.UserDelBtn.AutoEllipsis = true;
            this.UserDelBtn.Location = new System.Drawing.Point(324, 224);
            this.UserDelBtn.Name = "UserDelBtn";
            this.UserDelBtn.Size = new System.Drawing.Size(88, 35);
            this.UserDelBtn.TabIndex = 6;
            this.UserDelBtn.Text = "삭제";
            this.UserDelBtn.UseVisualStyleBackColor = true;
            this.UserDelBtn.Click += new System.EventHandler(this.UserDelBtn_Click);
            // 
            // UserUdtBtn
            // 
            this.UserUdtBtn.AutoSize = true;
            this.UserUdtBtn.Location = new System.Drawing.Point(190, 224);
            this.UserUdtBtn.Name = "UserUdtBtn";
            this.UserUdtBtn.Size = new System.Drawing.Size(88, 35);
            this.UserUdtBtn.TabIndex = 5;
            this.UserUdtBtn.Text = "수정";
            this.UserUdtBtn.UseVisualStyleBackColor = true;
            this.UserUdtBtn.Click += new System.EventHandler(this.UserUdtBtn_Click);
            // 
            // UserAddBtn
            // 
            this.UserAddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserAddBtn.Location = new System.Drawing.Point(59, 224);
            this.UserAddBtn.Name = "UserAddBtn";
            this.UserAddBtn.Size = new System.Drawing.Size(88, 35);
            this.UserAddBtn.TabIndex = 4;
            this.UserAddBtn.Text = "추가";
            this.UserAddBtn.UseVisualStyleBackColor = true;
            this.UserAddBtn.Click += new System.EventHandler(this.UserAddBtn_Click);
            // 
            // NameTbox
            // 
            this.NameTbox.Location = new System.Drawing.Point(143, 105);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(174, 25);
            this.NameTbox.TabIndex = 3;
            // 
            // IDTbox
            // 
            this.IDTbox.Location = new System.Drawing.Point(143, 57);
            this.IDTbox.Name = "IDTbox";
            this.IDTbox.Size = new System.Drawing.Size(174, 25);
            this.IDTbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // UserService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserService";
            this.Text = "사용자 관리";
            this.Load += new System.EventHandler(this.UserService_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManagerDataSet6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserDelBtn;
        private System.Windows.Forms.Button UserUdtBtn;
        private System.Windows.Forms.Button UserAddBtn;
        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.TextBox IDTbox;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private BookManagerDataSet6 bookManagerDataSet6;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BookManagerDataSet6TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}