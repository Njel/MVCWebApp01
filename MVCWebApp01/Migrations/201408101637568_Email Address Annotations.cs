namespace MVCWebApp01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailAddressAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewerEmail", c => c.String());
        }
    }
}
