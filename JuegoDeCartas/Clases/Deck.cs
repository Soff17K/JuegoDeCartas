using JuegoDeCartas.Enumeradores;
using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Clases
{
    public class Deck : IDeckDeCartas
    {
        private List<ICarta> _deck;

        public Deck()
        {
            _deck = new List<ICarta>();

            var figuras = Enum.GetValues(typeof(FigurasCartasEnum)).Cast<FigurasCartasEnum>().ToList();
            var valores = Enum.GetValues(typeof(ValoresCartasEnum)).Cast<ValoresCartasEnum>().ToList();

            foreach (var figura in figuras)
            {
                foreach (var valor in valores)
                {
                    _deck.Add(new Carta(figura, valor));
                }
            }
        }

        public void BarajearDeck()
        {
            var rnd = new Random();
            _deck = _deck.OrderBy(x => rnd.Next()).ToList();
        }

        public void MeterCarta(ICarta carta)
        {
            if (carta == null)
            {
                throw new ArgumentNullException("La carta a meter no puede ser nula");
            }

            _deck.Add(carta);
        }

        public void MeterCarta(List<ICarta> cartas)
        {
            if (cartas != null &&  cartas.Count > 0)
            {
                _deck.AddRange(cartas);
            }
        }

        public ICarta SacarCarta(int indiceCarta)
        {
            if (indiceCarta < 0 || indiceCarta >= _deck.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera del rango del mazo");
            }

            var carta = _deck[indiceCarta];
            _deck.RemoveAt(indiceCarta);

            return carta;
        }

        public ICarta VerCarta(int indiceCarta)
        {
            if (indiceCarta >= 0 && indiceCarta <= _deck.Count)
            {
                return _deck[indiceCarta];
            }
            else
            {
                throw new IndexOutOfRangeException("El índice de la carta está fuera de rango");
            }
        }
    }
}
