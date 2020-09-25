using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using test.Modelo;

namespace test.Servicios.Factory
{
    public class Read : IRead
    {
        public void readFile()
        {
            string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\NA0611EFM03625.xml";

            try
            {
                using (StreamReader reader = new StreamReader(path, new UnicodeEncoding()))
                {
                    string line;
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t'};
                    string[] separatingStrings = {/* "<<", "...", "#", "a" , "<"*/};

                    while ((line = reader.ReadLine()) != null)
                    {

                       // Console.WriteLine(line);

                        string[] items = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                        //string[] items = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); 
                        // System.Console.WriteLine($"{items.Length} substrings in text:");

                        foreach (var word in items)
                        {
                         System.Console.WriteLine($"<{word}>");
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }


        }
    }
}

