using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Modelo;
using test.Modelo.BaseDatos;

namespace test.DAL
{
    //public class ResumenDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<ResumenEntities>
    //{
    //    protected override void Seed(ResumenEntities context)
    //    {

    //        var listaResumen = new List<Resumen>
    //        {
    //        new Resumen {Id= 1 , Columna1="Carson", Columna2="adsdad", Columna3="10", Columna4="asdsda",Columna5="adadsdas", Columna6="asdsd"},
    //        new Resumen {Id= 1 , Columna1="asdsdn", Columna2="adsdad", Columna3="10", Columna4="asdsda",Columna5="adadsdas", Columna6="asdsd"},
    //        new Resumen {Id= 2 , Columna1="Casdsdn", Columna2="adsdad", Columna3="10", Columna4="asdsda",Columna5="adadsdas", Columna6="asdsd"},

    //        };
    //        listaResumen.ForEach(s => context.Columnas.Add(s));
    //        context.SaveChanges();

    //    }
    //}
}
