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
using proyecto1.Controllers;
namespace proyecto1.ViewComponents
{
    public class DetalleJuegosViewComponent : ViewComponent
    {
        private readonly OContext _context;

        public DetalleJuegosViewComponent(OContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var Jugados = await _context.Partida
                .Where(s => s.IdUsuario == HomeController.Usuario)
                .ToListAsync<Partida>();
            return View("DetalleJuegos", Jugados);

        }
    }
}
