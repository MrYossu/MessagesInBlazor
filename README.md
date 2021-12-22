# Messages in Blazor

If you're used to MVVM, and like the idea of being able to send messages around the application, without having to resort to the coupling and complexity that comes with using `Eventhandler<T>` in your Blazor components, then take a look at this very simple example.

Here we show how to broadcast and receive messages, irrespective of where in the UI tree the components live.

As an added bonus, with one simple change, we can recreate SignalR!

See [this blog post](https://www.pixata.co.uk/2021/12/22/mvvm-style-messaging-in-blazor/) for more details.
