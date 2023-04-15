using System.Text.Json.Serialization;

namespace MovieApp.Models;

//API key = 3d16f1e91053992401099962ac5650c9

public record MovieResponse {

    [JsonPropertyName("page")]
    public int page { get; init; }

    // [JsonPropertyName("results")]
    // public string results { get; init; }

    [JsonPropertyName("poster_path")]
    public string poster_path { get; init; }

    [JsonPropertyName("adult")]
    public bool adult { get; init; }

    [JsonPropertyName("overview")]
    public string overview { get; init; }

    [JsonPropertyName("release_date")]
    public string release_date { get; init; }

    [JsonPropertyName("genre_ids")]
    public int[] genre_ids { get; init; }

    [JsonPropertyName("id")]
    public int id { get; init; }

    [JsonPropertyName("original_title")]
    public string original_title { get; init; }

    [JsonPropertyName("original_language")]
    public string original_language { get; init; }

    [JsonPropertyName("title")]
    public string title { get; init; }

    [JsonPropertyName("backdrop_path")]
    public string backdrop_path { get; init; }

    [JsonPropertyName("popularity")]
    public int popularity { get; init; }

    [JsonPropertyName("vote_count")]
    public int vote_count { get; init; }

    [JsonPropertyName("video")]
    public bool video { get; init; }

    [JsonPropertyName("vote_average")]
    public int vote_average { get; init; }

    [JsonPropertyName("total_results")]
    public int total_results { get; init; }

    [JsonPropertyName("total_pages")]
    public int total_pages { get; init; }

}

