using Assets.GameLogic.Scripts.Units;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameLogic.Scripts.UI.Menu
{
  public class MainUserGenerator : MonoBehaviour
  {
    [SerializeField] private Text unitName;
    [SerializeField] private Text unitRase;
    [SerializeField] private Text unitGender;

    [SerializeField]
    private Text appleValue;
    [SerializeField]
    private Text chairValue;
    [SerializeField]
    private Text potatoValue;

    public void Generate()
    {
      var unit = Unit.Random();
      unitName.text = unit.Name.Value;
      unitRase.text = unit.Race.ToString();
      unitGender.text = unit.Gender.ToString();

      appleValue.text = unit.InteractableObjectsMap.AppleMapCell.Attitude.ToString();
      chairValue.text = unit.InteractableObjectsMap.ChairMapCell.Attitude.ToString();
      potatoValue.text = unit.InteractableObjectsMap.PotatoMapCell.Attitude.ToString();

      GameStateController.CurrentUnit = unit;
    }
  }
}