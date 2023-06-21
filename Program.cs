Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica("Love of my life", queen, 213) { Disponivel = true };
Musica musica2 = new Musica("Bohemian Rhaspsody", queen, 354) { Disponivel = false };

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);


//musica2.ExbirFichaTecnica();
//musica1.ExbirFichaTecnica();
//albumDoQueen.ExibirMusicasAlbum();
//queen.ExibirDiscografia();

Podcast podcast1 = new Podcast("Rafinha Cast", "Rafa Coelho");

Episodio episodio1 = new Episodio("Rafa com o Rafa?", 180, 1); //{ Resumo = "Rafinha convidou outro rafa e fizeram bagunça no Podcast!"};
Episodio episodio2 = new Episodio("Rafa feat Moreira", 355, 2); //{ Resumo = "Rafa convida trappers para seu Podcast e olha no que deu!"};
Episodio episodio3 = new Episodio("Ana Beatriz Barbosa", 277, 3); //{ Resumo = "Rafa finalmente decide cuidar da sua saude mental e convida terapeuta renomada na area!"};

podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.AdicionarEpisodio(episodio3);

episodio1.AdicionarConvidados("Rafael Lange");
episodio1.AdicionarConvidados("Carlos");
episodio1.AdicionarConvidados("Bruno");

episodio2.AdicionarConvidados("Rafa moreira");
episodio2.AdicionarConvidados("Orochi");
episodio2.AdicionarConvidados("Bruno");

episodio3.AdicionarConvidados("Ana beatriz barbosa");
episodio3.AdicionarConvidados("Carlos");
episodio3.AdicionarConvidados("Bruno");


podcast1.ExibirDetalhes();

