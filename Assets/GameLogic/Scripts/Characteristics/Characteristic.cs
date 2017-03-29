namespace Assets.GameLogic.Scripts.Characteristics
{
  public class Characteristic
  {
    public enum Type
    {
      Poison
    }

    public Characteristic.Type CharacteristicType { get; private set; }
    
    public Characteristic(Characteristic.Type type)
    {
      CharacteristicType = type;
    }

    public static Characteristic Create(Characteristic.Type type)
    {
      switch (type)
      {
        case Characteristic.Type.Poison:
        {
            return new PoisonCharacteristic(type);
        }
      }
      return null;
    }
  }
}