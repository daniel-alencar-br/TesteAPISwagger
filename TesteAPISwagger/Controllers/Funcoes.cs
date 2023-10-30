using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPISwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Funcoes : ControllerBase
    {
        [HttpGet("{Valor}")]
        public int Get(int Valor)
        {
            return (2 * Valor);
        }
    }
}
