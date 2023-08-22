using System.Collections;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace SS4.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")] 
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    [JsonPropertyName("key")]
    public int Chave { get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[Chave];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Duração: {Duracao/1000}");
        Console.WriteLine($"Gênero: {Genero}");
        
        Console.WriteLine($"Tonalidade: {Tonalidade}\n");
    }
}