class Banda
{
    public Banda(string nome)
    {
        this.Nome = nome;
    }

    private List<Album> albuns = new List<Album>();
    public string Nome { get;}

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibindo discografia da banda'{Nome}'.\n");

        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome}. Duração do álbum: {album.DuracaoTotal} segundos.");
        }
    }
}