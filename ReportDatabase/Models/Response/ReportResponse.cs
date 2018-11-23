using System.Collections.Generic;
using System.Linq;

namespace ReportDatabase.Models.Response
{
    public class ReportResponse
    {
        private List<StudentMark> report;

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Term { get; set; }
        public class SubjectMark
        {
            public string Subject { get; set; }
            public int Marks { get; set; }
        }
        public List<SubjectMark> SubjectMarks { get; set; }

        public ReportResponse(List<StudentMark> report)
        {
            StudentId = report.FirstOrDefault().StudentId;
            FirstName = report.FirstOrDefault().Student.FName;
            LastName = report.FirstOrDefault().Student.LName;
            Term = report.FirstOrDefault().TermId;

            List<SubjectMark> SubjectMarksSet = new List<SubjectMark>();

            foreach (var entry in report)
            {
                var subjectMarkEntry = new SubjectMark()
                {
                    Subject = entry.Report.Subjects.SubjectName,
                    Marks = entry.Mark
                };
                SubjectMarksSet.Add(subjectMarkEntry);
            }

            SubjectMarks = SubjectMarksSet;

        }
    }
}


