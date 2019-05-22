namespace CsharpTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandardId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                    })
                .PrimaryKey(t => t.StandardId);
            
            CreateTable(
                "dbo.StudentInfo",
                c => new
                    {
                        Name = c.String(nullable: false, storeType: "ntext"),
                        StudentID = c.Int(nullable: false, identity: true),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        StdId = c.Int(nullable: false),
                        Teacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Standards", t => t.StdId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId)
                .Index(t => t.StdId)
                .Index(t => t.Teacher_TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInfo", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentInfo", "StdId", "dbo.Standards");
            DropIndex("dbo.StudentInfo", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.StudentInfo", new[] { "StdId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.StudentInfo");
            DropTable("dbo.Standards");
        }
    }
}
