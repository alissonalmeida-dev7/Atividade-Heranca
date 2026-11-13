namespace AtividadeHeranca.Ex10
{
    public class Consultoria : Servico, IContratavel
    {
        public Consultoria(string nome) : base(nome)
        {
        }
        public void Contratar()
        {
            Console.WriteLine($"Você contratou o serviço de consultoria do(a) {Nome}!");
        }
    }
}