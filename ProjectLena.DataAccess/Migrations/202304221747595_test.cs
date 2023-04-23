namespace ProjectLena.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Forms", "UserId", "dbo.Users");
            DropIndex("dbo.Forms", new[] { "UserId" });
            DropColumn("dbo.Forms", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forms", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Forms", "UserId");
            AddForeignKey("dbo.Forms", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
