using System;
using System.Collections.Generic;
using System.Collections;
namespace Proyecto

{
    public class Agreement
    {

        public JobOffer JobOffer {get;}
        public Worker Worker {get;}
        public Employer Employer {get;}
        public int EmployerScore {get; set;}
        public int WorkerScore {get; set;}
        
        public DateTime DateTime;

        
        public Agreement(JobOffer jobOffer, Employer Employer)
        {
            this.JobOffer = jobOffer;            
            this.Employer = Employer;
            this.Worker = jobOffer.Worker;
           
        }

        public void ReviewWorker(JobReview review)
        {
            this.WorkerScore=review.JobScore;

        }
        public void ReviewEmployer(JobReview review)
        {
            this.EmployerScore=review.JobScore;

        }

        
    }
}