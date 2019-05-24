using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新语法
{
    public class PigType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    }

    public class Pig
    {
        public int PID { get; set; }
        public int TypeID { get; set; }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

            }
        }

        /// <summary>
        /// 自动属性
        /// 本质上：编译器会将自动属性拆分成一个私有的字段和getxxx() setxxx()
        /// </summary>
        public int Age
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "ID=" + this.PID + " Name=" + this.Name + " Age=" + this.Age + " TypeID=" + this.TypeID;
        }
    }
}
