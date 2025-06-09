using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Localidad
    {
        public int idLocalidad { get; set; }
        public string descripcionLocalidad { get; set; }

        public Localidad() { }

        public Localidad(int id, string descripcion)
        {
            idLocalidad = id;
            descripcionLocalidad = descripcion;
        }

    }
}

