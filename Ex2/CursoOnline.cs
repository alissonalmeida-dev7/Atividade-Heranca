namespace AtividadeHeranca
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria {get; set;}

        public CursoOnline()
        {
            
        }   

        public CursoOnline(string nome, decimal preco, int carga_horaria) : base(nome, preco)
        {
            CargaHoraria = carga_horaria;
            Console.WriteLine($"Seu curso é o '{Nome}', seu preço é {Preco:C} e ele tem {CargaHoraria} horas de carga horaria.");  
        }   
    }
}