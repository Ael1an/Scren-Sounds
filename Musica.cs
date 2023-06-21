class Musica
{
    public Musica(string nome, Banda artista, int duracao)
    {
        this.Nome = nome; 
        this.Artista = artista;
        this.Duracao = duracao;
    }

    public string Nome { get;}
    public Banda Artista { get;}
    public int Duracao { get;}
    public bool Disponivel { get; set; }
    public GeneroMusical Genero { get; set; }
    public string DescrisaoResumida => $"A música pertence a banda {Artista}";

    public void ExbirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos.");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano atual.\n");
        }
        else
        {
            Console.WriteLine("Indiponível para seu plano atual, aumente seu nível.\n");

        }
    }
    public void ExibirArtistaENome()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Artista: {Artista.Nome}.");
    }

}