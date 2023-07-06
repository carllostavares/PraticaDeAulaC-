
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menus
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {//nesse caso o VIRTUAL indica que pode ser sobrescrito por um descendente
        Console.Clear();
    }

}
