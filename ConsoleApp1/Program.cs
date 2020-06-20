using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            File.WriteAllText("examen.txt", text);
            FileStream stream = new FileStream("examen.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            Console.WriteLine("Введенный вами текст в файл (examen.txt): " + str);
            Console.ReadKey();
            }
        }
    }
