using Assets.GameLogic.Scripts.Categories;
using Assets.GameLogic.Scripts.Tools.Randomize;
using Assets.GameLogic.Scripts.Units;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameLogic.Scripts.InteractableObjects
{
  public class InterractionCalculation : MonoBehaviour
  {
    [SerializeField] private Text resultText;
    [SerializeField] private Text interractionText;

    public void Generate()
    {
      var unit = GameStateController.CurrentUnit;
      var interactableObject = GameStateController.InteractableObject;

      var subCategoryType = interactableObject.SubCategory.GetType();
      var attitude = 0;
        
      if (subCategoryType == typeof(AppleSubCategory))
      {
        attitude = Randomizer.Do(-30, 30) + unit.InteractableObjectsMap.AppleMapCell.Attitude;
      }
      if (subCategoryType == typeof(PotatoSubCategory))
      {
        attitude = Randomizer.Do(-30, 30) + unit.InteractableObjectsMap.PotatoMapCell.Attitude;
      }
      if (subCategoryType == typeof(ChairSubCategory))
      {
        attitude = Randomizer.Do(-30, 30) + unit.InteractableObjectsMap.ChairMapCell.Attitude;
      }

      var res = CalcAffect(attitude);
      var resultString = string.Empty;
      var interractionResult = string.Empty;
      var ares = interactableObject.CardableObject.Get(res)[0].Do(unit);

      switch (res)
      {
        case Unit.AttitudePower.Min:
        {
          resultString = "ненавидит";
            break;
        }
          case Unit.AttitudePower.Low:
        {
          resultString = "недолюбливает";
          break;
        }
          case Unit.AttitudePower.Normal:
        {
          resultString = "норм";
            break;
        }
        case Unit.AttitudePower.Hight:
        {
          resultString = "любит";
            break;
        }
          case Unit.AttitudePower.Max:
        {
          resultString = "обожает";
          break;
        }
      }

      interractionText.text = string.Format("{0} {1} {2}", unit.Name.Value, ares.Text, interactableObject.Name);
      resultText.text = string.Format("{0} {1} {2}", unit.Name.Value, resultString, interactableObject.Name);
    }

    private Unit.AttitudePower CalcAffect(int val)
    {
      if(val < -60)
        return Unit.AttitudePower.Min;
      if(val > -60 && val < -20)
        return Unit.AttitudePower.Low;
      if(val > -20 && val < 20)
        return Unit.AttitudePower.Normal;
      if(val > 20 && val < 60)
        return Unit.AttitudePower.Hight;
  //    if(val > 60)
        return Unit.AttitudePower.Max;
    }
  }
}