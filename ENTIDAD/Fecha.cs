using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Fecha
    {

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }

        public Fecha() { }

        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
        }
    }
        
}
