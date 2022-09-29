using System;
using System.Collections.Generic;
namespace Proyecto

{
    public class Service{
        public string Name {get; set;}
        public string Description {get; set;}
        
        public Service(string nombre, string description)
        {
            this.Name = nombre;
            this.Description = description;
        }
    }
}
