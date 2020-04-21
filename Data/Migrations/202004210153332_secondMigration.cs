namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "DateUpdated", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "DateUpdated", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
