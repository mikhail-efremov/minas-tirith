using System.Collections.Generic;
using Assets.GameLogic.Scripts.Units;

public class CardableObject
{
  private const int Count = 5;
  private readonly List<Card>[] _cardCollection = new List<Card>[Count];

  public void Set(Unit.AttitudePower index, List<Card> cards)
  {
    if((int)index > Count)
      return;
    _cardCollection[(int)index] = cards;
  }

  public List<Card> Get(Unit.AttitudePower index)
  {
    if ((int)index > Count)
      return null;
    return _cardCollection[(int)index];
  } 
}