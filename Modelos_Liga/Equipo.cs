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

        //Relaciones
        public List<Jugador> Jugadores { get; set; }
        public List<Inscripcion> Inscripciones { get; set; }

        //Listas para diferenciar equipos (Local/Visitante)
        public List<Partido> PartidosComoLocar {  get; set; }
        public List<Partido> PartidosComoVisitante { get; set; }
    }
}
