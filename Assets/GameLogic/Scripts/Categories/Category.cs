using System;
using Assets.GameLogic.Scripts.Tools.Randomize;
using UnityEngine;

namespace Assets.GameLogic.Scripts.Categories
{
  public class Category
  {
    public CategoryType CategoryType { get; private set; }

    public SubCategory SubCategory { get; protected set; }

    public Category(CategoryType type)
    {
      CategoryType = type;
    }
    /*
    public static InteractableObject Create(CategoryType category)
    {
      switch (category)
      {
        case CategoryType.Food:
        {
            return new FoodCategory();
        }
        case CategoryType.Furniture:
        {
            return new FurnitureCategory();
        }
      }
      throw new ArgumentException();
    }
    */

    public override string ToString()
    {
      return CategoryType.ToString();
    }

    public static Category Random()
    {
      var ci = Randomizer.Do(0, 1);

      if (ci == 0)
      {
        var cat = new FoodCategory();
        var subi = Randomizer.Do(0, 1, (int)Time.time);
        if (subi == 0)
        {
          cat.SubCategory = new AppleSubCategory();
          return cat;
        }
        if (subi == 1)
        {
          cat.SubCategory = new PotatoSubCategory();
          return cat;
        }
      }
      else if (ci == 1)
      {
        var cat = new FurnitureCategory();
        cat.SubCategory = new ChairSubCategory();
        return cat;
      }
      throw new ArgumentException();
    }
  }
}