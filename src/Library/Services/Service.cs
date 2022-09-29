using System;
using System.Collections.Generic;
namespace Proyecto

{
    public class Service{
        public string Name {get;}
        public string Description {get;}
        
        public Service(string nombre, string description)
        {
            this.Name = nombre;
            this.Description = description;
        }
    }
}
