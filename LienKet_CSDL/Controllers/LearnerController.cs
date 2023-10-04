using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LienKet_CSDL.Data;
using LienKet_CSDL.Models;

namespace LienKet_CSDL.Controllers
{
    public class LearnerController : Controller
    {
            private SchoolContext db;
            public LearnerController(SchoolContext context)
            {
                db = context;
            }
            public IActionResult Index()
            {
                var learners = db.Learners.Include(m => m.Major).ToList();
                return View(learners);
            }
    }
}
