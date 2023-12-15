using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JuegoDeCartas.Poker
{
    public class Jugador : IJugador
    {
        private List<ICarta> mano;

        public Jugador()
        {
            mano = new List<ICarta>();
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
            throw new NotImplementedException();
            /*Console.WriteLine("¿Quieres devolver alguna carta?");
             * La respuesta la poner en un switch
             * switch(respuesta)
             * {
             *   case 1(No):
             *   break;
             *   
             *   case2(Si):
             *   do
             *   {
             *     Console.Writeline("¿En qué posición está la carta que quieres devolver");

             *     funcion DevolverCarta(respuesta - 1) el -1 pq el índice de la lista empieza en 0
             *     después acá no se si sería crear un nuevo deck o usar uno ya existente en el juego pero ajá
             *     MeterCarta(carta devuelta);
             *     y después sacar otra carta para darsela
             *     SacarCarta(0);
             *     mano.Add(carta sacada); me imagino que se tendría que agregar en la posición de donde la sacó o no se
             *   while(si quiera devolver otra carta)
             *   { 
             *     Console.Writeline("¿Quieres devolver otra carta?");
             *   }
             * 
             * 
             * 
             * 
             */
        }

    }
}
