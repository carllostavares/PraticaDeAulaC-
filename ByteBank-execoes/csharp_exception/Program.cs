using csharp_exception.Titular;
using csharp_exception.Contas;


try
{
    ContaCorrente conta1 = new ContaCorrente(283, "1234-X");
    Console.WriteLine(ContaCorrente.TaxaOperacao);

}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}

