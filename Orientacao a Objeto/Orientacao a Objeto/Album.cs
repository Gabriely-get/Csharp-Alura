class Album
{
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void MostrarMusicas()
    {
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara você ouvir este álbum você precisa de {DuracaoTotal}s\n");
    }
}