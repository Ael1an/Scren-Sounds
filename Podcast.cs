class Podcast
{
    public Podcast(string nome, string host)
    {
        this.Nome = nome;
        this.Host = host;
    }

    public List<Episodio> episodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodio => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"O podcast '{Nome}' está sendo hosteado por {Host}.\nApresentando os epsidios já produzidos:\n");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);

        }
        Console.WriteLine($"Total de episodios: {TotalEpisodio}");
    }
}