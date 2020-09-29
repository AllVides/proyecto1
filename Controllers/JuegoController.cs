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

namespace proyecto1.Controllers
{

    public class JuegoController : Controller
    {
        public JuegoController( )
        {
            
       

        }
        public IActionResult Bandeja()
        {
            
            ViewData["FileName"] = FileName;
            return View();
        }

        public String FileName { get; set; }

        public IActionResult Tablero()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult CargarXml(IFormFile upload)
        {
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
                XmlNodeList nodos = xml.SelectNodes("//tablero/ficha");
                String fichas ="";
                foreach (XmlNode posicion in nodos)
                {
                    fichas += posicion.SelectSingleNode("color").InnerText + ",";
                    fichas += posicion.SelectSingleNode("columna").InnerText + ",";
                    fichas += posicion.SelectSingleNode("fila").InnerText + ";";
                }

                ViewData["Turno"] = xml.SelectSingleNode("//tablero/siguienteTiro/color").InnerText;
                ViewData["Fichas"] = fichas;
                ViewData["FileName"] = upload.FileName;
               
            }
            else
            {
                ViewData["Turno"] = null;
                ViewData["Fichas"] = null;
                ViewData["FileName"] = null;
            }

            return View("Tablero");
        }

       


    }
}
