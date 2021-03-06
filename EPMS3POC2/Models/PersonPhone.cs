﻿using System;
using System.Collections.Generic;

namespace EPMS3POC2.Models
{
    public partial class PersonPhone
    {
        public long PersonPhoneId { get; set; }
        public long PersonId { get; set; }
        public long PhoneId { get; set; }
        public long PhoneTypeId { get; set; }
        public short? IsPersonPhonePreference { get; set; }
        public short? IsUsedToConfirm { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string CreatedByProgram { get; set; }
        public string ModifiedByProgram { get; set; }
        public int RecordStatus { get; set; }

        public Person Person { get; set; }
        public Phone Phone { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
