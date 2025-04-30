using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class ExaminationTest
{
	// Arrange
	private int PetID = 1;
	private int EmployeeID = 1;
	private DateTime Date = DateTime.Now;
	private string Type = "Operation";
	private decimal Price = 500m;

	[TestMethod]
	public void Constructor_ValidData_ShouuldCreateObject()
	{
		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, Type, Price);

		// Assert
		Assert.AreEqual(PetID, exam.PetID);
		Assert.AreEqual(EmployeeID, exam.EmployeeID);
		Assert.AreEqual(Date, exam.Date);
		Assert.AreEqual(Type, exam.Type);
		Assert.AreEqual(Price, exam.Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PetidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(0, EmployeeID, Date, Type, Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_EmployeeidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(PetID, 0, Date, Type, Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PriceWithTooManyDecimals_ShouldThrowException()
	{
		// Arrange
		decimal priceWithTooManyDecimals = 123.456m;

		// Act
		_ = new Examination(PetID, EmployeeID, Date, Type, priceWithTooManyDecimals);
	}

	[TestMethod]
	public void Constructor_PriceWithTwoDecimals_ShouldNotThrow()
	{
		// Arrange
		decimal validPriceWithTwoDecimals = 123.45m;

		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, Type, validPriceWithTwoDecimals);

		// Assert
		Assert.AreEqual(validPriceWithTwoDecimals, exam.Price);
	}


}
