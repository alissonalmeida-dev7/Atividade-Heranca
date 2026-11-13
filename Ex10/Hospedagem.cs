namespace AtividadeHeranca.Ex10
{
    public class Hospedagem : Servico, ICancelavel, IContratavel
    {
        public Hospedagem(string nome) : base(nome)
        {
            
        }

        public void Cancelar()
        {
            Console.WriteLine($"Voce cancelou o serviço de hospedagem do(a) {Nome}!");
        }

        public void Contratar()
        {
            Console.WriteLine($"Voce contratou o serviço de hospedagem do(a) {Nome}!");
        }
    }
}