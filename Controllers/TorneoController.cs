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
using System.Xml;
using System.Windows.Input;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using proyecto1.Models.GameLogic;
using System.Dynamic;

namespace proyecto1.Controllers
{
    public class TorneoController : Controller
    {

        public static LogicaTorneo torneo { get; set; }
        private readonly OContext _context;
        public TorneoController(OContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        { return View(); }
        public IActionResult VistaTorneo()
        {
            TorneoController.torneo = new LogicaTorneo();


            return View("VistaTorneo", TorneoController.torneo);
        }

        [HttpPost]
        public IActionResult Iniciar(IFormFile upload)
        {
            string[] valores = CargarXml(upload);
            TorneoController.torneo = new LogicaTorneo(valores);

            return View("VistaTorneo", TorneoController.torneo);
        }

        public IActionResult Resultado()
        {
            TorneoController.torneo.quienGana();
            return View("VistaTorneo", TorneoController.torneo);
        }

        public async Task<IActionResult> Final()
        {
            _context.Add(new Torneo
            {
                nombre = TorneoController.torneo.nombreTorneo,
                tamaño = TorneoController.torneo.tamaño
            }) ;
            _context.SaveChanges();

            int idTorneo = _context.Torneo.Where(u => u.nombre == TorneoController.torneo.nombreTorneo).LastOrDefault().IdTorneo;
            
            _context.Add(new Participante
            {
                IdTorneo = idTorneo,
                IdUsuario = HomeController.Usuario
            }) ;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Juego");
        }


        public string[] CargarXml(IFormFile upload)
        {
            string[] valores = new string[2];
            string posiciones = "";
            if (upload != null)
            {
                StreamReader reader = new StreamReader(upload.OpenReadStream());
                string document = "";
                string line;
                do
                {
                    line = reader.ReadLine();
                    document += line;
                } while (line != null);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(document);
                XmlNodeList nodos = xml.SelectNodes("//campeonato/equipo");

                foreach (XmlNode posicion in nodos)
                {
                    posiciones += posicion.SelectSingleNode("nombreEquipo").InnerText + ",";
                }

                string nombre = xml.SelectSingleNode("//campeonato/nombre").InnerText;

                valores[0] = posiciones;
                valores[1] = nombre;
                
            }
            return valores;

        }
    }
}
