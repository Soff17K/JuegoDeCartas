using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas.Clases;

namespace JuegoDeCartas.Poker
{
    public class JuegoPoker : IJuego
    {
        public IDealer Dealer { get; set; }
        public bool JuegoTerminado { get; set; }

        public List<IJugador> jugadores;

        public JuegoPoker (IDealer dealer)
        {
            this.Dealer = dealer;
            jugadores = new List<IJugador> ();
        }

        public void AgregarJugador(IJugador jugador)
        {
            // Código para agregar un jugador al juego
        }

        public void IniciarJuego()
        {
            // Código para iniciar el juego
        }

        public void JugarRonda()
        {
            // Código para jugar una ronda del juego
        }

        public void MostrarGanador()
        {
            // Código para mostrar al ganador del juego
        }
    }
}
