
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
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
using test.Modelo.BaseDatos;

namespace test.Servicios.Reader
{
    public class Read : IRead
    {
        public void readFile()
        {


            try
            {

                using (var context = new Modelo.BaseDatos.ResumenEntities()) //entidad de data entity

                {
                    string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\AutoClaveK.txt";

                    string[] lines = File.ReadAllLines(path, new UnicodeEncoding());

                    List<Row> lista = new List<Row>(); //declaro la lista del Read
                                                       //foreach (string line in lines)
                                                       //{
                    Row row = new Row
                    {
                        Column1 = lines[0].Trim(),
                        Column2 = lines[1].Trim(),
                        Programa = lines[2].Replace(" ", String.Empty).Substring(8,2),
                        Column4 = lines[3].Substring(1, 49).Trim(),
                        Column5 = lines[4].Trim(),
                        Column6 = lines[5].Substring(1, 49).Trim()

                    };
                    lista.Add(row);
                    //}


                    var prueba = new Resumen();// declaro una nueva hoja resumen

                    foreach (var x in lista)  //recorro la lista
                    {


                        prueba.Columna1 = x.Column1;
                        prueba.Columna2 = x.Column2;
                        prueba.Columna3 = x.Programa;
                        prueba.Columna4 = x.Column4;
                        prueba.Columna5 = x.Column5;
                        prueba.Columna6 = x.Column6;


                    }

                    try
                    {
                        context.Resumen.Add(prueba);
                        context.SaveChanges();
                         }
                             catch (DbEntityValidationException dbEx)
                            {
                         foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                            }
                          }
                         }

                    }
            }


            catch (Exception e)
            {
                Console.WriteLine("El archivo no pudo ser leido:");
                Console.WriteLine(e.Message);

            }

        }

    }

}







            //for (int i = 0; i < 8; i++)
            //{
            //var prueba = new Resumen();
            ////prueba.Id = i;
            //prueba.Columna1 = "Iranzo";
            //prueba.Columna2 = "Javier";
            //prueba.Columna3 = "Fuentes";
            //prueba.Columna4 = "Herrera";
            //prueba.Columna5 = "asdasd";
            //prueba.Columna6 = "asdsa";

            //context.Resumen.Add(prueba);
            //context.SaveChanges();
            //}

            //    //FUNCIONANDO

            //    //List<string> list = new List<string>();
            //    List<Row> lista = new List<Row>();
            //    string[] lines = File.ReadAllLines(path, new UnicodeEncoding());


            //    //foreach (string line in lines)
            //    //{
            //        Row row = new Row
            //        {
            //            Column1 = lines[0].Trim(),
            //            Column2 = lines[1].Trim(),
            //            Programa = lines[2].Trim(),
            //            Column4 = lines[3],
            //            Column5 = lines[4].Trim(),
            //            Column6 = lines[5].Substring(1, 12)

            //    };
            //        lista.Add(row);


            //    //}




            //    foreach (var x in lista)
            //    {
            //        Console.WriteLine(x.Programa);

            //        //    context.SaveChanges();
            //    }



            //    Console.WriteLine(lista.Count());



            //}

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
        

           



