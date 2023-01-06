using System.Text.Json.Serialization;
using GeoGuessrTrainer.DomainGame.Game;

namespace GeoGuessrTrainer.DomainGame.Stats;

public sealed class CountryStat
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global - Init through Json deserialization
    public GuessableDomain GuessableDomain { get; init; } = null!;
    public int SuccessCount { get; set; }
    public int PromptedCount { get; set; }

    // ReSharper disable once UnusedMember.Global - Retrieved in blazor data table
    [JsonIgnore] public double SuccessRate => (double)SuccessCount / PromptedCount;

    // ReSharper disable once UnusedMember.Global - Used through Json deserialization
    public CountryStat()
    {
    }

    public CountryStat(GuessableDomain inGuessableDomain)
    {
        GuessableDomain = inGuessableDomain;
    }
}