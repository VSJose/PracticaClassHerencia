using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHerenciaVSJL.Clases
{
    class Cliente:Persona
    {
        String NIT;
        String Procedencia;

        public Cliente()
        {
            NIT = "--";
            Procedencia = "--";
        }

        public string NIT1
        {
            get
            {
                return NIT;
            }

            set
            {
                NIT = value;
            }
        }

        public string Procedencia1
        {
            get
            {
                return Procedencia;
            }

            set
            {
                Procedencia = value;
            }
        }
    }
}
