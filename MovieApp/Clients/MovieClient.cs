using System.Net.Http.Json;
using MovieApp.Models;

namespace MovieApp.Clients;

public class MovieClient {

    private readonly HttpClient _client;

    public MovieClient(HttpClient client) {
        _client = client;
    }

    public async Task<MovieResponse> GetMovieResponse() {
        return await _client.GetFromJsonAsync<MovieResponse>("https://api.themoviedb.org/3/movie/popular?api_key=3d16f1e91053992401099962ac5650c9&language=en-US&page=1");
    }

}