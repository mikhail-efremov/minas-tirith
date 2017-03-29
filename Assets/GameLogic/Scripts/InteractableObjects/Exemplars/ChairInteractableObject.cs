using System.Collections.Generic;
using Assets.GameLogic.Scripts.Actions;
using Assets.GameLogic.Scripts.Categories;
using Assets.GameLogic.Scripts.InteractableObjects;
using Assets.GameLogic.Scripts.Units;

public class ChairInteractableObject : InteractableObject
{
  public ChairInteractableObject() {
    Category = new FurnitureCategory();
    SubCategory = new ChairSubCategory();
    SetCardableObject();
  }

  private void SetCardableObject() {
    CardableObject.Set(Unit.AttitudePower.Max, new List<Card> { new Card(new IgnoreAction("обцеловал")) });
    CardableObject.Set(Unit.AttitudePower.Hight, new List<Card> { new Card(new IgnoreAction("сел с удовольствием на")) });
    CardableObject.Set(Unit.AttitudePower.Normal, new List<Card> { new Card(new PeekAction("взял с собой")) });
    CardableObject.Set(Unit.AttitudePower.Low, new List<Card> { new Card(new IgnoreAction("проигнорировал")) });
    CardableObject.Set(Unit.AttitudePower.Min, new List<Card> { new Card(new IgnoreAction("выбросил")) });
  }

  protected override string GenName() {
    return "Роскошный табурет";
  }
}