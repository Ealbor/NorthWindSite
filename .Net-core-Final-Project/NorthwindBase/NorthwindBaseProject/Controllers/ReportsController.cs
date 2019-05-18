using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ReportsController : Controller
    {

        //This controller will depend on the NORTHWIND REPOSITORY
        private INorthwindRepository repository;
        public ReportsController(INorthwindRepository repo) => repository = repo;



        //this is the IActionResult associated with the link in the nav bar. 
        public IActionResult Index()
        {
            return View();
        }

        
        //This is the route that I'm using for my final project
        //Custom query returns customers by country
        [HttpGet, Route("reports/globalCustomers")]
        public IEnumerable<CountryCustomers> GetCustomerCountries()
        {
            return repository.Customers.GroupBy(c => c.Country).Select(grp => new CountryCustomers
            {
                Country = grp.Key,
                NumCompanies = grp.Count()
            }).OrderByDescending(g => g.NumCompanies);
        }


        //This route isn't needed at all.
        //The data should only be sent one time to the front end,  and then manupulated from there.
        //By relying on multi routes, we're expecting the server to be immune to failure, which is not smart. 
        //Send the data once, then manupulate it there with the route above 


        //Riley's Route
        // returns all products


            //Used to return all products
        [HttpGet, Route("reports/allProducts")]
        public IEnumerable<Product> Get() => repository.Products.OrderBy(p => p.ProductId);


        public IActionResult CategoryBreakdown() => View(repository.Categories.OrderBy(c => c.CategoryId));




        //Custom query returns customers by country by name
        [HttpGet, Route("reports/globalCustomers/{name}")]
        public CountryCustomers GetCountryCustomers(String name)
        {
            int numCustomers = repository.Customers.Where(c => c.Country.ToLower() == name.ToLower()).Count();

            return new CountryCustomers
            {
                Country = name,
                NumCompanies = numCustomers
            };
        }
    }
}