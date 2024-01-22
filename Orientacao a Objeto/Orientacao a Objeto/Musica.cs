class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } // propriedades no C# tem letra maiúscula
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence a banda {Artista.Nome}";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}; \nArtista: {Artista}; \nDuração: {Duracao}; \nDisponível: {Disponivel}; \nDescrição: {DescricaoResumida}\n");
    }

    public Musica (Banda artista, string nome)
    {
        Nome = nome;
        Artista = artista;    
    }
}