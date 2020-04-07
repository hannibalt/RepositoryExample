using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rep_BusinessLayer.IRepository;
using Rep_BusinessLayer.Repository;
using Rep_DataLayer.Models;

namespace Rep_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private IRepository<Countries> CountryRepository;
        private IUnitOfWork _CountryUnitofWork;
        private DbContext _dbContext;
        public CountryController()
        {
            _dbContext = new TravelDbContext();
            _CountryUnitofWork = new EFUnitOfWork(_dbContext);
            CountryRepository = _CountryUnitofWork.GetRepository<Countries>();
        }

        [HttpGet]
        public List<Countries> GetCountries()
        {
            return CountryRepository.GetAll().ToList();
        }

        [HttpPost]
        public void POST(Countries countries)
        {
            CountryRepository.Insert(countries);
            _CountryUnitofWork.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            CountryRepository.Delete(id);
            _CountryUnitofWork.SaveChanges();
        }

        [HttpPut("{id}")]
        public void PUT(Countries countries)
        {
            var s = CountryRepository.GetById(countries.CountryId);
            s.CountryName = countries.CountryName;
            CountryRepository.Update(s);
            _CountryUnitofWork.SaveChanges();
        }


        [HttpGet("{id}")]
        public Countries GetCoutries(int id)
        {
            return CountryRepository.Get(s => s.CountryId == id);
        }
    }
}