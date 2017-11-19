namespace Code_10
{
    public enum Operacoes { Soma, Subtracao, Multiplicacao, Divisao, Nenhuma };

    public class Calculadora
    {
        public float? operador;
        public float? aux;

        public Operacoes OperacaoSelecionada { get; set; }
        public bool IgualPressionado { get; set; }

        public Calculadora()
        {
            OperacaoSelecionada = Operacoes.Nenhuma;
        }

        public float Calcula(float num2)
        {
            switch (OperacaoSelecionada)
            {
                case Operacoes.Soma:
                    return (float)num2 + (float)operador;
                case Operacoes.Subtracao:
                    return (float)num2 - (float)operador;
                case Operacoes.Multiplicacao:
                    return (float)num2 * (float)operador;
                case Operacoes.Divisao:
                    return (float)num2 / (float)operador;
                default:
                    return 0;
            }
        }
    }
}
