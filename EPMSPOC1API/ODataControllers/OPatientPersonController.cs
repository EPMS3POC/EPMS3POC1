using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EPMS3POC1.Models;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Cors;

namespace TestAppCore.Controllers
{
    //[Route("api/[controller]")]
    [Produces("application/json")]
    public class OPatientPersonController : ODataController //Controller
    {
        private readonly EPMSPOCContext _context;

        public OPatientPersonController(EPMSPOCContext context)
        {
            _context = context;
        }

        // GET: api/People
        // [HttpGet]
        //[ODataRoute("PatientPerson")]


        //public IEnumerable<PatientPerson> GetPatientPerson()
        [HttpGet]
        [Produces("application/json")]
        [ODataRoute("PatientPerson")]
        [EnableCors("CorsPolicy")]
      //[EnableQuery(PageSize = 20)]
        public IActionResult PatientPerson()
        {
            //List<PatientPerson> orderHistoryList = await _context.PatientPerson.AsNoTracking().FromSql($"EXECUTE [dbo].[GetPatientPerson]").ToListAsync();
           // var patientPerson = _context.PatientPerson
                //  .FromSql("EXEC [dbo].[GetPatientPerson]")
                //  .ToList();
            //return Ok(patientPerson); //
            return Ok(_context.PatientPerson.AsNoTracking().FromSql<PatientPerson>("EXEC [dbo].[GetPatientPerson]"));
        }

    }
}
       /*
    [Produces("application/json")
  -- did not work in Unbound version of Odata
    public class PatientPersonController : ODataController
    {
        private readonly EPMSPOCContext _context;

        public PatientPersonController(EPMSPOCContext context)
        {
            _context = context;
        }

        // GET: odata/PatientPerson
        // GET: odata/customers
        [ODataRoute("PatientPerson")]
        [EnableQuery(PageSize = 20)]

        //public IEnumerable<PatientPerson> GetPerson()

        public IQueryable<PatientPerson> Get()
        {
            return this._context.PatientPerson.AsNoTracking().FromSql<PatientPerson>("EXEC [dbo].[GetPatientPerson]");
        }


    }
}
*/