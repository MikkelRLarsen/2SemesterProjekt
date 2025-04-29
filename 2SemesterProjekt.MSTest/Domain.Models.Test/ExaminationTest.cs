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
	private decimal Price = 500;
	public static IEnumerable<object[]> GetInvalidPrices()
	{
		yield return new object[] { 0m };
		yield return new object[] { 100.99m };
		yield return new object[] { 0.100m };
		yield return new object[] { 0.999m };
	}



	[TestMethod]
	[DynamicData(nameof(GetInvalidPrices), DynamicDataSourceType.Method)]
	public void Given_Price_Expect_Error_Since_Its_Over_2_Digit(decimal price)
	{
		Assert.ThrowsException<ArgumentException>(() => new Examination(PetID, EmployeeID, Date, Type, price));
	}


}
