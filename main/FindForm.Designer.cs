namespace main
{
    partial class FindForm
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
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTbox = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindLabel
            // 
            this.FindLabel.Font = new System.Drawing.Font("굴림", 15F);
            this.FindLabel.Location = new System.Drawing.Point(29, 43);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(420, 41);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "수정할 도서의 Isbn을 입력해주세요.";
            // 
            // FindTbox
            // 
            this.FindTbox.Location = new System.Drawing.Point(51, 117);
            this.FindTbox.Name = "FindTbox";
            this.FindTbox.Size = new System.Drawing.Size(213, 25);
            this.FindTbox.TabIndex = 1;
            // 
            // FindBtn
            // 
            this.FindBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindBtn.Location = new System.Drawing.Point(305, 117);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(105, 25);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "확인";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 173);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.FindTbox);
            this.Controls.Add(this.FindLabel);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTbox;
        private System.Windows.Forms.Button FindBtn;
    }
}