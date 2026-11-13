namespace AtividadeHeranca.Ex7
{
    public abstract class Equipamento
    {
        public string? Modelo { get; set; }
        protected string? NumeroSerie;

        public Equipamento(string? modelo, string? numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Seu equipamento é do modelo: {Modelo} e seu numero de serie é: {NumeroSerie}.");
        }
    }
}