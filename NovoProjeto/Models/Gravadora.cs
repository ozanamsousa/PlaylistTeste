using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoProjeto.Models
{
    public class Gravadora
    {
        public int Id { get; set; }
        public string NomeGravadora { get; set; }

        public Gravadora(){}

        public Gravadora(int id, string nomeGravadora){
            Id = id;
            NomeGravadora = nomeGravadora;
        }
    }
}