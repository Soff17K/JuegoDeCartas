using JuegoDeCartas.Enumeradores;
using JuegoDeCartas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Clases
{
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
}
