using Nestle.WebApplication.Models.BEAN;
using Nestle.WebApplication.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nestle.WebApplication.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            ProductoDAO proDAO = new ProductoDAO();
            List<ProductoBEAN> lista = proDAO.listaProducto();
            return View(lista);
        }
    }
}