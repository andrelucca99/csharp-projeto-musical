using System.Text.Json;
using ScreenSound_04_api.Filtros;
using ScreenSound_04_api.Modelos;

using (HttpClient client = new HttpClient())
{
  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    LinqFilter.FiltrarMusicasEmCSharp(musicas);

    // musicas[1].ExibirDetalhesDaMusica();
    // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
    // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Katy Perry");
    // LinqFilter.FiltrarMusicasPeloAno(musicas, 1999);

    // var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
    // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
    // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
    // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
    // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
    // musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

    // musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
    // musicasPreferidasDoDaniel.GerarArquivoJson();
    // musicasPreferidasDoDaniel.GerarDocumentoTXTComAsMusicasFavoritas();
  }
  catch (Exception err)
  {
    Console.WriteLine($"erro: {err.Message}");
  }
}