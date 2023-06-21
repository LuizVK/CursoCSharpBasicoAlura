class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    private List<Episodio> episodios = new List<Episodio>();

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}");
    }
}