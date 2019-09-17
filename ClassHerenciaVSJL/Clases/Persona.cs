using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHerenciaVSJL.Clases
{
    class Persona
    {
        private String Nombre;
        private String Apellido;
        private String CI;

        public Persona()
        {
            Nombre = "--";
            Apellido = "--";
            CI = "--";
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }

        public string CI1
        {
            get
            {
                return CI;
            }

            set
            {
                CI = value;
            }
        }
    }
}
