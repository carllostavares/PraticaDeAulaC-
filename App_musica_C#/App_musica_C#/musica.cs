﻿class Musica
{
    public Musica(Banda artista,string nome) 
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}

    public Banda Artista { get; }

    public int Duracao { get; set; }

    public bool Disponivel{get; set;}

    public Genero Genero {get; set;}

    public string DescricaoResumida => $"A musica{Nome} pertence a {Artista}";



    public void ExibirFichaTecnica()

    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível para plano!");
        }else
        {
            Console.WriteLine("Não disponível para plano!");
        }
    }

} 