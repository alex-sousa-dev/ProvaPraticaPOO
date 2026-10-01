using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPraticaPOO
{
    internal class Veiculo
    {
        public abstract class Veiculo
        {
            public string Identificacao { get; }
            public double CapacidadeCarga { get; }
            public string TipoCombustivel { get; }

            public int QuantidadeEntregas { get; private set; }

            public Veiculo(string identificacao, double capacidadeCarga, string tipoCombustivel)
            {
                Identificacao = identificacao;
                CapacidadeCarga = capacidadeCarga;
                TipoCombustivel = tipoCombustivel;
                QuantidadeEntregas = 0;
            }

            protected void IncrementarEntrega()
            {
                QuantidadeEntregas++;
            }

            public abstract string RegistrarEntrega();
        }

    }
}
