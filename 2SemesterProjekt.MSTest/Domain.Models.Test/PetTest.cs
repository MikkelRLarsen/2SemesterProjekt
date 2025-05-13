using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.MSTest;

[TestClass]
public class PetTest
{
    // Accept criteria: PetName is not empty or does not only contain whitespace.
    [TestMethod]
    [DataRow("Connor")]
    public void PetNameIsValid(string validPetName)
    {
        var pet = new Pet(1, validPetName, 1, DateTime.Now, null);
    }

    [TestMethod]
    [DataRow("")]
    [DataRow("       ")]
    public void PetNameIsInvalid(string invalidPetName)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, invalidPetName, 1, DateTime.Now, null));
    }

    // Accept criteria: Species is not empty or does not only contain whitespace.
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    public void SpeciesIsValid(int validSpecies)
    {
        var pet = new Pet(1, "Connor", validSpecies, DateTime.Now, null);
    }
    [TestMethod]
    [DataRow(0)]
    public void SpeciesIsInvalid(int invalidSpecies)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, "Connor", invalidSpecies, DateTime.Now, null));
    }

    // Accept criteria: CustomerID is not 0.
    [TestMethod]
    [DataRow(1)]
    public void CustomerIDIsValid(int validCustomerID)
    {
        var pet = new Pet(validCustomerID, "Connor", 1, DateTime.Now, null);
    }

    [TestMethod]
    [DataRow(0)]
    public void CustomerIDIsInvalid(int invalidCustomerID)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(invalidCustomerID, "Connor", 1, DateTime.Now, null));
    }
}