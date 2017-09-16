using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateArea.Models
{
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dimension1 { get; set; }
        public string Dimension2 { get; set; }

        public Shape(int id, string name, string dimension1)
        {
            this.Id = id;
            this.Name = name;
            this.Dimension1 = dimension1;
        }

        public Shape(int id,string name,string dimension1,string dimension2)
        {
            this.Id = id;
            this.Name = name;
            this.Dimension1 = dimension1;
            this.Dimension2 = dimension2;
        }
    }

    public class Shapes
    {
        public List<Shape> shapesList { get; set; }

        public Shapes()
        {
            shapesList = new List<Shape>();
        }

        public void AddShape(int id, string name, string dimension1)
        {
            Shape shape = new Shape(id, name, dimension1);
            shapesList.Add(shape);
        }


        public void AddShape(int id,string name,string dimension1,string dimension2)
        {
            Shape shape = new Shape(id, name, dimension1, dimension2);
            shapesList.Add(shape);
        }

        public void SeedShapes()
        {
            AddShape(1, "Square", "Side Length");
            AddShape(2, "Rectangle", "Length", "Width");
            AddShape(3, "Triangle", "Base", "Height");
            AddShape(4, "Circle", "Radius");
        }

        public List<Shape> GetShapesList()
        {
            return shapesList;
        }
    }
}