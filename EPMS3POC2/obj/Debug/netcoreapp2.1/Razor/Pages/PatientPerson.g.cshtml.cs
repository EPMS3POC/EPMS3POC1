#pragma checksum "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3358d89e56839049a148dfb4997d8e4cf433a471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EPMS3POC2.Pages.Pages_PatientPerson), @"mvc.1.0.razor-page", @"/Pages/PatientPerson.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/PatientPerson.cshtml", typeof(EPMS3POC2.Pages.Pages_PatientPerson), null)]
namespace EPMS3POC2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\_ViewImports.cshtml"
using EPMS3POC2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3358d89e56839049a148dfb4997d8e4cf433a471", @"/Pages/PatientPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2ee8bfd4d71e74bcea4931b4c25fa5395b5e19", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PatientPerson : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
  
    Layout = "~/Pages/Shared/_LayoutAspen.cshtml";
    ViewData["Title"] = "PatientPerson";

#line default
#line hidden
            BeginContext(154, 1136, true);
            WriteLiteral(@"
    <div class=""row mt-1"">
        <div class=""col"">
            <ol class=""breadcrumb breadcrumb-right-arrow m-0 p-2"">
                <li class=""breadcrumb-item"">
                    <a href=""/"">
                        <span><i class=""fa fa-home""></i> Home</span>
                    </a>
                </li>
                <li class=""breadcrumb-item"">
                    <span>Patient Person</span>
                </li>
            </ol>
        </div>
    </div>
    <div class=""container-fluid"" style=""margin-bottom:50px;"">
        <div class=""row"">
            <div class=""col"">
                <div class=""card"">
                    <!-- header slot here -->
                    <div class=""card-header bg-primary text-white"">
                        <h6>Patient Person</h6>
                    </div>
                    <!-- body slot here -->
                    <div class=""card-body"">
                        <table class=""table table-bordered table-striped table-condensed"">
   ");
            WriteLiteral("                         <thead>\r\n                                <tr>\r\n                                    <th>");
            EndContext();
            BeginContext(1291, 58, false);
#line 36 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.PersonId));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1397, 59, false);
#line 37 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1504, 58, false);
#line 38 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1610, 59, false);
#line 39 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1717, 60, false);
#line 40 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.GenderName));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1825, 70, false);
#line 41 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.SocialSecurityNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(1943, 70, false);
#line 42 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.RelationshipTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(2061, 62, false);
#line 43 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.FacilityName));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(2171, 65, false);
#line 44 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 89, true);
            WriteLiteral("</th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(2326, 62, false);
#line 46 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                   Write(Html.DisplayNameFor(model => model.personPatient.RecordStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2388, 159, true);
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                 foreach (var item in Model.lstPersonPatient)
                                {

#line default
#line hidden
            BeginContext(2661, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2748, 43, false);
#line 54 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PersonId));

#line default
#line hidden
            EndContext();
            BeginContext(2791, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2843, 44, false);
#line 55 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2939, 43, false);
#line 56 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3034, 44, false);
#line 57 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3130, 45, false);
#line 58 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.GenderName));

#line default
#line hidden
            EndContext();
            BeginContext(3175, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3227, 55, false);
#line 59 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SocialSecurityNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3282, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3334, 55, false);
#line 60 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.RelationshipTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(3389, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3441, 47, false);
#line 61 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FacilityName));

#line default
#line hidden
            EndContext();
            BeginContext(3488, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3540, 50, false);
#line 62 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AppointmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(3590, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3642, 47, false);
#line 63 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.RecordStatus));

#line default
#line hidden
            EndContext();
            BeginContext(3689, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 65 "C:\Users\adevakumar\Desktop\EPMS3POC1 - Copy\EPMS3POC1 - Copy\EPMS3POC2\Pages\PatientPerson.cshtml"
                                }

#line default
#line hidden
            BeginContext(3774, 137, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                    <!-- footer -->\r\n");
            EndContext();
            BeginContext(4015, 90, true);
            WriteLiteral("                </div>\r\n\r\n                \r\n            </div>\r\n        </div>\r\n    </div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EPMS3POC2.Pages.PatientPersonModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EPMS3POC2.Pages.PatientPersonModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EPMS3POC2.Pages.PatientPersonModel>)PageContext?.ViewData;
        public EPMS3POC2.Pages.PatientPersonModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591