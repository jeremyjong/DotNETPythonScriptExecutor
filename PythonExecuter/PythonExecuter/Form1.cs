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
using System.IO;
using System.Diagnostics;


namespace PythonExecuter
{
    public partial class Form1 : Form
    {

        private Process currentProcess;
        private StringBuilder outStringBuilder = new StringBuilder();
        private int readCount = 0;
        private Boolean isCanceled = false;


        public void GetSettings()
        {
            txt_python_dir.Text = Properties.Settings.Default.PythonDirectory;
            txt_work_dir.Text = Properties.Settings.Default.WorkDirectory;
            txt_python_cmd.Text = Properties.Settings.Default.PythonCommand;
            txt_input.Text = Properties.Settings.Default.Input;


        }

        public void SaveSettings()
        {
            Properties.Settings.Default.PythonDirectory = txt_python_dir.Text;
            Properties.Settings.Default.WorkDirectory = txt_work_dir.Text;
            Properties.Settings.Default.PythonCommand = txt_python_cmd.Text;
            Properties.Settings.Default.Input = txt_input.Text;

            Properties.Settings.Default.Save();

        }


        public Form1()
        {
            
            InitializeComponent();
            GetSettings();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // 標準入力エリアのクリア
            this.txt_input.Clear();
            // 標準出力エリアのクリア
            this.txt_output.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (currentProcess != null)
            {
                try
                {
                    currentProcess.Kill();
                    isCanceled = true;
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2);
                }
            }
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            // 前処理
            btn_exec.Enabled = false;
            btn_clear.Enabled = true;
            isCanceled = false;
            readCount = 0;
            outStringBuilder.Clear();
            this.Invoke((MethodInvoker)(() => this.txt_output.Clear()));

            // 実行
            RunCommandLineAsync();
        }


        public void RunCommandLineAsync()
        {

            ProcessStartInfo psInfo = new ProcessStartInfo();
            psInfo.FileName = this.txt_python_dir.Text.Trim();
            psInfo.WorkingDirectory = this.txt_work_dir.Text.Trim();
            psInfo.Arguments = this.txt_python_cmd.Text.Trim();

            psInfo.CreateNoWindow = true;
            psInfo.UseShellExecute = false;
            psInfo.RedirectStandardInput = true;
            psInfo.RedirectStandardOutput = true;
            psInfo.RedirectStandardError = true;

            // Process p = Process.Start(psInfo);
            Process p = new System.Diagnostics.Process();
            p.StartInfo = psInfo;

            p.EnableRaisingEvents = true;
            p.Exited += onExited;
            p.OutputDataReceived += p_OutputDataReceived;
            p.ErrorDataReceived += p_ErrorDataReceived;

            p.Start();

            // 標準入力への書き込み
            using (StreamWriter sw = p.StandardInput)
            {
                sw.Write(this.txt_input.Text.Trim());
            }

            //非同期で出力とエラーの読み取りを開始
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            currentProcess = p;
        }


        void p_OutputDataReceived(object sender,
            System.Diagnostics.DataReceivedEventArgs e)
        {
            processMessage(sender, e);
        }

        /// <summary>
        /// 標準エラーを受け取った時の処理
        /// </summary>
        void p_ErrorDataReceived(object sender,
            System.Diagnostics.DataReceivedEventArgs e)
        {
            processMessage(sender, e);
        }


        void processMessage(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (e != null && e.Data != null && e.Data.Length > 0)
            {
                outStringBuilder.Append(e.Data + "\r\n");
            }
            readCount++;
            // まとまったタイミングで吐き出し
            if (readCount % 5 == 0)
            {
                this.Invoke((MethodInvoker)(() => AppendText(outStringBuilder.ToString(), false)));
                outStringBuilder.Clear();
                // スレッドを占有しないようスリープを入れる
                if (readCount % 1000 == 0)
                {
                    Thread.Sleep(100);
                }
            }
        }


        public void AppendText(String data, Boolean console)
        {
            txt_output.AppendText(data);
            if (console)
            {
                txt_output.AppendText("\r\n");
                Console.WriteLine(data);
            }
        }


        void onExited(object sender, EventArgs e)
        {
            int exitCode;

            if (currentProcess != null)
            {
                currentProcess.WaitForExit();

                // 吐き出されずに残っているデータの吐き出し
                this.Invoke((MethodInvoker)(() => AppendText(outStringBuilder.ToString(), false)));
                outStringBuilder.Clear();

                exitCode = currentProcess.ExitCode;
                currentProcess.CancelOutputRead();
                currentProcess.CancelErrorRead();
                currentProcess.Close();
                currentProcess.Dispose();
                currentProcess = null;

                this.Invoke((MethodInvoker)(() => this.btn_exec.Enabled = true));


                if (isCanceled)
                {
                    // 完了メッセージ
                    this.Invoke((MethodInvoker)(() => MessageBox.Show("処理をキャンセルしました")));
                    

                }
                else
                {
                    if (exitCode == 0)
                    {
                        // 完了メッセージ
                        this.Invoke((MethodInvoker)(() => MessageBox.Show("処理が完了しました")));
                    }
                    else
                    {
                        // 完了メッセージ
                        this.Invoke((MethodInvoker)(() => MessageBox.Show("エラーが発生しました")));
                    }
                }
            }

            
        }

        private void btn_python_dir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();            
            fdlg.Filter = "Python Executable (*.exe)|*.exe";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_python_dir.Text = fdlg.FileName;
            }                                 
        }

        private void btn_work_dir_Click(object sender, EventArgs e)
        {           

            FolderBrowserDialog folderdlg = new FolderBrowserDialog(); 
            
            if (folderdlg.ShowDialog() == DialogResult.OK)
            {
                txt_work_dir.Text = folderdlg.SelectedPath + "\\";
            }
        }

        private void btn_python_script_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "Python Executable (*.py)|*.py";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string result = Path.GetFileName(fdlg.FileName);
                txt_python_cmd.Text = result;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
