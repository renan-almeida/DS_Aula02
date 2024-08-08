// See https://aka.ms/new-console-template for more information
using Aula02rh.Models;
using Aula02rh.Models.Enuns;
using System;

namespace Aula02rh
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Funcionario func = new Funcionario();
            func.Id = 10;
            func.Nome = "Neymar";
            func.CPf = "12345678910";
            func.DataAdmissão = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M;
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("========================");
            Console.WriteLine(mensagem);
            Console.WriteLine("========================"); */

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do funcionario: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            func.CPf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissão = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de funcionario (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal ValorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("=======================");
            Console.WriteLine($"O salário reajustado é {func.Salario}. \n");
            Console.WriteLine($"O desconto do VT é {ValorDescontoVT}. \n");
            Console.WriteLine("====================================");

        }
    } 
}

