using System;
using System.Reflection.Emit;
namespace Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }                
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Descricao = descricao;
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
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

        public void exclui()
        {
           this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }


    }
}