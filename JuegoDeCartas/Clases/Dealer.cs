using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Clases
{
    public class Dealer : IDealer
    {
        private readonly IDeckDeCartas _deckDeCartas;
        private readonly List<ICarta> _cartas;

        public Dealer(IDeckDeCartas deckDeCartas)
        {
            _deckDeCartas = deckDeCartas;
            _cartas = new List<ICarta>();
        }
        public void BarajearDeck()
        {
            _deckDeCartas.BarajearDeck();
        }

        public void RecogerCartas(List<ICarta> cartas)
        {
            if (cartas == null || cartas.Count == 0)
            {
                throw new ArgumentException("No se han proporcionado cartas para recoger");
            }

            foreach (var carta in cartas)
            {
                _deckDeCartas.MeterCarta(carta);
            }

            _cartas.Clear();
        }

        public List<ICarta> RepartirCartas(int numeroDeCartas)
        {
            if (numeroDeCartas <= 0)
            {
                throw new ArgumentException("El número de cartas a repartir debe ser mayor a 0");
            }

            for (int i = 0; i < numeroDeCartas; i++)
            {
                _cartas.Add(_deckDeCartas.SacarCarta(0));
            }

            return _cartas;
        }
    }

}
