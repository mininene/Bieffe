using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using test.Servicios.Factory;
using static System.Net.Mime.MediaTypeNames;


namespace test
{
    class Program
    {
   

        static void Main(string[] args)
        {
            Wrapper.ConnectionWrapper con = new Wrapper.ConnectionWrapper();

            float version = con.get_version();
            Console.WriteLine(version);

            uint handle = con.ConnectSession(4002, "10.109.80.91");
            Console.WriteLine("Valor de Sesion: "+ handle);

            uint lhandle= con.ConnectApi(handle);
            Console.WriteLine("Valor de Conexion: "+ lhandle);

            uint result= con.GetData(handle, "0828K10522.LOG", "C:\\Users\\fuenteI3\\Desktop\\patata.txt");
            Console.WriteLine("Resultado de getData: "+ result);

            uint lasterror = con.GetError();
            Console.WriteLine("Valor Error: " + lasterror);

            Console.WriteLine("Cerrar Conexion valor: " + con.CloseConnection(ref handle));

            //StringBuilder abuffer= new StringBuilder(32);
            //string strout = abuffer.ToString();
            //Console.WriteLine(strout);
            ////Console.WriteLine(buffer.Capacity.ToString());
            ////Console.WriteLine("Mensaje de error string: " + s);
            //Console.WriteLine( con.GetMessage(lasterror,  abuffer));
            //Console.WriteLine("Mensaje de error: " + message.ToString());


           IReadFactory lectura = new ReadFactory();
           lectura.readFile();
            
           


            Console.ReadKey();
        }
    }
}
            

        
 








 






            
    
          
          
        



    


    

