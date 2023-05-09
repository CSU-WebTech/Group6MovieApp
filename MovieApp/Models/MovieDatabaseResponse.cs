using System.Text.Json.Serialization;

namespace MovieApp.Models;

public record MovieResponse {

    [JsonPropertyName("results")]
    public string? results { get; init; }

    [JsonPropertyName("poster_path")]
    public string? poster_path { get; init; }

    [JsonPropertyName("genre_ids")]
    public int[] genre_ids { get; init; }

    [JsonPropertyName("id")]
    public int? id { get; init; }

    [JsonPropertyName("title")]
    public string? title { get; init; }

    [JsonPropertyName("backdrop_path")]
    public string? backdrop_path { get; init; }

    [JsonPropertyName("vote_average")]
    public double? vote_average { get; init; }

    [JsonPropertyName("total_results")]
    public int? total_results { get; init; }

}

