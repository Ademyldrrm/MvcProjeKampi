namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_mig3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 400));
        }
    }
}
