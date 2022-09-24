using System;

namespace Proyecto;

public class Employer
{
    private string Name {get;}
    private string Phone {get;}
    private string Address {get;}
    private int Score {get;}

    public Employer(string name, string phone, string address)
    {
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }
}