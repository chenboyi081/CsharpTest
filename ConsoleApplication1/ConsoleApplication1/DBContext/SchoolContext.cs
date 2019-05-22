using CsharpTest.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest.DBContext
{
    public class SchoolContext : System.Data.Entity.DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {

        }

        //即使Teacher类没有被包含在context的一个DbSet中，Code-First依然会创建一个Teachers表
        //即使context仅包含基类（base class）作为DbSet属性，Code-First也会包含它的派生类（derived class）

        public System.Data.Entity.DbSet<Student> Students { get; set; }
        public System.Data.Entity.DbSet<Standard> Standards { get; set; }

        //Fluent API 配置是作为EF从领域类构建模型的应用，我们可以通过覆写DbContext类的OnModelCreating方法来注入配置
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here

            base.OnModelCreating(modelBuilder);
        }
    }
}
