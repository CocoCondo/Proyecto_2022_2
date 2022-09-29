using System;

namespace Proyecto;

public class Admin : User
{

    public Admin(string username, string password, string name) 
        : base(username, password, name)
    {
        
    }
    
    public void CreateService(string name, string description)
    {

    }
    public void RemoveService(string name)
    {
        
    }
    public void RemoveOffer(int id)
    {
        
    }
}