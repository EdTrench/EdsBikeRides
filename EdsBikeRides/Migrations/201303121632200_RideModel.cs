namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RideModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BoughtDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Rides", "Bike_Id", c => c.Int());
            AddForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes", "Id");
            CreateIndex("dbo.Rides", "Bike_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Rides", new[] { "Bike_Id" });
            DropForeignKey("dbo.Rides", "Bike_Id", "dbo.Bikes");
            DropColumn("dbo.Rides", "Bike_Id");
            DropTable("dbo.Bikes");
        }
    }
}
