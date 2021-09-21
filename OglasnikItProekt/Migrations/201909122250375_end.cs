namespace OglasnikItProekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avtomobils", "imgURL", c => c.String());
            AddColumn("dbo.Laptops", "imgURL", c => c.String());
            AddColumn("dbo.Mebels", "imgURL", c => c.String());
            AddColumn("dbo.Mobilens", "imgURL", c => c.String());
            AddColumn("dbo.BelaTehnikas", "imgURL", c => c.String());
            AddColumn("dbo.Zivealistes", "imgURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zivealistes", "imgURL");
            DropColumn("dbo.BelaTehnikas", "imgURL");
            DropColumn("dbo.Mobilens", "imgURL");
            DropColumn("dbo.Mebels", "imgURL");
            DropColumn("dbo.Laptops", "imgURL");
            DropColumn("dbo.Avtomobils", "imgURL");
        }
    }
}
