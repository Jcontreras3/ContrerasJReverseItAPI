//Jovann Contreras
//Date 10/27/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReverseIt.Models;

namespace ContrerasJReverseItAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseController : ControllerBase
    {
        [HttpGet]
        [Route("Reverse")]

        public string ReverseItChallenge(ReverseItModel item)
        {
            string reverseString = "";
            for (int i = item.revStr.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + item.revStr.Substring(i, 1);
            }

            return reverseString;
        }
    }
}