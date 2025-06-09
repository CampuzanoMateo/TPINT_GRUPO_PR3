using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Medico
    {
        /*
        private int idMedico;
        private int legajoMedico;
        private int dniMedico;
        private int idEspecialidadMedico;
        private string nombreMedico;
        private string apellidoMedico;
        private string sexoMedico;
        private string nacionalidadMedico;
        private Fecha FechaNaciminetoMedico;
        private string direccionMedico;
        private string localidadMedico;
        private int idProvincia_Medico;
        private string correoMedico;
        private string telefonoMedico;
        */

        public int idMedico { get; set; }
        public int legajoMedico { get; set; }
        public int dniMedico { get; set; }
        public int idEspecialidadMedico { get; set; }
        public string nombreMedico { get; set; }
        public string apellidoMedico { get; set; }
        public string sexoMedico { get; set; }
        public string nacionalidadMedico { get; set; }
        public Fecha fechaNacimientoMedico { get; set; }
        public string direccionMedico { get; set; }
        public string localidadMedico { get; set; }
        public int idProvincia_Medico { get; set; }
        public string correoMedico { get; set; }
        public string telefonoMedico { get; set; }
        /*
        public string diasMedico {  get; set; }
        public string horariosAtencionMedico { get; set; }
        */

        public Medico() { }

        public Medico(int id, int legajo, int dni, int idEspecialidad,
                  string nombre, string apellido, string sexo, string nacionalidad,
                  Fecha fechaNacimiento, string direccion, string localidad,
                  int idProvincia, string correo, string telefono)
        {
            idMedico = id;
            legajoMedico = legajo;
            dniMedico = dni;
            idEspecialidadMedico = idEspecialidad;
            nombreMedico = nombre;
            apellidoMedico = apellido;
            sexoMedico = sexo;
            nacionalidadMedico = nacionalidad;
            fechaNacimientoMedico = fechaNacimiento;
            direccionMedico = direccion;
            localidadMedico = localidad;
            idProvincia_Medico = idProvincia;
            correoMedico = correo;
            telefonoMedico = telefono;
        }
    }
}
