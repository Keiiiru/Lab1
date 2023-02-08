using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace tochka
{

    class Tochka_v_prostranstve
    {
        private double a, b;

        public void numbers() 
        {
            Console.WriteLine("Введите X: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void Set_a(double pa) { a = pa; }
        public double Get_a() { return a; }

        public void Set_b(double pb) { b = pb; }
        public double Get_b() { return b; }


        public double S => Math.Sqrt((Math.Pow(a, 2) - Math.Pow(0, 2)) + (Math.Pow(b, 2) - Math.Pow(0, 2)));


        public void Information()
        {
            string str = "**********************\n" +
                         "*                    *\n" +
                         "*Точка в пространстве*\n" +
                         "*                    *\n" +
                         "**********************";
            Console.WriteLine(str);

            Console.WriteLine("Точка в пространстве: \n" +
                "x = {0}\n" +
                "y = {1}\n", a, b);

            Console.WriteLine("Расстояние равно {0}", S);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Расстояние до точки";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Tochka_v_prostranstve p;

            p = new Tochka_v_prostranstve();

            p.numbers();
            p.Information();



            Console.ReadKey();
        }
    }
}
