using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHerenciaVSJL.Clases
{
    class Empleado:Persona
    {
        private int codEmpleado;
        private String Direccion;

        public Empleado()
        {
            this.codEmpleado = 0;
            Direccion = "--";
        }

        public int CodEmpleado
        {
            get
            {
                return codEmpleado;
            }

            set
            {
                codEmpleado = value;
            }
        }

        public string Direccion1
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }
    }
}
