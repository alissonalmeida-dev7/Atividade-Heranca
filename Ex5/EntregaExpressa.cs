namespace AtividadeHeranca.Ex5
{
    public class EntregaExpressa : Entrega
    {
        public override void CalcularFrete()
        {
            decimal Resultado = Distancia * 1.10m;
            Console.WriteLine($"Considerando a entrega expressa, tem taxa adicional, seu frete é {Resultado}");
        }
    }
}