using CompanyDepartments.Data;
using Microsoft.AspNetCore.Mvc;

namespace CompanyDepartments.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listDepartments = _context.Departments.ToList();

            return View(listDepartments);
        }

        public IActionResult AddEmployee(string id)
        {
            ChangeEmployeeCount(int.Parse(id));

            return RedirectToAction(nameof(Index));
        }

        private void ChangeEmployeeCount(int id)
        {
            var department = _context.Departments.FirstOrDefault(x => x.Id == id);

            department.EmployeeCount += 1;

            if(department.IdParent != 0)
                ChangeEmployeeCount(department.IdParent);

            _context.SaveChanges();
        }
    }
}
