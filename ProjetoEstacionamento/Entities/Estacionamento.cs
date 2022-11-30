using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjetoEstacionamento.Entities;

public class Estacionamento
{
    public decimal PrecoInicial { get; set; }
    public decimal PrecoPorHora { get; set; }
    public List<string> Veiculos { get; set; }
   
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        PrecoInicial = precoInicial;
        PrecoPorHora = precoPorHora;
        List<string> veiculo = new List<string>();
        Veiculos = veiculo;
    }

    public void AdicionarVeiculo(string placa)
    {
        placa.ToLower();
        string veiculo = new string(placa);
        Veiculos.Add(veiculo);
        Console.WriteLine("Veículo adicionado com sucesso!");
        Console.ReadLine();

    }
    public void RemoverVeiculo()
    {
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Não existem veículos estacionados");
        }
        else
        {
            Console.Write("Digite a placa do veículo que deseja remover: ");
            string placa = Console.ReadLine();
            placa.ToLower();
            bool a = Veiculos.Contains(placa);
            if (a)
            {
                Console.Write("Favor digitar o tempo de permanência do veículo em horas: ");
                int tempoDePermanência = int.Parse(Console.ReadLine());
                decimal total = PrecoInicial + PrecoPorHora * tempoDePermanência;
                Console.WriteLine($"Preço a ser pago: R${total}, Remover veículo?(s/n)");
                string resposta = Console.ReadLine();
                resposta.ToLower();
                if (resposta == "s")
                {
                    Veiculos.Remove(placa);
                    Console.WriteLine("Veículo removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Veículo não removido!");
                }               
            }
            else if (!a)
            {
                Console.WriteLine("Veículo não cadastrado, favor verificar a placa!");
            }
        }
        Console.ReadLine();

    }
    public void ListarVeiculos()
    {
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Não existem veículos estacionados!");
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Lista de veículos cadastrados:");
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
            Console.ReadLine();
        }
    }

}
