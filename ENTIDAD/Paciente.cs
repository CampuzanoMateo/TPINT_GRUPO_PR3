using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ENTIDAD
{
    public class Paciente
    {
        /*
        private int dniPaciente;
        private string nombrePaciente;
        private string apellidoPaciente;
        private string sexoPaciente;
        private string nacionalidadPaciente;
        private string direccionPaciente;
        private string localidadPaciente;
        private int idProvincia_Paciente;
        private string correoPaciente;
        private string telefonoPaciente;
        private Fecha FechaNaciminetoPaciente;
        */


        public int dniPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }
        public string sexoPaciente { get; set; }
        public string nacionalidadPaciente { get; set; }
        public string direccionPaciente { get; set; }
        public string localidadPaciente { get; set; }
        public int idProvincia_Paciente { get; set; }
        public string correoPaciente { get; set; }
        public string telefonoPaciente { get; set; }
        public Fecha fechaNacimientoPaciente { get; set; }

        public Paciente() { }

        public Paciente(int dni, string nombre, string apellido, string sexo, string nacionalidad,
                        string direccion, string localidad, int idProvincia, string correo,
                        string telefono, Fecha fechaNacimiento)
        {
            dniPaciente = dni;
            nombrePaciente = nombre;
            apellidoPaciente = apellido;
            sexoPaciente = sexo;
            nacionalidadPaciente = nacionalidad;
            direccionPaciente = direccion;
            localidadPaciente = localidad;
            idProvincia_Paciente = idProvincia;
            correoPaciente = correo;
            telefonoPaciente = telefono;
            fechaNacimientoPaciente = fechaNacimiento;
        }    
        
    }
}
