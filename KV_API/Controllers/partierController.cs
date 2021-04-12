using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KV_API.Models;
using KV_API.Data;

using System.Net;
using System.Net.Http;

using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http.Headers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KV_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class partierController : ControllerBase
    {
        private readonly DataContext _dc;

        public partierController(DataContext dc)
        {
           _dc = dc;
        }


        [HttpGet]
       
        public async Task<IActionResult> Getpartier()
        {
            //int partier = await _dc.KommunalValg2021.Max(x => x.ID).ToListAsync();

            var partier = await _dc.KommunalValg2021.ToListAsync();


            return Ok(partier);
        }

        //// GET: api/<partierController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<partierController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<partierController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<partierController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<partierController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
