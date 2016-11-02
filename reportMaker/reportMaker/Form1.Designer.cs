namespace reportMaker
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
            this.appscanReportOpen = new System.Windows.Forms.Button();
            this.txtBox_reportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListBox_Vulnerlist = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createReport = new System.Windows.Forms.Button();
            this.txtBox_reportName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_performer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_domainCategory = new System.Windows.Forms.ComboBox();
            this.txtBox_reportSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appscanReportOpen
            // 
            this.appscanReportOpen.Location = new System.Drawing.Point(312, 36);
            this.appscanReportOpen.Name = "appscanReportOpen";
            this.appscanReportOpen.Size = new System.Drawing.Size(164, 23);
            this.appscanReportOpen.TabIndex = 0;
            this.appscanReportOpen.Text = "AppScan 보고서 불러오기";
            this.appscanReportOpen.UseVisualStyleBackColor = true;
            this.appscanReportOpen.Click += new System.EventHandler(this.appscanReportOpen_Click);
            // 
            // txtBox_reportPath
            // 
            this.txtBox_reportPath.Location = new System.Drawing.Point(13, 38);
            this.txtBox_reportPath.Name = "txtBox_reportPath";
            this.txtBox_reportPath.Size = new System.Drawing.Size(285, 21);
            this.txtBox_reportPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "AppScan 보고서 경로";
            // 
            // chkListBox_Vulnerlist
            // 
            this.chkListBox_Vulnerlist.FormattingEnabled = true;
            this.chkListBox_Vulnerlist.Location = new System.Drawing.Point(13, 219);
            this.chkListBox_Vulnerlist.Name = "chkListBox_Vulnerlist";
            this.chkListBox_Vulnerlist.Size = new System.Drawing.Size(463, 340);
            this.chkListBox_Vulnerlist.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "발견 취약점 목록";
            // 
            // createReport
            // 
            this.createReport.Location = new System.Drawing.Point(312, 86);
            this.createReport.Name = "createReport";
            this.createReport.Size = new System.Drawing.Size(161, 101);
            this.createReport.TabIndex = 5;
            this.createReport.Text = "엑셀 보고서 생성";
            this.createReport.UseVisualStyleBackColor = true;
            this.createReport.Click += new System.EventHandler(this.createReport_Click);
            // 
            // txtBox_reportName
            // 
            this.txtBox_reportName.Location = new System.Drawing.Point(113, 86);
            this.txtBox_reportName.Name = "txtBox_reportName";
            this.txtBox_reportName.Size = new System.Drawing.Size(185, 21);
            this.txtBox_reportName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "보안 검수 명 :";
            // 
            // txtBox_performer
            // 
            this.txtBox_performer.Location = new System.Drawing.Point(113, 113);
            this.txtBox_performer.Name = "txtBox_performer";
            this.txtBox_performer.Size = new System.Drawing.Size(185, 21);
            this.txtBox_performer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "검수자 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "구분 :";
            // 
            // cbb_domainCategory
            // 
            this.cbb_domainCategory.FormattingEnabled = true;
            this.cbb_domainCategory.Location = new System.Drawing.Point(113, 140);
            this.cbb_domainCategory.Name = "cbb_domainCategory";
            this.cbb_domainCategory.Size = new System.Drawing.Size(185, 20);
            this.cbb_domainCategory.TabIndex = 8;
            this.cbb_domainCategory.SelectedIndexChanged += new System.EventHandler(this.cbb_domainCategory_SelectedIndexChanged);
            // 
            // txtBox_reportSubject
            // 
            this.txtBox_reportSubject.Location = new System.Drawing.Point(112, 166);
            this.txtBox_reportSubject.Name = "txtBox_reportSubject";
            this.txtBox_reportSubject.Size = new System.Drawing.Size(186, 21);
            this.txtBox_reportSubject.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "제목 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 571);
            this.Controls.Add(this.cbb_domainCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_reportSubject);
            this.Controls.Add(this.txtBox_performer);
            this.Controls.Add(this.txtBox_reportName);
            this.Controls.Add(this.createReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkListBox_Vulnerlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_reportPath);
            this.Controls.Add(this.appscanReportOpen);
            this.Name = "Form1";
            this.Text = "AppScan 보고서 생성 프로그램 Version 0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button appscanReportOpen;
        private System.Windows.Forms.TextBox txtBox_reportPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBox_Vulnerlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createReport;
        private System.Windows.Forms.TextBox txtBox_reportName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_performer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_domainCategory;
        private System.Windows.Forms.TextBox txtBox_reportSubject;
        private System.Windows.Forms.Label label6;
    }
}

