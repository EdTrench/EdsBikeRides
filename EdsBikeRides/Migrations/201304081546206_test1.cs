namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            DropColumn("dbo.Rides", "Bike_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rides", "Bike_Id", c => c.Int());
            CreateIndex("dbo.Rides", "Bike_Id");
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id");
        }
    }
}
