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
    
  }
}
