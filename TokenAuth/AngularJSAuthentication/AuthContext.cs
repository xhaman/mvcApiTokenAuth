﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSAuthentication
{
    class AuthContext :IdentityDbContext<IdentityUser>
    {
        public AuthContext():base ("AuthContext")
        {

        }
    }
}
