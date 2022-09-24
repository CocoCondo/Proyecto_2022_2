using System;

namespace Proyecto;

public class Worker
{
    public string Name {get;}          //Guardo los datos del Worker con un Getter
    public string Phone {get;}
    public string Address {get;}
    public int Score {get;}

    public Worker(string name, string phone, string address) //Constructor de la clase
    {
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }
}