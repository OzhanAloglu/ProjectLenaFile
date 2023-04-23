namespace ProjectLena.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userıd : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Forms", "CreateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Forms", "CreateBy", c => c.Int(nullable: false));
        }
    }
}
