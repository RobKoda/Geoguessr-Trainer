using System.Text.Json;
using Blazored.LocalStorage;

namespace GeoGuessrTrainer.DomainGame.Stats;

public sealed class DomainsStatsSaver
{
    private const string StatsCookieKey = "com.robkoda.geoguessrtrainer.domains";

    private readonly ILocalStorageService _localStorageService;

    public DomainsStatsSaver(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }

    public async Task SaveStats(DomainsStats stats) =>
        await _localStorageService.SetItemAsStringAsync(StatsCookieKey, JsonSerializer.Serialize(stats.Stats));

    public async Task<DomainsStats> GetStats()
    {
        var theSerializedStoredStats = await _localStorageService.GetItemAsStringAsync(StatsCookieKey);
        return string.IsNullOrWhiteSpace(theSerializedStoredStats) ? new DomainsStats() : new DomainsStats(JsonSerializer.Deserialize<IList<CountryStat>>(theSerializedStoredStats)!);
    }
}