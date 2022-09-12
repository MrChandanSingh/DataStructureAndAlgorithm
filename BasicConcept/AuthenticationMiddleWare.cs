using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept
{
    public class AuthenticationMiddleWare
    {
        private RequestDelegate _next;
        public AuthenticationMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
    }
}
