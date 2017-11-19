using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Code_17
{
    class Jogador
    {
        public string Apelido { get; set; }
        public string UrlFoto { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public int Idade { get; set; }
        public string Clube { get; set; }
    }
    class JogadorDataModel
    {
        public ObservableCollection<Jogador> todosJogadores;

        public JogadorDataModel()
        {
            todosJogadores = new ObservableCollection<Jogador>();
            todosJogadores.Add(new Jogador()
            {
                Apelido = "Kaká",
                UrlFoto = "https://upload.wikimedia.org/wikipedia/commons/e/e4/Kaka_17.jpg",
                Nome = "Ricardo Izecson dos Santos Leite",
                Clube = "Orlando City",
                Idade = 35,
                Nacionalidade = "Brasileira",
                Naturalidade = "Gama - DF"
            });

            todosJogadores.Add(new Jogador()
            {
                Apelido = "Romário",
                UrlFoto = "https://upload.wikimedia.org/wikipedia/commons/a/a4/Senador_Rom%C3%A1rio_%28Retrato_oficial%29.jpg",
                Nome = "Romário de Souza Faria",
                Clube = "nenhum",
                Idade = 51,
                Nacionalidade = "Brasileira",
                Naturalidade = "Rio de Janeiro - RJ"
            });

            todosJogadores.Add(new Jogador()
            {
                Apelido = "Juninho Pernambucano",
                UrlFoto = "https://upload.wikimedia.org/wikipedia/commons/e/ef/Juninho_Pernambucano.JPG",
                Nome = "Antônio Augusto Ribeiro Reis Júnior",
                Clube = "nenhum",
                Idade = 42,
                Nacionalidade = "Brasileira",
                Naturalidade = "Recife - PE"
            });
        }

    }
}
