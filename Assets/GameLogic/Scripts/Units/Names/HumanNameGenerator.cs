using System.Collections.Generic;
using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.Units.Names
{
  internal class HumanNameGenerator : NameGenerator
  {
    private List<string> firstManNameCollection = new List<string>
    {
      "Лёха",
      "Серёга",
      "Арагорн",
      "Джорж"
    };

    private List<string> firstFamaleNameCollection = new List<string>
    {
      "Катюха",
      "Жанна",
      "Джайна",
      "Соня"
    };

    public override string GenFirstName(Unit unit) {
      if (unit.Gender.GenderType == Gender.Type.Male)
        return firstManNameCollection[Randomizer.Do(0, firstManNameCollection.Count - 1)];
      return firstFamaleNameCollection[Randomizer.Do(0, firstManNameCollection.Count - 1)];
    }

    public override string GenSecondName(Unit unit)
    {
      int border = 55;
      int minBorder = -50;

      if (unit.Gender.GenderType == Gender.Type.Male) {
        if (unit.InteractableObjectsMap.AppleMapCell.Attitude > border)
          return "Любитель яблок";
        if (unit.InteractableObjectsMap.PotatoMapCell.Attitude > border)
          return "Любитель картошки";
        if (unit.InteractableObjectsMap.ChairMapCell.Attitude > border)
          return "Любитель стульев";
      }
      if (unit.InteractableObjectsMap.AppleMapCell.Attitude > border)
        return "Любительница яблок";
      if (unit.InteractableObjectsMap.PotatoMapCell.Attitude > border)
        return "Любительница картошки";
      if (unit.InteractableObjectsMap.ChairMapCell.Attitude > border)
        return "Любительница стульев";

      if (unit.Gender.GenderType == Gender.Type.Male) {
        if (unit.InteractableObjectsMap.AppleMapCell.Attitude < minBorder)
          return "Нелюбитель яблок";
        if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
          return "Не фанат картошки";
        if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
          return "Брюзга стульев";
      }
      if (unit.InteractableObjectsMap.AppleMapCell.Attitude < minBorder)
        return "Не фанатка яблок";
      if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
        return "Не фанатка картошки";
      if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
        return "Не любительница стульев";
      return string.Empty;
    }
  }
}