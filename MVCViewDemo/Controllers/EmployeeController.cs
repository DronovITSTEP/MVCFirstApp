using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MVCViewDemo.Models;
using NuGet.Protocol.Plugins;

namespace MVCViewDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmpDBContext _dbContext = new EmpDBContext();
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
            /*var employes = from e in _dbContext.Employees
                            orderby e.Id
                            select e;*/
            return View();
        }
        public ActionResult Employees()
        {
            var employees = from e in GetEmployeeList()
                            orderby e.Id
                            select e;
            return View(employees);
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
        public ActionResult Create(/*IFormCollection collection*/ Employee emp)
        {
            try
            {
                /*Employee emp = new Employee();
                emp.Name = collection["Name"];
                DateTime jDate;
                DateTime.TryParse(collection["CreatedDate"], out jDate);
                emp.CreatedDate = jDate;
                string age = collection["Age"];
                emp.Age = Int32.Parse(age);*/
                //employees.Add(emp);
                _dbContext.Employees.Add(emp);
                _dbContext.SaveChangesAsync();
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
            //List<Employee> emplList = employees;
            var employee = _dbContext.Employees.Single(m => m.Id == id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {                
                var employee = _dbContext.Employees.Single(m => m.Id == id);
                TryUpdateModelAsync(employee);
                _dbContext.SaveChangesAsync();
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
