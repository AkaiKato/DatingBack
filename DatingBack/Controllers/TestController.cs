﻿using Domain.Interfaces.UoW;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetHelloWorld")]
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello World!");
        }

        [Authorize]
        [HttpGet("GetHelloWorldAuthorized")]
        public IActionResult GetHelloWorldAuthorized()
        {
            return Ok("Hello authorized World!");
        }

    }
}
