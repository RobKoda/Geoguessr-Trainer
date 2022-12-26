using System.Text.Json.Serialization;
using GeoguessrTrainer.Domains.Game;

namespace GeoguessrTrainer.Domains.Stats;

public sealed class DomainsStats
{
    // ReSharper disable once MemberCanBePrivate.Global - Used for serialization in local storage
    public IList<CountryStat> Stats { get; }

    [JsonIgnore]
    public int TotalPrompted => Stats.Sum(inStat => inStat.PromptedCount);

    [JsonIgnore]
    public int TotalSuccess => Stats.Sum(inStat => inStat.SuccessCount);

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

    public void AddPrompted(GuessableDomain inDomain)
    {
        var theGuessableDomain = Stats.SingleOrDefault(inCountryStat => inCountryStat.GuessableDomain == inDomain);
        theGuessableDomain!.PromptedCount++;
    }

    public void AddSuccess(GuessableDomain inDomain)
    {
        var theGuessableDomain = Stats.SingleOrDefault(inCountryStat => inCountryStat.GuessableDomain == inDomain);
        theGuessableDomain!.PromptedCount++;
        theGuessableDomain.SuccessCount++;
    }
}