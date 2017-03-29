namespace Assets.GameLogic.Scripts.Categories
{
  public abstract class SubCategory : ISubCategory
  {
    public abstract string Name { get; protected set; }
    public int Attitude = 0;

    public abstract string TypeToString();
  }
}