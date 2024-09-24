using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BEM VINDO AO CINERAPHA 3DMAX");
        Console.WriteLine("Aperte um botão para continuar");
        Console.WriteLine("1. Comprar Ingressos");
        Console.WriteLine("2. Ver historico de compras");

        var escolha = Console.ReadLine();
        var continuar = 1;
        List<string> historico = new List<string>(); 

        while (continuar != 0)
        {
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Quantos ingressos deseja comprar?");
                    int quant = Convert.ToInt32(Console.ReadLine());
                    double preco = quant * 25.00;

                    Console.WriteLine("Deseja informar cupom?");
                    Console.WriteLine("1. Sim // 2. Não");
                    var inserirCupom = Console.ReadLine();

                    if (inserirCupom == "1")
                    {
                        Console.WriteLine("Insira o cupom: ");
                        var cupom = Console.ReadLine();

                        if (cupom == "SuperDescontaoElvioGilberto")
                        {
                            preco = preco * 0.75;
                        } else {
                            Console.WriteLine("Cupom Invalido!!");
                        }
                    }

                    Console.WriteLine("O total a pagar é:");
                    Console.WriteLine(preco);

                    historico.Add($"{quant} Ingressos, R$ {preco}");

                    Console.WriteLine("Aperta 1 para continuar e 0 para terminar");
                    continuar = Convert.ToInt32(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("Histórico de compras:");
                    foreach (var item in historico)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Aperta 1 para continuar e 0 para terminar");
                    continuar = Convert.ToInt32(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            if (continuar != 0)
            {
                Console.WriteLine("1. Comprar Ingressos");
                Console.WriteLine("2. Ver historico de compras");
                escolha = Console.ReadLine();
            }
        }
    }
}