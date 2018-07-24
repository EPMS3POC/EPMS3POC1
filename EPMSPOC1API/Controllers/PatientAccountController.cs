using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using EPMS3POC1.Models;

namespace EPMSPOC1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    /// 
    /// </summary>
    public class PatientAccountController : ControllerBase
    {

        private readonly EPMSPOCContext _context;

        public PatientAccountController(EPMSPOCContext context)
        {
            _context = context;
        }
        // GET api/PatientAccount
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            
            return Ok(_context.PatientAccount.AsNoTracking().FromSql<PatientAccount>("EXEC [dbo].[GetPatientAccount]"));
            //return new string[] { "value1", "value2" };
        }

        // GET api/PatientAccount/5
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

        // PUT api/PatientAccount/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/PatientAccount/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
