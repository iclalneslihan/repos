namespace Blog3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogv4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Tag_Id", c => c.Int());
            CreateIndex("dbo.Users", "Tag_Id");
            AddForeignKey("dbo.Users", "Tag_Id", "dbo.Tags", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.Users", new[] { "Tag_Id" });
            DropColumn("dbo.Users", "Tag_Id");
        }
    }
}
