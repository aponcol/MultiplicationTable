using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MultiplicationTable.Models;
using System.Web.Routing;

namespace MultiplicationTable.Controllers
{
    public class HomeController : Controller
    {
        public enum MatrixBase { Decimal = 1, Binary, Hexadecimal };

        public ActionResult Index(string matrix_size = "10", string matrix_base = "Decimal")
        {
            int matrixSize = int.Parse(matrix_size);
            TableGenerator tableGenerator = new TableGenerator();
            int[,] table = tableGenerator.GetTable(matrixSize);
            ViewBag.Table = table;
            return View();
        }
    }
}
