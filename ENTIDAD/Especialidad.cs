using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Especialidad
    {
        public int idEspecialidad {  get; set; }
        public string descripcionEspecialidad { get; set; }

        public Especialidad() { }

        public Especialidad(int id , string descripcion)
        {
            idEspecialidad = id;
            descripcionEspecialidad = descripcion;

        }
 
    }
}
