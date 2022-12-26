using System.Text.Json.Serialization;
using GeoguessrTrainer.Domains.Game;

namespace GeoguessrTrainer.Domains.Stats;

public sealed class CountryStat
{
    public GuessableDomain GuessableDomain { get; }
    public int SuccessCount { get; set; }
    public int PromptedCount { get; set; }

    [JsonIgnore] public double SuccessRate => (double)SuccessCount / PromptedCount;

    public CountryStat(GuessableDomain inGuessableDomain)
    {
        GuessableDomain = inGuessableDomain;
    }
}