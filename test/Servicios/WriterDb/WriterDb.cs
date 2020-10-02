using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Modelo;
using test.Modelo.Datos;

namespace test.Servicios.WriterDb
{
    public class WriterDb : IWriterDb
    {
        public void WriteFile()
        {
            try
            {

                using (var context = new HojaResumenDb()) //entidad de data entity

                {
                    string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\AutoClaveK.txt";

                    string[] lines = File.ReadAllLines(path, new UnicodeEncoding());
                    //var t = lines.SkipWhile(s => s.Contains("Header"));
                   

                    List<Row> lista = new List<Row>(); //declaro la lista que quiero cargar
                    var longitud = lines.Length;
                    Row row = new Row
                    {
                        IdAutoclave = lines[10].Replace(" ", String.Empty).Substring(10),
                 
                        IdSeccion = "Sabi2",//directo
                        NumeroCiclo = lines[25].Replace(" ", String.Empty).Substring(12),
                        Programa = lines[2].Replace(" ", String.Empty).Substring(8),
                        DatosPrograma = lines[3],
                        Programador = lines[5].Replace(" ", String.Empty).Substring(10),
                        Operador = lines[6].Replace(" ", String.Empty).Substring(8),
                        CodigoProducto = lines[8].Replace(" ", String.Empty).Substring(11),
                        Lote = lines[9].Replace(" ", String.Empty).Substring(6),
                        Notas = lines[12] + lines[13],
                        Formato = "XL",  //directo
                        IdUsuario = "1",  //directo
                        Fase1 = lines[223].Substring(12),
                        DuracionTotalF1 = lines[227].Replace(" ", String.Empty).Substring(21),

                        Fase2 = lines[231].Substring(12),
                        DuracionTotalF2 = lines[458].Replace(" ", String.Empty).Substring(21),

                        Fase3 = lines[462].Substring(12),
                        DuracionTotalF3 = lines[796].Replace(" ", String.Empty).Substring(21),

                        Fase4 = lines[800].Substring(12),
                        DuracionTotalF4 = lines[816].Replace(" ", String.Empty).Substring(21),
                        
                        Fase5 = lines[820].Substring(12),
                        DuracionTotalF5 = lines[826].Replace(" ", String.Empty).Substring(21),
                        TIF5 = lines[822].Substring(4),
                        TISubF5 = lines[823].Substring(14),
                        TFF5 = lines[824].Substring(4),
                        TFSubF5= lines[825].Substring(14),

                        Fase6 = lines[820].Substring(12),
                        DuracionTotalF6 = lines[826].Replace(" ", String.Empty).Substring(21),
                        TIF6 = lines[832].Substring(4),
                        TISubF6 = lines[833].Substring(14),
                        TFF6 = lines[880].Substring(4),
                        TFSubF6 = lines[881].Substring(14),

                        Fase7 = lines[886].Substring(12),
                        DuracionTotalF7 = lines[898].Replace(" ", String.Empty).Substring(21),
                        TIF7 = lines[888].Substring(4),
                        TISubF7 = lines[889].Substring(14),

                        Fase8 = lines[902].Substring(12),
                        DuracionTotalF8 = lines[942].Replace(" ", String.Empty).Substring(21),
                        TIF8 = lines[904].Substring(4),
                        TISubF8 = lines[905].Substring(14),
                        TFF8 = lines[940].Substring(4),

                        Fase9 = lines[1012].Substring(12),
                        DuracionTotalF9 = lines[1252].Replace(" ", String.Empty).Substring(21),
                        TIF9 = lines[1014].Substring(4),
                        TISubF9 = lines[1015].Substring(14),
                        TFF9 = lines[1250].Substring(4),

                        Fase10 = lines[1256].Substring(12),
                        DuracionTotalF10 = lines[1260].Replace(" ", String.Empty).Substring(21),

                        Fase11 = lines[1264].Substring(12),
                        DuracionTotalF11 = lines[1328].Replace(" ", String.Empty).Substring(21),

                        Fase12 = lines[1332].Substring(12),
                        DuracionTotalF12 = "Desconocida",

                        Fase13 = "No",
                        TFF13 = "No",
                        TFSubF13 = "No",

                        HoraInicio = lines[1338].Substring(22),
                        HoraFin = lines[1339].Substring(22),

                        EsterilizacionN = lines[1340].Substring(26),
                        TMinima = lines[1341].Replace(" ", String.Empty).Substring(25) ,
                        TMaxima = lines[1342].Replace(" ", String.Empty).Substring(25) ,
                        DuracionTotal = lines[1343].Replace(" ", String.Empty).Substring(25),
                        FtzMin = lines[1344].Replace(" ", String.Empty).Substring(11),
                        FtzMax = lines[1345].Replace(" ", String.Empty).Substring(11),
                        AperturaPuerta = lines[1347].Trim(),                
                        TiempoCiclo = "No",


                    };
                    lista.Add(row); //añado elementos
                   


                    var ciclos = new Ciclos();// Instancio objeto Ciclos

                    foreach (var s in lista)  //recorro la lista
                    {


                        ciclos.IdAutoclave = s.IdAutoclave;
                        ciclos.IdSeccion = s.IdSeccion;
                        ciclos.NumeroCiclo = s.NumeroCiclo;
                        ciclos.Programa = s.Programa;
                        ciclos.DatosPrograma = s.DatosPrograma;
                        ciclos.Programador = s.Programador;
                        ciclos.Operador = s.Operador;
                        ciclos.CodigoProducto = s.CodigoProducto;
                        ciclos.Lote = s.Lote;
                        ciclos.Notas = s.Notas;
                        ciclos.Formato = s.Formato;
                        ciclos.IdUsuario = s.IdUsuario;
                        ciclos.Fase1 = s.Fase1;
                        ciclos.DuracionTotalF1 = s.DuracionTotalF1;

                        ciclos.Fase2 = s.Fase2;
                        ciclos.DuracionTotalF2 = s.DuracionTotalF2;

                        ciclos.Fase3 = s.Fase3;
                        ciclos.DuracionTotalF3 = s.DuracionTotalF3;

                        ciclos.Fase4 = s.Fase4;
                        ciclos.DuracionTotalF4 = s.DuracionTotalF4;

                        ciclos.Fase5 = s.Fase5;
                        ciclos.DuracionTotalF5 = s.DuracionTotalF5;
                        ciclos.TIF5 = s.TIF5;
                        ciclos.TISubF5 = s.TISubF5;
                        ciclos.TFF5 = s.TFF5;
                        ciclos.TFSubF5 = s.TFSubF5;


                        ciclos.Fase6 = s.Fase6;
                        ciclos.DuracionTotalF6 = s.DuracionTotalF6;
                        ciclos.TIF6 = s.TIF6;
                        ciclos.TISubF6 = s.TISubF6;
                        ciclos.TFF6 = s.TFF6;
                        ciclos.TFSubF6 = s.TFSubF6;

                        ciclos.Fase7 = s.Fase7;
                        ciclos.DuracionTotalF7 = s.DuracionTotalF7;
                        ciclos.TIF7 = s.TIF7;
                        ciclos.TISubF7 = s.TISubF7;

                        ciclos.Fase8 = s.Fase8;
                        ciclos.DuracionTotalF8 = s.DuracionTotalF8;
                        ciclos.TIF8 = s.TIF8;
                        ciclos.TISubF8 = s.TISubF8;
                        ciclos.TFF8 = s.TFF8;

                        ciclos.Fase9 = s.Fase9;
                        ciclos.DuracionTotalF9 = s.DuracionTotalF9;
                        ciclos.TIF9 = s.TIF9;
                        ciclos.TISubF9 = s.TISubF9;
                        ciclos.TFF9 = s.TFF9;

                        ciclos.Fase10 = s.Fase10;
                        ciclos.DuracionTotalF10 = s.DuracionTotalF10;

                        ciclos.Fase11 = s.Fase11;
                        ciclos.DuracionTotalF11 = s.DuracionTotalF11;

                        ciclos.Fase12 = s.Fase12;
                        ciclos.DuracionTotalF12 = s.DuracionTotalF12;

                        ciclos.Fase13 = s.Fase13;
                        ciclos.TFF13 = s.TFF13;
                        ciclos.TFSubF13 = s.TFSubF13;

                        ciclos.HoraInicio = s.HoraInicio;
                        ciclos.HoraFin = s.HoraFin;

                        ciclos.EsterilizacionN = s.EsterilizacionN;
                        ciclos.TMinima = s.TMinima;
                        ciclos.TMaxima = s.TMaxima;
                        ciclos.DuracionTotal = s.DuracionTotal;
                        ciclos.FtzMin = s.FtzMin;
                        ciclos.FtzMax = s.FtzMax;
                        ciclos.AperturaPuerta = s.AperturaPuerta;
                        ciclos.TiempoCiclo = s.TiempoCiclo;




                    }

                    try
                    {
                        context.Ciclos.Add(ciclos);
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

 