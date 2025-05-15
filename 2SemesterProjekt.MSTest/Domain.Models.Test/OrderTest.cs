namespace _2SemesterProjekt.MSTest;
using _2SemesterProjekt.Domain.Models;

[TestClass]
public class OrderTest
{
    // Arrange
    private int CustomerID = 3;
    private DateTime OrderDate = DateTime.Now;
    private int TotalPrice = 50;

    [TestMethod]
    public void OrderWithCustomerID_ShouldBeCreated()
    {
        // Act
        Order validOrder = new Order(CustomerID, OrderDate, TotalPrice);

        // Assert
        Assert.AreEqual(validOrder.CustomerID, CustomerID);
        Assert.AreEqual(validOrder.OrderDate, OrderDate);
        Assert.AreEqual(validOrder.TotalPrice, TotalPrice);
    }

    [TestMethod]
    public void OrderWithoutCustomerID_ShouldBeCreated()
    {
        // Act
        Order validOrder = new Order(OrderDate, TotalPrice);

        // Assert
        Assert.AreEqual(validOrder.OrderDate, OrderDate);
        Assert.AreEqual(validOrder.TotalPrice, TotalPrice);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void OrderWithInvalidCustomerID_ShouldThrowException()
    {
        // Act
        Order invalidOrder = new Order(0, OrderDate, TotalPrice);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void OrderWithInvalidTotalPrice_ShouldThrowException()
    {
        // Act
        Order invalidOrder = new Order(OrderDate, -300);
    }
}
