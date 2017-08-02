namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final_960511 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "Students.Student", name: "Name", newName: "FirstName");
            RenameColumn(table: "Students.Student", name: "Family", newName: "LastName");
            AddColumn("Students.Student", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("Students.Student", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AlterColumn("Students.Contact", "Type", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("Students.Contact", "Value", c => c.String(maxLength: 100));
            AlterColumn("Students.Student", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("Students.Student", "LastName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("Students.Contact", "Value", unique: true);
            DropColumn("Students.Student", "Age");
        }
        
        public override void Down()
        {
            AddColumn("Students.Student", "Age", c => c.Int(nullable: false));
            DropIndex("Students.Contact", new[] { "Value" });
            AlterColumn("Students.Student", "LastName", c => c.String());
            AlterColumn("Students.Student", "FirstName", c => c.String());
            AlterColumn("Students.Contact", "Value", c => c.String());
            AlterColumn("Students.Contact", "Type", c => c.String());
            DropColumn("Students.Student", "RowVersion");
            DropColumn("Students.Student", "BirthDate");
            RenameColumn(table: "Students.Student", name: "LastName", newName: "Family");
            RenameColumn(table: "Students.Student", name: "FirstName", newName: "Name");
        }
    }
}
