using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.Units.Races
{
  public class UnitRace
  {
    public enum Type
    {
      Human = 0,
      Orc = 1,
      Elf = 2
    }

    public Type RaceType { get; private set; }

    public static UnitRace Random()
    {
      var index = Randomizer.Do(0, 2);
      return ByIndex(index);
    }

    public UnitRace(Type type)
    {
      RaceType = type;
    }

    public static UnitRace GetRace(Type type) {
      switch (type) {
        case Type.Human: 
          {
            return new HumanRace();
          }
          case Type.Elf:
          {
            return new ElfRace();
          }
          case Type.Orc:
          {
            return new OrcRace();
          }
      }
      return null;
    }

    public override string ToString()
    {
      return string.Format("{0}", RaceType);
    }

    private static UnitRace ByIndex(int index)
    {
      return GetRace((Type)index);
    }
  }
}