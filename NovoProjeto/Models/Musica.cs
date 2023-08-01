using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjeto.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo {get; set; }
        public string Genero {get; set; }     
        public DateTime DuracaoInicial { get; set; }
        public DateTime DuracaoFinal { get; set; }
        public DateTime Ano { get; set; }

        public Musica()
        {

        }
        public Musica(int id, string titulo, string subtitulo, string genero, DateTime duracaoInicial, DateTime duracaoFinal, DateTime ano)
        {
            Id = id;
            Titulo = titulo;
            Subtitulo = subtitulo;
            Genero = genero;
            DuracaoInicial = duracaoInicial;
            DuracaoFinal = duracaoFinal;
        }
    }
}