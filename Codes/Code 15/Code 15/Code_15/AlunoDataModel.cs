using System;
using System.Collections.Generic;
using System.Text;

namespace Code_15
{
    class AlunoDataModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public string CorFavorita { get; set; }

        public AlunoDataModel()
        {
            this.Nome = "Marcos Augusto Lima";
            this.Idade = 42;
            this.Profissao = "Autônomo";
            this.CorFavorita = "Azul";
        }
    }
}
