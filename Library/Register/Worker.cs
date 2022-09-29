using System;
using System.Collections;

namespace Proyecto;

public class Worker : IUser
{
    public string Username {get;}
    public string Password {get;}
    public string Name {get;}
    public string Phone {get;}
    public string Address {get;}
    public int Score {get;set;}

     public List<JobReview> ReviewList = new List<JobReview>();

    public Worker(string username, string password, string name, string phone, string address)
    {
        this.Username = username;
        this.Password = password;
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }

    public JobOffer PublishJobOffer(Service service, Worker worker, Double offerprice)
    {
        JobOffer job = new JobOffer( service,  worker,  offerprice);

        return job;
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
}