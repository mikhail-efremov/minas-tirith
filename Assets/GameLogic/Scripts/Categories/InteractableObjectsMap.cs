using Assets.GameLogic.Scripts.InteractableObjects;

namespace Assets.GameLogic.Scripts.Categories
{
  public class InteractableObjectsMap
  {
    public InteractableObjectMapCell AppleMapCell = new InteractableObjectMapCell(new AppleInteractableObject());
    public InteractableObjectMapCell PotatoMapCell = new InteractableObjectMapCell(new PotatoInteractableObject());
    public InteractableObjectMapCell ChairMapCell = new InteractableObjectMapCell(new ChairInteractableObject());
    
//    public FoodCategory FoodCategory = new FoodCategory();
//    public FurnitureCategory FurnitureCategory = new FurnitureCategory();
  }

  public class InteractableObjectMapCell
  {
    public InteractableObject InteractableObject { get; private set; }

    private int _attitude = 0;
    public int Attitude {
      get { return _attitude; }
      set { _attitude = value; }
    }

    public InteractableObjectMapCell(InteractableObject interactableObject)
    {
      InteractableObject = interactableObject;
    }
  }
}