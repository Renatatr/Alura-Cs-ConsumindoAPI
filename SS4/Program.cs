using System.Text.Json;
using SS4.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
      //  LinqFilter.FiltrarTodosGenerosMusicais(musicas);
      //  LinqOrder.ExibirListaArtistasOrdenados(musicas);
      //  LinqFilter.FiltrarArtistaPorGeneroMusica(musicas, "blues");
      //  LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
      //  LinqFilter.FiltrarMusicasPorAno(musicas, "2012");

        var musicasPreferidasRenata = new MusicasPreferidas("RENATA");
        musicasPreferidasRenata.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasRenata.AdicionarMusicasFavoritas(musicas[11]);
        musicasPreferidasRenata.AdicionarMusicasFavoritas(musicas[10]);
        musicasPreferidasRenata.AdicionarMusicasFavoritas(musicas[111]);
        musicasPreferidasRenata.AdicionarMusicasFavoritas(musicas[1111]);
        
        musicasPreferidasRenata.ExibirMusicasFavoritas();
        
        var musicasPreferidasJose = new MusicasPreferidas("RENATA");
        musicasPreferidasJose.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasJose.AdicionarMusicasFavoritas(musicas[22]);
        musicasPreferidasJose.AdicionarMusicasFavoritas(musicas[20]);
        musicasPreferidasJose.AdicionarMusicasFavoritas(musicas[222]);
        musicasPreferidasJose.AdicionarMusicasFavoritas(musicas[3]);
                         
        musicasPreferidasJose.ExibirMusicasFavoritas();

        musicasPreferidasJose.GerarArquivoJSON();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
    }
    
}