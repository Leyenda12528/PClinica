using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Datos
{
    class Consulta_Sintomas
    {
        private int id_consulta;
        private String salida;
        private int categoria;

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public String Salida
        {
            get { return salida; }
            set { salida = value; }
        }

        public int ID_Consulta
        {
            get { return id_consulta; }
            set { id_consulta = value; }
        }

    }
}
