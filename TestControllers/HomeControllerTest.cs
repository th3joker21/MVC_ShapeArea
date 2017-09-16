using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;
using CalculateArea.Controllers;
using CalculateArea.Models;

namespace CalculateArea.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoadShapeTest()
        {
            HomeController controller = new HomeController();

            
            int i = 1;  //Shape ID
            string name = "Square";
            string dimension1 = "Side Length";
            string dimension2 = null;
            /*
            int i = 2;  //Shape ID
            string name = "Rectangle";
            string dimension1 = "Length";
            string dimension2 = "Width";
            
            int i = 3;  //Shape ID
            string name = "Triangle";
            string dimension1 = "Base";
            string dimension2 = "Height";
            
            int i = 4;  //Shape ID
            string name = "Circle";
            string dimension1 = "Radius";
            string dimension2 = null;
             */

            PartialViewResult result = controller.LoadShape(i) as PartialViewResult;

            var shape = result.ViewData.Model as Shape;

            Assert.IsNotNull(result);
            Assert.AreEqual(i, shape.Id);
            Assert.AreEqual(name, shape.Name);
            Assert.AreEqual(dimension1, shape.Dimension1);
            Assert.AreEqual(dimension2, shape.Dimension2);
        }

        [TestMethod]
        public void AreaCalculationSquareTest()
        {
            HomeController controller = new HomeController();

            var dimensions = new Dimensions(1, 5);

            double answer = 25;
            
            JsonResult result = controller.AreaCalculation(dimensions) as JsonResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("<b>The area is: " + answer + "<b>", result.Data.ToString());
        }

        [TestMethod]
        public void AreaCalculationRectangleTest()
        {
            HomeController controller = new HomeController();

            var dimensions = new Dimensions(2, 2, 4);

            double answer = 8;

            JsonResult result = controller.AreaCalculation(dimensions) as JsonResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("<b>The area is: " + answer + "<b>", result.Data.ToString());
        }

        [TestMethod]
        public void AreaCalculationTriangleTest()
        {
            HomeController controller = new HomeController();

            var dimensions = new Dimensions(3, 4, 5);

            double answer = 10;

            JsonResult result = controller.AreaCalculation(dimensions) as JsonResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("<b>The area is: " + answer + "<b>", result.Data.ToString());
        }

        [TestMethod]
        public void AreaCalculationCircleTest()
        {
            HomeController controller = new HomeController();

            //pi = 3.14159
            var dimensions = new Dimensions(4, 3);

            double answer = 28.27431;

            JsonResult result = controller.AreaCalculation(dimensions) as JsonResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("<b>The area is: " + answer + "<b>", result.Data.ToString());
        }
    }
}
