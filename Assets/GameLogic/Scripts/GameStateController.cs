using Assets.GameLogic.Scripts.InteractableObjects;
using UnityEngine;
using Assets.GameLogic.Scripts.Units;

namespace Assets.GameLogic.Scripts
{
  public class GameStateController : MonoBehaviour
  {
    private static Unit _currentUnit;
    public static Unit CurrentUnit
    {
      get { return _currentUnit; }
      set { _currentUnit = value; }
    }

    private static InteractableObject _interactableObject;
    public static InteractableObject InteractableObject
    {
      get { return _interactableObject; }
      set { _interactableObject = value; }
    }
  }
}