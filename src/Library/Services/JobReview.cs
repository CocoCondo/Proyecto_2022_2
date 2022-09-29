using System;
using System.Collections.Generic;
using System.Collections;
namespace Proyecto

{
    public class JobReview
    {

        public double JobScore {get; set;}
        
        public string Review{get; set;}
        public DateTime DateTime{get;}

        
        public JobReview(double jobScore, string review)
        {
            this.JobScore = jobScore;            
            this.Review = review;
           
        }

        
    }
}