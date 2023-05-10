using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Picture {get; set;}
    public string HowLongToStay { get; set; }
    public string TraveledWith { get; set; }
    public string JournalEntry { get; set;}
    public int Id { get; }
    private static List<Place> _instances = new List<Place> {};
    
    public Place()
    {
      _instances.Add(this);
      Id = _instances.Count; 
    }
    public Place(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count; 
    }
    public Place(string cityName, string picture, string howLongToStay, string traveledWith, string journalEntry)
    {
      CityName = cityName;
      Picture = picture;
      HowLongToStay = howLongToStay;
      TraveledWith = traveledWith;
      JournalEntry = journalEntry;
      _instances.Add(this);
      Id = _instances.Count; 
    }
    public static void ClearAll()
    {
      _instances.Clear(); 
    }
    public static List<Place> GetAll()
    {
      return _instances; 
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}