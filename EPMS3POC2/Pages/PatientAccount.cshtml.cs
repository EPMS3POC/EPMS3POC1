using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EPMS3POC2.Models;
using EPMS3POC2.Services;

namespace EPMS3POC2.Pages
{
    public class PatientAccountModel : PageModel
    {
        public List<PatientAccount> lstPatientAccount { get; set; }
        public PatientAccount PatientAccount { get; set; }
        public void OnGet() => lstPatientAccount = Service.GetAll<PatientAccount>("PatientAccount").Result;       
    }
}