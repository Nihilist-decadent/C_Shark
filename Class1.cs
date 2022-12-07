using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HW_1_Andrey;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace HW_1_Andrey
{

    class Rectrangle
    {
        private double _Width;
        private double _Height;

        public double getSquare()
        {
            return _Width * _Height;
        }

        public double getPerimeter()
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

    }
    internal class RectrainglePrinter
    {
        public void Print()
        {
            Rectrangle rectrangle = new Rectrangle();

            Console.WriteLine("inf about tringle:");
            Console.WriteLine($"wysota: {rectrangle.Set_height}");
            Console.WriteLine($"shyrina: {rectrangle.Set_width}");
            Console.WriteLine($"inf about Square: {rectrangle.getSquare()}");
            Console.WriteLine($"inf about Perimeter: {rectrangle.getPerimeter()}");
        }
    }
    class RecReadFile
    {
        public async void Record()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            string[] InfArray = new string[2];
            Console.WriteLine("input ur width");
            InfArray[0] = Console.ReadLine();

            Console.WriteLine("input ur height");
            InfArray[1] = Console.ReadLine();

            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                for (int i = 0; i < InfArray.Length; i++)
                {
                    // преобразуем строку в байты
                    byte[] buffer = Encoding.Default.GetBytes(InfArray[i]);
                    // запись массива байтов в файл
                    await fstream.WriteAsync(buffer, 0, buffer.Length);
                    Console.WriteLine("Текст записан в файл");
                }
            }

        }

        static public string[] Read()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            string[] files = File.ReadAllLines(path);
            return files;
        }
       
    }
    internal class Program
    {
        static public int[] Output()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            string[] files = File.ReadAllLines(path);
            int[] ReturnIntValue = new int[2];
            while (true)
            {
                if (files != null)
                {
                   if (files.Length == 2)
                   {
                      int[] ValueInt = Array.ConvertAll(files, SeparateWords => int.Parse(SeparateWords));
                      ReturnIntValue = ValueInt;
                   }
                   else { Console.WriteLine("int 2 chisla dolbaeb"); }
                   break;
                }
                else { Console.WriteLine("Dolbayeb int something"); }
                break;
            }
            return ReturnIntValue;
        }
        static void Main(string[] args)
        {
            Rectrangle rectrangle = new Rectrangle();
            RectrainglePrinter rectrainglePrinter = new RectrainglePrinter();
            RecReadFile recread = new RecReadFile();
            
            int[] OutputValues = Output();
            rectrangle.Set_width = OutputValues[0];
            rectrangle.Set_height = OutputValues[1];

            rectrainglePrinter.Print();
            Console.ReadKey();
        }
    }
}
