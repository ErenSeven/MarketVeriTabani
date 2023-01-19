﻿namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class satisDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "SatisFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "SatisFiyati", c => c.Long(nullable: false));
        }
    }
}
