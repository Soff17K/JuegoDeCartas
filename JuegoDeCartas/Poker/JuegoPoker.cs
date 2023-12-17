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

            /*foreach (var jugador in jugadores){

                var mano = jugador.MostrarCartas();

                foreach (var carta in mano){

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

                    var poker = (mismoNumero); // aqui se vería verificar cuál es el valor de la quinta carta

                    var full = ((mismoNumero && mismoNumero)); // aqui se debe comparar 3 cartas con mismo valor con 2 cartas de mismo valor

                    var color = mismoPalo; // aqui la carta más alta debería verificar el valor de la mano

                    var escalera = (escalera9a5 || escalera8a4 || escalera7a3 || escalera6a2 || escalera5aAs);
                    
                    var trio = (mismoNumero); // aquí debería verificar si hay 3 cartas del mismo valor

                    var doblePareja = (mismoNumero && mismoNumero ); // aquí debería verificar si hay dos parejas de cartas del mismo valor
                    
                    var pareja = (mismoNumero); // aqui debería verificar si hay dos cartas del mismo valor

                    var cartaMasAlta = (mismoNumero); // aquí realmente debería simplemente seleccionar la carta más alta

                    if (escaleraReal){

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una escalera real!");

                    }
                    else if (escaleraDeColor) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una escalera de color!");

                    }
                    else if (poker) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con un poker!");

                    }
                    else if (full) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con un full!");

                    }
                    else if (color) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con un 'color'!");

                    }
                    else if (escalera) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una escalera!");

                    }
                    else if (trio) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con un trio!");

                    }
                    else if (doblePareja) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una doble pareja!");

                    }
                    else if (pareja) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una pareja!");

                    }
                    else if (cartaMasAlta) {

                        System.Console.WriteLine($"¡Jugador # ganó la partida con una carta más alta!");

                    }

                }

            }*/
        }
    }
}
