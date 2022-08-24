using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MVCViewDemo.Models;
using NuGet.Protocol.Plugins;

namespace MVCViewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public static List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 0,
                    Name = "Alex",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 25
                },
                new Employee
                {
                    Id = 1,
                    Name = "Ivan",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 50
                },
                new Employee
                {
                    Id = 2,
                    Name = "Artem",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 32
                }
            };
        public ActionResult Index()
        {
            /*var employees = from e in GetEmployeeList()
                            orderby e.Id
                            select e;*/
            var employes = from e in employees
                            orderby e.Id
                            select e;
            return View(employes);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            List<Employee> emplList = employees;
            var employee = emplList.Single(m => m.Id == id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {                
                var employee = employees.Single(m => m.Id == id);
                TryUpdateModelAsync(employee);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 0,
                    Name = "Alex",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 25
                },
                new Employee
                {
                    Id = 1,
                    Name = "Ivan",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 50
                },
                new Employee
                {
                    Id = 2,
                    Name = "Artem",
                    CreatedDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 32
                }
            };
        }

            
    }
}
