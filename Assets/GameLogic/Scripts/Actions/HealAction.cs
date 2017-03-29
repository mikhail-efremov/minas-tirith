using Assets.GameLogic.Scripts.Units;

namespace Assets.GameLogic.Scripts.Actions
{
  public class HealAction : Action
  {
    public int healPower = 1;

    public HealAction(string text) : base(text)
    {
    }

    public override ActionResult Do(IUnit unit)
    {
      unit.Health.Value += healPower;
      return new ActionResult(_text);
    }
  }
}