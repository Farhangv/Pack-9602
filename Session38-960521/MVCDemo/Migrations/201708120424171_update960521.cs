namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update960521 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Students.Student", "Phone", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("Students.Student", "Phone", c => c.String());
        }
    }
}
