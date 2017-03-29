using System.Collections.Generic;

namespace Assets.GameLogic.Scripts.Characteristics
{
  public interface ICharacteristicable
  {
    List<Characteristic.Type> Characteristics { get; }
  }
}