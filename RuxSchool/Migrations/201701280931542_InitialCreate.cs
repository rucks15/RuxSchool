namespace RuxSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamResults",
                c => new
                    {
                        exam_number = c.Int(nullable: false, identity: true),
                        RollNumber = c.Int(nullable: false),
                        exam_title = c.String(),
                        exam_date = c.String(),
                        gpa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        percentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.exam_number)
                .ForeignKey("dbo.Students", t => t.RollNumber, cascadeDelete: true)
                .Index(t => t.RollNumber);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        RollNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EmailID = c.String(),
                        DOB = c.String(),
                        Medium = c.Int(nullable: false),
                        Standard = c.String(),
                        WorkingDays = c.Int(nullable: false),
                        Marks = c.Int(nullable: false),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RollNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamResults", "RollNumber", "dbo.Students");
            DropIndex("dbo.ExamResults", new[] { "RollNumber" });
            DropTable("dbo.Students");
            DropTable("dbo.ExamResults");
        }
    }
}
