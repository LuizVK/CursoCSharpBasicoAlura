//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponível = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponível = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAbum();
//queen.ExibirDiscografia();

Podcast novoCast = new Podcast("Luizinho", "Novo Cast");

Episodio episodio1 = new Episodio(1, "Episódio 1", 5);
episodio1.AdicionarConvidados("Teste");
episodio1.AdicionarConvidados("teste123");

Episodio episodio2 = new Episodio(2, "Episódio 2", 6);
episodio2.AdicionarConvidados("O carinha");

Episodio episodio3 = new Episodio(3, "Episódio 3", 7);

novoCast.AdicionarEpisodio(episodio3);
novoCast.AdicionarEpisodio(episodio1);
novoCast.AdicionarEpisodio(episodio2);

Console.WriteLine($"Episódio 1: {episodio1.Resumo}");
Console.WriteLine($"Episódio 2: {episodio2.Resumo}");
Console.WriteLine($"Episódio 3: {episodio3.Resumo}");

novoCast.ExibirDetalhes();