using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Homework8
{
    public partial class Form1 : Form
    {
        List<order> NewList = new List<order>();
        List<orderDetail> NewDetail=new List<orderDetail>();
        public Form1()
        {
            InitializeComponent();
            orderBindingSource = new BindingSource();
            orderBindingSource.DataSource = NewList;          
            orderDetailBindingSource = new BindingSource();
            orderDetailBindingSource.DataSource = NewDetail;
            this.myGrid.DataSource = orderBindingSource;
            this.detailGrid.DataSource = orderDetailBindingSource;
            using (var db = new newModel())
            {
                NewList=db.orderDb.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            orderBindingSource.DataSource = NewList;
            this.myGrid.DataSource = orderBindingSource;
            int index = this.myGrid.CurrentRow.Index;
            detailGrid.DataSource = NewList[index].detailList;
            myGrid.Refresh();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.myGrid.CurrentRow != null)
            {
                int index = this.myGrid.CurrentRow.Index;
                int a=NewList[index].Id;
                //根据索引，删除DataGridView里面选中的记录          
                using (var db = new newModel())
                {
                    var tmp = db.orderDb.SingleOrDefault(o => o.Id == a);
                    db.orderDb.Remove(tmp);                   
                    db.SaveChanges();                   
                }
               orderBindingSource.RemoveAt(index);
                myGrid.Refresh();
                detailGrid.Refresh();
            }
        }




        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
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
            using (var db = new newModel())
            {
                NewList = db.orderDb.ToList();
            }
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
            if (this.myGrid.CurrentRow != null)
            {
                int index = this.myGrid.CurrentRow.Index;
                detailGrid.DataSource = NewList[index].detailList;
                detailGrid.Refresh();
            }

        }

        private void detailGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
