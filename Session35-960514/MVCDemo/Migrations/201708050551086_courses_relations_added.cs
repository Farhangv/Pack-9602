namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courses_relations_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Edu.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Duration = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Student_Id })
                .ForeignKey("Edu.Course", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("Students.Student", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Student_Id);
            
            AddColumn("Students.Contact", "StudentId", c => c.Int(nullable: false));
            CreateIndex("Students.Contact", "StudentId");
            AddForeignKey("Students.Contact", "StudentId", "Students.Student", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseStudents", "Student_Id", "Students.Student");
            DropForeignKey("dbo.CourseStudents", "Course_Id", "Edu.Course");
            DropForeignKey("Students.Contact", "StudentId", "Students.Student");
            DropIndex("dbo.CourseStudents", new[] { "Student_Id" });
            DropIndex("dbo.CourseStudents", new[] { "Course_Id" });
            DropIndex("Students.Contact", new[] { "StudentId" });
            DropColumn("Students.Contact", "StudentId");
            DropTable("dbo.CourseStudents");
            DropTable("Edu.Course");
        }
    }
}
