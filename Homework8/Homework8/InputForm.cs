using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class InputForm : Form
    {
        orderDetail NewDetail;
        order tmpOrder=new order();

        public InputForm()
        {
            InitializeComponent();
            
        }
        public orderDetail returnObject()
        {
            return NewDetail;
        }
        public void getOrder(order NewOrder)
        {
            tmpOrder = NewOrder;
        }

        private void textBox_Num_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Num.TextLength == 0||textBox_Name.TextLength==0||textBox_Price.TextLength==0)
                    MessageBox.Show("输入不能为空");
                else
                {
                    int i = tmpOrder.detailList.Count;
                    NewDetail = new orderDetail(i,new product(double.Parse(textBox_Price.Text), uint.Parse(textBox_ProductId.Text), textBox_Name.Text),int.Parse(textBox_Num.Text));
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
