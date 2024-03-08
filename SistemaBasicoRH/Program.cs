using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBasicoRH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de cadastro de Funcionário");
            List<string> Funcionario = new List<string>();
            string opcao = "";

            Console.WriteLine("Sejá bem vindo ao sistema de cadastro");

            do
            {
                Console.WriteLine("Opções");
                Console.WriteLine("1. Adicionar Funcionário");
                Console.WriteLine("2. Excluir Funcionário");
                Console.WriteLine("3. Visualizar Funcionários");
                Console.WriteLine("4. Sair");

                try
                {
                    opcao = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Opção invalida");
                    continue;
                }

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do novo funcionário");
                        string numFunci = Console.ReadLine();
                        Funcionario.Add(numFunci);
                        Console.WriteLine("Funcionário adcionado com secesso!!");
                        break;
                    case "2":
                        for (int i = 0; i < Funcionario.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} . {Funcionario[i]}");
                        }
                        Console.WriteLine("Por favor digite o número do funcionário para excluir");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out int FuncionárioNum) && FuncionárioNum >= 1 && FuncionárioNum <= Funcionario.Count)
                        {
                            Funcionario.RemoveAt(FuncionárioNum - 1);
                            Console.WriteLine("Funcionário excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Número de funcionário inválido!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Lista de funcionários");
                        if (Funcionario.Count == 0)
                        {
                            Console.WriteLine("Lista está vazia..");
                        }
                        else
                        {
                            for (int i = 0; i < Funcionario.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} . {Funcionario[i]}");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Saindo do sistema");
                        break;
                    case "5":
                        Console.WriteLine("Opção invalida");
                        break;

                }
            }

            while (opcao != "4");
            Console.WriteLine("Obrigado por utilizar o sistema");
        }
    }
}
