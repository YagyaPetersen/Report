using ReportDatabase.Models.Response;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace ReportDatabase.Controllers
{
    public class ReportController : ApiController
    {
        ReportDBContext ReportDBContext = new ReportDBContext();

        [Route("api/student/{id}/term/{termId}")]
        [HttpGet]
        public IHttpActionResult GetMarks(int id, int termId)
        {
            using (var allSubjects = new ReportDBContext())
            {
                var Maths = ReportDBContext.Subject.Find(1);
                var IT = ReportDBContext.Subject.Find(2);
                var English = ReportDBContext.Subject.Find(3);
                var Physics = ReportDBContext.Subject.Find(4);
                var Afrikaans = ReportDBContext.Subject.Find(5);
                var LO = ReportDBContext.Subject.Find(6);
                var History = ReportDBContext.Subject.Find(7);

                var marks = ReportDBContext.StudentMark.Where(a => a.StudentId == id && a.TermId == termId).FirstOrDefault();

                var report = ReportDBContext.StudentMark
                    .Include(a => a.Terms)
                    .Include(a => a.Student.Grade)
                    .Include(a => a.Report.Subjects)
                    .Include(a => a.Report.MarkType)
                    .Include(a => a.Report.Teacher).Where(a => a.StudentId == id && a.TermId == termId)
                    .ToList();

                if (report == null)
                {
                    return NotFound();
                }

                var StudentResponse = new ReportResponse(report);

                return Ok(StudentResponse);

            }
        }
    }
}



