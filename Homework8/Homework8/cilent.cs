using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class cilent
    {
        public int cilentId { get; set; }
        public string cilentName { get; set; }

        public cilent() { }
        public cilent(int id,string name)
        {
            this.cilentId = id;
            this.cilentName = name;
        }
        public override string ToString()
        {
            return $"客户ID:{cilentId}, 客户姓名:{cilentName}";
        }

    }
}
