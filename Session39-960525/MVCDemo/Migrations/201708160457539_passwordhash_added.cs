namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordhash_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("Security.User", "PasswordHash", c => c.String());
            DropColumn("Security.User", "Password");
        }
        
        public override void Down()
        {
            AddColumn("Security.User", "Password", c => c.String());
            DropColumn("Security.User", "PasswordHash");
        }
    }
}
