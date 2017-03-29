using Assets.GameLogic.Scripts.Actions;
using Assets.GameLogic.Scripts.Units;

public class Card
{
  private Action _action;

  public Card(Action action)
  {
    _action = action;
  }

  public ActionResult Do(Unit unit)
  {
    return _action.Do(unit);
  }
}