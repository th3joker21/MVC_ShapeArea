using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculateArea.Models;

namespace CalculateArea.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Shapes shapes = new Shapes();
            shapes.SeedShapes();
            List<Shape> shapesList = shapes.GetShapesList();
            return View(shapesList);
        }

        [HttpPost]
        public ActionResult LoadShape(int shapeId)
        {
            Shapes shapes = new Shapes();
            shapes.SeedShapes();
            List<Shape> shapesList = shapes.GetShapesList();

            Shape shape = shapesList[shapeId-1];
            return PartialView(shape);
        }

        [HttpPost]
        public JsonResult AreaCalculation(Dimensions values)
        {
            double result = 0;

            switch (values.shapeID)
            {
                case 1:
                    result = values.Dimension1 * values.Dimension1;
                    break;
                case 2:
                    result = values.Dimension1 * values.Dimension2;
                    break;
                case 3:
                    result = .5 * values.Dimension1 * values.Dimension2;
                    break;
                case 4:
                    result = 3.14159 * values.Dimension1 * values.Dimension1;
                    break;
            }

            return Json("<b>The area is: "+result+"<b>", JsonRequestBehavior.AllowGet);
        }

    }
}