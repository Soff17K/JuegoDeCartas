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
            jugadores.Add(jugador);
        }

        public void IniciarJuego()
        {
          
            Dealer.BarajearDeck();
            foreach(var jugador in jugadores)
            {
                Dealer.RepartirCartas(5);
                jugador.MostrarCartas();
            }  

        }

        public void JugarRonda()
        {
            foreach(var jugador in jugadores)
            {
                jugador.RealizarJugada();
            }
        }

        public void MostrarGanador()
        {
            // Código para mostrar al ganador del juego
        }
    }
}
