using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateArea.Models
{
    public class Dimensions
    {
        public int shapeID { get; set; }
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public Dimensions()
        {
        }

        public Dimensions(int shapeID, double dim1)
        {
            this.shapeID = shapeID;
            this.Dimension1 = dim1;
        }

        public Dimensions(int shapeID, double dim1, double dim2)
        {
            this.shapeID = shapeID;
            this.Dimension1 = dim1;
            this.Dimension2 = dim2;
        }
    }
}