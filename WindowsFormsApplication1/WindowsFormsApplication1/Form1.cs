using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Alarm> clocks = new List<Alarm>();
        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string h = DateTime.Now.Hour.ToString();//获取系统时间小时
            string m = DateTime.Now.Minute.ToString();//获取系统时间分钟
            string s = DateTime.Now.Second.ToString();//获取系统时间秒
            timeLabel.Text = "当前时间：" + h + "时" + m + "分" + s + "秒";

            foreach (Alarm clockI in clocks)
            {
                if (clockI.alarm_hour == h && clockI.alarm_minute == m)
                {
                    clocks.Remove(clockI);
                    MessageBox.Show("闹钟提示");
                    break;
                }
            }               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alarm_hour = alarmHour.Value.ToString();
            string alarm_minute = alarmMinute.Value.ToString();
            Alarm alarmClock = new Alarm(alarm_hour, alarm_minute);
            clocks.Add(alarmClock);
            Console.WriteLine("新闹钟：" + alarm_hour + ":" + alarm_minute);// 闹钟列表输出在控制台
        }

    }
}
