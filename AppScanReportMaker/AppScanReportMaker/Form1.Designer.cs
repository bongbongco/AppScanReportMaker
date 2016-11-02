namespace AppScanReportMaker
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_selectedScanPath = new System.Windows.Forms.Button();
            this.txtbox_result = new System.Windows.Forms.TextBox();
            this.txtbox_path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_selectedScanPath
            // 
            this.bt_selectedScanPath.Location = new System.Drawing.Point(325, 25);
            this.bt_selectedScanPath.Name = "bt_selectedScanPath";
            this.bt_selectedScanPath.Size = new System.Drawing.Size(149, 26);
            this.bt_selectedScanPath.TabIndex = 0;
            this.bt_selectedScanPath.Text = "디렉터리 지정";
            this.bt_selectedScanPath.UseVisualStyleBackColor = true;
            this.bt_selectedScanPath.Click += new System.EventHandler(this.bt_selectedScanPath_Click);
            // 
            // txtbox_result
            // 
            this.txtbox_result.Location = new System.Drawing.Point(12, 67);
            this.txtbox_result.Multiline = true;
            this.txtbox_result.Name = "txtbox_result";
            this.txtbox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_result.Size = new System.Drawing.Size(462, 295);
            this.txtbox_result.TabIndex = 1;
            // 
            // txtbox_path
            // 
            this.txtbox_path.Location = new System.Drawing.Point(12, 30);
            this.txtbox_path.Name = "txtbox_path";
            this.txtbox_path.Size = new System.Drawing.Size(294, 21);
            this.txtbox_path.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 379);
            this.Controls.Add(this.txtbox_path);
            this.Controls.Add(this.txtbox_result);
            this.Controls.Add(this.bt_selectedScanPath);
            this.Name = "Form1";
            this.Text = "AppScan 보고서 생성 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_selectedScanPath;
        private System.Windows.Forms.TextBox txtbox_result;
        private System.Windows.Forms.TextBox txtbox_path;
    }
}

