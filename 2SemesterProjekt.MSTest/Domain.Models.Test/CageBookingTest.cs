using _2SemesterProjekt.Domain.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class CageBookingTest
{
    // Arrange
    private DateTime StartDate = DateTime.Now;
    private DateTime EndDate = DateTime.Now.AddDays(2);
    private decimal Price = 500m;
    private int CageID = 1;

    [TestMethod]
    public void Constructor_ValidData_ShouldCreateObject()
    {
        // Act
        CageBooking newCageBooking = new CageBooking(StartDate, EndDate, Price, CageID);

        // Assert
        Assert.AreEqual(StartDate, newCageBooking.StartDate);
        Assert.AreEqual(EndDate, newCageBooking.EndDate);
        Assert.AreEqual(Price, newCageBooking.TotalPrice);
        Assert.AreEqual(CageID, newCageBooking.CageID);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_StartDateIsBeforeTodaysDate_ShouldThrowException()
    {
        // Arrange
        DateTime negativeDate = DateTime.Now.AddDays(-1);
        
        //Act
        _ = new CageBooking(negativeDate, EndDate, Price, CageID);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_PriceWithTooManyDecimals_ShouldThrowException()
    {
        // Arrange
        decimal priceWithTooManyDecimals = 123.456m;

        // Act
        _ = new CageBooking(StartDate, EndDate, priceWithTooManyDecimals, CageID);
    }

    [TestMethod]
    public void Constructor_PriceWithTwoDecimals_ShouldNotThrow()
    {
        // Arrange
        decimal validPriceWithTwoDecimals = 123.45m;

        // Act
        CageBooking newCageBooking = new CageBooking(StartDate, EndDate, validPriceWithTwoDecimals, CageID);

        // Assert
        Assert.AreEqual(validPriceWithTwoDecimals, newCageBooking.TotalPrice);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_CageBookingIdZero_ShouldThrowException()
    {
        // Act
        _ = new CageBooking(StartDate, EndDate, Price, 0);
    }
}
