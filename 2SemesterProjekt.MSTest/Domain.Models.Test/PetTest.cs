using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProject.Domain.Models;
namespace _2SemesterProjekt.MSTest;

[TestClass]
public class PetTest
{
    [TestMethod]
    [DataRow("Connor")]
    public void PetNameIsValid(string validPetName)
    {
        var pet = new Pet(1, validPetName, "Hund", DateTime.Now);
    }

    [TestMethod]
    [DataRow("")]
    [DataRow("       ")]
    public void PetNameIsInvalid(string invalidPetName)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, invalidPetName, "Hund", DateTime.Now));
    }

    [TestMethod]
    [DataRow("Hund")]
    [DataRow("Kat")]
    public void SpeciesIsValid(string validSpecies)
    {
        var pet = new Pet(1, "Connor", validSpecies, DateTime.Now);
    }
    [TestMethod]
    [DataRow("")]
    [DataRow("     ")]
    public void SpeciesIsInvalid(string invalidSpecies)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(1, "Connor", invalidSpecies, DateTime.Now));
    }

    [TestMethod]
    [DataRow(1)]
    public void CustomerIDIsValid(int validCustomerID)
    {
        var pet = new Pet(validCustomerID, "Connor", "Hund", DateTime.Now);
    }

    [TestMethod]
    [DataRow(0)]
    public void CustomerIDIsInvalid(int invalidCustomerID)
    {
        Assert.ThrowsException<ArgumentException>(() =>
        new Pet(invalidCustomerID, "Connor", "Hund", DateTime.Now));
    }
}
