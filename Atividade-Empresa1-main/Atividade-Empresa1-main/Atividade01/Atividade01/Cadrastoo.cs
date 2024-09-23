using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class Cadrastoo : Form
    {
        public Cadrastoo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Cnpj = txt_cnpj.Text;
            empresa.RazaoSocial = txt_razaosocial.Text;
            empresa.SituacaoCad = cb_sitacaocadastral.Text;
            empresa.RegimeTribu = "";
            if (rb_simples.Checked)
            {
                empresa.RegimeTribu = "Simples Nacional";
            }
            else if (rb_lucro.Checked)
            {
                empresa.RegimeTribu = "Lucro Presumido";
            }
            else if (rb_lucroreal.Checked)
            {
                empresa.RegimeTribu = "Lucro Real";
            }
            empresa.DataInicio = Convert.ToDateTime(dt_inicio.Text);
            empresa.Telefone = mask_telefone.Text;
            empresa.Endereco = cb_estado.Text;
            empresa.Tipo = "";
            if (rb_filial.Checked)
            {
                empresa.Tipo = "Filial";
            }
            else if (rb_matriz.Checked)
            {
                empresa.Tipo = "Matriz";
            }
            empresa.PorteEmpre = "";
            if (rb_pequeno.Checked)
            {
                empresa.PorteEmpre = "Pequeno";
            }
            else if (rb_medio.Checked)
            {
                empresa.PorteEmpre = "Médio";
            }
            else if (rb_grande.Checked)
            {
                empresa.PorteEmpre = "Grande";
            }
            empresa.NaturezaJuri = cb_natureza.Text;
            empresa.NomePropri = txt_nomefantasia.Text;
            empresa.CPFpropri = txt_cpf.Text;


            MessageBox.Show($"Cnpj = {empresa.Cnpj}\n" +
                $"Razao Social = {empresa.RazaoSocial}\n" +
                $"Situação Cadastral = {empresa.SituacaoCad}\n" +
                $"Regime Tributário = {empresa.RegimeTribu}\n" +
                $"Data Inicio = {empresa.DataInicio}\n" +
                $"Telefone = {empresa.Telefone}\n" +
                $"Capital Social = {empresa.CapitalSocial}\n" +
                $"Endereço = {empresa.Endereco}\n" +
                $"Tipo = {empresa.Tipo} " +
                $"Porte Empresa = {empresa.PorteEmpre}\n" +
                $"Natureza Juridíca = {empresa.NaturezaJuri}\n " +
                $"Nome Proprietário = {empresa.NomePropri}\n" +
                $"CPF Proprietário = {empresa.CPFpropri} ");
        }

        private void txt_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
