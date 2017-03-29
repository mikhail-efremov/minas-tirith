namespace Assets.GameLogic.Scripts.Units
{
  public class Gender
  {
    public enum Type
    {
      Male = 0,
      Famale = 1
    }

    private Type _genderType;
    public Type GenderType {
      get { return _genderType; }
    }

    public Gender(Type type)
    {
      _genderType = type;
    }

    public override string ToString()
    {
      return string.Format("{0}", _genderType);
    }
  }
}