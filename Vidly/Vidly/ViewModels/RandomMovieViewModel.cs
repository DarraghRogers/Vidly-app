using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;//this needs to be added because it is using the models folder

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}