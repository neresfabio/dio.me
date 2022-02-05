using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Discricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Discricao = descricao;
            this.Ano = ano;
            this.Excluido = false; // obs: tomar cuidado com exclusão de informação LGPD leitura recomendada.
        }

        // Ação a ser feita

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Discrição : " + this.Discricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}