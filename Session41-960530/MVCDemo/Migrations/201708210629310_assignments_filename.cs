namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assignments_filename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "FileName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assignments", "FileName");
        }
    }
}
