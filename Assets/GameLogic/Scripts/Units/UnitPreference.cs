using Assets.GameLogic.Scripts.Categories;

namespace Assets.GameLogic.Scripts.Units
{
  public class UnitPreference
  {
    public Category Category { get; private set; }
    public ISubCategory SubCategory { get; private set; }
  }
}