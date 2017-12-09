namespace SQL_RestApi_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartGridInfoAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SmartGridInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        kiloWattPrice = c.Double(nullable: false),
                        tokenPrice = c.Double(nullable: false),
                        nationalGridPrice = c.Double(nullable: false),
                        timeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SmartGridInfoes");
        }
    }
}
