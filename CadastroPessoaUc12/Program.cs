using CadastroPessoaUc12.Classes;

Console.Clear();

Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    | 
|        Pessoas Físicas e Juridícas.       |
=============================================
");

Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo:     |
|-------------------------------------------|   
|            1 - Pessoa Física              |
|            2 - Pessoa Juridíca            |
|                                           |
|            0 - Sair                       |
=============================================
");

 opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    PessoaFisica novaPf =new PessoaFisica();
    PessoaFisica metodosPf = new PessoaFisica();
    Endereco novoEndPf = new Endereco();

    novaPf.Nome = "Afranio Dimas";
    novaPf.dataNasc = new DateTime(2000, 01, 01);
    novaPf.Cpf = "1234567890";
    novaPf.Rendimento = 8500.5f;

    novoEndPf.Logradouro = "5th Avenue Park";
    novoEndPf.numero = 1485;
    novoEndPf.complemento = "5th on the Park";
    novoEndPf.endComercial = true;

    novaPf.Endereco = novoEndPf;

    Console.Clear();
    Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.numero}
Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
");

    //condicao ? "Sim" : "Não"

    // exemplo de concatenação e interpolação
    // Console.WriteLine($"Nome: {novaPf.Nome} nome: {novaPf.Nome}");
    // Console.WriteLine("Nome: " + novaPf.Nome + "Nome: " + novaPf.Nome);

    Console.WriteLine($"Aperte ENTER para continuar");
    Console.ReadLine();

    
        break;

    case "2":
    PessoaJuridica novaPj = new PessoaJuridica();
    PessoaJuridica metodosPj = new PessoaJuridica();
    Endereco novoEndPj = new Endereco();

    novaPj.Nome = "Nome Pj";
    novaPj.RazaoSocial = "Razão Social Pj";
    novaPj.Cnpj = "00.000.000/0001-00";
    novaPj.Rendimento = 12000.5f;

    novoEndPj.Logradouro = "5th Avenue Park";
    novoEndPj.numero = 1485;
    novoEndPj.complemento = "5th on the Park";
    novoEndPj.endComercial = true;

    novaPj.Endereco = novoEndPj;

    Console.Clear();
    Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Sim" : "Não")}
Endereço: {novaPj.Endereco.Logradouro}, N°: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

    Console.WriteLine($"Aperte ENTER para continuar");
    Console.ReadLine();
    
        break;

    case "0":
    Console.Clear();
    Console.WriteLine($"Obrigado por utilizar nosso sistema!");
    Thread.Sleep(3000);

    Utils.BarraCarregamento("Finalizando", 500, 6);

    
        break;

    default:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Opção Inválida, por favor digite uma opção válida.");
    Console.ResetColor();
    Thread.Sleep(3000);
    
        break;
}

} while (opcao != "0");

// static void BarraCarregamento(string texto, int tempo, int quantidade)
// {
//     Console.BackgroundColor = ConsoleColor.DarkBlue;
//     Console.ForegroundColor = ConsoleColor.DarkMagenta;

//     Console.Write(texto);

//     for (var contador = 0; contador < quantidade; contador++)
//     {
//      Console.Write(".");
//      Thread.Sleep(tempo); 
//     }
//    Console.ResetColor();
// }


