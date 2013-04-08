namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rides", "Bike_Id", c => c.Int());
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id");
            CreateIndex("dbo.Rides", "Bike_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            DropColumn("dbo.Rides", "Bike_Id");
        }
    }
}
