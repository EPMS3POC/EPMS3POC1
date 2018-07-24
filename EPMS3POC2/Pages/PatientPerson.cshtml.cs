using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EPMS3POC2.Models;
using EPMS3POC2.Services;

namespace EPMS3POC2.Pages
{
    public class PatientPersonModel : PageModel
    {
        public List<PatientPerson> lstPersonPatient { get; set; }
        public PatientPerson personPatient { get; set; }
        public void OnGet() => lstPersonPatient = Service.GetAll<PatientPerson>("PatientPerson").Result;
    }
}