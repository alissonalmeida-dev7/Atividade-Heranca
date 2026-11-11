namespace AtividadeHeranca
{
    public class Veiculo
    {
        public string? Marca {get; set;}
        public string? Modelo {get; set;}

        public Veiculo()
        {
            
        }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Seu veiculo é da marca: {Marca} e do modelo: {Modelo}");
        }
    }
}