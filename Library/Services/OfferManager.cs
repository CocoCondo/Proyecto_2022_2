using System;
using System.Collections.Generic;
using System.Linq;
namespace Proyecto

{
    class OfferManager{

        string Servicio {get; set;}
        Worker Trabajador {get;}

        Double Costos{get;}

        
        public static List<JobOffer> Sort_Score(ServiceManager lista){
            List<JobOffer> x=lista.Lista;
            List<JobOffer> sorted= x.OrderBy(x => x.Trabajador.Score).ToList();
            return sorted;
        }
        public static List<JobOffer> Find(ServiceManager lista,string categoria){
            List<JobOffer> w= new List<JobOffer>();
            List<JobOffer> x=lista.Lista;
            foreach (JobOffer i in x){
                if (i.Servicio==categoria){
                    w.Add(i);
                }
            }
            return(w);

        }

        
    }
}