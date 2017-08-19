namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class properties_added_to_student : DbMigration
    {
        public override void Up()
        {
            AddColumn("Students.Student", "Email", c => c.String());
            AddColumn("Students.Student", "Phone", c => c.String());
            AddColumn("Students.Student", "BirthCertificateNumber", c => c.Int(nullable: false));
            AddColumn("Students.Student", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Students.Student", "Description");
            DropColumn("Students.Student", "BirthCertificateNumber");
            DropColumn("Students.Student", "Phone");
            DropColumn("Students.Student", "Email");
        }
    }
}
