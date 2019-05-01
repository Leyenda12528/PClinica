using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Datos
{
    public class Consulta
    {
        private int id_consulta;
        private int id_pac;
        private int id_doc;        
        private int categoria;
        private int puntaje;                
        private String salida;
        private int id_estado;
        private List<int> listaSintomas;

        public List<int> ListaSintomas
        {
            get { return listaSintomas; }
            set { listaSintomas = value; }
        }


        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public String Salida
        {
            get { return salida; }
            set { salida = value; }
        }

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public int Id_doc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }

        public int Id_pac
        {
            get { return id_pac; }
            set { id_pac = value; }
        }

        public int Id_consulta
        {
            get { return id_consulta; }
            set { id_consulta = value; }
        }

    }
}
