using System.Text.Json.Serialization;

namespace MovieApp.Models;

//API key = 3d16f1e91053992401099962ac5650c9

public record MovieResponse {
    //original_title, poster_path, "genres": id, "name"

    [JsonPropertyName('original_title')]
    public string original_title { get; init; }

    [JsonPropertyName('poster_path')]
    public string poster_path { get; init; }

    [JsonPropertyName('genres.name')]
    public string genres { get; init; }

}

