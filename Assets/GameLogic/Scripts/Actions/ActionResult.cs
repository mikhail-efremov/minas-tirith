using System;

namespace Assets.GameLogic.Scripts.Actions
{
  public class ActionResult
  {
    private readonly string _text = String.Empty;
    public string Text { get { return _text; } }

    public ActionResult(string text)
    {
      _text = text;
    }
  }
}