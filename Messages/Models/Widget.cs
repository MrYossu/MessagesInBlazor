namespace Messages.Models; 

public class Widget {
  public string Name { get; set; }
  public DateTime Date { get; private set; } = DateTime.Now;
}