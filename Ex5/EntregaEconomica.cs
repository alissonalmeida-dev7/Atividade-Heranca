namespace AtividadeHeranca.Ex5
{
    public class EntregaEconomica : Entrega
    {
        public override void CalcularFrete()
        {
            decimal Resultado = Distancia - (Distancia * 0.10m);
            Console.WriteLine($"Considerando a entrega expressa, tem tarifa reduzida, seu frete é {Resultado}");
        }      
    }
}