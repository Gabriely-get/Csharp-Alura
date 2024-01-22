class Banda
{
    public string Nome { get; }
    public List<Album> Albums { get; set; } = new List<Album>();    

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (Album album in Albums)
        {
            Console.WriteLine($"\nA banda {Nome} possui o disco {album.Nome} ({album.DuracaoTotal})\n");
        }
    }

    public Banda (string nome)
    {
        Nome = nome; // ou eu inicializo o valor no set ou no construtor mas sem o set
    }
}