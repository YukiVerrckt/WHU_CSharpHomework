using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Alarm
    {
        public string alarm_hour;
        public string alarm_minute;

        public Alarm()
        { }
        public Alarm(string hour,string minute)
        {
            this.alarm_hour = hour;
            this.alarm_minute = minute;
        }
    }
}
