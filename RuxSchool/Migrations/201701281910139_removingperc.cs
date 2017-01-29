namespace RuxSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingperc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Marks", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.ExamResults", "percentage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExamResults", "percentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Students", "Marks", c => c.Int(nullable: false));
        }
    }
}
