namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _28082013 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            AddColumn("dbo.Rides", "BikeId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Rides", "BikeId", "dbo.Bikes", "Id", cascadeDelete: true);
            CreateIndex("dbo.Rides", "BikeId");
            DropColumn("dbo.Rides", "Bike_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rides", "Bike_Id", c => c.Int());
            DropIndex("dbo.Rides", new[] { "BikeId" });
            DropForeignKey("dbo.Rides", "BikeId", "dbo.Bikes");
            DropColumn("dbo.Rides", "BikeId");
            CreateIndex("dbo.Rides", "Bike_Id");
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id");
        }
    }
}
