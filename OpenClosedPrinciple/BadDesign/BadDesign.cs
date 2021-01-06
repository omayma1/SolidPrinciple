using System;

public class BadDesign
{
    //Method not open to extension
    //This method don't calculate the are of all the shapes like Triangle
    //We must modify the method .So it is not xlosed to modification.
    public double Area(object[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                area += rectangle.Width * rectangle.Height;
            }
            else
            {
                Circle circle = (Circle)shape;
                area += circle.Radius * circle.Radius * Math.PI;
            }
        }
        return area;
    }
    
    public class AreaCalculator
    {
        public double Area(Rectangle[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }
            return area;
        }
    }
}
