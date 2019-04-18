using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Base
{
    public class Conexion
    {
        private static String servidor = "LAPTOP-4P7F97LR";
        private static String usuario = "sa";
        private static String clave = "Leyenda12528";
        private static String db = "Proyecto";
        public static String cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
    }
}
