namespace Assignment_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1 : Create a Class Point3D with the following attributes: X, Y, Z.

            #region Q2 : Override the ToString Function to produce this output:
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #endregion

            #region Q3 : Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //Console.WriteLine($"Enter Coorditions for point 1 (X,Y,Z)");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //Point3D point1 = new Point3D(x, y, z);

            //Console.WriteLine($"Enter Coorditions for point 2 (X,Y,Z)");
            //x = int.Parse(Console.ReadLine());
            //y = int.Parse(Console.ReadLine());
            //z = int.Parse(Console.ReadLine());
            //Point3D point2 = new Point3D(x, y, z);
            #endregion

            #region Q4 : Try to use == , If(P1 == P2)   Does it work properly?
            //if (point1 == point2) { 
            //}
            //No, we need to override the == operator to compare two objects of the same type 
            #endregion

            #region Q5 : Define an array of points and sort this array based on X & Y coordinates.

            //    Point3D[] points = new Point3D[]
            //{
            //    new Point3D(3, 4, 5),
            //    new Point3D(1, 2, 3),
            //    new Point3D(5, 1, 6),
            //    new Point3D(2, 2, 2),
            //    new Point3D(3, 1, 4),
            //};

            //Array.Sort(points, ComparePoints);

            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion

            #region Second Project: Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().

            //double num1 = 10;
            //double num2 = 5;

            //Console.WriteLine($"Addition: {Maths.Add(num1, num2)}");
            //Console.WriteLine($"Subtraction: {Maths.Subtract(num1, num2)}");
            //Console.WriteLine($"Multiplication: {Maths.Multiply(num1, num2)}");
            //Console.WriteLine($"Division: {Maths.Divide(num1, num2)}");

            #endregion



        }

        #region Q5
        public static int ComparePoints(Point3D p1, Point3D p2)
        {
            if (p1.X < p2.X) return -1;
            if (p1.X > p2.X) return 1;

            // If X values are the same, compare Y
            if (p1.Y < p2.Y) return -1;
            if (p1.Y > p2.Y) return 1;

            return 0; // X and Y are equal
        } 
        #endregion

    }
}
