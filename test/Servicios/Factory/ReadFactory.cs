using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Modelo;

namespace test.Servicios.Factory
{
    public class ReadFactory : IReadFactory
    {
        public void readFile()
        {
            string path = @"C:\Users\fuenteI3\Desktop\patata.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
