using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Liga
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoTorneo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        //public List<Inscripcion> Inscripciones { get; set; }
        public List<Partido> Partidos { get; set; }
    }

}

