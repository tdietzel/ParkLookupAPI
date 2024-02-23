namespace ParkLookup.Models
{
  public class State
  {
    public int StateId { get; set; }
    public List<StatePark> Parks { get; set; }
  }

  public class StatePark
  {
    public int StateParkId { get; set; }
    public int StateId { get; set; }
    public string ParkName { get; set; }
  }
}