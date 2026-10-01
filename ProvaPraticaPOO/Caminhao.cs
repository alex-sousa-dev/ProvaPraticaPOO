using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPraticaPOO
{
    internal class Caminhao
    {
        public class Caminhao : Veiculo, IManutencao
        {
            public int NumeroEixos { get; }

            public Caminhao(
                string identificacao,
            double capacidadeCarga,
            string tipoCombustivel,
                int numeroEixos)
                : base(identificacao, capacidadeCarga, tipoCombustivel);
            {
                NumeroEixos = numeroEixos;
            }

            public override string RegistrarEntrega()
            {
                IncrementarEntrega();

                return $"Entrega registrada pelo caminhão {Identificacao}.";
            }

            public string RealizarManutencao()
            {
                return $"Caminhão {Identificacao}: revisão dos freios realizada.";
            }
        }

    }
}
