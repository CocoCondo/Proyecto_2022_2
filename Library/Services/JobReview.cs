using System;
using System.Collections.Generic;
using System.Collections;
namespace Proyecto

{
    class JobReview
    {

        public int JobScore {get;}
        
        public string Review{get;}
        public DateTime DateTime;

        
        public JobReview(int jobScore, string review)
        {
            this.JobScore = jobScore;            
            this.Review = review;
           
        }

        
    }
}