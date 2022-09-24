using System;
using System.Collections.Generic;
namespace Proyecto

{
    class JobOffer{

        public string Servicio {get; set;}
        public Worker Trabajador {get;}

        Double Costos{get;}

        
        public JobOffer(string categoria, Worker trabajador, Double costos){
            this.Servicio= categoria;            
            this.Trabajador= trabajador;
            this.Costos= costos;

        }
        
    }
}