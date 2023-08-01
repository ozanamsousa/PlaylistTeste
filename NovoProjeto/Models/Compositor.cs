using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjeto.Models
{
    public class Compositor 
    {
        public int IdCompositor { get; set; } 
        public string Nome { get; set; } 
        public int Idade { get; set; } 
    
    public Compositor(){}
    
    public Compositor(int idCompositor, string nome, int idade)
    {
        IdCompositor = idCompositor;
        Nome = nome;
        Idade = idade;
    }   
    }
}
