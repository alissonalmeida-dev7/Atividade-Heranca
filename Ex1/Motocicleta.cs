namespace AtividadeHeranca
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas {get; set;}

        public Motocicleta()
        {
            
        }

        public Motocicleta(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Sua moto é da marca: {Marca}, do modelo: {Modelo} e tem {Cilindradas} cilindradas.");
        }
    }
}