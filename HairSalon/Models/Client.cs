using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _id;
    private int _sylistId;

    public Client (string name, int sylistId , int id = 0)
    {
      _name = name;
      _sylistId = sylistId;
      _id = id;

    }

    public string GetClientName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public int GetStylistId()
    {
      return _sylistId;
    }
  }
}
