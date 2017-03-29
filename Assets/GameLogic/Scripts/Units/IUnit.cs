using System.Collections.Generic;
using Assets.GameLogic.Scripts.Perks;
using Assets.GameLogic.Scripts.Units.Races;

namespace Assets.GameLogic.Scripts.Units
{
  public interface IUnit
  {
    UnitName Name { get; }
    Gender Gender { get; }
    UnitRace Race { get; }
    List<Perk> Perks { get; }
    Health Health { get; }
  }
}