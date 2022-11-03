using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SaguirreReyesAskingQuetions.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MiniChallenge3Controller : ControllerBase
    {
        [HttpGet]
        [Route("MiniChallenge3/{name}/{question}")]
        public string askingquestions(string name, string question)
        {
            return $"Hello {name}! \n What time did you wake up today? \n {question} Whoa not even im awake at that time, enjoy your day :)";
        }
    }    
