class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponível { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponível)
        {
            Console.WriteLine($"Dispovível no plano.");
        }
        else
        {
            Console.WriteLine($"Adquira o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"{Nome}/{Artista}");
    }
}