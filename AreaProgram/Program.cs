using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSeleziona una figura geometrica della quale calcolare l' area:\n1-Triangolo\n2-Cerchio\n3-Quadrato");
            int selezione = Convert.ToInt32(Console.ReadLine());

            switch (selezione)
            {
                case 1:
                    Triangle triangle = new Triangle();
                    Console.WriteLine("Inserisci la base del triangolo: ");
                    triangle.Base = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci l' altezza del triangolo: ");
                    triangle.Height = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'area del triangolo e': "+triangle.Area(triangle.Base, triangle.Height));
                    Main(args);


                    break;
                case 3:
                    Square square = new Square();
                    Console.WriteLine("Inserisci il lato del quadrato: ");
                    square.Side = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'area del quadrato e': " + square.Area(square.Side));
                    Main(args);
                    break;

                case 2:
                    Circle circle = new Circle();
                    Console.WriteLine("Inserisci il raggio del cerchio: ");
                    circle.Radius = (double)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("L'area del cerchio e': " + circle.Area(circle.Radius));
                    Main(args);

                    break;
                default:
                    Console.WriteLine("\nScelta non valida, riprova!\n");
                    Main(args);
                    break;

            }
            Console.Read();
        }
    }
}
