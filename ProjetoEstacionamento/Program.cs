using System;
using System.Diagnostics.CodeAnalysis;
using ProjetoEstacionamento.Entities;

namespace ProjetoEstacionamento;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o preço inicial do seu estacionamento: ");
        decimal precoInicial = decimal.Parse(Console.ReadLine());
        Console.Write("Digite o preço por hora do seu estacionamento: ");
        decimal precPorHora = decimal.Parse(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial,precPorHora);
        bool ligado = true;
        while (ligado) 
        {
            Console.WriteLine("1.Cadastrar veículo\n" + 
                "2.Remover veículo\n" + 
                "3.Listar veículos\n" + 
                "4.Encerrar");
            Console.Write("Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: Console.Write("Digite a placa do veículo que deseja adicionar: ");
                    string placaAdicionar = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placaAdicionar);
                    Console.Clear();
                    break;
                case 2: Console.Write("Digite a placa do veículo que deseja remover: ");
                    string placaRemover = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placaRemover);
                    Console.Clear();
                    break;
                case 3: estacionamento.ListarVeiculos();
                    Console.Clear();
                    break;
                case 4: Console.WriteLine("Programa encerrado!");
                    ligado = false;
                    break;
            }
        }       
    }
}
