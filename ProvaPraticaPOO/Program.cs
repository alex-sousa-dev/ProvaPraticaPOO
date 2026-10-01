using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPraticaPOO
{
    internal class Program
    {
        class Program
        {
            static void Main()
            {
                Caminhao caminhao = new Caminhao(
                    "CAM-001",
                    15000,
                    "Diesel",
                    6
                );

                Van van = new Van(
                    "VAN-001",
                    1500,
                    "Flex",
                    true
                );

              
                Console.WriteLine(caminhao.RegistrarEntrega());
                Console.WriteLine(caminhao.RegistrarEntrega());

            
                Console.WriteLine(van.RegistrarEntrega());
                Console.WriteLine(van.RegistrarEntrega());

                Console.WriteLine();

               
                IManutencao manutencaoCaminhao = caminhao;
                IManutencao manutencaoVan = van;

                Console.WriteLine(manutencaoCaminhao.RealizarManutencao());
                Console.WriteLine(manutencaoVan.RealizarManutencao());

                Console.WriteLine();

           
                ExibirDados(caminhao);
                ExibirDados(van);
            }

            static void ExibirDados(Veiculo veiculo)
            {
                Console.WriteLine("----- Dados do Veículo -----");
                Console.WriteLine($"Identificação: {veiculo.Identificacao}");
                Console.WriteLine($"Capacidade de carga: {veiculo.CapacidadeCarga} kg");
                Console.WriteLine($"Combustível: {veiculo.TipoCombustivel}");
                Console.WriteLine($"Quantidade de entregas: {veiculo.QuantidadeEntregas}");
                Console.WriteLine();
            }
        }

    }
}
