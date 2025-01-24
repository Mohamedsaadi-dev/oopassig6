namespace oopassig6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first project

            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            Point3D P1 = ReadPoint("P1");
            Point3D P2 = ReadPoint("P2");

            Console.WriteLine(P1 == P2 ? "P1 and P2 are equal" : "P1 and P2 are not equal");


            Point3D[] points = new Point3D[]
            {
            new Point3D(3, 5, 1),
            new Point3D(1, 2, 3),
            new Point3D(5, 1, 4),
            new Point3D(2, 3, 2)
            };

            var sortedPoints = points.OrderBy(p => p.X).ThenBy(p => p.Y).ToArray();
            Console.WriteLine("\nSorted Points:");
            foreach (var point in sortedPoints)
            {
                Console.WriteLine(point);
            }

            Point3D clonedPoint = (Point3D)P1.Clone();
            Console.WriteLine($"\nCloned Point: {clonedPoint}");
        }
        private static Point3D ReadPoint(string pointName)
        {
            int x, y, z;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Enter coordinates for {pointName} (X Y Z):");
                    string[] inputs = Console.ReadLine()?.Split(' ');
                    if (inputs.Length != 3) throw new FormatException("Invalid input format.");

                    x = int.Parse(inputs[0]);
                    y = int.Parse(inputs[1]);
                    z = int.Parse(inputs[2]);

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}. Please try again.");
                }
            }
            return new Point3D(x, y, z);

        }
        #endregion
        #region
        double num1 = 20;

        double num2 = 5;

        // Console.WriteLine($"Addition: {Maths.Add(num1, num2)}");    

        //  Console.WriteLine($"Subtraction: {Maths.Subtract(num1, num2)}");

        // Console.WriteLine($"Multiplication: {Maths.Multiply(num1, num2)}");

        // Console.WriteLine($"Division: {Maths.Divide(num1, num2)}");   
       

        #endregion
        #region third project

        #endregion

    }







}

