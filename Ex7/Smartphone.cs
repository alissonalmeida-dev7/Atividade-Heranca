namespace AtividadeHeranca.Ex7
{
    public class Smartphone : Equipamento
    {
        public decimal Armazenamento { get; set; }

        public Smartphone(string? modelo, string? numeroSerie, decimal armazenamento) : base(modelo, numeroSerie)
        {
            Armazenamento = armazenamento;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Ele tem {Armazenamento} GB de armazenamento.");
        }
    }
}