namespace AtividadeHeranca
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas {get; set;}

        public Ebook()
        {
            
        }   

        public Ebook(string nome, decimal preco, int quantidade_paginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidade_paginas;
            Console.WriteLine($"Seu livro é o '{Nome}', seu preço é {Preco:C} e ele tem {QuantidadePaginas} paginas.");        
        }     
    }
}