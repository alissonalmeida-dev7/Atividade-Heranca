namespace AtividadeHeranca.Ex5
{
    public class RetiradaLocal : Entrega
    {
        public override void CalcularFrete()
        {
            Console.WriteLine("Considerando a retirada local, você não paga frete.");
        }
    }
}