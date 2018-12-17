namespace CellPhone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CellPhoneContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Brand");
        }
    }
}
