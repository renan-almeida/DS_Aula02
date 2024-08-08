using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02rh.Models.Enuns;

namespace Aula02rh.Models
{
    public class Funcionario
    {
        public int Id{get; set;}
        public string Nome { get; set; } ="";
        public string CPf { get; set; } = string.Empty;
        public DateTime DataAdmissão { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }



        public void ReajustarSalario()
        {
           Salario = Salario + (Salario * 10 / 100);    
        }

        public string ExibirPeriodoExperiencia()
        {
            string PeriodoExperiencia = string.Format("Períodos de experiência: {0} até {1}", DataAdmissão, DataAdmissão.AddMonths(3));
            return PeriodoExperiencia;
        }

        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool validarCpf()
        {
            if (ContarCaracteres(CPf) == 11)
            return true;
            else
            return false;
        }


    }
}