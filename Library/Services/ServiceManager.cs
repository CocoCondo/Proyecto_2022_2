using System;
using System.Collections.Generic;
namespace Proyecto

{
    class ServiceManager{

        public List<JobOffer> Lista {get;}
        
        public ServiceManager(){
            this.Lista= new List<JobOffer>();
        }
        public void Add_Service(JobOffer joboffer){
            this.Lista.Add(joboffer);
        }
        public void Remove_Service(JobOffer joboffer){
            if(this.Lista.Contains(joboffer)){
            this.Lista.Remove(joboffer);
            }
        
        }
    }
}