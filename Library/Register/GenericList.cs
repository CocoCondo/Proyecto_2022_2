using System.Collections.Generic;

namespace Proyecto;

public class GenericList<T>
{
    private IList<T> RegisterList = new List<T>();
        public void Add(T user)
        {
            this.RegisterList.Add(user);
        }
        public void Remove(T user)
        {
            this.RegisterList.Remove(user);
        }

    public IEnumerator<T> GetEnumerator()
        {
            return this.RegisterList.GetEnumerator();
        }
}