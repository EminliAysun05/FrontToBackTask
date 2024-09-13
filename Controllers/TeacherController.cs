using FrontToBack.DataAccesLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class TeacherController:Controller
    {
        private readonly AppDbContext _dbContext;

        public TeacherController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Teachers.Include(x => x.TeacherGroups).ThenInclude(x=>x.Group).ToList();
            return View(students);
        }
    }
}
