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


namespace proyecto1.Controllers
{

    public class JuegoController : Controller
    {

        public JuegoController( )
        {
            
       

        }
        public IActionResult Bandeja()
        {
            return View();
        }

        public IActionResult Tablero()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CargarXml(/*HttpPostedFileBase file*/)
        {

            /*
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }


            
            XmlReader reader = XmlReader.Create(nombre);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    //return only when you have START tag  
                    switch (reader.Name.ToString())
                    {
                        case "mercado":
                            textBox1.AppendText("Frutas del mercado: \r\n");
                            break;
                        case "nombre":
                            textBox1.AppendText("Nombre de la Fruta: " + reader.ReadString() + "\r\n");
                            break;
                        case "color":
                            textBox1.AppendText("Color de la Fruta: " + reader.ReadString() + "\r\n");
                            break;
                        case "tamanio":
                            textBox1.AppendText("Tamaño de la Fruta: " + reader.ReadString() + "\r\n\r\n");
                            break;
                    }
                }
            }
            */
            return View("Tablero", "Juego");
        }

        
    }
}
