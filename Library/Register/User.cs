using System;

namespace Proyecto;

public abstract class User
{
    protected User(string username, string password, string name)
    {
        this.Username = username;
        this.Password = password;
        this.Name = name;
    }
    public string Username {get;}
    public string Password {get;}
    public string Name {get;}
}