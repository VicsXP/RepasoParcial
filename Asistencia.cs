using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    internal class Asistencia
    {
        int noEmpleado;
        int horasTrabajadas;
        string mes;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public string Mes { get => mes; set => mes = value; }

    }
}
