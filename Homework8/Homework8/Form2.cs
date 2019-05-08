using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cilent NewClient = new cilent();
                if (textBox_clientId.TextLength == 0 || textBox_clientName.TextLength == 0 || textBox_orderId.TextLength == 0)           
                    MessageBox.Show("输入不能为空");                       
                else
                {
                    NewClient.cilentId = int.Parse(textBox_clientId.Text);
                    NewClient.cilentName = textBox_clientName.Text;
                    order tmp = new order(int.Parse(textBox_orderId.Text),NewClient);
                    InputForm form4 = new InputForm();
                    
                    form4.getOrder(tmp);
                    form4.ShowDialog();
                    orderDetail newDetail = form4.returnObject();
                    newDetail.orderDetailId = tmp.Id;
                    tmp.detailList.Add(newDetail);
                    tmp.calculate();
                    using (var db = new newModel())
                    {
                        db.orderDb.Add(tmp);
                        Form1.orderBindingSource.Add(tmp);
                        db.SaveChanges();
                    }
                    Close();
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_orderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar))&&e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_clientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
