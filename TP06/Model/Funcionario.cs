using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06.Model
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public int AnosDeServico { get; set; }

        public Funcionario(string nome, string departamento, double salario, int anosDeServico)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            AnosDeServico = anosDeServico;
        }
    }
}
