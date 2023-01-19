namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SatisLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "SatisFiyati", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "SatisFiyati", c => c.Int(nullable: false));
        }
    }
}
