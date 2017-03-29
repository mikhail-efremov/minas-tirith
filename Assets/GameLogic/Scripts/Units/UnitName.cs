using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.Units
{
  public class UnitName
  {
    public string Value;

    public UnitName(string value)
    {
      Value = value;
    }

    public static UnitName GetRandomVasyaName()
    {
      return new UnitName(string.Format("Вася{0}", Randomizer.Do(0, 999)));
    }
  }
}