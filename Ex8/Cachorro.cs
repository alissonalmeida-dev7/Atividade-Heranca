namespace AtividadeHeranca.Ex8
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Seu cachorro {Nome}, está latindo: AU AU!");
        }
    }
}