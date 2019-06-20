using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Controllers
{
    class Senhas
    {
        #region atributos
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;
        #endregion

        #region propriedades
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        public Queue<Senha> FilaSenhas { get { return filaSenhas; } } //read only
        #endregion

        #region construtores
        public Senhas() {
            ProximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }
        #endregion

        #region metodos
        public void gerar() {
            filaSenhas.Enqueue(new Senha(ProximoAtendimento));
            ProximoAtendimento++;
        }
        #endregion
    }
}
