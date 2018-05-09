namespace DotNetCoreConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUpdatedAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "UpdatedAt");
        }
    }
}
