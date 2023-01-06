namespace GeoGuessrTrainer.DomainGame.Game;

public sealed class GuessableDomainList
{
    private Stack<GuessableDomain> _pool = new();

    public GuessableDomain GetNext()
    {
        EnsurePoolHasNext();
        return _pool.Pop();
    }

    public void SetPool(IEnumerable<GuessableDomain> inPool) =>
        _pool = new Stack<GuessableDomain>(inPool.Shuffle());

    private void EnsurePoolHasNext()
    {
        if (!_pool.Any()) SetPool(GuessableDomain.List.Shuffle());
    }
}