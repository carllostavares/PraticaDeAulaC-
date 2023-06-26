
using ByteBank.Funcionários;

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro Amaral";
pedro.Cpf = "123.456.789-10";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor Carlos = new Diretor();

Carlos.Nome = "Carlos Tavares";
Carlos.Cpf = "999.456.789-10";
Carlos.Salario = 9000;

Console.WriteLine(Carlos.Nome);
Console.WriteLine(Carlos.GetBonificacao());
