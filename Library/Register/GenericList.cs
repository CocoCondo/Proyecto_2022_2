using System.Collections.Generic;

namespace Proyecto;

public class GenericList<T>                                 //Creo una GenericList para guardar Worker y Employer en Register
{
    private IList<T> RegisterList = new List<T>();
        public void Add(T user)                             //Un método para agregar objetos a la lista
        {
            this.RegisterList.Add(user);
        }
        public void Remove(T user)                          //Y uno para eliminarlos
        {
            this.RegisterList.Remove(user);
        }

    public IEnumerator<T> GetEnumerator()                   //Para recorrer la lista (?)
        {
            return this.RegisterList.GetEnumerator();
        }
}