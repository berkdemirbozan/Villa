﻿using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class AppUser : IdentityUser<ObjectId>

    {
        public string NameSurname { get; set; }
    }
}
