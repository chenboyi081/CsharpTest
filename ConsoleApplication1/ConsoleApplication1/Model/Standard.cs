using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest.Model
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        [InverseProperty("CurrentStandard")]    //我们已经知道，如果类中没有包含外键属性，Code-First默认约定会创建一个{类名}_{主键}的外键列。当我们类与类之间有多个关系的时候，就可以使用InverseProperty特性。
        public ICollection<Student> CurrentStudents { get; set; }


    }

}
