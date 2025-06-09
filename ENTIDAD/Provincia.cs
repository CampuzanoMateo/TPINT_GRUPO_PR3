using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Provincia
    {
        public int idProvincia {  get; set; }
        public string descripcionProvincia { get; set; }

        public Provincia() { }

        public Provincia(int id, string decripcion)
        {
            idProvincia = id;
            descripcionProvincia = decripcion;
        }
    }
}
