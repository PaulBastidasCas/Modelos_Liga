using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Liga
{
    public class Partido
    {
        public int Id { get; set; }
        public DateTime FechaJuego { get; set; }
        public string Fase { get; set; } 
        public bool Programado { get; set; }

        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }

        public int TorneoId { get; set; }
        public Torneo Torneo { get; set; }

        public int EquipoLocalId { get; set; }
        //public Equipo EquipoLocal { get; set; }

        public int EquipoVisitanteId { get; set; }
        //public Equipo EquipoVisitante { get; set; }

        //public List<DetallePartido> Detalles { get; set; }
    }


}

