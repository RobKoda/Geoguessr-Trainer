using System.Text.Json.Serialization;
using GeoGuessrTrainer.DomainGame.Game;

namespace GeoGuessrTrainer.DomainGame.Stats;

public sealed class DomainsStats
{
    // ReSharper disable once MemberCanBePrivate.Global - Used for serialization in local storage
    public IList<CountryStat> Stats { get; }

    [JsonIgnore] private int TotalPrompted => Stats.Sum(inStat => inStat.PromptedCount);

    [JsonIgnore] private int TotalSuccess => Stats.Sum(inStat => inStat.SuccessCount);

    [JsonIgnore]
    public double SuccessPercentage => (double) TotalSuccess / TotalPrompted;

    public DomainsStats()
    {
        Stats = new List<CountryStat>();
        foreach (var theGuessable in GuessableDomain.List)
        {
            Stats.Add(new CountryStat(theGuessable));
        }
    }

    public DomainsStats(IList<CountryStat> stats)
    {
        Stats = stats;
    }

    public void AddPrompted(GuessableDomain inDomain) =>
        Stats.SingleOrDefault(inCountryStat => inCountryStat.GuessableDomain == inDomain)!.PromptedCount++;

    public void AddSuccess(GuessableDomain inDomain) =>
        Stats.SingleOrDefault(inCountryStat => inCountryStat.GuessableDomain == inDomain)!.SuccessCount++;
}