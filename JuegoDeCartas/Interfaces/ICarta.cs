using System;
using JuegoDeCartas.Enumeradores;

namespace JuegoDeCartas.Interfaces
{
	public interface ICarta
	{
		FigurasCartasEnum Figura { get; }
		ValoresCartasEnum Valor { get; }
	}
}

