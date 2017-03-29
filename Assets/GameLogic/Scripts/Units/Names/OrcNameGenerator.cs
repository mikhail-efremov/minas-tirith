using System.Collections.Generic;
using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.Units.Names
{
  internal class OrcNameGenerator : NameGenerator
  {
    private List<string> firstManNameCollection = new List<string>
    {
      "Урук",
      "Жмурок",
      "Крылюк",
      "Жопорок"
    };

    private List<string> firstFamaleNameCollection = new List<string>
    {
      "Красава",
      "Буль-Буль",
      "Ульяна",
      "Зеленоножка"
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
          return "Жрун яблок";
        if (unit.InteractableObjectsMap.PotatoMapCell.Attitude > border)
          return "Жрун картошки";
        if (unit.InteractableObjectsMap.ChairMapCell.Attitude > border)
          return "Любитель стульев";
      }
      if (unit.InteractableObjectsMap.AppleMapCell.Attitude > border)
        return "Жруниха яблок";
      if (unit.InteractableObjectsMap.PotatoMapCell.Attitude > border)
        return "Жруниха картошки";
      if (unit.InteractableObjectsMap.ChairMapCell.Attitude > border)
        return "Любительница стульев";

      if (unit.Gender.GenderType == Gender.Type.Male) {
        if (unit.InteractableObjectsMap.AppleMapCell.Attitude < minBorder)
          return "Ненависник яблок";
        if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
          return "Ненависник картошки";
        if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
          return "Разрушитель стульев";
      }
      if (unit.InteractableObjectsMap.AppleMapCell.Attitude < minBorder)
        return "Врагунья яблок";
      if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
        return "Демониха картошки";
      if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
        return "Разрушительница стульев";
      return string.Empty;
    }
  }
}