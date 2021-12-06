namespace PropertyGrid_INI_Test
{
    partial class FrmMAIN
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
            this.Btn_pGridForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_pGridForm
            // 
            this.Btn_pGridForm.Location = new System.Drawing.Point(12, 12);
            this.Btn_pGridForm.Name = "Btn_pGridForm";
            this.Btn_pGridForm.Size = new System.Drawing.Size(114, 51);
            this.Btn_pGridForm.TabIndex = 0;
            this.Btn_pGridForm.Text = "PropertyGrid";
            this.Btn_pGridForm.UseVisualStyleBackColor = true;
            this.Btn_pGridForm.Click += new System.EventHandler(this.Btn_pGridForm_Click);
            // 
            // FrmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 581);
            this.Controls.Add(this.Btn_pGridForm);
            this.Name = "FrmMAIN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMAIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_pGridForm;
    }
}

