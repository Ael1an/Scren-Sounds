using System.ComponentModel;

class Episodio
{
    public Episodio(string titulo, int duracao, int ordem)
    {
        this.Titulo = titulo;
        this.Ordem = ordem;
        this.Duracao = duracao;

    }

    public List<string> convidados = new List<string>();
    private string convidadosConcatenados;
    public int Duracao { get;}
    public int Ordem { get;}
    public string Titulo { get;}
    public string Resumo => $"Episodio {this.Ordem} ({Duracao} Min) \nTitulo: {this.Titulo} \nConvidados: {convidadosConcatenados}.\n";

    public void AdicionarConvidados(string convidadoNome)
    {
        convidados.Add(convidadoNome);
        convidadosConcatenados = string.Join(", ", convidados.ToArray());
    }
}