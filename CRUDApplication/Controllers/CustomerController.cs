using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication.Controllers
{
    public class CustomerController : Controller
    {
        private CRUDContext _crudContext;

        public CustomerController(CRUDContext crudContext)
        {
            this._crudContext = crudContext;

        }


        public IActionResult Index()
        {
            IEnumerable<CustomerViewModel> model = _crudContext.Set<Customer>().ToList().Select(s => new CustomerViewModel
            {
                Id=s.Id,
                Name = $"{s.FirstName} {s.LastName}",
                MobileNo=s.MobileNo,
                Email=s.Email

            });
            return View("Index", model);
        }
    }
}