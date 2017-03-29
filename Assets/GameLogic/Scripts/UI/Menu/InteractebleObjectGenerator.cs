using Assets.GameLogic.Scripts.InteractableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GameLogic.Scripts.UI.Menu
{
  public class InteractebleObjectGenerator : MonoBehaviour
  {
    [SerializeField]
    private Text objectName;
    [SerializeField]
    private Text objectCategory;
    [SerializeField]
    private Text objectSubCategory;

    public void Generate()
    {
      var obj = InteractableObject.GetRandom();
      objectName.text = obj.SubCategory.Name;
      objectCategory.text = obj.Category.ToString();
      objectSubCategory.text = obj.SubCategory.TypeToString();

      GameStateController.InteractableObject = obj;
    }
  }
}