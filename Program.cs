using AtividadeHeranca.Ex3;
using AtividadeHeranca.Ex4;
using AtividadeHeranca.Ex5;
using AtividadeHeranca.Ex6;
using AtividadeHeranca.Ex7;
using AtividadeHeranca.Ex8;
using AtividadeHeranca.Ex9;
using AtividadeHeranca.Ex10;


//* Ex1 
// Carro carro = new Carro("BMW", "X1", 4);
// carro.ExibirInformacoes();

// Motocicleta moto = new Motocicleta("Honda", "170", 170);
// moto.ExibirInformacoes();

//* Ex2
// Ebook livro = new Ebook("It a coisa", 150m, 327);
// CursoOnline curso = new CursoOnline("Aulão Enem", 50m, 12);

//* Ex3
// JogoDigital jogoDigital = new JogoDigital("Fortnite", "Pc", 62);
// JogoFisico jogoFisico = new JogoFisico("Gta V", "Ps4", 2);

//* Ex4
// NotificacaoEmail notificacaoEmail = new NotificacaoEmail();
// notificacaoEmail.ExibirNotifacacao();

// NotificacaoPush notificacaoPush = new NotificacaoPush();
// notificacaoPush.ExibirNotifacacao();

// NotificacaoSMS notificacaoSMS = new NotificacaoSMS();
// notificacaoSMS.ExibirNotifacacao();

//* Ex5
// foreach(var frete in new List<Entrega>
// {
//     new EntregaExpressa(),
//     new EntregaEconomica(),
//     new RetiradaLocal()
// })
// {
//     frete.Distancia = 100m;
//     frete.CalcularFrete();
// }

//* Ex6
// Relatorio relatorio = new Relatorio();
// relatorio.Imprimir();
// relatorio.Exportar();

// Contrato contrato = new Contrato();
// contrato.Imprimir();

//* Ex7
// Notebook notebook = new Notebook("VivoBook Go 15", "4364343", 8m);
// notebook.ExibirInformacoes();

// Smartphone smartphone = new Smartphone("Iphone 13", "42344234", 252m);
// smartphone.ExibirInformacoes();

//* Ex8
// foreach(var animal in new List<Animal>
// {
//     new Cachorro("Terror"),
//     new Gato("Kitty"),
//     new Passaro("Clovis")
// })
// {
//     animal.Apresentar();
//     animal.EmitirSom();
// }

//* Ex9
BancoDados notebook = new BancoDados();
notebook.Ler();
notebook.Salvar("App");

ArquivoTexto pdf = new ArquivoTexto();
pdf.Ler();
pdf.Salvar("Mensagem");

//* Ex10
// Hospedagem hospedagem = new Hospedagem("Trivago");
// hospedagem.Contratar();
// hospedagem.Cancelar();

// Consultoria consultoria = new Consultoria("Mentalista");
// consultoria.Contratar();
