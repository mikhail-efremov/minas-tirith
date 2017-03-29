using System;

namespace Assets.GameLogic.Scripts.Tools.Randomize
{
  public class Randomizer
  {
    private static Random _random = new Random();

    public static int Do(int minValue, int maxValue)
    {
      return _random.Next(minValue, maxValue + 1);
    }

    public static int Do(int minValue, int maxValue, int seed) {
      return new Random(seed).Next(minValue, maxValue + 1);
    }
  }
}