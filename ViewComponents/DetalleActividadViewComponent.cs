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
    public class DetalleActividadViewComponent : ViewComponent
    {
        private readonly OContext _context;

        public DetalleActividadViewComponent(OContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Participado = await _context.Participante
                .Where(s => s.IdUsuario == HomeController.Usuario)
                .ToListAsync<Participante>();

            List<Torneo> torneos = new List<Torneo>();
            foreach(Participante p in Participado)
            {
                var tor = _context.Torneo
                .Where(s => s.IdTorneo == p.IdTorneo).FirstOrDefault();
                torneos.Add(tor);
            }

            

                return View("DetalleActividad", torneos);
        }
    }
}
