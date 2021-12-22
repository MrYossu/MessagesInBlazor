using Messages.Models;

namespace Messages.MessageStuff; 

public class SoupDragon {
  public Action<Widget> NewWidget;

  public void RaiseNewWidget(Widget w) =>
    NewWidget?.Invoke(w);
}