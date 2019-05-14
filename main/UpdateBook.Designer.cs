namespace main
{
    partial class UpdateBook
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
            this.IsbnLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.PubLB = new System.Windows.Forms.Label();
            this.PageLB = new System.Windows.Forms.Label();
            this.IsbnTbox = new System.Windows.Forms.TextBox();
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.PubTbox = new System.Windows.Forms.TextBox();
            this.PageTbox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TextLB = new System.Windows.Forms.Label();
            this.OldLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IsbnLB
            // 
            this.IsbnLB.Font = new System.Drawing.Font("굴림", 12F);
            this.IsbnLB.Location = new System.Drawing.Point(54, 81);
            this.IsbnLB.Name = "IsbnLB";
            this.IsbnLB.Size = new System.Drawing.Size(100, 23);
            this.IsbnLB.TabIndex = 0;
            this.IsbnLB.Text = "Isbn";
            // 
            // NameLB
            // 
            this.NameLB.Font = new System.Drawing.Font("굴림", 12F);
            this.NameLB.Location = new System.Drawing.Point(54, 138);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(100, 23);
            this.NameLB.TabIndex = 1;
            this.NameLB.Text = "도서 이름";
            // 
            // PubLB
            // 
            this.PubLB.Font = new System.Drawing.Font("굴림", 12F);
            this.PubLB.Location = new System.Drawing.Point(54, 190);
            this.PubLB.Name = "PubLB";
            this.PubLB.Size = new System.Drawing.Size(100, 23);
            this.PubLB.TabIndex = 2;
            this.PubLB.Text = "출판사";
            // 
            // PageLB
            // 
            this.PageLB.Font = new System.Drawing.Font("굴림", 12F);
            this.PageLB.Location = new System.Drawing.Point(54, 239);
            this.PageLB.Name = "PageLB";
            this.PageLB.Size = new System.Drawing.Size(100, 23);
            this.PageLB.TabIndex = 3;
            this.PageLB.Text = "페이지";
            // 
            // IsbnTbox
            // 
            this.IsbnTbox.Location = new System.Drawing.Point(207, 79);
            this.IsbnTbox.Name = "IsbnTbox";
            this.IsbnTbox.Size = new System.Drawing.Size(137, 25);
            this.IsbnTbox.TabIndex = 4;
            // 
            // NameTbox
            // 
            this.NameTbox.Location = new System.Drawing.Point(207, 136);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(137, 25);
            this.NameTbox.TabIndex = 5;
            // 
            // PubTbox
            // 
            this.PubTbox.Location = new System.Drawing.Point(207, 188);
            this.PubTbox.Name = "PubTbox";
            this.PubTbox.Size = new System.Drawing.Size(137, 25);
            this.PubTbox.TabIndex = 6;
            // 
            // PageTbox
            // 
            this.PageTbox.Location = new System.Drawing.Point(207, 237);
            this.PageTbox.Name = "PageTbox";
            this.PageTbox.Size = new System.Drawing.Size(137, 25);
            this.PageTbox.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateBtn.Location = new System.Drawing.Point(58, 324);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(132, 36);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CancelBtn.Location = new System.Drawing.Point(243, 324);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(132, 36);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TextLB
            // 
            this.TextLB.Location = new System.Drawing.Point(28, 38);
            this.TextLB.Name = "TextLB";
            this.TextLB.Size = new System.Drawing.Size(137, 23);
            this.TextLB.TabIndex = 10;
            this.TextLB.Text = "변경할 도서의 Isbn";
            // 
            // OldLB
            // 
            this.OldLB.Location = new System.Drawing.Point(204, 38);
            this.OldLB.Name = "OldLB";
            this.OldLB.Size = new System.Drawing.Size(100, 23);
            this.OldLB.TabIndex = 11;
            this.OldLB.Text = "ex";
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 395);
            this.Controls.Add(this.OldLB);
            this.Controls.Add(this.TextLB);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.PageTbox);
            this.Controls.Add(this.PubTbox);
            this.Controls.Add(this.NameTbox);
            this.Controls.Add(this.IsbnTbox);
            this.Controls.Add(this.PageLB);
            this.Controls.Add(this.PubLB);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.IsbnLB);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsbnLB;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label PubLB;
        private System.Windows.Forms.Label PageLB;
        private System.Windows.Forms.TextBox IsbnTbox;
        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.TextBox PubTbox;
        private System.Windows.Forms.TextBox PageTbox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label TextLB;
        private System.Windows.Forms.Label OldLB;
    }
}