namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField_StringTags_ToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "StringTags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "StringTags");
        }
    }
}
