using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NovoProjeto.Models.Helpers;
using NovoProjeto.Models;

namespace NovoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caminho da pasta que você deseja criar
            var pasta = @"C:\TesteXml";

            // Verifica se a pasta já existe e, se não existir, a cria
            if (!System.IO.Directory.Exists(pasta))
            {
                System.IO.Directory.CreateDirectory(pasta);
            }
            Artista a1 = new Artista (1,"Gustavo Lima", 29);
            Musica m1 = new Musica (1, "Inventor de Amores", "volume2", "Sertanejo", DateTime.Now, DateTime.Now, new DateTime(2023, 8, 1, 0, 4, 30));
           
           // Serializando em XML
        string xmlData = XmlSerializationHelper.SerializandoXml(a1);
        string xmlData1 = XmlSerializationHelper.SerializandoXml(m1);

        // Imprimindo o XML resultante
        Console.WriteLine(xmlData);

        // Deserializando de XML para objeto
        Artista pessoa = XmlSerializationHelper.DeserializandoParaXml<Artista>(xmlData);

        // Imprimindo os atributos do objeto deserializado
        Console.WriteLine(pessoa.Id);
        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Idade);

        Musica musica = XmlSerializationHelper.DeserializandoParaXml<Musica>(xmlData1);

        // Imprimindo os atributos do objeto deserializado
        Console.WriteLine(musica.Id);
        Console.WriteLine(musica.Titulo);
        Console.WriteLine(musica.Subtitulo);
        Console.WriteLine(musica.Genero);
        Console.WriteLine(musica.DuracaoInicial.ToString("HH:mm:ss"));
        Console.WriteLine(musica.DuracaoFinal.ToString("HH:mm:ss"));

         // Caminho completo do arquivo onde o XML será salvo (pasta C:\TesteXml)
        string arquivoArtista = Path.Combine(pasta, "artista.xml");
        string arquivoMusica = Path.Combine(pasta, "musica.xml");
        XmlSerializer serializer = new XmlSerializer(typeof(Artista));
            using (StreamWriter writer = new StreamWriter(arquivoArtista))
            {
                serializer.Serialize(writer, a1);
            }

            serializer = new XmlSerializer(typeof(Musica));
            using (StreamWriter writer = new StreamWriter(arquivoMusica))
            {
                serializer.Serialize(writer, m1);
            }
        Console.WriteLine("Arquivos XML salvos em C:\\TesteXml.");
            
        }
    }
}