using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPMS3POC1.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

//Models Required
//---------------
//ACC.Account
//PER.Address
//PER.AddressType
//PER.AppointmentPreference
//PER.Country
//PER.Gender
//PER.GeoCode
//PER.IdentityProofType
//PER.Language
//PER.Patient
//PER.PatientPreference
//PER.Person
//PER.PersonAddress
//PER.PersonLanguage
//PER.PersonPhone
//PER.Phone
//PER.PhoneType
//PER.PreferenceType
//PER.Prefix
//PER.Relationship
//PER.RelationshipType
//PER.State
//PER.ZipCode
//PER.User

public class EPMSPOCModelBuilder
{
    public IEdmModel GetEdmModel(IServiceProvider serviceProvider)
    {
        var builder = new ODataConventionModelBuilder();


        // This is the stored Odata Function reqiured for a stroed porcedure call  
        builder.Function("PatientPerson")
            .ReturnsCollectionFromEntitySet<PatientPerson>("PatientPerson");
        builder.Function("PatientAccount")
           .ReturnsCollectionFromEntitySet<PatientAccount>("PatientAccount");

        builder.EntitySet<Account>(nameof(Account))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Address>(nameof(Address))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<AddressType>(nameof(AddressType))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<AppointmentPreference>(nameof(AppointmentPreference))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Country>(nameof(Country))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Gender>(nameof(Gender))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<GeoCode>(nameof(GeoCode))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<IdentityProofType>(nameof(IdentityProofType))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Language>(nameof(Language))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Patient>(nameof(Patient))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PatientPreference>(nameof(PatientPreference))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Person>(nameof(Person))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PersonAddress>(nameof(PersonAddress))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PersonLanguage>(nameof(PersonLanguage))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PersonPhone>(nameof(PersonPhone))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Phone>(nameof(Phone))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PhoneType>(nameof(PhoneType))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<PreferenceType>(nameof(PreferenceType))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Prefix>(nameof(Prefix))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<Relationship>(nameof(Relationship))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<RelationshipType>(nameof(RelationshipType))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<State>(nameof(State))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<ZipCode>(nameof(ZipCode))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        builder.EntitySet<User>(nameof(User))
                            .EntityType
                            .Filter() // Allow for the $filter Command
                            .Count() // Allow for the $count Command
                            .Expand() // Allow for the $expand Command
                            .OrderBy() // Allow for the $orderby Command
                            .Page() // Allow for the $top and $skip Commands
                            .Select();// Allow for the $select Command;

        return builder.GetEdmModel();
}
}


namespace TestAppCore.OdataModel
{
    public class EPMSPOCModelBuilder
    {
    }
}
