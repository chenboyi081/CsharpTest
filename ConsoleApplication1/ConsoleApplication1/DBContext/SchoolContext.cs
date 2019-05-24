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

            //base.OnModelCreating(modelBuilder);

            //Configure default schema
            //modelBuilder.HasDefaultSchema("Admin");

            //Configure primary key
            //modelBuilder.Entity<Student>().HasKey<int>(s => s.StudentID);
            //modelBuilder.Entity<Standard>().HasKey<int>(s => s.StandardId);

            //Configure composite primary key
            //modelBuilder.Entity<Student>().HasKey<int>(s => new { s.StudentKey, s.StudentName });

            //modelBuilder.Entity<Student>().Map(m =>
            //{
            //    m.Properties(p => new { p.StudentID, p.StudentName });
            //    m.ToTable("StudentInfo");

            //}).Map(m => {
            //    m.Properties(p => new { p.StudentID, p.Height, p.Weight, p.Photo, p.DateOfBirth });
            //    m.ToTable("StudentInfoDetail");

            //});

            //modelBuilder.Entity<Student>()
            //     .Property(p => p.DateOfBirth)
            //     .HasColumnName("DoB")
            //     .HasColumnOrder(3)
            //     .HasColumnType("datetime2");

            ////Configure Null Column
            //modelBuilder.Entity<Student>()
            //        .Property(p => p.Height)
            //        .IsOptional();

            ////Configure NotNull Column
            //modelBuilder.Entity<Student>()
            //    .Property(p => p.Weight)
            //    .IsRequired();

            ////Set StudentName column size to 50
            //modelBuilder.Entity<Student>()
            //        .Property(p => p.StudentName)
            //        .HasMaxLength(50);

            ////Set StudentName column size to 50 and change datatype to nchar 
            ////IsFixedLength() change datatype from nvarchar to nchar
            //modelBuilder.Entity<Student>()
            //        .Property(p => p.StudentName)
            //        .HasMaxLength(50).IsFixedLength();

            ////Set size decimal(2,2)
            //modelBuilder.Entity<Student>()
            //    .Property(p => p.Height)
            //    .HasPrecision(2, 2);

            //    //Map entity to table
            //    modelBuilder.Entity<Standard>().ToTable("StandardInfo", "dbo");

            // Configure StudentId as PK for StudentAddress
            modelBuilder.Entity<StudentAddress>()
                .HasKey(e => e.StudentId);

            // Configure Student & StudentAddress entity
            modelBuilder.Entity<Student>()
                        .HasOptional(s => s.Address) // Student实体的Address属性使用了HasOptional()方法，即Address属性不是必须的，可为空
                        .WithRequired(ad => ad.Student); // StudentAddress类的Student属性使用了WithRequired()方法，即Student属性为必填，不能为空，如果存储StudentAddress实体的时候发现Student属性为空，则会抛出异常。这样配置以后，StudentAddressId就已经是外键了。

            //    // one - to - many
            //modelBuilder.Entity<Student>()
            //            .HasRequired<Standard>(s => s.CurrentStandard) // Student entity requires Standard 
            //            .WithMany(s => s.CurrentStudents); // Standard entity includes many Students entities
        }
}
}
