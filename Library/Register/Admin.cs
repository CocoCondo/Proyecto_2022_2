using System;

namespace Proyecto;

public class Admin : IUser
{
    public string Username {get;}
    public string Password {get;}

    private Admin(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
    private static Admin instance;
    public static Admin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Admin("Administrador","123");
                }

                return instance;
            }
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