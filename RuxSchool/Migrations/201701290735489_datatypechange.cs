namespace RuxSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypechange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ExamResults", "exam_date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ExamResults", "exam_date", c => c.String());
        }
    }
}
