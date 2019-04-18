using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Datos
{
    public class Usuario
    {
        private String nombre;
        private String apellido;
        private int id_user;
        private int edad;
        private String telefono;        
        private String usuario;
        private String pass;
        private int id_especialidad;
        private String especialidad;
        private int id_estado;

        public int ID_estdo
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public String Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }


        public int ID_especialidad
        {
            get { return id_especialidad; }
            set { id_especialidad = value; }
        }

        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public String User
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
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

    }
}
