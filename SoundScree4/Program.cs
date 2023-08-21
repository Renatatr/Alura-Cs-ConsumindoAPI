using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Temos um problema: {e.Message}");
    }
    
}