public static class Grupo
{
    public static Dictionary<int, discos> albumes { get; private set; } = new Dictionary<int, discos>();

    public static void InicializarGrupo()
    {
        discos disco1 = new discos("Thriller", "Michael Jackson", "Quincy Jones", "Pop",
            new List<string> { "Thriller", "Beat It", "Billie Jean", "Wanna Be Startin Somethin’" },
            1, "/imagenes/thriller.jpg");

        discos disco2 = new discos("Back in Black", "AC/DC", "Robert John Lange", "Rock",
            new List<string> { "Back in Black", "Hells Bells", "Shoot to Thrill" },
            2, "/imagenes/backinblack.jpg");

        discos disco3 = new discos("Abbey Road", "The Beatles", "George Martin", "Rock",
            new List<string> { "Come Together", "Something", "Octopus's Garden" },
            3, "/imagenes/abbeyroad.jpg");

        discos disco4 = new discos("Nevermind", "Nirvana", "Butch Vig", "Grunge",
            new List<string> { "Smells Like Teen Spirit", "Come As You Are", "Lithium" },
            4, "/imagenes/nevermind.jpg");

        discos disco5 = new discos("The Dark Side of the Moon", "Pink Floyd", "Pink Floyd", "Progressive Rock",
            new List<string> { "Money", "Time", "Us and Them" },
            5, "/imagenes/darkside.jpg");

        discos disco6 = new discos("21", "Adele", "Paul Epworth", "Pop",
            new List<string> { "Rolling in the Deep", "Someone Like You", "Set Fire to the Rain" },
            6, "/imagenes/21.jpg");

        discos disco7 = new discos("A Night at the Opera", "Queen", "Roy Thomas Baker", "Rock",
            new List<string> { "Bohemian Rhapsody", "Love of My Life", "You're My Best Friend" },
            7, "/imagenes/anightattheopera.jpg");

        discos disco8 = new discos("The Marshall Mathers LP", "Eminem", "Dr. Dre", "Hip-Hop",
            new List<string> { "The Real Slim Shady", "Stan", "The Way I Am" },
            8, "/imagenes/marshallmatherslp.jpg");

        discos disco9 = new discos("Lover", "Taylor Swift", "Jack Antonoff", "Pop",
            new List<string> { "Lover", "Cruel Summer", "The Archer" },
            9, "/imagenes/lover.jpg");

        discos disco10 = new discos("Random Access Memories", "Daft Punk", "Daft Punk", "Electronic",
            new List<string> { "Get Lucky", "Instant Crush", "Lose Yourself to Dance" },
            10, "/imagenes/randomaccessmemories.jpg");

        albumes.Add(disco1.ID, disco1);
        albumes.Add(disco2.ID, disco2);
        albumes.Add(disco3.ID, disco3);
        albumes.Add(disco4.ID, disco4);
        albumes.Add(disco5.ID, disco5);
        albumes.Add(disco6.ID, disco6);
        albumes.Add(disco7.ID, disco7);
        albumes.Add(disco8.ID, disco8);
        albumes.Add(disco9.ID, disco9);
        albumes.Add(disco10.ID, disco10);
    }
}