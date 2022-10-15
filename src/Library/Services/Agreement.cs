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
        private static int ID; // tipo especial ID se puede usar 
        
        public Agreement(JobOffer jobOffer, Employer Employer)
        {
            this.JobOffer = jobOffer;            
            this.Employer = Employer;
            this.Worker = jobOffer.Worker;
            ID=ID+1;
            this.AgreementID = ID;
            //TODO: mientras no recibio el review, podemos poner -1 asi no lo cuenta o imprime, o 0 y dejar el string vacio, como prefieran.
            this.EmployerReview = new JobReview(-1,"not review yet");
            this.WorkerReview = new JobReview(-1,"not review yet");
            //necesita tener este valor asignado para poder crear una instancia de agreement

        }
        public void AcceptAgreement(bool answer)
        {
            
        }        
    }
}