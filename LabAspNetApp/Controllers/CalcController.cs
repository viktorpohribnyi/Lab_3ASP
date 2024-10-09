﻿using LabAspNetApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabAspNetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b) => Ok(_calcService.Add(a, b));

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b) => Ok(_calcService.Subtract(a, b));

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b) => Ok(_calcService.Multiply(a, b));

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                return Ok(_calcService.Divide(a, b));
            }
            catch (DivideByZeroException)
            {
                return BadRequest("Division by zero is not allowed.");
            }
        }
    }
}
