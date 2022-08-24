using Microsoft.AspNetCore.Mvc;

namespace MVCFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        public string GetAllCustomer()
        {
            return "Возврат всех сотрудников";
        }
    }
}
