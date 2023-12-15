using System.Collections.Generic;
using JuegoDeCartas.Enumeradores;
using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Clases;

namespace JuegoDeCartas.Poker
{
    internal class Poker
    {
        
    }

    
    public class Juego : IJuego
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


