using Messages.Models;

namespace Messages.MessageStuff; 

public static class StaticChicken {
  public static Action<Widget> NewWidget;

  public static void RaiseNewWidget(Widget w) =>
    NewWidget?.Invoke(w);
}