using System.Collections.Generic;
using Assets.GameLogic.Scripts.Perks;
using Assets.GameLogic.Scripts.Categories;
using Assets.GameLogic.Scripts.Units.Races;
using Assets.GameLogic.Scripts.Tools.Randomize;
using Assets.GameLogic.Scripts.Units.Names;

namespace Assets.GameLogic.Scripts.Units
{
  public class Unit : IUnit
  {
    public UnitName Name { get; private set; }
    public Gender Gender { get; private set; }
    public UnitRace Race { get; private set; }
    public List<Perk> Perks { get; private set; }
    public InteractableObjectsMap InteractableObjectsMap { get; private set; }

    private Health _health = new Health(5);
    public Health Health {
      get { return _health; }
    }

    public static Unit Random()
    {
      var unit = new Unit
      {
        Gender = new Gender((Gender.Type)Randomizer.Do(0, 1)),
        Race = UnitRace.Random()
      };
      unit.InteractableObjectsMap = CalculateCategoriesMap(unit);

      unit.Name = new UnitName(UnitNameGenerator.Gen(unit, true));
      return unit;
    }

    private static InteractableObjectsMap CalculateCategoriesMap(Unit unit)
    {
      var catMap = new InteractableObjectsMap();

      switch (unit.Race.RaceType) {
        case UnitRace.Type.Human: {
            catMap.AppleMapCell.Attitude += 10 + Randomizer.Do(-10, 10);
            catMap.PotatoMapCell.Attitude += 20 + Randomizer.Do(-15, 15);
            catMap.ChairMapCell.Attitude += Randomizer.Do(-10, 30);
            break;
          }
        case UnitRace.Type.Elf: {
            catMap.AppleMapCell.Attitude += 40 + Randomizer.Do(-50, 0);
            catMap.PotatoMapCell.Attitude += 10 + Randomizer.Do(-80, 10);
            catMap.ChairMapCell.Attitude += Randomizer.Do(15, 40);
            break;
          }
        case UnitRace.Type.Orc: {
            catMap.AppleMapCell.Attitude += -40 + Randomizer.Do(-50, 20);
            catMap.PotatoMapCell.Attitude += 10 + Randomizer.Do(-40, 10);
            catMap.ChairMapCell.Attitude += Randomizer.Do(-100, 10);
            break;
          }
      }

      switch (unit.Gender.GenderType) {
        case Gender.Type.Male: {
            catMap.PotatoMapCell.Attitude += 10 + Randomizer.Do(-10, 10);
            break;
          }
        case Gender.Type.Famale: {
            catMap.AppleMapCell.Attitude += 40 + Randomizer.Do(-50, 20);
            break;
          }
      }
      return catMap;
    }

    public enum AttitudePower
    {
      Min = 0,
      Low = 1,
      Normal = 2,
      Hight = 3,
      Max = 4
    }
  }
}