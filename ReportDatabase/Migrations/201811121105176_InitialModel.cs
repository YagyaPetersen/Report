namespace ReportDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        StudentGrade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.MarkTypes",
                c => new
                    {
                        MarkTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.MarkTypeId);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        MarkTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        GradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.StudentMarks",
                c => new
                    {
                        StudentMarkId = c.Int(nullable: false, identity: true),
                        ReportId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentMarkId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.Terms",
                c => new
                    {
                        TermId = c.Int(nullable: false, identity: true),
                        Term = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TermId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Terms");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.StudentMarks");
            DropTable("dbo.Students");
            DropTable("dbo.Reports");
            DropTable("dbo.MarkTypes");
            DropTable("dbo.Grades");
        }
    }
}
