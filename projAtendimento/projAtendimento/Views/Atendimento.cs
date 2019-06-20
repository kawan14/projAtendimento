using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Controllers;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Views
{
    public partial class Atendimento : Form
    {
        #region Atributos

        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();
        #endregion

        #region Construtores

        public Atendimento()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblNumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            guiches.ListaGuiches[index].chamar(senhas.FilaSenhas);
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lbxSenhas.Items.Clear();
            senhas.FilaSenhas.ToList().ForEach(i => lbxSenhas.Items.Add(i.dadosParciais()));
        }

        private void btnListarAtend_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            lbxSenhasGuiche.Items.Clear();
            guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => lbxSenhasGuiche.Items.Add(i.dadosCompletos()));
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }


}
