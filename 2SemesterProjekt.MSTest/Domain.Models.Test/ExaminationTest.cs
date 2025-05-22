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
	private int CageBookingID = 1;

	[TestMethod]
	public void Constructor_ValidData_ShouuldCreateObject()
	{
		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, Price, CageBookingID);

		// Assert
		Assert.AreEqual(PetID, exam.PetID);
		Assert.AreEqual(EmployeeID, exam.EmployeeID);
		Assert.AreEqual(Date, exam.Date);
		Assert.AreEqual(ExaminationTypeID, exam.ExaminationTypeID);
		Assert.AreEqual(Price, exam.Price);
		Assert.AreEqual(CageBookingID, exam.CageBookingID);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PetidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(0, EmployeeID, Date, ExaminationTypeID, Price, CageBookingID);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_EmployeeidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(PetID, 0, Date, ExaminationTypeID, Price, CageBookingID);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_ExaminationTypeidZero_ShouldThrowException()
	{
		//Act
		_ = new Examination(PetID, EmployeeID, Date, 0, Price, CageBookingID);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Constructor_PriceWithTooManyDecimals_ShouldThrowException()
	{
		// Arrange
		decimal priceWithTooManyDecimals = 123.456m;

		// Act
		_ = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, priceWithTooManyDecimals, CageBookingID);
	}

	[TestMethod]
	public void Constructor_PriceWithTwoDecimals_ShouldNotThrow()
	{
		// Arrange
		decimal validPriceWithTwoDecimals = 123.45m;

		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, validPriceWithTwoDecimals, CageBookingID);

		// Assert
		Assert.AreEqual(validPriceWithTwoDecimals, exam.Price);
	}

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_CageBookingIdZero_ShouldThrowException()
    {
        // Act
        _ = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, Price, 0);
    }

    [TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void Validation_AddingInvalidCageBookingToExam_ShouldThrowException()
	{
		// Arrange
		int invalidCageBooking = 0;

		// Act
		Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, Price, CageBookingID);
		exam.SetCageBookingID(invalidCageBooking);
    }

	[TestMethod]
	public void Validation_AddingValidCageBookingToExam_ShouldNotThrow()
	{
		// Arrange
		int validCageBooking = 1;

        // Act
        Examination exam = new Examination(PetID, EmployeeID, Date, ExaminationTypeID, Price, CageBookingID);
        exam.SetCageBookingID(validCageBooking);
    }
}
