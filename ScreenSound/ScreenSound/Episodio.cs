class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> convidados = new List<string>();

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao} minutos) -> {string.Join(", ", convidados)}.";

    public void AdicionarConvidados(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
    }
}