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
        public ActionResult Index(string matrix_size = "10", string matrix_base = "1")
        {
            int matrixSize = int.Parse(matrix_size);
            TableGenerator tableGenerator = new TableGenerator();
            int[,] table = tableGenerator.GetTable(matrixSize);
            ViewBag.Table = table;
            ViewBag.CurrentMatrixSize = matrixSize;
            ViewBag.CurrentMatrixBase = matrix_base;
            ViewBag.IsBinary = matrix_base == "2";
            ViewBag.IsHex = matrix_base == "3";
            return View();
        }
    }
}