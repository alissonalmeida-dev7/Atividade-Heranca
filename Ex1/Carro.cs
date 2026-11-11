namespace AtividadeHeranca
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas {get; set;}

        public Carro()
        {
            
        }

        public Carro(string marca, string modelo, int quantidade_portas) : base(marca, modelo)
        {
            QuantidadePortas = quantidade_portas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Seu carro é da marca: {Marca}, do modelo: {Modelo} e tem {QuantidadePortas} portas.");
        }
    }
}