using System;
using System.Collections;

namespace Proyecto;

public class Worker : User
{    public string Phone {get;}
    public string Address {get;}
    public double Score {get; set;}
    public bool Avability {get; set;}
    public IList<DateTime> AvabilityList = new List<DateTime>();
    public IList<JobReview> ReviewList = new List<JobReview>();
    
    public Worker(string username, string password, string name, string phone, string address)
        :base(username, password, name)
    {
        this.Phone = phone;
        this.Address = address;
    }

    public void GetScoreAverage()
    {
        double scoreTotal = 0;
        foreach (var review in this.ReviewList)
        {
            scoreTotal += review.JobScore;
        }
        this.Score = (int)scoreTotal/ReviewList.Count;
    }
    public void AddAvailabilityList(DateTime datetime)
    {
        this.AvabilityList.Add(datetime);
    }
    public void AddReviewList(JobReview jobreview)
    {
        this.ReviewList.Add(jobreview);
    }
}