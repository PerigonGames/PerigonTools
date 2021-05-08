using System.Collections.Generic;

namespace PerigonGames
{
    public interface IRandomUtility
    {
        int NextInt();
        int NextInt(int maxValue);
        int NextInt(int minValue, int maxValue);

        double NextDouble();

        bool CoinFlip();
        bool CoinFlip(float probability);

        bool NextTryGetElement<T>(IList<T> list, out T element);
    }
}
