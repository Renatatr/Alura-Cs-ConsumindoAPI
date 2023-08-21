using System.Security.Cryptography.X509Certificates;
using SS4.Modelos;

namespace SS4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusica(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("lista de artista por gênero músical");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicaPorArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).Distinct().ToList();
        Console.WriteLine("lista de artista por gênero músical");
        foreach (var musica in musicaPorArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicaPorAno = musicas.Where(musica => musica.Ano!.Equals(ano)).Distinct().ToList();
        Console.WriteLine("lista de música por ano de lançamento");
        foreach (var musica in musicaPorAno)
        {
            Console.WriteLine($"- {musica.Nome} ({musica.Ano}).");
        }
    }
}