using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> Departments = new List<Department>();

            Departments.Add(new Department { Id = 1, Name = "Eletronics" });
            Departments.Add(new Department { Id = 2, Name = "Fashion" });

            return View(Departments);
        }

        public IActionResult Create()
        {

            Console.WriteLine("Enter ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            Department depart = (new Department{ Id = id, Name = name});

            return View(depart);

        }

    }
}
