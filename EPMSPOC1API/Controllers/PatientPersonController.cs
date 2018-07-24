using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EPMS3POC1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace EPMSPOC1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    /// 
    /// </summary>
    public class PatientPersonController : ControllerBase
    {

        private readonly EPMSPOCContext _context;

        public PatientPersonController(EPMSPOCContext context)
        {
            _context = context;
        }
        // GET api/PatientPerson
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            
            return Ok(_context.PatientPerson.AsNoTracking().FromSql<PatientPerson>("EXEC [dbo].[GetPatientPerson]"));
            //return new string[] { "value1", "value2" };
        }

        // GET api/PatientPerson/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/PatientPerson/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/PatientPerson/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
