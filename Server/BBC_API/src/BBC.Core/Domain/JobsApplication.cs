﻿using BBC.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC.Core.Domain
{
    public class JobsApplication : EntityBase<int>
    {
        public string Contact { get; set; }
        public ICollection<JobAdvert> Jobs { get; set; }
    }
}