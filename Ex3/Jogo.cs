namespace AtividadeHeranca
{
    public abstract class Jogo
    {
        public string? Nome {get; set;}
        protected string? Plataforma {get; set;}

        public Jogo()
        {
            
        }
        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"O nome do seu jogo é {Nome} e sua plataforma é {Plataforma}");
        }
    }
}