using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP06.Model;

namespace TP06.Controller
{
    internal class FuncionarioController
    {
        static FuncionarioController()
        {
            foreach (var f in FuncionarioModel.Funcionarios)
            {
                if (f.AnosDeServico >= 10)
                    f.Salario *= 1.05;
            }
        }

        public static List<Funcionario> FiltrarPorInicial(string letra)
        {
            return FuncionarioModel.Funcionarios
                .Where(f => f.Nome.StartsWith(letra, System.StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(f => f.AnosDeServico)
                .ToList();
        }

        public static List<Funcionario> FiltrarPorSalario(double salarioMin)
        {
            return FuncionarioModel.Funcionarios
                .Where(f => f.Salario >= salarioMin)
                .OrderByDescending(f => f.AnosDeServico)
                .ToList();
        }

        public static double CalcularTotalSalarios(List<Funcionario> lista)
        {
            return lista.Sum(f => f.Salario);
        }

        public static IEnumerable<IGrouping<string, Funcionario>> AgruparPorDepartamento()
        {
            return FuncionarioModel.Funcionarios.GroupBy(f => f.Departamento);
        }

        public static IEnumerable<IGrouping<char, Funcionario>> AgruparPorInicial()
        {
            return FuncionarioModel.Funcionarios.GroupBy(f => f.Nome[0]);
        }

        public static List<string> NomesMaiusculos()
        {
            return FuncionarioModel.Funcionarios.Select(f => f.Nome.ToUpper()).ToList();
        }
    }
}
