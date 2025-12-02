using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos_Liga
{
    public class Detalle
    {
        public int Id { get; set; }
        public TipoEvento Tipo { get; set; } // Gol, Amarilla, Roja
        public int Minuto { get; set; }

        // FKs
        public int PartidoId { get; set; }
        public Partido Partido { get; set; }

        public int JugadorId { get; set; }
        public Jugador Jugador { get; set; }
    }

    public enum TipoEvento { Gol, TarjetaAmarilla, TarjetaRoja }
}
}
