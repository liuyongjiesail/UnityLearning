using System;

namespace FirstConsoleApp
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello wo");

            //float cosine = (float)Math.Cos(45 * Math.PI / 180);
            //Single x = (float)Math.Cos(45 * Math.PI / 180);

            //Console.WriteLine("Cosine of 45 degrees:" + cosine + x);

            double angle;

            // prompt for and get angle
            Console.Write("Enter angle in degrees: ");
            angle = float.Parse(Console.ReadLine());

            // convert angle to radians
            angle *= 180 / Math.PI;

            // calculate and print cos and sin

            Console.WriteLine(Math.Cos(angle));
            Console.WriteLine(Math.Sin(angle));


        }
    }
}
