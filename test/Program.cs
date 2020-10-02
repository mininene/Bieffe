using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Modelo;
using test.Servicios.WriterBd;

namespace test
{
    class Program
    {


        static void Main(string[] args)
        {
            ////Wrapper.ConnectionWrapper con = new Wrapper.ConnectionWrapper();

            ////var ListaDatos = new List<ConnectionData>
            //// {
            ////     new ConnectionData { Version=4002, Ip="10.109.80.90", Remote="0827J07105.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveJ.txt" },
            ////     new ConnectionData { Version=4002, Ip="10.109.80.91", Remote="0828K10522.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveK.txt" },
            ////     new ConnectionData { Version=4001, Ip="10.109.80.92", Remote="1167L20683.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveL.txt" },
            ////     new ConnectionData { Version=37, Ip="10.109.80.83", Remote="8389C22477.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveC.txt" },
            //// };

            ////foreach (var item in ListaDatos)
            ////{
            ////    System.Threading.Thread.Sleep(1000);

            ////    float version = con.get_version();
            ////    Console.WriteLine(version);


            ////    uint handle = con.ConnectSession(item.Version, item.Ip);
            //uint handle = con.ConnectSession(4002, "10.109.80.90");
            // uint handle = con.ConnectSession(4002, "10.109.80.91");
            //uint handle = con.ConnectSession(4401, "10.109.80.92");
            //uint handle = con.ConnectSession(37, "10.109.80.83");

            ////Console.WriteLine("Valor de Sesion: " + handle);

            ////uint lhandle = con.ConnectApi(handle);
            ////Console.WriteLine("Valor de Conexion: " + lhandle);

            ////uint result = con.GetData(handle, item.Remote, item.Local);
            //uint result = con.GetData(handle, "0827J07105.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveJ.txt");
            // uint result = con.GetData(handle, "0828K10522.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveK.txt");
            //uint result = con.GetData(handle, "1167L20681.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveL.txt");
            //uint result = con.GetData(handle, "8389C22477.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveC.txt");

            ////Console.WriteLine("Resultado de getData: " + result);

            ////uint lasterror = con.GetError();
            ////Console.WriteLine("Valor Error: " + lasterror);

            ////Console.WriteLine("Cerrar Conexion valor: " + con.CloseConnection(ref handle));

            //    //StringBuilder abuffer= new StringBuilder(32);
            //    //string strout = abuffer.ToString();
            //    //Console.WriteLine(strout);
            //    ////Console.WriteLine(buffer.Capacity.ToString());
            //    ////Console.WriteLine("Mensaje de error string: " + s);
            //    //Console.WriteLine( con.GetMessage(lasterror,  abuffer));
            //    //Console.WriteLine("Mensaje de error: " + message.ToString());

            //}
            //using (var context = new HojaResumenDb())

            //{
            //    var stdQuery = (from d in context.Ciclos

            //                    select new { Id = d.IdAutoclave, Programador = d.Programador });

            //    foreach (var q in stdQuery)

            //    {

            //        Console.WriteLine("ID : " + q.Id + ", Nombre : " + q.Programador);

            //    }
            //}


            //using (var context = new HojaResumenDb())

            //{
            //    var query = from d in context.Ciclos.Where(x => x.Id == 63)
            //                select d;

            //    foreach (var q in query)

            //    {

            //        Console.WriteLine("ID: " + q.IdAutoclave+ " " + "Programador: "+  q.Programador +" "  + "Operador: " + " " + q.Operador);

            //    }

            //}






            //IRead lectura = new Read();
            //lectura.readFile();
            //IWriterDb writer = new WriterDb();
           // writer.WriteFile();
            //IWriterBd getWriter = new Writer();
            //getWriter.Writer();

            // Console.WriteLine("Escribiendo en la base de datos");


            List<string> nuevosRegistros = new List<string>();
            string path = @"C:\Users\fuenteI3\Desktop\ReportesGenerados\AutoClaveK.txt";
            string Programa = "PROGRAMA";
            string Programador = "PROGRAMAD.";
            string Operador = "OPERADOR";
            string CodigoP = " CODIGO PROD.";
            string Lote = "N.LOTE";
            string IdMaquina = "ID.MAQUINA";
            string Notas = "NOTAS";
            string FaseUno = "FASE    1";
            string FaseDos = "FASE    2";
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
            string DuracionF2 = "$DURAC.TOTAL FASE";
            string Tiempo = "+TIEMPO";
            string InicioT = "+";
            string FinalT = "<";

            string HoraI = " HORA COMIEN.PROGR.";
            string HoraF = " HORA FIN PROGRAMA";
            string EsterN = " ESTERILIZACION N.";
            string TMin = " TEMP.MIN.ESTERILIZACION";
            string Tmax = " TEMP.MAX.ESTERILIZACION";
            string DFE = " DURACION FASE DE ESTER.";
            string Fmin = " F(T,z) MIN.:";
            string Fmax = " F(T,z) MAX.:";
            string ok = "OK APERTURA";






            //string[] words = File.ReadAllLines(path, new UnicodeEncoding());

            //List<Row> nuevaLista = new List<Row>(); //declaro la lista que quiero cargar
            //Row row = new Row
            //{
            //    IdAutoclave="holaaa",
            //    //IdAutoclave = words.FirstOrDefault(s => s.Contains(IdMaquina)).Replace(" ", String.Empty).Substring(10),
            //    Fase1 = (words.FirstOrDefault(s => s.Contains(FaseUno))).Substring(12).Trim(),
            //    Fase2 = (words.FirstOrDefault(s => s.Contains(FaseDos))).Substring(12).Trim(),
            //    Fase3 = (words.FirstOrDefault(s => s.Contains(FaseTres))).Substring(12).Trim(),
            //    Fase4 = (words.FirstOrDefault(s => s.Contains(FaseCuatro))).Substring(12).Trim(),
            //    Fase5 = (words.FirstOrDefault(s => s.Contains(FaseCinco))).Substring(12).Trim(),
            //    Fase6 = (words.FirstOrDefault(s => s.Contains(FaseSeis))).Substring(12).Trim(),
            //    Fase7 = (words.FirstOrDefault(s => s.Contains(FaseSiete))).Substring(12).Trim(),
            //    Fase8 = (words.FirstOrDefault(s => s.Contains(FaseOcho))).Substring(12).Trim(),
            //    Fase9 = (words.FirstOrDefault(s => s.Contains(FaseNueve))).Substring(12).Trim(),
            //    Fase10 = (words.FirstOrDefault(s => s.Contains(FaseDiez))).Substring(12).Trim(),
            //    Fase11 = (words.FirstOrDefault(s => s.Contains(FaseOnce))).Substring(12).Trim(),
            //    Fase12 = (words.FirstOrDefault(s => s.Contains(FaseDoce))).Substring(12).Trim(),
            //    Fase13 = (words.FirstOrDefault(s => s.Contains(FaseTrece))).Substring(12).Trim(),

            //};

            //Console.WriteLine(row.IdAutoclave);
            //nuevaLista.Add(row); //añado elementos




            //Console.WriteLine(get0 );
            //Console.WriteLine(get1);
            //Console.WriteLine(get2);
            //Console.WriteLine(get3);

            string[] con = File.ReadAllLines(path, new UnicodeEncoding());
          
            var records = new List<string>();
            var records2 = new List<string>();
            var records3 = new List<string>();
            var records4 = new List<string>();
            var records5 = new List<string>();
            var records6 = new List<string>();
            string s = (@"#
<");
            var texts = File.ReadAllLines(path, new UnicodeEncoding());
            records = texts.Where(lines => lines.Contains("+"))
                          .ToList();

            records2 = texts.Where(lines => lines.Contains("$")).ToList(); 

            records3= texts.Where(lines => lines.Contains("$")).ToList();

            records4 = texts.Where(lines => lines.Contains("+FASE    5") || lines.Contains("$")).ToList();

            for (int i = 0; i < con.Length; i++)
            {
                if (con[i].Contains("+FASE    5") || con[i].Contains("+FASE    6") || con[i].Contains("+FASE    7")
                    || con[i].Contains("+FASE    8") || con[i].Contains("+FASE    9") && i >= 0)
                {
                    string res = con[i - 6] ;
                    string fo = con[i - 5];
                   Console.WriteLine(res);
                    Console.WriteLine(fo);
                    records5.Add(res);
                    records6.Add(fo);
                }
            }

            





            

            //Console.WriteLine(s);

            //records4.ForEach(r => Console.WriteLine(r.ToArray()));
            //Console.WriteLine(records4);

            List<Row> lista = new List<Row>(); //declaro la lista que quiero cargar

            Row row = new Row
            {
                IdAutoclave = records2[2],
                Notas= texts[12] + 13,
                TFF13 = records5[0],
            }; lista.Add(row); //añado elementos


            //foreach (var p in lista)
            //{
            //    Console.WriteLine(p.IdAutoclave + p.Notas + p.TFF13);
            //}








            //   var filter = File.ReadLines(path, new UnicodeEncoding())    

            //   .Where(lines => ((lines.Contains(IdMaquina) || (lines.Contains(Programa) || (lines.Contains(Programador) || (lines.Contains(Operador) || (lines.Contains(CodigoP)
            //|| (lines.Contains(Lote) || (lines.Contains(Notas) || (lines.Contains(FaseUno) || (lines.Contains(FaseDos) || (lines.Contains(FaseTres)
            //|| (lines.Contains(FaseCuatro) || (lines.Contains(FaseCinco) || (lines.Contains(FaseSeis) || (lines.Contains(FaseSiete) || (lines.Contains(FaseOcho)
            //|| lines.Contains(FaseNueve) || lines.Contains(FaseDiez) || lines.Contains(FaseOnce) || lines.Contains(FaseDoce) || lines.Contains(FaseTrece) || lines.Contains(DuracionF2)
            //|| lines.Contains(Tiempo) || lines.Contains(InicioT) || lines.Contains(HoraI) || lines.Contains(HoraF) || lines.Contains(EsterN) || lines.Contains(TMin)
            //|| lines.Contains(Tmax) || lines.Contains(DFE) || lines.Contains(Fmin) || lines.Contains(Fmax) || lines.Contains(" N. PROGRESIVO") || lines.Contains(" MODELO")))))))))))))))))).ToArray();
            //   int i = 0;
            //   foreach (var s in filter)
            //   {
            //       i++;
            //       Console.WriteLine("Linea: " + i + "         " + "  " + s);
            //   }


            //var filter = File.ReadAllLines(path, new UnicodeEncoding())
            //.Where(lines => ((lines.Contains("+") || lines.Contains("#")))).ToArray();
            //int i = 0;
            //string v = "";
            //foreach (var s in filter)
            //{
            //    i++;
            //    v = "\f" + s;
            //    Console.WriteLine("Linea: " + i + "         " + "  " + s);

            //}
            //Console.WriteLine(v);










            //File.Delete(path);

            //int index = 0;

            //foreach (string lines in con)
            //{
            //    int flag = 0;
            //    if (lines.Contains(IdMaquina) || (lines.Contains(Programa) || (lines.Contains(Programador) || (lines.Contains(Operador) || (lines.Contains(CodigoP)
            //         || (lines.Contains(Lote) || (lines.Contains(Notas) || (lines.Contains(FaseUno) || (lines.Contains(FaseDos) || (lines.Contains(FaseTres)
            //         || (lines.Contains(FaseCuatro) || (lines.Contains(FaseCinco) || (lines.Contains(FaseSeis) || (lines.Contains(FaseSiete) || (lines.Contains(FaseOcho)
            //         || lines.Contains(FaseNueve) || lines.Contains(FaseDiez) || lines.Contains(FaseOnce) || lines.Contains(FaseDoce) || lines.Contains(FaseTrece) || lines.Contains(DuracionF2)
            //         || lines.Contains(Tiempo) || lines.Contains(InicioT) || lines.Contains(HoraI) || lines.Contains(HoraF) || lines.Contains(EsterN) || lines.Contains(TMin)
            //         || lines.Contains(Tmax) || lines.Contains(DFE) || lines.Contains(Fmin) || lines.Contains(Fmax) || lines.AsQueryable.Contains(ok) )))))))))))))))


            //    {

            //            index++;


            //        nuevosRegistros.Add(lines);
            //    }
            //}
            //int pos = con.IndexOf("#");
            //Console.WriteLine(index);

            ////var x= nuevosRegistros.Split
            //int x = 0;
            //foreach (var s in nuevosRegistros)
            //{
            //    x++;

            //    Console.WriteLine(s.get +"                               " +"linea: " + x /*+System.Environment.NewLine*/);
            //}

            //var ciclos = new Ciclos();// Instancio objeto Ciclos


            //foreach (var s in nuevosRegistros)  //recorro la lista
            //{
            //    ciclos.IdAutoclave = String textStr[] = yourString.split("\\r\\n|\\n|\\r");
            //}


            //  var targetLines = File.ReadAllLines(path)
            //          .Select((x, i) => new { Line = x, LineNumber = i })
            //          .Where(x => x.Line.Contains(uno))
            //          .ToList();

            //foreach (var line in targetLines)
            //{
            //    Console.WriteLine("{0} : {1}", line.LineNumber, line.Line);
            //}



            //string[] lines = File.ReadAllLines(path, new UnicodeEncoding());


            //var testlines = from line in lines
            //                where line.Contains(uno)
            //                select line;

            //foreach (var x in testlines)
            //{
            //    Console.WriteLine(x);
            //}

            ////}
            //Console.WriteLine("Escribiendo en la base de datos...");







            Console.ReadKey();

        }











}
}


            

        
    


            

        
 








 






            
    
          
          
        



    


    

