using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallpapertool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String url = "https://wallhaven.cc/toplist?page=2";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        // 刷新
        private void button1_Click(object sender, EventArgs e)
        {
            String filepath = textBox1.Text;
            webBrowser2.Navigate(filepath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //对 webBrowser2 进行点击 然后右键 - v - r
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String url = "http://139.196.171.60/watchTV/a-plan/?name=lewd";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {// 自动顺序给文件重一名
         // 执行命令 py .\watch_nput.py -p C:\lightspeed\9\ponypic 后面这个路径根据当前textbox1内容替换
            string path = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(path) || !System.IO.Directory.Exists(path))
            {
                MessageBox.Show("请输入有效的文件夹路径！");
                return;
            }

            // 拼接完整命令
            string command = $"py C:\\Users\\kasus\\Documents\\GitHub\\imagewatcher\\watch_nput.py -p \"{path}\"";

            // 启动一个新的 cmd 窗口，并执行命令，不自动关闭
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/k {command}",
                UseShellExecute = true, // 必须为 true 才能打开窗口
                CreateNoWindow = false, // 显示窗口
                WorkingDirectory = Application.StartupPath // 确保脚本路径是当前目录
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动失败：" + ex.Message);
            }
        }
    }
}
