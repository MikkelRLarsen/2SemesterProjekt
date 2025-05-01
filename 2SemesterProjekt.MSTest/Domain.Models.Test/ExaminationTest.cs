using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class ExaminationTest
{
	// Arrange
	private int PetID = 1;
	private int EmployeeID = 1;
	private DateTime Date = DateTime.Now;
	private int ExaminationTypeID = 1;
	private decimal Price = 500m;

	[TestMethod]
	public void Constructor_ValidData_ShouuldCreateObject()
	{
		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, Price);

		// Assert
		Assert.AreEqual(PetID, exam.PetID);
		Assert.AreEqual(EmployeeID, exam.EmployeeID);
		Assert.AreEqual(Date, exam.Date);
		Assert.AreEqual(ExaminationTypeID, exam.ExaminationTypeID);
		Assert.AreEqual(Price, exam.Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PetidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(0, EmployeeID, Date, ExaminationTypeID, Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_EmployeeidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(PetID, 0, Date, ExaminationTypeID, Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_ExaminationTypeidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(PetID, EmployeeID, Date, 0, Price);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PriceWithTooManyDecimals_ShouldThrowException()
	{
		// Arrange
		decimal priceWithTooManyDecimals = 123.456m;

		// Act
		_ = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, priceWithTooManyDecimals);
	}

	[TestMethod]
	public void Constructor_PriceWithTwoDecimals_ShouldNotThrow()
	{
		// Arrange
		decimal validPriceWithTwoDecimals = 123.45m;

		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, validPriceWithTwoDecimals);

		// Assert
		Assert.AreEqual(validPriceWithTwoDecimals, exam.Price);
	}


}
