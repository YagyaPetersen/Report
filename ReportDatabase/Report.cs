using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ReportDatabase
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }

        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }
        public Subjects Subjects { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

       [ForeignKey("MarkType")]
        public int MarkTypeId { get; set; }
        public MarkType MarkType { get; set; }
    }

    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LName { get; set; }

    }

    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LName { get; set; }
        
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }

    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public int StudentGrade { get; set; }
    }

    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }

        [MaxLength(50)]
        [Required]
        public string SubjectName { get; set; }
    }

    public class Terms
    {
        [Key]
        public int TermId { get; set; }
        public int Term { get; set; }
    }

    public class MarkType
    {
        [Key]
        public int MarkTypeId { get; set; }
        [MaxLength(20)]
        [Required]
        public string TypeName { get; set; }

    }

    public class StudentMark
    {
        [Key]
        public int StudentMarkId { get; set; }

        [ForeignKey("Report")]
        public int ReportId { get; set; }
        public Report Report { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int Mark { get; set; }

        [ForeignKey("Terms")]
        public int TermId { get; set; }
        public Terms Terms { get; set; }

    }

    public class ReportDBContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Subjects> Subject { get; set; }
        public DbSet<Terms> Term { get; set; }
        public DbSet<MarkType> MarkType { get; set; }
        public DbSet<StudentMark> StudentMark { get; set; }

        public ReportDBContext()
            : base("name=ReportSystemDatabase")
        {

        }
    }
}