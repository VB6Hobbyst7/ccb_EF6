namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class linhaUtilizada : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bordadoes", "CreatedDate");
            DropColumn("dbo.Bordadoes", "ModifiedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bordadoes", "ModifiedDate", c => c.DateTime(precision: 0));
            AddColumn("dbo.Bordadoes", "CreatedDate", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
