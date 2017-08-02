namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_table_names : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contacts", newName: "Contact");
            RenameTable(name: "dbo.Students", newName: "Student");
            MoveTable(name: "dbo.Contact", newSchema: "Students");
            MoveTable(name: "dbo.Student", newSchema: "Students");
        }
        
        public override void Down()
        {
            MoveTable(name: "Students.Student", newSchema: "dbo");
            MoveTable(name: "Students.Contact", newSchema: "dbo");
            RenameTable(name: "dbo.Student", newName: "Students");
            RenameTable(name: "dbo.Contact", newName: "Contacts");
        }
    }
}
