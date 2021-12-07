using Papelaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Papelaria.Controllers
{
    public class CategoriasController : Controller
    {

        private static IList<Categoria> categorias = new List<Categoria>()
        {

            new Categoria()
            {
                CategoriaId = 1,
                Nome = "Caderno Paltado"
            },

        };



        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }


       // Metodo Create()
        public ActionResult Create(Categoria categoria)
        {
            return View();
        }




    }
}