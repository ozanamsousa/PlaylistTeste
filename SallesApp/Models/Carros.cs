using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesApp.Models
{
    public class Carros
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo {get; set}

        public Carros(){}
        public Carros(int id, string nome, string descricao, double preco, DateTime anoFabricaco, DateTime anoModelo){
            Id = id,
            Nome = nome,
            Descricao = descricao,
            Preco = preco,
            AnoFabricacao = anoFabricaco,
            AnoModelo = anoModelo,
        }
        public string ToString()
        {
            System.Console.WriteLine($"Seu carro adquirido é: {nome}, o ano de fabricacao é: {anoFabricacao}, modelo: {anoModelo}"  );
        }
    }
}