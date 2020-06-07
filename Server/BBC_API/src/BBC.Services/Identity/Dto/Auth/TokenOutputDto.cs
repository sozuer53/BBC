﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBC.Services.Identity.Dto.Auth
{
    public class TokenOutputDto
    {
        public bool? HasVerifiedEmail { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string[] Errors { get; set; }
        public List<string> Roles { get; set; }
        public TokenOutputDto()
        {
            Roles = new List<string>();
        }

    }
}
