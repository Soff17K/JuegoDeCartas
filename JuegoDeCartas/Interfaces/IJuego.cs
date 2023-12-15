﻿using System;
namespace JuegoDeCartas.Interfaces
{
	public interface IJuego
	{
		IDealer Dealer { get; }
		bool JuegoTerminado { get; }
		void AgregarJugador(IJugador jugador);
		void IniciarJuego();
		void JugarRonda();
		void MostrarGanador();
	}
}

