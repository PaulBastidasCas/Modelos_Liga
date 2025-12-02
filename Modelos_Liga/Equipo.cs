using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Liga
{
    public class Equipo
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Jugador>? Jugadores { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }

        public List<Partido>? PartidosComoLocal { get; set; }
        public List<Partido>? PartidosComoVisitante { get; set; }
    }
}
