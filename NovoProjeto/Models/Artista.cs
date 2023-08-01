using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjeto.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; } 
        
        public Artista(){}
        
        public Artista(int id, string nome, int idade)
        {
        Id = id;
        Nome = nome;
        Idade = idade;
        }
    }
}