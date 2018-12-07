using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTests
  // : IDisposable
  {
    // public void Dispose()
    // {
    //   Client.ClearAll();
    //   Stylist.ClearAll();
    // }

    public ClientTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todolisttest;";
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
      {
        Client newClient = new Client("test", 1);
        Assert.AreEqual(typeof(Client), newClient.GetType());
      }

      [TestMethod]
      public void GetClientName_ReturnsClientName_String()
      {
        //Arrange
        string clientName = "Tavish";
        Client newClient = new Client(clientName, 1);

        //Act
        string result = newClient.GetClientName();

        //Assert
        Assert.AreEqual(clientName, result);
      }

      [TestMethod]
      public void GetId_ReturnsClientId_Int()
      {
        //Arrange
        string clientName = "Tavish";
        Client newClient = new Client(clientName, 1);

        //Act
        int result = newClient.GetId();

        //Assert
        Assert.AreEqual(0, result);
      }
  }
}
