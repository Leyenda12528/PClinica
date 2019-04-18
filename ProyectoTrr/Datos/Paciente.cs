using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Datos
{
    public class Paciente
    {
        private int id_pac;
        private String nombre;
        private String apellido;
        private int edad;
        private String tel;
        private String dir;
        private String sangre;
        private String nombreC;
        private String telC;
        private int id_estado;

        public int ID_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public String TelC
        {
            get { return telC; }
            set { telC = value; }
        }

        public String NombreC
        {
            get { return nombreC; }
            set { nombreC = value; }
        }

        public String  Sangre
        {
            get { return sangre; }
            set { sangre = value; }
        }

        public String Direccion
        {
            get { return dir; }
            set { dir = value; }
        }

        public String Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int ID_pac
        {
            get { return id_pac; }
            set { id_pac = value; }
        }

    }
}
