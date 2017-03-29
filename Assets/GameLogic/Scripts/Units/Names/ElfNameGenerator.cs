using System.Collections.Generic;
using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.Units.Names
{
  internal class ElfNameGenerator : NameGenerator
  {
    private List<string> firstManNameCollection = new List<string>
    {
      "Гендальф",
      "Мулфарион",
      "Иллидан",
      "Келебримбор"
    };

    private List<string> firstFamaleNameCollection = new List<string>
    {
      "Галадриэль",
      "Арвен",
      "Мелиан",
      "Тиранда"
    };

    public override string GenFirstName(Unit unit)
    {
      if(unit.Gender.GenderType == Gender.Type.Male)
        return firstManNameCollection[Randomizer.Do(0, firstManNameCollection.Count - 1)];
      return firstFamaleNameCollection[Randomizer.Do(0, firstManNameCollection.Count - 1)];
    }

    public override string GenSecondName(Unit unit)
    {
      int border = 55;
      int minBorder = -50;

      if (unit.Gender.GenderType == Gender.Type.Male)
      {
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
          return "Не любитель яблок";
        if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
          return "Не любитель картошки";
        if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
          return "Не любитель стульев";
      }
      if (unit.InteractableObjectsMap.AppleMapCell.Attitude < minBorder)
        return "Не любительница яблок";
      if (unit.InteractableObjectsMap.PotatoMapCell.Attitude < minBorder)
        return "Не любительница картошки";
      if (unit.InteractableObjectsMap.ChairMapCell.Attitude < minBorder)
        return "Не любительница стульев";
      return string.Empty;
    }
  }
}