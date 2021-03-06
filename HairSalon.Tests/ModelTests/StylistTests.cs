using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// using HairSalon.Controllers;
using HairSalon.Models;
using System;


namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {
    public void Dispose()
    {
      Client.ClearAll();
      Stylist.ClearAll();
    }
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

    [TestMethod]
    public void Save_SavesStylistToDatabase_StylistList()
    {
      //Arrage
      Stylist testStylist = new Stylist("Tavish");
      testStylist.Save();

      //Act
      List<Stylist> result = Stylist.GetAll();
      List<Stylist> testList = new List<Stylist>{testStylist};

      //Assert
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllStylistObjects_StylistList()
    {
      //Arrange
      string name01 = "Tavish";
      string name02 = "OKeefe";
      Stylist newStylist1 = new Stylist(name01);
      newStylist1.Save();
      Stylist newStylist2 = new Stylist(name02);
      newStylist2.Save();
      List<Stylist> newList = new List<Stylist>{ newStylist1, newStylist2 };

      //Act
      List<Stylist> result = Stylist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectStylist_Stylist()
    {
      //Arrange
      Stylist testStylist = new Stylist("Tavish");
      testStylist.Save();

      //Act
      Stylist foundStylist = Stylist.Find(testStylist.GetId());

      //Assert
      Assert.AreEqual(testStylist, foundStylist);
    }

    [TestMethod]
    public void GetClients_ReturnsEmptyClientList_ClientList()
    {
      //Arrange
      string name = "Fred";
      Stylist newStylist = new Stylist(name);
      List<Client> newList = new List<Client>{};

      //Act
      List<Client> result = newStylist.GetClients();

      //Arrange
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetClients_RetrievesAllClientsWithStylist_ClientList()
    {
      //Arrange, Act
      Stylist testStylist = new Stylist("Tavish");
      testStylist.Save();
      Client firstClient = new Client("George", testStylist.GetId());
      firstClient.Save();
      Client secondClient = new Client("Susan", testStylist.GetId());
      secondClient.Save();
      List<Client> testClientList = new List<Client> {firstClient, secondClient};
      List<Client> resultClientList = testStylist.GetClients();

      //Assert
      CollectionAssert.AreEqual(testClientList, resultClientList);
    }


  }
}
