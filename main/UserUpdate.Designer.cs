namespace main
{
    partial class UserUpdate
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
            this.IdLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.IdTbox = new System.Windows.Forms.TextBox();
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UpdatingLb = new System.Windows.Forms.Label();
            this.FindIdLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdLb
            // 
            this.IdLb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdLb.Location = new System.Drawing.Point(45, 93);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(56, 33);
            this.IdLb.TabIndex = 0;
            this.IdLb.Text = "Id ";
            // 
            // NameLb
            // 
            this.NameLb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameLb.Location = new System.Drawing.Point(45, 147);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(72, 34);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "Name";
            // 
            // IdTbox
            // 
            this.IdTbox.Location = new System.Drawing.Point(153, 93);
            this.IdTbox.Name = "IdTbox";
            this.IdTbox.Size = new System.Drawing.Size(121, 25);
            this.IdTbox.TabIndex = 2;
            // 
            // NameTbox
            // 
            this.NameTbox.Location = new System.Drawing.Point(153, 147);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(121, 25);
            this.NameTbox.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateBtn.Location = new System.Drawing.Point(49, 232);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(96, 43);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "수정";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CloseBtn.Location = new System.Drawing.Point(197, 232);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(96, 43);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "취소";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UpdatingLb
            // 
            this.UpdatingLb.AutoSize = true;
            this.UpdatingLb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.UpdatingLb.Location = new System.Drawing.Point(12, 30);
            this.UpdatingLb.Name = "UpdatingLb";
            this.UpdatingLb.Size = new System.Drawing.Size(163, 15);
            this.UpdatingLb.TabIndex = 6;
            this.UpdatingLb.Text = "수정할 유저의 아이디";
            // 
            // FindIdLb
            // 
            this.FindIdLb.AutoSize = true;
            this.FindIdLb.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.FindIdLb.Location = new System.Drawing.Point(194, 30);
            this.FindIdLb.Name = "FindIdLb";
            this.FindIdLb.Size = new System.Drawing.Size(28, 17);
            this.FindIdLb.TabIndex = 7;
            this.FindIdLb.Text = "ex";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 391);
            this.Controls.Add(this.FindIdLb);
            this.Controls.Add(this.UpdatingLb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.NameTbox);
            this.Controls.Add(this.IdTbox);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.IdLb);
            this.Name = "UserUpdate";
            this.Text = "UserUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox IdTbox;
        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label UpdatingLb;
        private System.Windows.Forms.Label FindIdLb;
    }
}