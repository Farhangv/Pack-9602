namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Students.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 10),
                        Value = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Value, unique: true);
            
            CreateTable(
                "Students.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Security.User", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "Security.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Students.Student", "Id", "Security.User");
            DropIndex("Students.Student", new[] { "Id" });
            DropIndex("Students.Contact", new[] { "Value" });
            DropTable("Security.User");
            DropTable("Students.Student");
            DropTable("Students.Contact");
        }
    }
}
