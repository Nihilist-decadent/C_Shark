using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HW_1_Andrey;
using static System.Net.Mime.MediaTypeNames;

namespace HW_1_Andrey
{

    class Rectrangle
    {
        private double _Width;
        private double _Height;

        public double Square()
        {
            return _Width * _Height;
        }

        public double Perimeter()
        {
            return 2 * (_Width + _Height);
        }

        public double Set_width 
        { 
             get { return _Width; }
             set { _Width = value; } 
        }

        public double Set_height
        { 
            get { return _Height; }
            set { _Height = value; } 
        }

        public void Print(double square, double perimeter)
        {
            Console.WriteLine("inf about tringle:");
            Console.WriteLine($"wysota: {_Height}");
            Console.WriteLine($"shyrina: {_Width}");
            Console.WriteLine($"inf about Square: {Square()}");
            Console.WriteLine($"inf about Perimeter: {Perimeter()}");
        }


    }
    internal class Program
    {
        //static public int SetWidth()
        //{
        //    int result;
        //    Console.WriteLine("введите ширину");
        //    while (!int.TryParse(Console.ReadLine(), out result))
        //    {
        //        Console.Write("ОШИБКА! Повторите ввод: ");
        //    }
        //    return result;
        //}
        //static public int SetHeight()
        //{
        //    int result;
        //    Console.WriteLine("ввдите высоту");
        //    while (!int.TryParse(Console.ReadLine(), out result))
        //    {
        //        Console.Write("ОШИБКА! Повторите ввод: ");
        //    }
        //    return result;
        //}

        static public int[] Output()
        {
            StreamReader file = new StreamReader("E:\\info.txt");
            string OutText = file.ReadLine();
            int[] ReturnIntValue = new int[3];
            while (true)
            {
                if (OutText != null)
                {
                    while (true)
                    {
                        string[] Words = OutText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string SeparateWords in Words)
                        {
                        }
                        if (Words.Length == 2)
                        {
                            int[] ValueInt = Array.ConvertAll(Words, SeparateWords => int.Parse(SeparateWords));
                            ReturnIntValue = ValueInt;
                        }
                        else { Console.WriteLine("int 2 chisla dolbaeb"); }
                        break;
                    }
                }
                else { Console.WriteLine("Dolbayeb int something"); }
                break;
            }
            file.Close();
            return ReturnIntValue;
        }
        //static public int[] Convert()
        //{
        //    string[] blyt = Output();
        //    string text ="1";
        //    for(int i=0; i<blyt.Length; i++)
        //    {
        //        if (blyt[i] != null)
        //        {
        //            text = blyt[i];
        //        }
        //    }
        //    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    foreach (string s in words)
        //    {
        //    }

        //    int[] ValueInt = Array.ConvertAll(words, s => int.Parse(s));
        //    return ValueInt;
        //}
        static void Main(string[] args)
        
        {
            Rectrangle rectrangle = new Rectrangle();

            int[] OutputValues = Output();
            rectrangle.Set_width = OutputValues[0];
            rectrangle.Set_height = OutputValues[1];

            rectrangle.Print(rectrangle.Square(), rectrangle.Perimeter());

            //StreamWriter file = new StreamWriter("E:\\info.txt", false);
            //file.WriteLine($"рассчитанная площадь: " + $"{rectrangle.Square()}");
            //file.WriteLine($"рассчитанный периметр: {rectrangle.Perimeter()}");
            //file.Close();

            Console.ReadKey();
        }
    }
}
