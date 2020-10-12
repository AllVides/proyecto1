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

namespace proyecto1.Controllers
{

    public class JuegoController : Controller
    {
        public static Tablero mesa { get; set; }
        public JuegoController()
        {
        }

        public IActionResult Index()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Movimiento(string lugar)
        {
            Tablero tablero = JuegoController.mesa;
            
            int[] posicion = tablero.Posicion(lugar);
            tablero.AccionMovimiento(posicion[0], posicion[1]);
            tablero.LimpiezaTablero();
            tablero.contador();
            tablero.MovimientosPosibles();
            tablero.PiezasEnJuego();
            JuegoController.mesa = tablero;
            if (tablero.FinJuego()) { return RedirectToAction("Final"); }
            //para trabajar los turnos en bucle
            return View("Tablero",tablero);
        }
    
        public IActionResult Final()
        {
            return View();
        }

        public IActionResult GuardarXml()
        {
            return View();
        }
        public IActionResult Tablero()
        {
            JuegoController.mesa = new Tablero();
            JuegoController.mesa.MovimientosPosibles();
            JuegoController.mesa.PiezasEnJuego();
            return View(JuegoController.mesa);
        }

        [HttpPost]
        public IActionResult Tablero(IFormFile upload)
        {
            string[] posiciones = null;
            posiciones = CargarXml(upload);
            JuegoController.mesa = (posiciones == null) ? new Tablero() : new Tablero(posiciones[0], posiciones[1]);
            JuegoController.mesa.MovimientosPosibles();
            JuegoController.mesa.PiezasEnJuego();
            if (JuegoController.mesa.FinJuego()) { return RedirectToAction("Final"); }
            return View(JuegoController.mesa);
            
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
                XmlNodeList nodos = xml.SelectNodes("//tablero/ficha");
                
                foreach (XmlNode posicion in nodos)
                {
                     posiciones += posicion.SelectSingleNode("color").InnerText + ",";
                     posiciones += posicion.SelectSingleNode("columna").InnerText + ",";
                     posiciones += posicion.SelectSingleNode("fila").InnerText + ";";
                }

                string turno = xml.SelectSingleNode("//tablero/siguienteTiro/color").InnerText;

                valores[0] = posiciones;
                valores[1] = turno;
            }
            return valores;

        }

        

       


    }
}
