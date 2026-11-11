namespace AtividadeHeranca.Ex3
{
    public class JogoDigital : Jogo
    {
        public int PesoGb {get; set;}

        public JogoDigital()
        {
            
        }

        public JogoDigital(string nome, string plataforma, int peso_Gb) : base(nome , plataforma)
        {
            PesoGb = peso_Gb;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do seu jogo digital é {Nome}, sua plataforma é {Plataforma} e ele pesa {PesoGb} GBs.");
        }
    }
}