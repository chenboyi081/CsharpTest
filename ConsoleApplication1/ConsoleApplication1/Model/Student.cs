using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest.Model
{
    [Table("StudentInfo")]
    public class Student
    {
        public Student()
        {

        }

        [Key]
        public int StudentID { get; set; }

        [Column("Name", Order = 1, TypeName = "ntext")]
        [Required]  //必输，非空
        [ConcurrencyCheck]  //所以Code-First会在update命令中把StudentName列包含进去以进行乐观并发检查
        [MaxLength(20)]
        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public byte[] Photo { get; set; }

        [NotMapped]
        public int? Age
        {
            get; set;
        }

        public decimal Height { get; set; }

        public float Weight { get; set; }

        //Foreign key for Standard

        public int CurrentStandardId { get; set; }

        [ForeignKey("CurrentStandardId")]   //ForeignKey特性覆写了默认约定，我们可以把外键属性列设置成不同名称
        public Standard CurrentStandard { get; set; }


        public Teacher Teacher { get; set; }

        public virtual StudentAddress Address { get; set; }

    }

    //即使Teacher类没有被包含在context的一个DbSet中，Code-First依然会创建一个Teachers表
    public class Teacher
    {
        public Teacher()
        {

        }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}
