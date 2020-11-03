using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using proyecto1.Models;
using proyecto1.Data;

namespace proyecto1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OContext _context;
        public static int Usuario;

        public HomeController(ILogger<HomeController> logger, OContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LogIn login)
        {
            if (ModelState.IsValid)
            {
                string usuario = login.User;
                string password = login.Password;

                var user = _context.Usuario.Where(u => u.username == usuario).FirstOrDefault();
                if (user == null)
                {
                    return View(login);
                }

                if (user.contraseña == password)
                {
                    HomeController.Usuario = user.IdUsuario;
                    return RedirectToAction("LoginOK");
                }
                

                return View(login);
            }
            else
            {
                return View(login);
            }
        }

        public ActionResult LoginOk()
        {
            //Codigo de resultado de validacion
            return RedirectToAction("Index","Juego");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
