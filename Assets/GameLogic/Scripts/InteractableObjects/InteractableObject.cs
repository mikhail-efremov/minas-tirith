using System;
using System.Collections.Generic;
using Assets.GameLogic.Scripts.Categories;
using Assets.GameLogic.Scripts.Characteristics;
using Assets.GameLogic.Scripts.Tools.Randomize;

namespace Assets.GameLogic.Scripts.InteractableObjects
{
  public abstract class InteractableObject : ICharacteristicable
  {
    public String Name { get; protected set; }
    public Category Category { get; protected set; }
    public SubCategory SubCategory { get; protected set; }
    public List<Characteristic.Type> Characteristics { get; protected set; }

    public CardableObject CardableObject = new CardableObject();

    protected abstract string GenName();

    public InteractableObject()
    {
      Name = GenName();
    }

    public static InteractableObject GetRandom()
    {
      var value = Randomizer.Do(0, 2);

      switch (value)
      {
        case 0: 
          {
            return new AppleInteractableObject();
          }

        case 1:
        {
          return new PotatoInteractableObject();
        }
        case 2:
        {
            return new ChairInteractableObject();
        }
      }
      return null;
    }
  }
}