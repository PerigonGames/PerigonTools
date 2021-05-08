using System.Collections.Generic;

namespace PerigonGames
{
    public class RandomUtility: IRandomUtility
    {
        public readonly int Seed;
        private System.Random _random;

        public RandomUtility(int? seed = null)
        {
            Seed = seed ?? new System.Random().Next();
            _random = new System.Random(Seed);
        }

        /// <summary>
        /// an int [0..int.MaxValue)
        /// </summary>
        /// <returns>integer</returns>
        public int NextInt() => _random.Next();

        /// <summary>
        /// An int [0..maxValue)
        /// </summary>
        /// <param name="maxValue">exclusive max value</param>
        /// <returns>integer</returns>
        public int NextInt(int maxValue) => _random.Next(maxValue);

        /// <summary>
        /// An int [minvalue..maxvalue)
        /// </summary>
        /// <param name="minValue">Inclusive min value</param>
        /// <param name="maxValue">exclusive max value</param>
        /// <returns>integer</returns>
        public int NextInt(int minValue, int maxValue) => _random.Next(minValue, maxValue);

        /// <summary>
        /// Returns a double [0..1]
        /// </summary>
        /// <returns></returns>
        public double NextDouble() => _random.NextDouble();


        /// <summary>
        /// Returns true or false with 50/50 rate
        /// </summary>
        /// <returns></returns>
        public bool CoinFlip()
        {
            return _random.Next() % 2 == 0;
        }

        /// <summary>
        /// returns true or false
        /// </summary>
        /// <param name="probability">probability to return true</param>
        /// <returns>boolean</returns>
        public bool CoinFlip(float probability)
        {
            return _random.NextDouble() >= probability;
        }

        /// <summary>
        /// returns random elements from the list
        /// </summary>
        /// <param name="list">IList</param>
        /// <param name="element">element in list</param>
        /// <typeparam name="T">Type of list</typeparam>
        /// <returns>Able to get Element</returns>
        public bool NextTryGetElement<T>(IList<T> list, out T element)
        {
            if (list.IsNullOrEmpty() || _random == null)
            {
                element = default;
                return false;
            }

            element = list[_random.Next(0, list.Count)];
            return true;
        }

    }
}