using Messages.MessageStuff;
using Messages.Models;
using Microsoft.AspNetCore.Components;

namespace Messages.Shared {
  public partial class NewWidget {
    [Inject]
    private SoupDragon SoupDragon { get; set; }

    private Widget _widget = new();

    private void AddNewWidget() {
      SoupDragon.RaiseNewWidget(_widget);
      _widget = new();
    }
  }
}