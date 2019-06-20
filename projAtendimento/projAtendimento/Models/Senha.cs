using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Models
{
    class Senha
    {
        #region atributos
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;
        #endregion

        #region propriedades
        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get { return this.dataGerac; } set { this.dataGerac = value; } }
        public DateTime HoraGerac { get { return this.horaGerac; } set { this.horaGerac = value; } }
        public DateTime DataAtend { get { return this.dataAtend; } set { this.dataAtend = value; } }
        public DateTime HoraAtend { get { return this.horaAtend; } set { this.horaAtend = value; } }
        #endregion

        #region construtores
        public Senha(int id) {
            this.Id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }
        #endregion

        #region metodos
        public string dadosParciais() {
            return Id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm");
        }

        public string dadosCompletos() {
            return Id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm") + 
                " - " + dataAtend.ToString("dd/MM/yyyy") + " - " + horaAtend.ToString("HH:mm");
        }
        #endregion
    }
}
