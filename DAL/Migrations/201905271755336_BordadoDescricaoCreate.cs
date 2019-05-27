namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BordadoDescricaoCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bordados", "Descricao", c => c.String(maxLength: 50, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bordados", "Descricao");
        }
    }
}
