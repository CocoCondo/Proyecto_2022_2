using System;
using System.Collections;
namespace Proyecto

{
    public class ServiceManager{ //No se usa en la primer entrega

        public IList ServiceList = new List<Service>();

        public void AddService(string name, string description)
        {
            this.ServiceList.Add(new Service(name, description));
        }
        public void RemoveService(Service service)
        {
            this.ServiceList.Remove(service);
        }
        public IList GetServiceList()
        {
            IList result = new ArrayList();
            foreach (Service service in this.ServiceList)
            {
                result.Add(service);
            }
            return result;
        }
    }
}