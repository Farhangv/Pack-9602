namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photo_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("Students.Student", "Photo", c => c.Binary());
            AddColumn("Students.Student", "PhotoExtension", c => c.String(maxLength: 5));
            AddColumn("Students.Student", "PhotoOriginalFileName", c => c.String(maxLength: 100));
            AddColumn("Students.Student", "PhotoContentType", c => c.String(maxLength: 30));
            AddColumn("Students.Student", "PhotoSize", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("Students.Student", "PhotoSize");
            DropColumn("Students.Student", "PhotoContentType");
            DropColumn("Students.Student", "PhotoOriginalFileName");
            DropColumn("Students.Student", "PhotoExtension");
            DropColumn("Students.Student", "Photo");
        }
    }
}
