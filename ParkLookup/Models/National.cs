namespace ParkLookup.Models
{
  public class National
  {
    public int NationalId { get; set; }
    public List<NationalPark> Parks { get; set; }
  }

  public class NationalPark
  {
    public int NationalParkId { get; set; }
    public int NationalId { get; set; }
    public string ParkName { get; set; }
  }
}