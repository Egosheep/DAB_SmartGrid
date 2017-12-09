namespace SQL_RestApi_Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seedmethod : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prosumers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Prosumers", new[] { "Address_Id" });
            RenameColumn(table: "dbo.Prosumers", name: "Address_Id", newName: "AddressId");
            AlterColumn("dbo.Prosumers", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Prosumers", "AddressId");
            AddForeignKey("dbo.Prosumers", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prosumers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Prosumers", new[] { "AddressId" });
            AlterColumn("dbo.Prosumers", "AddressId", c => c.Int());
            RenameColumn(table: "dbo.Prosumers", name: "AddressId", newName: "Address_Id");
            CreateIndex("dbo.Prosumers", "Address_Id");
            AddForeignKey("dbo.Prosumers", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
