using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework4_2;
using System.Data.OleDb;

namespace Homework8
{
    public partial class Form1 : Form
    {
        List<order> NewList = new List<order>();
        List<orderDetail> NewDetail = new List<orderDetail>();
        public Form1()
        {
            InitializeComponent();
            orderBindingSource = new BindingSource();            
            orderDetailBindingSource = new BindingSource();
            orderBindingSource.DataSource = NewList;
            orderDetailBindingSource.DataSource = NewDetail; 

            this.myGrid.DataSource = orderBindingSource;
            this.detailGrid.DataSource = orderDetailBindingSource;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            int index = this.myGrid.CurrentRow.Index;
            detailGrid.DataSource = NewList[index].detailList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = this.myGrid.CurrentRow.Index;

            //根据索引，删除DataGridView里面选中的记录

            orderBindingSource.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // orderBindingSource.Sort= "price DESC";
            // orderBindingSource.ResetBindings(false);
            NewList.Sort((a, b) => (int)(a.price - b.price));
            this.myGrid.DataSource = orderBindingSource;
            myGrid.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formProgram.orderWin.orderList = NewList;
            formProgram.orderWin.CreateXmlFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formProgram.orderWin.orderList = NewList;
            List<order> output = formProgram.orderWin.searchOrder(textBox_key.Text);
            myGrid.DataSource = output;
            myGrid.Refresh();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            myGrid.DataSource = orderBindingSource;
            myGrid.Refresh();
        }

        private void orderDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void myGrid_SelectionChanged(object sender, EventArgs e)
        {
            int index = this.myGrid.CurrentRow.Index;
            detailGrid.DataSource = NewList[index].detailList;
            detailGrid.Refresh();
        }

        private void detailGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
