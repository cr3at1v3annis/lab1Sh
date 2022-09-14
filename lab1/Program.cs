using System;
public class Program
    {
        static void Main()
        {

            Console.WriteLine("minimum of bytes is {0}, maximum of bytes is {1} ", byte.MinValue, byte.MaxValue);
            Console.WriteLine("minimum of sbytes is {0}, maximum of sbytes is {1} ", sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("minimum of bools is {0}, maximum of bool is {1} ", bool.TrueString, bool.FalseString);
            Console.WriteLine("minimum of char is {0}, maximum of char is {1} ", char.MinValue, char.MaxValue);

            Console.WriteLine("minimum of short is {0}, maximum of short is {1} ", short.MinValue, short.MaxValue);
            Console.WriteLine("minimum of ushort is {0}, maximum of ushort is {1} ", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("minimum of int is {0}, maximum of int is {1} ", int.MinValue, int.MaxValue);
            Console.WriteLine("minimum of uint is {0}, maximum of uint is {1} ", uint.MinValue, uint.MaxValue);

            Console.WriteLine("minimum of long is {0}, maximum of long is {1} ", long.MinValue, long.MaxValue);
            Console.WriteLine("minimum of ulong is {0}, maximum of ulong is {1} ", ulong.MinValue, ulong.MaxValue);

            Console.WriteLine("minimum of float is {0}, maximum of float is {1} ", float.MinValue, float.MaxValue);
            Console.WriteLine("minimum of double is {0}, maximum of double is {1} ", double.MinValue, double.MaxValue);

            double a;
            double b;
            Console.WriteLine("Введите значение первой стороны:");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение второй стороны:");
            double.TryParse(Console.ReadLine(), out b);
            Rectangle rec = new Rectangle(a, b);
            Console.WriteLine("Площадь равна {0}", rec.Area);
            Console.WriteLine("Периметр равен {0}", rec.Perimeter);

            Point pa = new Point(0, 0);
            Point pb = new Point(1, 1);
            Point pc = new Point(0, 1);
            Figure f = new Figure(pa, pb, pc);
            Console.WriteLine("Name is {0}", f.name);
            Console.WriteLine("Perimetr is {0}", f.getPerimeter());
        }
    }
