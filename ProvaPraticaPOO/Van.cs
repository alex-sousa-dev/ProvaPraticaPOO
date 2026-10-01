using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPraticaPOO
{
    internal class Van
    {
        public class Van : Veiculo, IManutencao
        {
            public bool PossuiRefrigeracao { get; }

            public Van(
                string identificacao,
                double capacidadeCarga,
                string tipoCombustivel,
                bool possuiRefrigeracao)
                : base(identificacao, capacidadeCarga, tipoCombustivel)
            {
                PossuiRefrigeracao = possuiRefrigeracao;
            }

            public override string RegistrarEntrega()
            {
                IncrementarEntrega();

                return $"Entrega registrada pela van {Identificacao}.";
            }

            public string RealizarManutencao()
            {
                return $"Van {Identificacao}: revisão dos pneus realizada.";
            }
        }

    }
}
