using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using proyecto1.Data;
using proyecto1.Controllers;
using proyecto1.Models;

namespace proyecto1.ViewComponents
{
    public class FiguraTorneoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(proyecto1.Models.GameLogic.LogicaTorneo torneo, int tamaño)
        {
            if(tamaño == 16)
            {
                return View("Equipos16", torneo);
            }
            else if (tamaño == 8)
            {
                return View("Equipos8", torneo);
            }
            else if (tamaño == 4)
            {
                return View("Equipos4", torneo);
            }
            return View();
        }
    }
}
