using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void txtRead_Click(object sender, EventArgs e)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
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
    }
}
