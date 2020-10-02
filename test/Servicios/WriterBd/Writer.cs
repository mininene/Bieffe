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

namespace test.Servicios.WriterBd
{
    public class Writer : IWriterBd
    {
        void IWriterBd.Writer()
        {


            try
            {
                string Ciclo = "N. PROGRESIVO";
                string Programa = " PROGRAMA          ";
                string Programador = "PROGRAMAD.";
                string Operador = "OPERADOR";
                string CodigoP = " CODIGO PROD.";
                string Lote = "N.LOTE";
                string IdMaquina = "ID.MAQUINA";
                string Notas = "NOTAS";
                string FaseUno = "FASE    1";
                string DuracionF1 = "$DURAC.TOTAL FASE";
                string FaseDos = "FASE    2";
                string DuracionF2 = "<             F \n";
                

                string FaseTres = "FASE    3";
                string FaseCuatro = "FASE    4";
                string FaseCinco = "FASE    5";
                string FaseSeis = "FASE    6";
                string FaseSiete = "FASE    7";
                string FaseOcho = "FASE    8";
                string FaseNueve = "FASE    9";
                string FaseDiez = "FASE   10";
                string FaseOnce = "FASE   11";
                string FaseDoce = "FASE   12";
                string FaseTrece = "FASE   13";


                string HoraI = " HORA COMIEN.PROGR.";
                string HoraF = " HORA FIN PROGRAMA";
                string EsterN = " ESTERILIZACION N.";
                string TMin = " TEMP.MIN.ESTERILIZACION";
                string Tmax = " TEMP.MAX.ESTERILIZACION";
                string DFE = " DURACION FASE DE ESTER.";
                string Fmin = " F(T,z) MIN.:";
                string Fmax = " F(T,z) MAX.:";
                string ok = "OK APERTURA";




                using (var context = new HojaResumenDb()) //entidad de data entity

                {
                    string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\AutoClavek1.txt";

                    string[] lines = File.ReadAllLines(path, new UnicodeEncoding());

                   

                    List<Row> lista = new List<Row>(); //declaro la lista que quiero cargar
                    try
                    {
                        Row row = new Row
                        {

                            IdAutoclave = (lines.FirstOrDefault(s => s.Contains(IdMaquina)).Replace(" ", String.Empty).Substring(10)).Trim(),
                            IdSeccion = "Sabi2 " + DateTime.Today,//directo
                            NumeroCiclo = (lines.FirstOrDefault(s => s.Contains(Ciclo)).Replace(" ", String.Empty).Substring(12)).Trim(),
                            Programa = (lines.FirstOrDefault(s => s.Contains(Programa)).Replace(" ", String.Empty).Substring(8)).Trim(),
                            DatosPrograma = lines[3],
                            Programador = (lines.FirstOrDefault(s => s.Contains(Programador)).Replace(" ", String.Empty).Substring(10)).Trim(),
                            Operador = (lines.FirstOrDefault(s => s.Contains(Operador)).Replace(" ", String.Empty).Substring(8)).Trim(),
                            CodigoProducto = (lines.FirstOrDefault(s => s.Contains(CodigoP)).Replace(" ", String.Empty).Substring(11)).Trim(),
                            Lote = (lines.FirstOrDefault(s => s.Contains(Lote)).Replace(" ", String.Empty).Substring(6)).Trim(),
                            Notas = lines[12] + lines[13],
                            //Formato = "XL",  //directo
                            //IdUsuario = "1",  //directo
                            Fase1 = (lines.FirstOrDefault(s => s.Contains(FaseUno)).Substring(12)).Trim(),
                            DuracionTotalF1 = (lines.FirstOrDefault(s => s.Contains(DuracionF1)).Replace(" ", String.Empty).Substring(21)).Trim(),


                            Fase2 = (lines.FirstOrDefault(s => s.Contains(FaseDos)).Substring(12)).Trim(),

                            //DuracionTotalF2 = lines.Where(),



                            //Fase3 = lines[462].Substring(12),
                            //DuracionTotalF3 = lines[796].Replace(" ", String.Empty).Substring(21),

                            //Fase4 = lines[800].Substring(12),
                            //DuracionTotalF4 = lines[816].Replace(" ", String.Empty).Substring(21),

                            //Fase5 = lines[820].Substring(12),
                            //DuracionTotalF5 = lines[826].Replace(" ", String.Empty).Substring(21),
                            //TIF5 = lines[822].Substring(4),
                            //TISubF5 = lines[823].Substring(14),
                            //TFF5 = lines[824].Substring(4),
                            //TFSubF5 = lines[825].Substring(14),

                            //Fase6 = lines[820].Substring(12),
                            //DuracionTotalF6 = lines[826].Replace(" ", String.Empty).Substring(21),
                            //TIF6 = lines[832].Substring(4),
                            //TISubF6 = lines[833].Substring(14),
                            //TFF6 = lines[880].Substring(4),
                            //TFSubF6 = lines[881].Substring(14),

                            //Fase7 = lines[886].Substring(12),
                            //DuracionTotalF7 = lines[898].Replace(" ", String.Empty).Substring(21),
                            //TIF7 = lines[888].Substring(4),
                            //TISubF7 = lines[889].Substring(14),

                            //Fase8 = lines[902].Substring(12),
                            //DuracionTotalF8 = lines[942].Replace(" ", String.Empty).Substring(21),
                            //TIF8 = lines[904].Substring(4),
                            //TISubF8 = lines[905].Substring(14),
                            //TFF8 = lines[940].Substring(4),

                            //Fase9 = lines[1012].Substring(12),
                            //DuracionTotalF9 = lines[1252].Replace(" ", String.Empty).Substring(21),
                            //TIF9 = lines[1014].Substring(4),
                            //TISubF9 = lines[1015].Substring(14),
                            //TFF9 = lines[1250].Substring(4),

                            //Fase10 = lines[1256].Substring(12),
                            //DuracionTotalF10 = lines[1260].Replace(" ", String.Empty).Substring(21),

                            //Fase11 = lines[1264].Substring(12),
                            //DuracionTotalF11 = lines[1328].Replace(" ", String.Empty).Substring(21),

                            //Fase12 = lines[1332].Substring(12),
                            //DuracionTotalF12 = "Desconocida",

                            //Fase13 = "No",
                            //TFF13 = "No",
                            //TFSubF13 = "No",

                            HoraInicio = (lines.FirstOrDefault(s => s.Contains(HoraI)).Substring(22)).Trim(),
                            HoraFin = (lines.FirstOrDefault(s => s.Contains(HoraF)).Substring(22)).Trim(),

                            EsterilizacionN = (lines.FirstOrDefault(s => s.Contains(EsterN)).Substring(26)).Trim(),
                            TMinima = (lines.FirstOrDefault(s => s.Contains(TMin)).Replace(" ", String.Empty).Substring(25)).Trim(),
                            TMaxima = (lines.FirstOrDefault(s => s.Contains(Tmax)).Replace(" ", String.Empty).Substring(25)).Trim(),
                            DuracionTotal = (lines.FirstOrDefault(s => s.Contains(DFE)).Replace(" ", String.Empty).Substring(25)).Trim(),
                            FtzMin = (lines.FirstOrDefault(s => s.Contains(Fmin)).Replace(" ", String.Empty).Substring(11)).Trim(),
                            FtzMax = (lines.FirstOrDefault(s => s.Contains(Fmax)).Replace(" ", String.Empty).Substring(11)).Trim(),
                            AperturaPuerta = lines.FirstOrDefault(s => s.Contains(ok)).Trim(),
                            TiempoCiclo = "No",


                        };
                        lista.Add(row); //añado elementos

                    }
                    catch { }

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
                        //ciclos.Formato = s.Formato;
                        //ciclos.IdUsuario = s.IdUsuario;
                        ciclos.Fase1 = s.Fase1;
                        ciclos.DuracionTotalF1 = s.DuracionTotalF1;

                        ciclos.Fase2 = s.Fase2;
                        ciclos.DuracionTotalF2 = s.DuracionTotalF2;
              
                        //ciclos.Fase3 = s.Fase3;
                        //ciclos.DuracionTotalF3 = s.DuracionTotalF3;

                        //ciclos.Fase4 = s.Fase4;
                        //ciclos.DuracionTotalF4 = s.DuracionTotalF4;

                        //ciclos.Fase5 = s.Fase5;
                        //ciclos.DuracionTotalF5 = s.DuracionTotalF5;
                        //ciclos.TIF5 = s.TIF5;
                        //ciclos.TISubF5 = s.TISubF5;
                        //ciclos.TFF5 = s.TFF5;
                        //ciclos.TFSubF5 = s.TFSubF5;


                        //ciclos.Fase6 = s.Fase6;
                        //ciclos.DuracionTotalF6 = s.DuracionTotalF6;
                        //ciclos.TIF6 = s.TIF6;
                        //ciclos.TISubF6 = s.TISubF6;
                        //ciclos.TFF6 = s.TFF6;
                        //ciclos.TFSubF6 = s.TFSubF6;

                        //ciclos.Fase7 = s.Fase7;
                        //ciclos.DuracionTotalF7 = s.DuracionTotalF7;
                        //ciclos.TIF7 = s.TIF7;
                        //ciclos.TISubF7 = s.TISubF7;

                        //ciclos.Fase8 = s.Fase8;
                        //ciclos.DuracionTotalF8 = s.DuracionTotalF8;
                        //ciclos.TIF8 = s.TIF8;
                        //ciclos.TISubF8 = s.TISubF8;
                        //ciclos.TFF8 = s.TFF8;

                        //ciclos.Fase9 = s.Fase9;
                        //ciclos.DuracionTotalF9 = s.DuracionTotalF9;
                        //ciclos.TIF9 = s.TIF9;
                        //ciclos.TISubF9 = s.TISubF9;
                        //ciclos.TFF9 = s.TFF9;

                        //ciclos.Fase10 = s.Fase10;
                        //ciclos.DuracionTotalF10 = s.DuracionTotalF10;

                        //ciclos.Fase11 = s.Fase11;
                        //ciclos.DuracionTotalF11 = s.DuracionTotalF11;

                        //ciclos.Fase12 = s.Fase12;
                        //ciclos.DuracionTotalF12 = s.DuracionTotalF12;

                        //ciclos.Fase13 = s.Fase13;
                        //ciclos.TFF13 = s.TFF13;
                        //ciclos.TFSubF13 = s.TFSubF13;

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



















    

