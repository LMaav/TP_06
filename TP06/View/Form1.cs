using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP06.Controller;


namespace TP06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Filtro_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string filtro = txt_Filtro.Text.Trim().ToUpper();

            if (double.TryParse(filtro, out double valorN) && filtro.Length >= 4)
            {
                var lista = FuncionarioController.FiltrarPorSalario(valorN);
                foreach (var f in lista)
                    listBox1.Items.Add($"{f.Nome} | {f.Departamento} | R${f.Salario} | {f.AnosDeServico} anos");

                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add($"Total de salários: R${FuncionarioController.CalcularTotalSalarios(lista)}");
            }
            else if (!string.IsNullOrEmpty(filtro) && filtro.Length == 1 && !double.TryParse(filtro, out double valor))
            {
                var lista = FuncionarioController.FiltrarPorInicial(filtro);
                foreach (var f in lista)
                    listBox1.Items.Add($"{f.Nome} | {f.Departamento} | R${f.Salario} | {f.AnosDeServico} anos");

                listBox1.Items.Add("------------------------------");
                listBox1.Items.Add($"Total de salários: R${FuncionarioController.CalcularTotalSalarios(lista)}");
            }
            else
            {
                MessageBox.Show("Digite somente uma letra para nomes ou 4 dígitos para salários.","Erro");
            }
        }

        private void btn_Maiuscula_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Nomes em maiúsculas:");
            foreach (var nome in FuncionarioController.NomesMaiusculos())
                listBox1.Items.Add(nome);
        }

        private void btn_Agrupar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var opcao = MessageBox.Show("Deseja agrupar por DEPARTAMENTO?\nClique em 'Não' para INICIAL DO NOME.",
                                        "Agrupamento",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                foreach (var grupo in FuncionarioController.AgruparPorDepartamento())
                {
                    listBox1.Items.Add($"Departamento: {grupo.Key} | Média Salarial: R${grupo.Average(f => f.Salario):F2}");
                    foreach (var f in grupo)
                        listBox1.Items.Add($" - {f.Nome}");
                }
            }
            else
            {
                foreach (var grupo in FuncionarioController.AgruparPorInicial())
                {
                    listBox1.Items.Add($"Inicial: {grupo.Key} | Média Salarial: R${grupo.Average(f => f.Salario):F2}");
                    foreach (var f in grupo)
                        listBox1.Items.Add($" - {f.Nome}");
                }
            }
        }
    }
}