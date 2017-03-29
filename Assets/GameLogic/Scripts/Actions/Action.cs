using Assets.GameLogic.Scripts.Units;

namespace Assets.GameLogic.Scripts.Actions
{
  public abstract class Action
  {
    public abstract ActionResult Do(IUnit unit);
    protected string _text;

    public Action(string text)
    {
      _text = text;
    }
  }
}