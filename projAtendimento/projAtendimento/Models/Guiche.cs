﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Models
{
    class Guiche
    {
        #region atributos
        private int id;
        private Queue<Senha> atendimentos;
        #endregion

        #region propriedades
        public int Id { get => id; set => id = value; }
        public Queue<Senha> Atendimentos { get { return atendimentos; } } 
        #endregion

        #region construtores
        public Guiche() {
            Id = 0;
            atendimentos = new Queue<Senha>();
        }
        public Guiche(int id)
        {
            this.Id = id;
            this.atendimentos = new Queue<Senha>();
        }
        #endregion

        #region metodos
        public bool chamar(Queue<Senha> filaSenhas) {
            if (filaSenhas.Count == 0) return false;
            Senha aux = filaSenhas.Dequeue();
            aux.DataAtend = DateTime.Now;
            aux.HoraAtend = DateTime.Now;
            atendimentos.Enqueue(aux);
            return true;
        }
        #endregion
    }
}
