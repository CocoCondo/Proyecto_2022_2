using System;
using System.Collections.Generic;
using System.Linq;
namespace Proyecto

{
    class OfferManager{

        string Servicio {get; set;}
        Worker Trabajador {get;}

        Double Costos{get;}

        
        public static void Sort_Score(ServiceManager lista){
            List<JobOffer> x=lista.Lista;
            x.OrderBy(x => x.Trabajador.Score).ToList();
        }
        public static void Find(ServiceManager lista,string categoria){
            List<JobOffer> x=lista.Lista;
            for (JobOffer i in x)

        }
        
    }
}