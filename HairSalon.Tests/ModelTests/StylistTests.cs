using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// using HairSalon.Controllers;
using HairSalon.Models;
using System;


namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest
  // : IDisposable
  {
    // public void Dispose()
    // {
    //   Client.ClearAll();
    //   Stylist.ClearAll();
    // }
    public StylistTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tavish_okeefe_test;";
    }

    [TestMethod]
    public void  GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      string result = newStylist.GetName();

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_Int()
    {
      //Arrange
      string name = "Test Stylist";
      Stylist newStylist = new Stylist(name);

      //Act
      int result = newStylist.GetId();

      //Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_StylistsEmptyAtFirst_List()
    {
      //Arrange, Act
      int result = Stylist.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
    }

  }
}
