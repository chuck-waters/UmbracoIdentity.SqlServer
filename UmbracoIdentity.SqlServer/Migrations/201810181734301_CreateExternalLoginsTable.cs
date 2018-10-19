namespace UmbracoIdentity.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateExternalLoginsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExternalLogins",
                c => new
                    {
                        ExternalLoginId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        LoginProvider = c.String(nullable: false, maxLength: 4000),
                        ProviderKey = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.ExternalLoginId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExternalLogins");
        }
    }
}
