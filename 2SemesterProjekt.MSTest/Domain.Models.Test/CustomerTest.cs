using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class CustomerTest
{
	// Arrange
	private string _firstName = "Lars";
	private string _lastName = "Nielsen";
	private string _email = "larsnielsen@mail.dk";
	private string _type = "Privat";
	private string _address = "larsvej 10, 7100 Vejle";
	private int _phone = 45461026;

	/// <summary>
	/// Acceptcriteria: FirstName only contains letters
	/// </summary>
	[TestMethod]
	[DataRow("Lars")]
	public void Given_First_Name_Is_Valid__Then_Entity_Is_Created(string validFirstName)
    {
		// Act
		var sut = new Customer(validFirstName, _lastName, _email, _address, _type, _phone);
    }

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("Lars!")]
	[DataRow("Lars1")]
	public void Given_First_Name_Is_Invalid__Then_ArgumentExeptiono_Is_Thrown(string invalidFirstName)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
		new Customer(invalidFirstName, _lastName, _email, _address, _type, _phone)
		);
	}

	/// <summary>
	/// Acceptcriteria: LastName only contains letters
	/// </summary>
	[TestMethod]
	[DataRow("Lars")]
	public void Given_Last_Name_Is_Valid__Then_Entity_Is_Created(string validLastName)
	{
		// Act
		var sut = new Customer(_firstName, validLastName, _email, _address, _type, _phone);
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("123")]
	[DataRow("Nielsen!")]
	public void Given_Last_Name_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidLastName)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Customer(_firstName, invalidLastName, _email, _address, _type, _phone)
		);
	}

	/// <summary>
	/// Acceptcriteria: Email contains @ and .
	/// </summary>
	[TestMethod]
	[DataRow("lars@mail.com")]
	[DataRow("user.name123@gmail.com")]
	[DataRow("lars.nielsen@outlook.dk")]
	public void Given_Email_Is_Valid__Then_Entity_Is_Created(string validEmail)
	{
		// Act
		var sut = new Customer(_firstName, _lastName, validEmail, _address, _type, _phone);
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("invalidemail")]
	[DataRow("test@")]
	[DataRow("@mail.com")]
	[DataRow("test@mail")]
	[DataRow("test@mail,com")]
	public void Given_Email_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidEmail)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Customer(_firstName, _lastName, invalidEmail, _address, _type, _phone)
		);
	}

	/// <summary>
	/// Accept criteria: Address only contains letters and digits
	/// </summary>
	[TestMethod]
	[DataRow("Vejlevej 10, 7100 Vejle")]
	[DataRow("Testgade 4B, København")]
	public void Given_Address_Is_Valid__Then_Entity_Is_Created(string validAddress)
	{
		// Act
		var sut = new Customer(_firstName, _lastName, _email, validAddress, _type, _phone);
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("Vejlevej10")]
	[DataRow("Testgade4B")]
	[DataRow("123456")]
	[DataRow("Address")]
	
	public void Given_Address_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidAddress)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Customer(_firstName, _lastName, _email, invalidAddress, _type, _phone)
		);
	}

	/// <summary>
	/// Accept criteria: Type can only be either "Privat" or "Erhverv"
	/// </summary>
	[TestMethod]
	[DataRow("Privat")]
	[DataRow("Erhverv")]
	public void Given_Type_Is_Valid__Then_Entity_Is_Created(string validType)
	{
		// Act
		var customer = new Customer(_firstName, _lastName, _email, _address, validType, _phone);
	}

	[TestMethod]
	[DataRow("")]
	[DataRow(" ")]
	[DataRow("123")]
	[DataRow("Privat1")]
	[DataRow("Erhverv!")]
	[DataRow("Test")]
	public void Given_Type_Is_Invalid__Then_ArgumentException_Is_Thrown(string invalidType)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Customer(_firstName, _lastName, _email, _address, invalidType, _phone)
		);
	}

	/// <summary>
	/// Accept criteria: PhoneNumber only contains postive number and has a length of 8.
	/// </summary>
	[TestMethod]
	[DataRow(12345678)]
	[DataRow(87654321)]
	public void Given_Phone_Is_Valid__Then_Entity_Is_Created(int validPhone)
	{
		// Act
		var sut = new Customer(_firstName, _lastName, _email, _address, _type, validPhone);
	}

	[TestMethod]
	[DataRow(123)]
	[DataRow(123456789)]
	[DataRow(-12345678)]
	public void Given_Phone_Is_Invalid__Then_ArgumentException_Is_Thrown(int invalidPhone)
	{
		// Act & Assert
		Assert.ThrowsException<ArgumentException>(() =>
			new Customer(_firstName, _lastName, _email, _address, _type, invalidPhone)
		);
	}
}

