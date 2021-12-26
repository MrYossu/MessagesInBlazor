using System.Collections.ObjectModel;
using Messages.MessageStuff;
using Messages.Models;
using Microsoft.AspNetCore.Components;

namespace Messages.Shared {
  public partial class WidgetList {
    [Inject]
    private SoupDragon SoupDragon { get; set; }

    private ObservableCollection<Widget> Widgets { get; } = new() { new Widget { Name = "Initial" } };

    protected override void OnInitialized() {
      SoupDragon.NewWidget += async w => {
        Widgets.Add(w);
        await InvokeAsync(StateHasChanged);
      };
      StaticChicken.NewWidget += async w => {
        Widgets.Add(w);
        await InvokeAsync(StateHasChanged);
      };
    }
  }
}