namespace AtividadeHeranca.Ex8
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Seu passaro {Nome}, está cantando: ♪♩♫ ");
        }
    }
}