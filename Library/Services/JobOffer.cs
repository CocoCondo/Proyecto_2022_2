using System;
using System.Collections.Generic;
using System.Collections;
namespace Proyecto

{
    class JobOffer
    {

        public Service Service {get; set;}
        public Worker Worker {get;}
        public Double OfferPrice{get;}
        public int Score {get;}
        private DateTime DateTime;

        
        public JobOffer(Service service, Worker worker, Double offerprice)
        {
            this.Service = service;            
            this.Worker = worker;
            this.OfferPrice = offerprice;
            this.Score = worker.Score; //El score de la JobOffer va a ser igual al score del Worker que oferta
        }
        
    }
}