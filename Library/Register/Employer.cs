using System;

namespace Proyecto;

public class Employer
{
    public string Name {get;}
    public string Phone {get;}
    public string Address {get;}
    public int Score {get;}

    public Employer(string name, string phone, string address)
    {
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }
}