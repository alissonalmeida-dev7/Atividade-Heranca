namespace AtividadeHeranca.Ex3
{
    public class JogoFisico : Jogo
    {
        public int QuantidadeCDs {get; set;}

        public JogoFisico()
        {
            
        }

        public JogoFisico(string nome, string plataforma, int quantidade_CDs) : base(nome , plataforma)
        {
            QuantidadeCDs = quantidade_CDs;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do seu jogo fisico é {Nome}, sua plataforma é {Plataforma} e você tem {QuantidadeCDs} CD(s).");
        }
    }
}