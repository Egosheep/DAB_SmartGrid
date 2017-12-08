namespace SQL_RestApi_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        HouseNumber = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prosumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleNames = c.String(),
                        LastName = c.String(),
                        ProsumerType = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prosumers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Prosumers", new[] { "Address_Id" });
            DropTable("dbo.Prosumers");
            DropTable("dbo.Addresses");
        }
    }
}
