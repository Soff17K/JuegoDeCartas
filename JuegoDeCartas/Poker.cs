using System.Collections.Generic;
using ProyectoOrdinario.Enumeradores;
using ProyectoOrdinario.Interfaces;

namespace JuegoDeCartas
{
    internal class Poker
    {
        
    }

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }

    public class Carta : ICarta
    {
        public FigurasCartasEnum Figura { get; set; }
		public ValoresCartasEnum Valor { get; set; }

		public Carta(FigurasCartasEnum figura, ValoresCartasEnum valor)
		{
			Figura = figura;
			Valor = valor;
		}
    }

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
            } else {

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

            } else {
                
                return mano[indiceCarta];
            }
        }

        public List<ICarta> MostrarCartas()
        {
            throw new NotImplementedException();
        }

        public void ObtenerCartas(List<ICarta> cartas)
        {
            throw new NotImplementedException();
        }

        public void RealizarJugada()
        {
            throw new NotImplementedException();
        }

        private void ValidarIndiceCarta(int indiceCarta)
    {
        if (indiceCarta < 0 || indiceCarta >= mano.Count)
        {
            throw new ArgumentOutOfRangeException("Índice fuera del rango de la mano del jugador");
        }
    }
    }

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


