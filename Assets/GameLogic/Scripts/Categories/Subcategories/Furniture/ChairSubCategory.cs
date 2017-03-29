namespace Assets.GameLogic.Scripts.Categories
{
  public class ChairSubCategory : FurnitureSubCategory
  {
    private string _name = "Стул";
    public override string Name {
      get { return _name; }
      protected set { _name = value; }
    }

    public ChairSubCategory() {
      Type = FurnitureSubCategoryType.Chair;
    }

    public override string TypeToString()
    {
      return Type.ToString();
    }
  }
}