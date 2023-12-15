using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas._21_BlackJack
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
        }

    }
}
