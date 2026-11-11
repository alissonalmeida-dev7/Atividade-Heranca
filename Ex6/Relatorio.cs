namespace AtividadeHeranca.Ex6
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Exportando o relatorio.");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo o relatorio.");
        }
    }
}