﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.IdentityDtos
{
    public class RegisterDto
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    }
}
