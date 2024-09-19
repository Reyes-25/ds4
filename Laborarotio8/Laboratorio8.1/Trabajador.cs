using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._1
{
    class Trabajador : Persona
    {
        // Campo de cada objeto Trabajador que almacena cuanto gana
        public int Sueldo;
        Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {   // Inicializamos cada Trabajador en base al constructor de Persona
            Sueldo = sueldo;
        }
    }
}
