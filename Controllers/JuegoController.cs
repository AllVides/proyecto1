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

        public IActionResult Tablero()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult CargarXml(IFormFile upload)
        {
            if (upload != null)
            {
                upload.OpenReadStream();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(upload.ToString());
                if (xml.SelectSingleNode("color").InnerText == "blanco")
                {
                    ViewData["FileName"] = "blanco";
                };
                
                

                
            }
            else
            {
                ViewData["FileName"] = "empty file";
            }

            return View("Bandeja");
        }

        public string FileName { get; set; }

       


    }
}
