using System;
using System.Collections.Generic;
using System.Collections;
namespace Proyecto

{
    public class Agreement
    {
        public int AgreementID{get;}
        public DateTime WorkToDoDateTime{get;}
        public DateTime AcceptedDateTime{get;}
        public JobOffer JobOffer {get;}
        public Worker Worker {get;}
        public Employer Employer {get;}
        public JobReview EmployerReview {get; set;}
        public JobReview WorkerReview {get; set;}
        
        public Agreement(JobOffer jobOffer, Employer Employer)
        {
            this.JobOffer = jobOffer;            
            this.Employer = Employer;
            this.Worker = jobOffer.Worker;
           
        }
        public void AcceptAgreement(bool answer)
        {
            
        }        
    }
}