namespace AtividadeHeranca.Ex8
{
    public abstract class Animal
    {
        public string? Nome {get; set;}

        public Animal(string nome)
        {
            Nome = nome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"O nome do animal é {Nome}.");
        }

        public abstract void EmitirSom();
    }
}