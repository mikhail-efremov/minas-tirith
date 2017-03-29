using Assets.GameLogic.Scripts.Units;

namespace Assets.GameLogic.Scripts.Actions
{
  public class PeekAction : Action
  {
    public PeekAction(string text) : base(text)
    {
    }

    public override ActionResult Do(IUnit unit)
    {
      return new ActionResult(_text);
    }
  }
}