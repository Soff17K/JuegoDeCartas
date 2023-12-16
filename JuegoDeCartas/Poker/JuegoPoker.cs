using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas.Deck;

namespace JuegoDeCartas.Poker
{
    public class JuegoPoker : IJuego
    {
        public IDealer Dealer { get; set; }
        public bool JuegoTerminado { get; set; }

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
