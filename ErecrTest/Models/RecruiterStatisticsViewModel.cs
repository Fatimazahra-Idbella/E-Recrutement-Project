using Microsoft.AspNetCore.Mvc;

namespace ErecrTest.Models
{
    public class RecruiterStatisticsViewModel 
    {
        
            public int TotalOffers { get; set; }
            public int TotalApplications { get; set; }
            public double AverageApplicationsPerOffer { get; set; }
        
        
    }
}

