using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        var pet = new Pet(1, validPetName, "Hund", DateTime.Now, null);
    }

    [TestMethod]
    [DataRow("")]
    [DataRow("       ")]
    public void PetNameIsInvalid(string invalidPetName)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, invalidPetName, "Hund", DateTime.Now, null));
    }

    // Accept criteria: Species is not empty or does not only contain whitespace.
    [TestMethod]
    [DataRow("Hund")]
    [DataRow("Kat")]
    public void SpeciesIsValid(string validSpecies)
    {
        var pet = new Pet(1, "Connor", validSpecies, DateTime.Now, null);
    }
    [TestMethod]
    [DataRow("")]
    [DataRow("     ")]
    public void SpeciesIsInvalid(string invalidSpecies)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, "Connor", invalidSpecies, DateTime.Now, null));
    }

    // Accept criteria: CustomerID is not 0.
    [TestMethod]
    [DataRow(1)]
    public void CustomerIDIsValid(int validCustomerID)
    {
        var pet = new Pet(validCustomerID, "Connor", "Hund", DateTime.Now, null);
    }

    [TestMethod]
    [DataRow(0)]
    public void CustomerIDIsInvalid(int invalidCustomerID)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(invalidCustomerID, "Connor", "Hund", DateTime.Now, null));
    }
}
