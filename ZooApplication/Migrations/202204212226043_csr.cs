namespace ZooApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class csr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CSRs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CSRs");
        }
    }
}
