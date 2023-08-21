using SS4.Modelos;

namespace SS4.Filtros;

internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct()
            .ToList();
        Console.WriteLine("Lista:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}