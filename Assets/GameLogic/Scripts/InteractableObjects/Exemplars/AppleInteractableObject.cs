using System.Collections.Generic;
using Assets.GameLogic.Scripts.Actions;
using Assets.GameLogic.Scripts.Categories;
using Assets.GameLogic.Scripts.Characteristics;
using Assets.GameLogic.Scripts.InteractableObjects;
using Assets.GameLogic.Scripts.Units;

public class AppleInteractableObject : InteractableObject
{
  public AppleInteractableObject()
  {
    Category = new FoodCategory();
    SubCategory = new AppleSubCategory();
    Characteristics = new List<Characteristic.Type> {Characteristic.Type.Poison};
    SetCardableObject();
  }

  private void SetCardableObject()
  {
    if (Characteristics.Contains(Characteristic.Type.Poison))
    {
      CardableObject.Set(Unit.AttitudePower.Max, new List<Card> {new Card(new EatAction("сьел с огрызком"))});
      CardableObject.Set(Unit.AttitudePower.Hight, new List<Card> {new Card(new EatAction("сьел"))});
      CardableObject.Set(Unit.AttitudePower.Normal, new List<Card> {new Card(new PeekAction("взял с собой"))});
      CardableObject.Set(Unit.AttitudePower.Low, new List<Card> {new Card(new IgnoreAction("проигнорировал"))});
      CardableObject.Set(Unit.AttitudePower.Min, new List<Card> {new Card(new IgnoreAction("выбросил"))});
    }
    else
    {
      
    }
  }

  protected override string GenName()
  {
    return "Никакое яблоко";
  }
}