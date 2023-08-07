using Microsoft.AspNetCore.Mvc;
using MVC.Example.BusinessLayer.Concrate;
using MVC.Example.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Example.UserInterface.Controllers
{
    public class KategoriController : Controller
    {
        CategoryManeger cm = new CategoryManeger( new CategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
