using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Metrics;
using JuegoDeCartas.Clases;

namespace JuegoDeCartas.Poker
{
    public class Jugador : IJugador
    {
        private List<ICarta> mano;
        private List<ICarta> nuevaMano;

        public Jugador()
        {
            mano = new List<ICarta>();
            nuevaMano = new List<ICarta>();
        }

        public ICarta DevolverCarta(int indiceCarta)
        {
            if (indiceCarta < 0 || indiceCarta >= mano.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera del rango de la mano del jugador");
            }
            else
            {

                var carta = mano[indiceCarta];
                mano.RemoveAt(indiceCarta);

                return carta;
            }

        }

        public List<ICarta> DevolverTodasLasCartas()
        {
            var todasLasCartas = new List<ICarta>(mano);
            mano.Clear();
            return todasLasCartas;
        }

        public ICarta MostrarCarta(int indiceCarta)
        {
            if (indiceCarta < 0 || indiceCarta >= mano.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera del rango de la mano del jugador");

            }
            else
            {

                return mano[indiceCarta];
            }
        }

        public List<ICarta> MostrarCartas()
        {
            return mano;
        }

        public void ObtenerCartas(List<ICarta> cartas)
        {
            mano.AddRange(cartas);
        }

        public void RealizarJugada()
        {

            Deck deck = new Deck();
            
            System.Console.WriteLine("¿Quieres devolver alguna carta?");
            Random rnd = new Random();

            int eleccion = rnd.Next(1,2+1);

            switch(eleccion){
                case 1:
                
                    break;

                case 2:

                    bool seguir = true;

                    do {
                        System.Console.WriteLine("¿En qué posición está la carta a devolver?");
                        int posicionDevolver = rnd.Next(1, 5+1);


                        if (posicionDevolver >= 0 && posicionDevolver < mano.Count)
                        {
                            ICarta cartaDevuelta = DevolverCarta(posicionDevolver);

                            nuevaMano.Add(cartaDevuelta); // Mete la carta devuelta en otro mazo

                            ICarta cartaSacada = deck.SacarCarta(0); // Saca una carta del mazo principal

                            mano.Add(cartaSacada); // Mete la carta sacada al mazo del jugador

                            System.Console.WriteLine("¿Quieres devolver otra carta?");
                            int eleccion2 = rnd.Next(1, 2 + 1);

                            if (eleccion2 == 1)
                            {
                                seguir = true;
                            }
                            else if (eleccion2 == 2)
                            {
                                seguir = false;
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("La posición ingresada no es válida. Inténtalo de nuevo.");
                        }

                        
                    } while (seguir == true);

                    break;
                
            }

        }

    }
}
