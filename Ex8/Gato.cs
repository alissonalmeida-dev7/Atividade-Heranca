namespace AtividadeHeranca.Ex8
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Seu gato {Nome}, está miando: Miauuuuu!");
        }
    }
}