namespace ZooApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wines2022 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wines");
        }
    }
}
