namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdı = c.String(),
                        BarkodNo = c.Int(nullable: false),
                        StokMiktar = c.Int(nullable: false),
                        SatisFiyati = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
