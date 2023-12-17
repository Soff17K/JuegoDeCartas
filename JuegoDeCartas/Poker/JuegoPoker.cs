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

            var escalera9a5 = (mano == ValoresCartasEnum.Nueve && 
                    mano == ValoresCartasEnum.Ocho && 
                    mano == ValoresCartasEnum.Siete &&
                    mano == ValoresCartasEnum.Seis &&
                    mano == ValoresCartasEnum.Cinco);

            var escalera8a4 = (mano == ValoresCartasEnum.Ocho && 
                    mano == ValoresCartasEnum.Siete &&
                    mano == ValoresCartasEnum.Seis &&
                    mano == ValoresCartasEnum.Cinco &&
                    mano == ValoresCartasEnum.Cuatro);

            var escalera7a3 = (mano == ValoresCartasEnum.Siete &&
                    mano == ValoresCartasEnum.Seis &&
                    mano == ValoresCartasEnum.Cinco &&
                    mano == ValoresCartasEnum.Cuatro &&
                    mano == ValoresCartasEnum.Tres);

            var escalera6a2 = (mano == ValoresCartasEnum.Seis &&
                    mano == ValoresCartasEnum.Cinco &&
                    mano == ValoresCartasEnum.Cuatro &&
                    mano == ValoresCartasEnum.Tres &&
                    mano == ValoresCartasEnum.Dos);

            var escalera5aAs = (mano == ValoresCartasEnum.Cinco &&
                    mano == ValoresCartasEnum.Cuatro &&
                    mano == ValoresCartasEnum.Tres &&
                    mano == ValoresCartasEnum.Dos
                    mano == ValoresCartasEnum.As);

            var mismoPalo = (mano == FigurasCartasEnum.Espadas || mano == FigurasCartasEnum.Diamantes ||
                    mano == FigurasCartasEnum.Corazones || mano == FigurasCartasEnum.Treboles );

            var mismoNumero = (mano == ValoresCartasEnum.Rey || mano == ValoresCartasEnum.Reina ||
                mano == ValoresCartasEnum.Jota || mano == ValoresCartasEnum.Diez || mano == ValoresCartasEnum.Nueve ||
                mano == ValoresCartasEnum.Ocho || mano == ValoresCartasEnum.Siete || mano == ValoresCartasEnum.Seis || 
                mano == ValoresCartasEnum.Cinco || mano == ValoresCartasEnum.Cuatro || mano == ValoresCartasEnum.Tres ||
                mano == ValoresCartasEnum.Dos || mano == ValoresCartasEnum.As);

            var escaleraReal = ((mano == ValoresCartasEnum.As && 
                    mano == ValoresCartasEnum.Rey && 
                    mano == ValoresCartasEnum.Reina && 
                    mano == ValoresCartasEnum.Jota &&
                    mano == ValoresCartasEnum.Diez) && 
                    mismoPalo);

            var escaleraDeColor = ((escalera9a5 || escalera8a4 || escalera7a3 ||
                    escalera6a2 || escalera5aAs) && mismoPalo);

            var poker = (mismoNumero);

            var full = ((mismoNumero /*3*/ && mismoNumero /*2*/) && mismoPalo);

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
