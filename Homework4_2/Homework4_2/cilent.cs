using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    public class cilent
    {
        public uint cilentId { get; set; }
        public string cilentName { get; set; }

        public cilent() { }
        public cilent(uint id,string name)
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
