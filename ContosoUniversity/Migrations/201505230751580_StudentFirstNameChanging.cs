namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentFirstNameChanging : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "FirstName", c => c.String(maxLength: 50));
            DropColumn("dbo.Student", "FirstMidName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 50));
            DropColumn("dbo.Student", "FirstName");
        }
    }
}
