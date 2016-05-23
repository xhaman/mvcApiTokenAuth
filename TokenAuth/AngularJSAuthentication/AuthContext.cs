﻿using AngularJSAuthentication.API.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
