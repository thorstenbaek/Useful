﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Useful.Core.Domain
{
    public class User
    {
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }
    }
}
