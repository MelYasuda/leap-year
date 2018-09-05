using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    public void IsLeapYear_UserInputInteger_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(-2012));
      Assert.AreEqual(false, testLeapYear.IsLeapYear(0));
    }
    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(6));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFourNotBy100_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(96));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFourBy100Not400_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(200));
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFourBy100By400_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
