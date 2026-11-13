namespace AtividadeHeranca.Ex9
{
    public interface IAmazenavel
    {
        public abstract void Salvar(string conteudo);

        public abstract void Ler();
    }
}