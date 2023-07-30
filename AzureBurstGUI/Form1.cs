using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Management.Automation;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace AzureBurstGUI
{
    public partial class Form1 : Form
    {
        private string userInput;
        private System.IO.StreamWriter standardInput;
        private Process process;
        private string placeholderText = "请输入要保存的本地路径/云存储路径（导出到本地/云）";
        private bool verbose = false;
        private bool saveLocal = false;
        private bool saveRemote = false;

        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        public Form1()
        {
            InitializeComponent();
        }
        private void InvokeScript(string cmd, string args)
        {
            if(!string.IsNullOrEmpty(args))
            {
                cmd += " ";
                cmd += args;
            }
            if(verbose)
            {
                cmd += " -Verbose";
            }
            if(saveRemote || saveLocal)
            {
                if (!string.IsNullOrEmpty(textSavePath.Text))
                {

                }
                else if(saveLocal)
                {

                }
            }
            
            
            standardInput.WriteLine(cmd);
        }
        // 辅助方法：禁用界面上的控件
        private void DisableControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }

        // 辅助方法：启用界面上的控件
        private void EnableControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {

            // 创建一个 Process 对象来执行 PowerShell
            process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            //process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.RedirectStandardError = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = false;

            
            process.Start();
            standardInput = process.StandardInput;
            standardInput.WriteLine("dir -Recurse .\\AzureBurst | Unblock-File");
            standardInput.WriteLine("$env:PSModulePath += ';C:\\Program Files\\WindowsPowerShell\\Modules;.\\Modules'");
            //standardInput.WriteLine("Import-Module .\\AzureBurst\\AzureBurst.psm1");
            using (var waitingForm = new WaitForm())
            {
                // 显示等待界面
                waitingForm.Show();
                // 禁用界面操作
                DisableControls();

                // 等待 10 秒钟
                await Task.Delay(10000); // 这里可以替换成你的任务代码

                // 启用界面操作
                EnableControls();
                // 关闭等待界面
                waitingForm.Close();

            }
            MessageBox.Show("初始化已完成，输出信息在新创建的控制台显示，点击各个按钮查看使用提示");
        }
        private void btnExecuteScript_Click(object sender, EventArgs e)
        {
            // 要执行的 PowerShell 脚本路径
            string scriptPath = "testgui.ps1";

            // 创建一个 Process 对象来执行 PowerShell
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-ExecutionPolicy Bypass -File \"{scriptPath}\"";
            process.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userInput.ToLower() == "exit")
            {
                process.Close();
            }

            // 发送用户输入的命令到 PowerShell 进程
            if (!string.IsNullOrEmpty(userInput))
            {
                standardInput.WriteLine(userInput);
            }
        }

        private void textScriptPath_TextChanged(object sender, EventArgs e)
        {
            userInput = textScriptPath.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                // 添加你要执行的 PowerShell 脚本或命令
                powerShell.AddScript("Get-Process");
                // 执行脚本并获取结果
                var result = powerShell.Invoke();

                // 处理结果
                if (powerShell.HadErrors)
                {
                    foreach (var errorRecord in powerShell.Streams.Error)
                    {
                        Console.WriteLine("Error: " + errorRecord.Exception.Message);
                    }
                }
                else
                {
                    foreach (var psObject in result)
                    {
                        Console.WriteLine(psObject.ToString());
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AttachConsole(process.Id);
            SetConsoleCtrlHandler(IntPtr.Zero, true);   //设置自己的ctrl+c处理，防止自己被终止
            GenerateConsoleCtrlEvent(0, 0); // 发送ctrl+c（注意：这是向所有共享该console的进程发送）
            Thread.Sleep(10);
            SetConsoleCtrlHandler(IntPtr.Zero, false); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 当 CheckBox1 被勾选时，取消 CheckBox2 的勾选
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                saveLocal = true;
                saveRemote = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // 当 CheckBox2 被勾选时，取消 CheckBox1 的勾选
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                saveRemote = true;
                saveLocal = false;
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 创建自定义的对话框对象
            Form2 dialogForm = new Form2();

            // 显示对话框，并获取用户输入的数据
            DialogResult result = dialogForm.ShowDialog();

            // 用户点击确定按钮并输入数据后，执行相关函数
            if (result == DialogResult.OK)
            {
                // 获取用户输入的参数
                string inputData = dialogForm.UserInputData;

                // 执行相关函数,将参数拼接到命令后面
                InvokeScript("Set-UserPassword ", inputData);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSave(object sender, EventArgs e)
        {
            // 创建 FolderBrowserDialog 对象
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            // 设置对话框的说明文本和根文件夹路径
            folderDialog.Description = "选择导出结果的保存路径";
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            // 如果用户选择了文件夹并点击了"确定"按钮
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择的文件夹路径
                string selectedPath = folderDialog.SelectedPath;

                // 在界面上显示选择的路径
                textSavePath.Text = selectedPath;
                textSavePath.ForeColor = SystemColors.WindowText;
            }
        }

        private void textSavePath_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textSavePath_Enter(object sender, EventArgs e)
        {
            // 当文本框获得焦点时，清空文本框并设置文本颜色为黑色
            if (textSavePath.Text == placeholderText)
            {
                textSavePath.Text = "";
                textSavePath.ForeColor = SystemColors.WindowText;
            }
        }
        private void textSavePath_Leave(object sender, EventArgs e)
        {
            // 当文本框失去焦点时，如果文本框内容为空，则恢复提示文字和灰色颜色
            if (string.IsNullOrEmpty(textSavePath.Text))
            {
                textSavePath.Text = placeholderText;
                textSavePath.ForeColor = SystemColors.GrayText;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
