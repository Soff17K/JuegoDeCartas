using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoDeCartas.Clases;
using JuegoDeCartas.Enumeradores;

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

            var escaleraReal = ((mano == ValoresCartasEnum.As && 
                    mano == ValoresCartasEnum.Rey && 
                    mano == ValoresCartasEnum.Reina && 
                    mano == ValoresCartasEnum.Jota &&
                    mano == ValoresCartasEnum.Diez) && 
                    (mano == FigurasCartasEnum.Espadas || mano == FigurasCartasEnum.Diamantes ||
                    mano == FigurasCartasEnum.Corazones || mano == FigurasCartasEnum.Treboles ));

            var escaleraDeColor = 

            for (int i = 0; i < jugadores.Count; i++)
            {
                foreach (var mano in jugadores){
                    
                    if (escaleraReal){

                        System.Console.WriteLine($"¡Jugador {i} ganó la partida con una escalera real!");

                    }
                    
                }
            }

        }
    }
}
