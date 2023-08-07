﻿using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;



try
{
    LeitorDeArquivo leitor = new LeitorDeArquivo("contasa.txt");
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch(IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida !");
}

//try
//{
//    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
//    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);

//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine("Operação negada ! Saldo Insuficiente !");
//    Console.WriteLine(ex.Message);
//}

