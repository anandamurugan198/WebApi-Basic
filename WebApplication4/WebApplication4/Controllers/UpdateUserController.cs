﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class UpdateUserController : ApiController
    {
        [HttpPut]
        public IHttpActionResult Update()
        {
            return Ok();
        }
    }
}
