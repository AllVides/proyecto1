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

    public class JuegoController : Controller
    {
        public static Tablero mesa { get; set; }

        private readonly OContext _context;
        public JuegoController(OContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Movimiento(string lugar)
        {
            Tablero tablero = JuegoController.mesa;
            int[] posicion;
            switch (lugar)
            {
                case "SaltarTurno": break;
                case "AutoPlay":
                    posicion = tablero.autoPosicion();
                    tablero.AccionMovimiento(posicion[0], posicion[1]);
                    break;
                case "FinJuego":
                    return RedirectToAction("Final"); 
                default:
                    posicion = tablero.Posicion(lugar);
                    tablero.AccionMovimiento(posicion[0], posicion[1]); 
                    break;
            }
            tablero.LimpiezaTablero();
            tablero.contador();
            tablero.MovimientosPosibles();
            tablero.PiezasEnJuego();
            JuegoController.mesa = tablero;
            //para trabajar los turnos en bucle
            return View("Tablero",tablero);
        }

    
        public IActionResult Final()
        {
            return View(JuegoController.mesa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Final(int usuario, int turnos, string ganador, string retador)
        {
                _context.Add(new Partida
                {
                    IdUsuario = usuario,
                    numTurnos = turnos,
                    resultado = ganador,
                    adversario = retador
                });
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Juego");
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

        public FileResult GuardarXml()
        {
            Tablero tabla = JuegoController.mesa;
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement tablero = doc.CreateElement(string.Empty, "tablero", string.Empty);
            doc.AppendChild(tablero);

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {

                    if (tabla.cuadricula[i, j].estado == 1 || tabla.cuadricula[i, j].estado == 2)
                    {
                        XmlElement ficha = doc.CreateElement(string.Empty, "ficha", string.Empty);
                        tablero.AppendChild(ficha);

                        XmlElement color = doc.CreateElement(string.Empty, "color", string.Empty);
                        XmlText text1 = doc.CreateTextNode((tabla.cuadricula[i, j].estado == 1) ? "blanco" : "negro");
                        color.AppendChild(text1);
                        ficha.AppendChild(color);

                        XmlElement columna = doc.CreateElement(string.Empty, "columna", string.Empty);
                        XmlText text2 = doc.CreateTextNode(tabla.cuadricula[i, j].columna);
                        columna.AppendChild(text2);
                        ficha.AppendChild(columna);

                        XmlElement fila = doc.CreateElement(string.Empty, "fila", string.Empty);
                        XmlText text3 = doc.CreateTextNode(tabla.cuadricula[i, j].fila.ToString());
                        fila.AppendChild(text3);
                        ficha.AppendChild(fila);
                    }

                }
            }

            XmlElement siguienteTiro = doc.CreateElement(string.Empty, "siguienteTiro", string.Empty);
            tablero.AppendChild(siguienteTiro);

            XmlElement colorTiro = doc.CreateElement(string.Empty, "color", string.Empty);
            XmlText text4 = doc.CreateTextNode(tabla.colorTurno);
            colorTiro.AppendChild(text4);
            siguienteTiro.AppendChild(colorTiro);

            var stream = new MemoryStream();
            doc.Save(stream);
            byte[] result = stream.ToArray();

            return File(result, "application/xml", "save.xml");
        }



    }
}
