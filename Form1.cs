using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string dir = AppDomain.CurrentDomain.BaseDirectory;
        
        private void txtRead_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\wyh.txt", dir);

            // 写入文件

            // 使用StreamWriter追加文本到文件末尾
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine("王跃辉编辑的");
            }

            
            TextBox textBox1 = new TextBox();
            // 读取文件
            using (StreamReader reader = new StreamReader(path))
            {
                // 将StreamReader中的内容读取到一个字符串中
                string content = reader.ReadToEnd();

                // 使用MessageBox.Show显示字符串内容
                MessageBox.Show(content);

            }
        }
        //返回0表示失败，非0为成功
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 读取 INI 文件的方法
        public static string ReadIniData(string section, string key, string noText, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(section, key, noText, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        private void IniRead_Click(object sender, EventArgs e)
        {
            string path = string.Format("{0}\\wyh.ini", dir);
            string section = "yuanshen"; // 替换为你的 INI 文件中的节名称
            string key = "name"; // 替换为你的 INI 文件中的键名称

            // 读取 INI 文件中的值
            string value = ReadIniData(section, key, "", path);

            // 在消息框中显示值
            MessageBox.Show(value);


        }
    }
}
