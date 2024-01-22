Carro carro = new Carro();
carro.Modelo = "Celta";
carro.QuantidadePortas = 7;
carro.Ano = 1955;
Console.WriteLine("------ Descrição carro ------");
Console.WriteLine(carro.DescricaoDetalhada + "\n");

Album albumDaNewJeans = new Album("New Journey");


Banda kpopNewJenas = new Banda("KpopNew Jenas");
kpopNewJenas.AddAlbum(albumDaNewJeans);


Musica musica1 = new Musica(kpopNewJenas, "Roxane");
musica1.Duracao = 10;

Musica musica2 = new Musica(kpopNewJenas, "Hype Boy")
{
    Duracao = 314,
    Disponivel = true,
};

Musica musica3 = new Musica(kpopNewJenas, "Hell Boy")
{
    Duracao = 412,
    Disponivel = false,
}; //inicializadores    

Console.WriteLine("------ Músicas ------");
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();

albumDaNewJeans.AddMusica(musica2);
albumDaNewJeans.AddMusica(musica3);
albumDaNewJeans.AddMusica(musica1);

Console.WriteLine("------ Albúm ------");
albumDaNewJeans.MostrarMusicas();

Console.WriteLine("------ Banda ------");
kpopNewJenas.ExibirDiscografia();