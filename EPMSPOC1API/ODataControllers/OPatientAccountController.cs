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

    [Produces("application/json")]
    public class OPatientAccountController : ODataController //Controller
    {
        private readonly EPMSPOCContext _context;

        public OPatientAccountController(EPMSPOCContext context)
        {
            _context = context;
        }

        // GET: api/People
        // [HttpGet]
        //[ODataRoute("PatientAccount")]


        //public IEnumerable<PatientAccount> GetPatientAccount()
        [HttpGet]
        [Produces("application/json")]
        [ODataRoute("PatientAccount")]
        [EnableCors("CorsPolicy")]
      //[EnableQuery(PageSize = 20)]
        public IActionResult PatientAccount()
        {
            //List<PatientAccount> orderHistoryList = await _context.PatientAccount.AsNoTracking().FromSql($"EXECUTE [dbo].[GetPatientAccount]").ToListAsync();
            // var patientAccount = _context.PatientAccount
            //  .FromSql("EXEC [dbo].[GetPatientAccount]")
            //  .ToList();
            //return Ok(patientAccount); //
            return Ok(_context.PatientAccount.AsNoTracking().FromSql<PatientAccount>("EXEC [dbo].[GetPatientAccount]"));
        }

    }
}
/*
[Produces("application/json")
-- did not work in Unbound version of Odata
public class PatientAccountController : ODataController
{
 private readonly EPMSPOCContext _context;

 public PatientAccountController(EPMSPOCContext context)
 {
     _context = context;
 }

 // GET: odata/PatientAccount
 // GET: odata/customers
 [ODataRoute("PatientAccount")]
 [EnableQuery(PageSize = 20)]

 //public IEnumerable<PatientAccount> GetPerson()

 public IQueryable<PatientAccount> Get()
 {
     return this._context.PatientAccount.AsNoTracking().FromSql<PatientAccount>("EXEC [dbo].[GetPatientAccount]");
 }


}
}
*/
