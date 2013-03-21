namespace EdsBikeRides.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BikeRidesWeight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Weight", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "Weight");
        }
    }
}
