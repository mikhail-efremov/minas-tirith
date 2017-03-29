namespace Assets.GameLogic.Scripts.Categories
{
  public class PotatoSubCategory : FoodSubCategory
  {
    private string _name = "Картофель";
    public override string Name {
      get { return _name; }
      protected set { _name = value; }
    }

    public PotatoSubCategory() {
      Type = FoodSubCategoryType.Potato;
    }

    public override string TypeToString()
    {
      return Type.ToString();
    }
  }
}