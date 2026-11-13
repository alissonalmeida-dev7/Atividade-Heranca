namespace AtividadeHeranca.Ex9
{
    public class ArquivoTexto : IAmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"Salvando {conteudo} no arquivo de texto.");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo conteúdo do arquivo de texto.");
        }
    }
}