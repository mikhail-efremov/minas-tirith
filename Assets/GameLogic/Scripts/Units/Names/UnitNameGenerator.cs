using Assets.GameLogic.Scripts.Units.Races;

namespace Assets.GameLogic.Scripts.Units.Names
{
  public static class UnitNameGenerator
  {
    public static string Gen(Unit unit, bool withSecondName)
    {
      var generator = GetGenerator(unit);
      if(generator == null)
        return "EMPTY_NAME";

      var firstName = generator.GenFirstName(unit);

      if (!withSecondName)
        return firstName;

      var secondName = generator.GenSecondName(unit);

      return string.Format("{0} {1}", firstName, secondName);
    }

    private static NameGenerator GetGenerator(Unit unit)
    {
      switch (unit.Race.RaceType) {
        case UnitRace.Type.Human: {
            return new HumanNameGenerator();
          }
        case UnitRace.Type.Elf: {
            return new ElfNameGenerator();
          }
        case UnitRace.Type.Orc: {
            return new OrcNameGenerator();
          }
      }
      return null;
    }
  }
}