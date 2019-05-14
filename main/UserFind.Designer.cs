namespace main
{
    partial class UserFind
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
            this.FindUserLb = new System.Windows.Forms.Label();
            this.FindUserTbox = new System.Windows.Forms.TextBox();
            this.FindUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindUserLb
            // 
            this.FindUserLb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindUserLb.Location = new System.Drawing.Point(27, 56);
            this.FindUserLb.Name = "FindUserLb";
            this.FindUserLb.Size = new System.Drawing.Size(338, 37);
            this.FindUserLb.TabIndex = 0;
            this.FindUserLb.Text = "수정할 유저의 ID를 입력해주세요.";
            // 
            // FindUserTbox
            // 
            this.FindUserTbox.Location = new System.Drawing.Point(62, 118);
            this.FindUserTbox.Name = "FindUserTbox";
            this.FindUserTbox.Size = new System.Drawing.Size(154, 25);
            this.FindUserTbox.TabIndex = 1;
            // 
            // FindUserBtn
            // 
            this.FindUserBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.FindUserBtn.Location = new System.Drawing.Point(253, 111);
            this.FindUserBtn.Name = "FindUserBtn";
            this.FindUserBtn.Size = new System.Drawing.Size(88, 34);
            this.FindUserBtn.TabIndex = 2;
            this.FindUserBtn.Text = "확인";
            this.FindUserBtn.UseVisualStyleBackColor = true;
            this.FindUserBtn.Click += new System.EventHandler(this.FindUserBtn_Click);
            // 
            // UserFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 204);
            this.Controls.Add(this.FindUserBtn);
            this.Controls.Add(this.FindUserTbox);
            this.Controls.Add(this.FindUserLb);
            this.Name = "UserFind";
            this.Text = "UserFind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindUserLb;
        private System.Windows.Forms.TextBox FindUserTbox;
        private System.Windows.Forms.Button FindUserBtn;
    }
}