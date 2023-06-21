class Album
{
    public Album(string nome)
    {
        this.Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();

    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Exibindo musicas do album '{this.Nome}.'\n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}.");
        }

        Console.WriteLine($"\nEsse álbum possui um total de {DuracaoTotal} segundos.");
    }
}