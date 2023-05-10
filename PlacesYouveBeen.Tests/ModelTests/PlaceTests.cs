using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    Place newPlace = new Place();
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Seattle";
      newPlace.CityName = cityName;
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void GetPicture_ReturnsPicture_String()
    {
      string picture = "seattle.jpg";
      newPlace.Picture = picture;
      Assert.AreEqual(newPlace.Picture, picture);
    }

    [TestMethod]
    public void GetHowLongToStay_ReturnsHowLongToStay_String()
    {
      string howLongToStay = "3 days";
      newPlace.HowLongToStay = howLongToStay;
      Assert.AreEqual(newPlace.HowLongToStay, howLongToStay);
    }

    [TestMethod]
    public void GetTraveledWith_ReturnsTraveledWith_String()
    {
      string traveledWith = "myself";
      newPlace.TraveledWith = traveledWith;
      Assert.AreEqual(newPlace.TraveledWith, traveledWith);
    }

    [TestMethod]
    public void GetJournalEntry_ReturnsJournalEntry_String()
    {
      string journalEntry = "It was fun!";
      newPlace.JournalEntry = journalEntry;
      Assert.AreEqual(newPlace.JournalEntry, journalEntry); 
    }
  }
}
