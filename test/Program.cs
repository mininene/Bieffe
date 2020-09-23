using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace test
{
    class Program
    {
   

        //public class Libreria
        //{

        //    //[DllImport("th4log.dll", EntryPoint = "sesion", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        //    //public static extern long th4_initSession(int version, string ipaddress);
            
        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern float th4_version();

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern uint th4_initSession(int version, [MarshalAs(UnmanagedType.LPStr)] string ipaddress);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern uint th4_connect(uint handle);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_test(string name);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_readFile(long handle, string remotefile, string localfile);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_lasterror();

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_close(long ls_handle);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_message(long errorcode, string message);

        //    [DllImport("th4log.dll", CallingConvention = CallingConvention.StdCall)]
        //    public static extern long th4_debug(long asl_debug);



        //}

        static void Main(string[] args)
        {
            Wrapper.ConnectionWrapper con = new Wrapper.ConnectionWrapper();

            Console.WriteLine(con.get_version());

            uint handle = con.ConnectSession(4002, "10.109.80.91");
            Console.WriteLine("Valor de Sesion: "+ handle);

            uint lhandle= con.ConnectApi(handle);
            Console.WriteLine("Valor de Conexion: "+ lhandle);

            
            uint result= con.GetData(handle, "0828K10522.LOG", "C:\\Users\\fuenteI3\\Desktop\\hola.txt");

            Console.WriteLine("Resultado de get"+ result);

            con.CloseConnection(ref handle);

           

          Console.ReadKey();
        }
    }
}
            

        
 








 






            
    
          
          
        



    


    

