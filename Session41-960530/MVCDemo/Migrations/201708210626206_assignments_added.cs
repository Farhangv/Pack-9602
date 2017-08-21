namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assignments_added : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseStudents", newName: "StudentCourses");
            DropPrimaryKey("dbo.StudentCourses");
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Edu.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("Students.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            AddPrimaryKey("dbo.StudentCourses", new[] { "Student_Id", "Course_Id" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "StudentId", "Students.Student");
            DropForeignKey("dbo.Assignments", "CourseId", "Edu.Course");
            DropIndex("dbo.Assignments", new[] { "StudentId" });
            DropIndex("dbo.Assignments", new[] { "CourseId" });
            DropPrimaryKey("dbo.StudentCourses");
            DropTable("dbo.Assignments");
            AddPrimaryKey("dbo.StudentCourses", new[] { "Course_Id", "Student_Id" });
            RenameTable(name: "dbo.StudentCourses", newName: "CourseStudents");
        }
    }
}
