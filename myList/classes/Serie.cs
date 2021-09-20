using System;

namespace myList.classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao{get; set;}
        private int Ano{get; set;}
        private bool deleted{get;set;}

        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.deleted = false;
        }

        public override string ToString()
        {
            //Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: "+ this.Genero + Environment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Environment.NewLine;
            retorno += "Descrição: "+ this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: "+ this.Ano + Environment.NewLine;
            retorno += "Excluido: "+ this.deleted + Environment.NewLine;
            return retorno;
        }


        public string getTitulo()
        {
            return this.Titulo;
        }
        public int getId()
        {
            return this.id;
        }

        public void delete()
        {
            this.deleted = true;
        }
    }
}