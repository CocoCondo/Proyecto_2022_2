using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto

{
    class OfferManager
    {
        private IList OfferList = new List<JobOffer>(); 

        public void AddOffer(JobOffer jobOffer)
        {
            this.OfferList.Add(jobOffer);
        }
        public void RemoveOffer(JobOffer jobOffer)
        {
            this.OfferList.Remove(jobOffer);
        }

        public List<JobOffer> SortByService(Service service)
        {
            List<JobOffer> result = new List<JobOffer>();
            foreach(JobOffer joboffer in OfferList)
            {
                if(joboffer.Equals(service))
                {
                    result.Add(joboffer);
                }
            }
            return result;
        }

        public List<JobOffer> SortByScore(Service service)
        {
            List<JobOffer> result = new List<JobOffer>();
            result = SortByService(service);
            result = result.OrderBy(result => result.Score).ToList();
            return result;
        }
    }
}