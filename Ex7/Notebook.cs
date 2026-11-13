namespace AtividadeHeranca.Ex7
{
    public class Notebook : Equipamento
    {
        public decimal MemoriaRAM { get; set; }

        public Notebook(string? modelo, string? numeroSerie, decimal memoriaRAM) : base(modelo, numeroSerie)
        {
            MemoriaRAM = memoriaRAM;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Ele tem {MemoriaRAM} GB de memoria RAM.");
        }
    }
}