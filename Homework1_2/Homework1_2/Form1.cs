using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s; 
            double result;
            if (textBox1.Text != "" && textBox2.Text != "")  //判断输入框是否为空
            {
                s = textBox1.Text;
                double first = double.Parse(s);        //字符串转换为数字
                s = textBox2.Text;
                double second = double.Parse(s);
                result = first * second;                //计算输出结果
                textBox3.Text = "" + result;             
            }
        }
    }
}
