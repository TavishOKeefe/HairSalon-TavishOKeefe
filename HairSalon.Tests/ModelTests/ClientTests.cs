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
  }
}
