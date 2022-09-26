using System;

namespace Proyecto;

public class Admin : IUser
{
    public string Username {get;}
    public string Password {get;}

    public Admin(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
    public void CreateService(string name, string description)
    {

    }
    public void RemoveService(string name, string description)
    {
        
    }
    public void RemoveOffer(string name, string description)
    {
        
    }
}