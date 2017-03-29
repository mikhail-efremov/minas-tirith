namespace Assets.GameLogic.Scripts.Units.Names
{
  internal abstract class NameGenerator
  {
    public abstract string GenFirstName(Unit unit);
    public abstract string GenSecondName(Unit unit);
  }
}