using System;

namespace Proyecto;

public class Employer : IUser
{
    public string Username {get;}
    public string Password {get;}
    public string Name {get;}
    public string Phone {get;}
    public string Address {get;}
    public int Score {get;}

    public Employer(string username, string password, string name, string phone, string address)
    {
        this.Username = username;
        this.Password = password;
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }
}