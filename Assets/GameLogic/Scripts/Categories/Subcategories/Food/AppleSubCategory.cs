namespace Assets.GameLogic.Scripts.Categories
{
  public class AppleSubCategory : FoodSubCategory
  {
    private string _name = "Яблоко";
    public override string Name {
      get { return _name; }
      protected set { _name = value; }
    }

    public AppleSubCategory() {
      Type = FoodSubCategoryType.Apple;
    }

    public override string TypeToString()
    {
      return Type.ToString();
    }
  }
}