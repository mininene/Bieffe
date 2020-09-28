

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using test.DAL;
using test.Modelo;
using test.Modelo.BaseDatos;
using test.Servicios.Reader;
using test.Servicios.WriterDb;
using static System.Net.Mime.MediaTypeNames;


namespace test
{
    class Program
    {


        static void Main(string[] args)
        {
            Wrapper.ConnectionWrapper con = new Wrapper.ConnectionWrapper();

            //var ListaDatos = new List<ConnectionData>
            // {
            //     new ConnectionData { Version=4002, Ip="10.109.80.90", Remote="0827J07105.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveJ.txt" },
            //     new ConnectionData { Version=4002, Ip="10.109.80.91", Remote="0828K10522.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveK.txt" },
            //     new ConnectionData { Version=4001, Ip="10.109.80.92", Remote="1167L20683.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveL.txt" },
            //     new ConnectionData { Version=37, Ip="10.109.80.83", Remote="8389C22477.LOG", Local="C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveC.txt" },
            // };

            //foreach (var item in ListaDatos)
            //{
            //    System.Threading.Thread.Sleep(1000);

            //    float version = con.get_version();
            //    Console.WriteLine(version);


            //    uint handle = con.ConnectSession(item.Version, item.Ip);
            //    //uint handle = con.ConnectSession(4002, "10.109.80.90");
            //    // uint handle = con.ConnectSession(4002, "10.109.80.91");
            //    //uint handle = con.ConnectSession(4401, "10.109.80.92");
            //    //uint handle = con.ConnectSession(37, "10.109.80.83");

            //    //Console.WriteLine("Valor de Sesion: " + handle);

            //    uint lhandle = con.ConnectApi(handle);
            //    Console.WriteLine("Valor de Conexion: " + lhandle);

            //    uint result = con.GetData(handle, item.Remote, item.Local);
            //    //uint result = con.GetData(handle, "0827J07105.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveJ.txt");
            //    // uint result = con.GetData(handle, "0828K10522.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveK.txt");
            //    //uint result = con.GetData(handle, "1167L20681.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveL.txt");
            //    //uint result = con.GetData(handle, "8389C22477.LOG", "C:\\Users\\fuenteI3\\Desktop\\ReportesGenerados\\AutoClaveC.txt");

            //    Console.WriteLine("Resultado de getData: " + result);

            //    uint lasterror = con.GetError();
            //    Console.WriteLine("Valor Error: " + lasterror);

            //    Console.WriteLine("Cerrar Conexion valor: " + con.CloseConnection(ref handle));

            //    //StringBuilder abuffer= new StringBuilder(32);
            //    //string strout = abuffer.ToString();
            //    //Console.WriteLine(strout);
            //    ////Console.WriteLine(buffer.Capacity.ToString());
            //    ////Console.WriteLine("Mensaje de error string: " + s);
            //    //Console.WriteLine( con.GetMessage(lasterror,  abuffer));
            //    //Console.WriteLine("Mensaje de error: " + message.ToString());

            //}
            //using (var context = new ResumenEntities())

            //{
            //      var stdQuery = (from d in context.Columnas

            //                    select new { Id = d.Id, Name = d.Columna1 });

            //    foreach (var q in stdQuery)

            //    {

            //        Console.WriteLine("ID : " + q.Id + ", Name : " + q.Name);

            //    }




            //IRead lectura = new Read();
            //lectura.readFile();
            IWriterDb writer = new WriterDb();
            writer.WriteFile();

            Console.WriteLine("Escribiendo en la base de datos");




            Console.ReadKey();

        }






           
                }




            }

        
    


            

        
 








 






            
    
          
          
        



    


    

