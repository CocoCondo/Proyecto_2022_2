using System;

namespace Proyecto;

public class Worker
{
    private string Name {get;}
    private string Phone {get;}
    private string Address {get;}
    private int Score {get;}

    public Worker(string name, string phone, string address)
    {
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }
}