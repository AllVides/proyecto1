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
    public class TableroMovilViewComponent : ViewComponent
    {
        
        public async Task<IViewComponentResult> InvokeAsync(proyecto1.Models.GameLogic.Tablero tablero)
        {   
            return View("TableroMovil", tablero);
        }
    }
}
