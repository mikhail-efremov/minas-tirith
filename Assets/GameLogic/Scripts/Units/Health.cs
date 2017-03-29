namespace Assets.GameLogic.Scripts.Units
{ 
  public class Health
  {
    private int _value = 0;

    public int Value
    {
      get { return _value; } 
      set { _value = value; }
    }

    public Health(int value)
    {
      _value = value;
    }
  }
}