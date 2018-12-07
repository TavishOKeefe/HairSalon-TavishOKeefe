using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTests : IDisposable
  {
    public void Dispose()
    {
      Client.ClearAll();
      Stylist.ClearAll();
    }

    public ClientTests()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=tavish_okeefe_test;";
    }

    [TestMethod]
    public void ClientConstructor_CreatesInstanceOfClient_Client()
      {
        Client newClient = new Client("test", 1);
        Assert.AreEqual(typeof(Client), newClient.GetType());
      }

      [TestMethod]
      public void GetClientName_ReturnsName_String()
      {
        //Arrange
        string clientName = "Tavish";
        Client newClient = new Client(clientName, 1);

        //Act
        string result = newClient.GetName();

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

      [TestMethod]
      public void GetAll_ClientEmptyAtFirst_List()
      {
        //Arrange, Act
        int result = Client.GetAll().Count;

        //Assert
        Assert.AreEqual(0, result);
      }
      
      [TestMethod]
      public void Save_SavesClientToDatabase_ClientList()
      {
        //Arrage
        Client testClient = new Client("Tavish", 1);
        testClient.Save();

        //Act
        List<Client> result = Client.GetAll();
        List<Client> testList = new List<Client>{testClient};

        //Assert
        CollectionAssert.AreEqual(testList, result);
      }

      [TestMethod]
      public void GetAll_ReturnsAllClientObjects_ClientList()
      {
        //Arrange
        string name01 = "Tavish";
        string name02 = "OKeefe";
        Client newClient1 = new Client(name01, 1);
        newClient1.Save();
        Client newClient2 = new Client(name02, 2);
        newClient2.Save();
        List<Client> newList = new List<Client>{ newClient1, newClient2 };

        //Act
        List<Client> result = Client.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }
  }
}
