
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using test.Modelo;

namespace test.Servicios.Reader
{
    public class Read : IRead
    {
        public void readFile()
        {

            // string GetValue(string line, string upperLimit, string lowerLimit)
            //{
            //    string pattern = string.Format(@"(?<={0})(.*?)(?={1})", upperLimit, lowerLimit);

            //    Match math = Regex.Match(line, pattern, RegexOptions.IgnoreCase);

            //    if (math.Success)
            //        return math.Value.Trim();

            //    return "";
            //}
            string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\AutoClaveK.txt";

            try
            {

                //FUNCIONANDO

                //List<string> list = new List<string>();
                List<Row> lista = new List<Row>();
                string[] lines = File.ReadAllLines(path, new UnicodeEncoding());


                foreach (string line in lines)
                {
                    Row row = new Row
                    {
                        Column1 = lines[0].Trim(),
                        Column2 = lines[1].Trim(),
                        Column3 = lines[2].Trim(),
                        Column4 = lines[3],
                        Column5 = lines[4].Trim(),
                        Column6 = lines[5].Substring(1, 12)
                    };
                    lista.Add(row);
                   
                }
                

             




                //Console.WriteLine(list[5]);

                //foreach (var tr in list)
                //{

                //    Row row = new Row();
                //    row.Column1 = list[0].Trim();
                //    row.Column2 = list[1].Trim();
                //    row.Column3 = list[2].Trim();
                //    row.Column4 = list[3].Trim();
                //    row.Column5 = list[4].Trim();
                //    row.Column6 = list[5].Trim();
                //    lista.Add(row);

                //}
                //Console.WriteLine(list.Count());
                //foreach( var s in lista)
                //{
                Console.WriteLine(lista.Count());
                    //Console.WriteLine(s.Column2);
                    //Console.WriteLine(s.Column3);
                    //Console.WriteLine(s.Column4);
                    //Console.WriteLine(s.Column5);
                    //Console.WriteLine(s.Column6);
                //}
               





















                //string line;
                //var list = new List<TablaResumen>();
                //using (var reader = new StreamReader(path, new UnicodeEncoding()))
                //{
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        list.Add(reader.ReadLine());
                //        //Console.WriteLine(list.Count);
                //    }

                //    foreach (TablaResumen s  in list)
                //    {
                //        Console.WriteLine(s);

                //    }

                //}




                // Open the file to read from.
                //var readText = File.ReadAllText(path, new UnicodeEncoding());
                //var pod = from line in readText
                //          select new
                //          {
                //              Programa = line.ToString().Trim(),


                //         };
                //Console.WriteLine(pod);


                //foreach (string line in File.ReadLines(path , new UnicodeEncoding()))
                //{
                //    if (line.Contains("PROGRAMAD"))
                //    {
                //        Console.WriteLine(line);
                //    }
                //}

                //string lines = File.ReadAllLines(path, new UnicodeEncoding());
                //var products = from line in lines
                //               select new
                //               {
                //                   ProductManufacturer = line.Substring(0, 12).Trim(),
                //                   ProductCode = line.Substring(12, 8).Trim(),
                //                   Description = line.Substring(20).Trim()
                //               };

                //var xml = new XDocument(new XElement("xml",
                //    from p in products
                //    select new XElement("Product",
                //        new XElement("ProductManufacturer", p.ProductManufacturer),
                //        new XElement("ProductCode", p.ProductCode),
                //        new XElement("Description", p.Description))));





                //using (XmlReader r = XmlReader.Create(new StreamReader(
                //path, new UnicodeEncoding())))
                //{
                //    while (r.Read())
                //    {
                //        Console.WriteLine(r.Value);
                //    }
                //}





                //XmlDocument doc = new XmlDocument();
                //doc.Load(path);

                //foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                //{
                //    string text = node.InnerText; //or loop through its children as well
                //    Console.WriteLine(text);
                //}

            }

            // using (StreamReader reader = new StreamReader(path, new UnicodeEncoding()))
            // {

            //    string line;
            //    //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //    string[] separatingStrings = {/* "<<", "...", "#", "a" , "<"*/};
            //    Console.WriteLine("The encoding used was {0}.", reader.CurrentEncoding);
            //    while ((line = reader.ReadLine()) != null)
            //    {

            //       // Console.WriteLine(line);


            //        string[] items = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            //        //string[] items = line.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            //        //System.Console.WriteLine($"{items.Length} substrings in text:");

            //        foreach (var word in items)
            //        {
            //            System.Console.WriteLine($"{word}");
            //        }
            //    }
            //}
            // }


            catch (Exception e)
            {
                Console.WriteLine("El archivo no pudo ser leido:");
                Console.WriteLine(e.Message);

            }


        }
    }
}

