
using Assets.GameLogic.Scripts.Units;

namespace Assets.GameLogic.Scripts.Actions
{
  public class IgnoreAction : Action
  {
    public IgnoreAction(string text) : base(text)
    {
    }

    public override ActionResult Do(IUnit unit)
    {
      return new ActionResult(_text);
    }
  }
}