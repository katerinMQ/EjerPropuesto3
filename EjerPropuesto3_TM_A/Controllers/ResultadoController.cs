using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjerPropuesto3_TM_A.Models;

namespace EjerPropuesto3_TM_A.Controllers
{
    public class ResultadoController : Controller
    {
        private RESULTADO objResultado = new RESULTADO();
        // GET: Resultado
        public ActionResult Index()
        {
            return View(objResultado.Listar());
        }

        public ActionResult Grafico1()
        {
            ViewBag.Categorias = objResultado.ObtenerCantidadCriterio();

            return View(objResultado.ObtenerCantidadCriterio());
        }

        public ActionResult Grafico2()
        {
            ViewBag.Categorias = objResultado.ObtenerCantidadCriterio();

            return View(objResultado.ObtenerCantidadCriterio());
        }

        public ActionResult Grafico3()
        {
            ViewBag.Categorias = objResultado.ObtenerCantidadCriterio();

            return View(objResultado.ObtenerCantidadCriterio());
        }

        public ActionResult Grafico4()
        {
            ViewBag.Categorias = objResultado.ObtenerCantidadCriterio();

            return View(objResultado.ObtenerCantidadCriterio());
        }

        public ActionResult Grafico5()
        {
            ViewBag.Categorias = objResultado.ObtenerCantidadCriterio();

            return View(objResultado.ObtenerCantidadCriterio());
        }


    }
}