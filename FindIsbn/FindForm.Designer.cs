﻿namespace FindIsbn
{
    partial class FindForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UisbnTbox = new System.Windows.Forms.TextBox();
            this.isbnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "수정할 도서의 Isbn을 입력해주세요.";
            // 
            // UisbnTbox
            // 
            this.UisbnTbox.Location = new System.Drawing.Point(62, 129);
            this.UisbnTbox.Name = "UisbnTbox";
            this.UisbnTbox.Size = new System.Drawing.Size(209, 25);
            this.UisbnTbox.TabIndex = 1;
            // 
            // isbnBtn
            // 
            this.isbnBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.isbnBtn.Location = new System.Drawing.Point(306, 129);
            this.isbnBtn.Name = "isbnBtn";
            this.isbnBtn.Size = new System.Drawing.Size(90, 23);
            this.isbnBtn.TabIndex = 2;
            this.isbnBtn.Text = "확인";
            this.isbnBtn.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 201);
            this.Controls.Add(this.isbnBtn);
            this.Controls.Add(this.UisbnTbox);
            this.Controls.Add(this.label1);
            this.Name = "FindForm";
            this.Text = "Isbn 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UisbnTbox;
        private System.Windows.Forms.Button isbnBtn;
    }
}

