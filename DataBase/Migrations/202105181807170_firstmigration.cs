namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoinName = c.String(),
                        RealValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        Operation_Id = c.Int(nullable: false, identity: true),
                        Client = c.String(),
                        Origin_Coin = c.String(),
                        Dest_Coin = c.String(),
                        Origin_Value = c.Double(nullable: false),
                        Dest_Value = c.Double(nullable: false),
                        Operation_Date = c.DateTime(nullable: false),
                        rate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Operation_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Operations");
            DropTable("dbo.Coins");
        }
    }
}
