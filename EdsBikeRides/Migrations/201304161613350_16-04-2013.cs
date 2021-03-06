namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _16042013 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            AlterColumn("dbo.Rides", "Bike_Id", c => c.Int(nullable: false));
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id", cascadeDelete: true);
            CreateIndex("dbo.Rides", "Bike_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            AlterColumn("dbo.Rides", "Bike_Id", c => c.Int());
            CreateIndex("dbo.Rides", "Bike_Id");
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id");
        }
    }
}
