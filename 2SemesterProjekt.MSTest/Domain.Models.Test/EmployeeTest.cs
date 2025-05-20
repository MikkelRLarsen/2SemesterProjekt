using _2SemesterProjekt.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class EmployeeTest
{
	// Arrange - gyldige standardværdier
	private string _firstName = "Anna";
	private string _lastName = "Jensen";

	/// <summary>
	/// Accept criteria: FirstName must contain only letters
	/// </summary>
	[TestMethod]
	[DataRow("Anna")]
	[DataRow("Mikkel")]
	public void Given_First_Name_Is_Valid__Then_Entity_Is_Created(string validFirstName)
	{
		// Act
		var employee = new Employee(validFirstName, _lastName, "Dyrelæge");
	}

	[TestMethod]
	[DataRow("Anna123")]
	[DataRow("123")]
	[DataRow("Anna!")]
	[DataRow(" ")]
	[DataRow("")]
	public void Given_First_Name_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidFirstName)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Employee(invalidFirstName, _lastName, "Assistent")
		);
	}

	/// <summary>
	/// Accept criteria: LastName must contain only letters
	/// </summary>
	[TestMethod]
	[DataRow("Jensen")]
	[DataRow("Larsen")]
	public void Given_Last_Name_Is_Valid__Then_Entity_Is_Created(string validLastName)
	{
		// Act
		var employee = new Employee(_firstName, validLastName, "Receptionist");
	}

	[TestMethod]
	[DataRow("Jensen123")]
	[DataRow("123")]
	[DataRow("Jensen!")]
	[DataRow(" ")]
	[DataRow("")]
	public void Given_Last_Name_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidLastName)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Employee(_firstName, invalidLastName, "Receptionist")
		);
	}

	/// <summary>
	/// Accept criteria: Type must be either "Dyrelæge", "Assistent", or "Receptionist"
	/// </summary>
	[TestMethod]
	[DataRow("Dyrelæge")]
	[DataRow("Assistent")]
	[DataRow("Receptionist")]
	public void Given_Type_Is_Valid__Then_Entity_Is_Created(string validType)
	{
		// Act
		var employee = new Employee(_firstName, _lastName, validType);
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("Chef")]
	[DataRow("Dyrelæge1")]
	[DataRow("Assistent!")]
	[DataRow("Reception")]
	public void Given_Type_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidType)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Employee(_firstName, _lastName, invalidType)
		);
	}
}
