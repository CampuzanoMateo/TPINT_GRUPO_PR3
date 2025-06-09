using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Turno
    {
        public int idTurno {  get; set; }
        public int idEspecialidad_Turno { get; set; }
        public int dniPaciente_Turno { get; set; }
        public Fecha diaTurno { get; set; }
        /*
        public int horario { get; set; }
        */
        public string estadoTurno { get; set; }
        public string observacionesTurno { get; set; }

        public Turno() { }

        public Turno (int idT, int idE, int dni , Fecha dia , string estado, string observaciones)
        {
            idTurno = idT;
            idEspecialidad_Turno = idE;
            dniPaciente_Turno = dni;
            diaTurno = dia;
            estadoTurno = estado;
            observacionesTurno = observaciones;
        }
        

    }
}
