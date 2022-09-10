
public class Rectangle
    {
        private double side1 { get; set;}
        private double side2 { get; set;}
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }    
        }
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        public double AreaCalculator() => side1 * side2;
        public double PerimeterCalculator() => 2 * (side1 + side2);

    }
