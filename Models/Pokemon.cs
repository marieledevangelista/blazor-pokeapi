using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("sprites")]
    public PokemonSprites? Sprites { get; set; }
}

public class PokemonSprites
{
    [JsonPropertyName("other")]
    public PokemonOtherSprites? Other { get; set; }
}

public class PokemonOtherSprites
{
    [JsonPropertyName("official-artwork")]
    public PokemonOfficialArtwork? OfficialArtwork { get; set; }
}

public class PokemonOfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
