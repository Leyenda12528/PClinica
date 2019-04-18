using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTrr.Datos
{
    public class Sintomas
    {
        private int id_sintoma;
        private String sintoma;
        private int puntaje;
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        public String Sintoma
        {
            get { return sintoma; }
            set { sintoma = value; }
        }

        public int Id_Sintoma
        {
            get { return id_sintoma; }
            set { id_sintoma = value; }
        }

    }
}
