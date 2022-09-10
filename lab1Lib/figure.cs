

public class Figure
    {
        public string name { get; set; }
        private Point[] points;
        private double perimeter = 0;
        public Figure(Point _a, Point _b, Point _c) 
        {
            points = new Point[3] {_a, _b, _c};
            name = "rectangle";
            PerimeterCalculator();
        }
        public Figure(Point _a, Point _b, Point _c, Point _d) 
        {
            points = new Point[4] {_a, _b, _c, _d};
            name = "square";
            PerimeterCalculator();
        }
        public Figure(Point _a, Point _b, Point _c, Point _d, Point _e) 
        {
            points = new Point[5] {_a, _b, _c, _d, _e};
            name = "pentagon";
            PerimeterCalculator();
        }
        public double getPerimeter() {
            return perimeter;
        }
        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.getX() - B.getX()), 2) + Math.Pow(A.getY() - B.getY(), 2));
        }
        public void PerimeterCalculator() 
        {
            for (int i = 1; i < points.Length; ++i) {
                perimeter += LengthSide(points[i - 1], points[i]);
            }
            perimeter += LengthSide(points[0], points[points.Length - 1]);
        }
    }