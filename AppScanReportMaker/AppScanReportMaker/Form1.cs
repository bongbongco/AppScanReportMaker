using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace AppScanReportMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_selectedScanPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show("스캔파일이 저장된 디렉터리를 지정해주세요");
            #region 스캔파일 디렉터리 불러오기
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string scanPath = dialog.SelectedPath;
            txtbox_path.Text = scanPath;
            #endregion

            MessageBox.Show("보고서를 생성할 디렉터리를 지정해주세요");
            #region 보고서 디렉터리 지정
            dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string savePath = dialog.SelectedPath;
            txtbox_path.Text = savePath;
            #endregion


            #region 스케줄로 진단된 스캔 파일 보고서 생성 요청
            if (System.IO.Directory.Exists(scanPath))
            {
	            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(scanPath);

	            foreach (var item in directoryInfo.GetFiles())
	            {

		            string scheduleFilePattern = @"[\w|\W]*\d{4}-\d{2}-\d{2}_\d{4}.scan$";
                    string scanFileName = item.Name;

                    //string test = selectedPath+"\\"+scanFileName;

		            if (Regex.IsMatch(item.Name, scheduleFilePattern))
		            {
                        CreateReport(scanPath, scanFileName, savePath);
			            //new Thread(new ThreadStart(CreateReport(selectedPath+"\\"+scanFileName))).Start();
			            //Delay(10000); // 10초 딜레이 설정
		            }
	            }
            }
            #endregion
        }

        #region 보고서 생성 함수
        private void CreateReport(string scanPath, string scanFileName, string savePath)
        {
	        System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
	        System.Diagnostics.Process process = new System.Diagnostics.Process();
	
	        processInfo.FileName = @"cmd";
	        processInfo.CreateNoWindow = true;
	        processInfo.UseShellExecute = false;
	        processInfo.RedirectStandardOutput = true;
	        processInfo.RedirectStandardInput = true;
	        processInfo.RedirectStandardError = true;

	        process.StartInfo = processInfo;
	        process.Start();

	        #region 보고서 생성
            process.StandardInput.Write("\"C:\\Program Files (x86)\\IBM\\AppScan Standard\\AppScanCMD.exe\" report -base_scan \"" + scanPath + "\\" + scanFileName + "\" -report_file \"" +savePath+ "\\" + scanFileName.Substring(0, scanFileName.IndexOf(".scan")) + ".html\" -report_type html"
        +Environment.NewLine);
            //process.StandardInput.Write("\"C:\\Program Files (x86)\\IBM\\AppScan Standard\\AppScanCMD.exe\" report -base_scan \"" + scanPath + "\" -report_file \"" + savePath.Substring(0, savePath.IndexOf(".scan")) + ".pdf\" -report_type pdf"
        //+Environment.NewLine);
	        #endregion

	        process.StandardInput.Close();
	
	        string resultValue = process.StandardOutput.ReadToEnd();
	        process.WaitForExit();
	        process.Close();

	        txtbox_result.Text += resultValue;
        }
        #endregion

        #region 시간 지연 함수
        private static DateTime Delay(int MS)
        {
	        DateTime ThisMoment = DateTime.Now;
	        TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
	        DateTime AfterWards = ThisMoment.Add(duration);
	        while (AfterWards >= ThisMoment)
	        {
		        System.Windows.Forms.Application.DoEvents();
		        ThisMoment = DateTime.Now;
	        }
	        return DateTime.Now;
        }
        #endregion
    }
}
