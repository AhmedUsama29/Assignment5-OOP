namespace Assignment_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1 : Create a Class Point3D with the following attributes: X, Y, Z.

            #region Q2 : Override the ToString Function to produce this output:
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            #endregion

            #region Q3 : Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            Console.WriteLine($"Enter Coorditions for point 1 (X,Y,Z)");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Point3D point1 = new Point3D(x, y, z);

            Console.WriteLine($"Enter Coorditions for point 2 (X,Y,Z)");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            Point3D point2 = new Point3D(x, y, z);
            #endregion

            #region Q4 : Try to use == , If(P1 == P2)   Does it work properly?
            //if (point1 == point2) { 
            //}
            //No, we need to override the == operator to compare two objects of the same type 
            #endregion

        }
    }
}
