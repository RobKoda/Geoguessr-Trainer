namespace GeoguessrTrainer.Domains.Game;

public static class ListExtensions
{
    public static IList<T> Shuffle<T>(this IEnumerable<T> list)
    {
        var theNewList = new List<T>(list);
        var rng = new Random();
        var n = theNewList.Count;

        while (n > 1) {
            n--;
            var k = rng.Next(n + 1);
            (theNewList[k], theNewList[n]) = (theNewList[n], theNewList[k]);
        }

        return theNewList;
    }
}