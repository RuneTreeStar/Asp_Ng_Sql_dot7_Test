using Asp_Ng_Sql_dot7_Test.Contracts;
using Asp_Ng_Sql_dot7_Test.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Ng_Sql_dot7_Test.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataContext dataContext;

        public StudentController(DataContext dataContext) {
            this.dataContext = dataContext;
        }

        [HttpPost]
        public virtual async Task<IActionResult> SetStudent([FromBody] SetStudentDTO studentSubmit)
        {
            dataContext.Students.Add(studentSubmit.Student);
            return Ok(true);
        }
    }
}
